using Feodosiya.Lib.Conf;
using Feodosiya.Lib.IO;
using FirebirdSql.Data.FirebirdClient;
using FluentFTP;
using PostExchangeFileViewer.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace PostExchangeFileViewer {
    public static class AppHelper {
        /// <summary>
        /// Конфигурационный файл
        /// </summary>
        public static ConfHelper ConfHelper { get; set; }

        /// <summary>
        /// Конфигурация программы
        /// </summary>
        public static Global Configuration { get; set; }



        /// <summary>
        /// Инициализация конфигурации приложения
        /// </summary>
        /// <returns></returns>
        public static bool InitConfiguration() {
            try {
                Assembly execAssembly = Assembly.GetExecutingAssembly();
                string currentDirectory = IOHelper.GetCurrentDir(execAssembly);

                string confPath = Path.Combine(currentDirectory, "settings.conf");
                if (!File.Exists(confPath)) {
                    File.WriteAllBytes(confPath, Properties.Resources.settings);
                    MessageBox.Show("Файл конфигурации приложения не был обнаружен. Создан файл конфигурации с параметрами по умолчанию.",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ConfHelper = new ConfHelper(confPath);
                Configuration = ConfHelper.LoadConfig<Global>();
                if (!ConfHelper.Success) {
                    MessageBox.Show("Ошибка при загрузке конфигурации:\r\n" + ConfHelper.LastError.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при загрузке конфигурации:\r\n" + ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static IEnumerable<ListViewItem> GetFileInfos(int zipCode, string fileType, DateTime dateBegin, DateTime dateEnd) {
            string connectionString = string.Format("User={0};Password={1};Database={2};DataSource={3};Pooling=false;Connection lifetime=60;Charset=WIN1251;",
                    Configuration.Sql.Username, Configuration.Sql.Password,
                    Configuration.Sql.Database, Configuration.Sql.DataSource);
            List<FileInfo> files = new List<FileInfo>();

            bool flag = (fileType == "_ALL_");
            if (flag || fileType == "1C") {
                List<string> directories = new List<string>();
                using (FtpClient client = new FtpClient(AppHelper.Configuration.Ftp.Host, 21,
                    new System.Net.NetworkCredential(AppHelper.Configuration.Ftp.Username, AppHelper.Configuration.Ftp.Password))) {
                    client.DownloadDataType = FtpDataType.ASCII;
                    client.DataConnectionType = FtpDataConnectionType.PASV;
                    client.ReadTimeout = 30000;
                    client.Connect();
                    client.SetWorkingDirectory(AppHelper.Configuration.Ftp.Cwd);

                    foreach (FtpListItem item in client.GetListing()) {
                        if (item.Type == FtpFileSystemObjectType.Directory) {
                            string directoryName = item.Name;
                            if (Regex.IsMatch(directoryName, @"\d{6}")) {
                                directories.Add(directoryName);
                            }
                        }
                    }

                    foreach (string directoryName in directories) {
                        if (directoryName != zipCode.ToString()) continue;

                        foreach (FtpListItem item in client.GetListing(AppHelper.Configuration.Ftp.Cwd + directoryName)) {
                            if (item.Type == FtpFileSystemObjectType.File) {
                                if (Regex.IsMatch(item.Name, AppHelper.Configuration.RegexFileName1C)) {
                                    try {
                                        byte[] buffer = new byte[item.Size];
                                        if (!client.Download(out buffer, item.FullName)) throw new Exception();
                                        string fileData = Encoding.UTF8.GetString(buffer);
                                        Regex regex = new Regex(AppHelper.Configuration.RegexFileContent1C);
                                        Match match = regex.Match(fileData);
                                        if (match.Success) {
                                            DateTime dateTime;
                                            DateTime.TryParseExact(match.Groups["DATE"].Value, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
                                            if (dateTime >= dateBegin && dateTime <= dateEnd) {
                                                files.Add(new FileInfo() {
                                                    Name = match.Groups["NAME"].Value,
                                                    Type = "1C",
                                                    Date = dateTime
                                                });
                                            }
                                        }
                                        else {
                                            files.Add(new FileInfo() {
                                                Name = $"Файл {item.Name} не обработан",
                                                Type = "1C",
                                                Date = new DateTime()
                                            });
                                        }
                                    }
                                    catch (Exception ex) {
                                        files.Add(new FileInfo() {
                                            Name = $"Ошибка: | {item.Name} | {ex.Message}",
                                            Type = "1C",
                                            Date = new DateTime()
                                        });
                                    }
                                }
                            }
                        }
                    }
                }
            }
            using (FbConnection connection = new FbConnection(connectionString)) {
                connection.Open();

                string cmd = flag ? string.Format(@"SELECT FILENAME, OPERATIONDATE, FILETYPE
                                FROM FILES
                                WHERE ZIPCODE={0}
                                AND OPERATIONDATE >='{1}' AND OPERATIONDATE <='{2}'
                                ORDER BY OPERATIONDATE ASC",
                                zipCode, dateBegin.ToString(), dateEnd.ToString()) :
                    string.Format(@"SELECT FILENAME, OPERATIONDATE, FILETYPE
                                FROM FILES
                                WHERE ZIPCODE={0}
                                AND FILETYPE='{1}'
                                AND OPERATIONDATE >='{2}' AND OPERATIONDATE <='{3}'
                                ORDER BY OPERATIONDATE ASC",
                                zipCode, fileType, dateBegin.ToString(), dateEnd.ToString());
                using (FbCommand command = new FbCommand(cmd, connection)) {
                    FbTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    using (FbDataReader reader = command.ExecuteReader()) {

                        while (reader.Read()) {
                            files.Add(new FileInfo() {
                                Name = reader["FILENAME"].ToString(),
                                Type = reader["FILETYPE"].ToString(),
                                Date = (DateTime)reader["OPERATIONDATE"]
                            });
                        }
                    }
                    transaction.Rollback();
                }

                foreach (FileInfo fileInfo in files.OrderBy(f => f.Date)) {
                    ListViewItem item = new ListViewItem(fileInfo.Name);
                    item.SubItems.Add(fileInfo.Date.ToString());
                    if (flag) {
                        string fType = (Configuration.FileTypes.FirstOrDefault(x => x.Type == fileInfo.Type) ?? new FileType() { Description = "???", Type = "???", RowColor = "fb0006" }).Description;
                        item.SubItems.Add(fType);
                    }
                    Color col = Color.FromArgb(int.Parse((Configuration.FileTypes.FirstOrDefault(x => x.Type == fileInfo.Type) ?? new FileType() { Description = "???", Type = "???", RowColor = "fb0006" }).RowColor, NumberStyles.HexNumber));
                    item.BackColor = Color.FromArgb(col.R, col.G, col.B);

                    yield return item;
                }
            }
        }
    }
}
