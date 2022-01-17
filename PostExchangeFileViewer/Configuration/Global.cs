using System.Collections.Generic;
using System.Runtime.Serialization;


namespace PostExchangeFileViewer.Configuration {
    [DataContract]
    public class Global {
        /// <summary>
        /// Параметры БД
        /// </summary>
        [DataMember]
        public Sql Sql { get; set; }

        /// <summary>
        /// Параметры FTP
        /// </summary>
        [DataMember]
        public Ftp Ftp { get; set; }

        /// <summary>
        /// Отделения связи
        /// </summary>
        [DataMember]
        public Dictionary<int, string> PostOffices { get; set; }

        /// <summary>
        /// Типы файлов
        /// </summary>
        [DataMember]
        public List<FileType> FileTypes { get; set; }

        /// <summary>
        /// Регулярное выражение для поиска 1С файлов
        /// </summary>
        [DataMember]
        public string RegexFileName1C { get; set; } // ^[A-zЁёА-я]{1}\d{4}_\d{4}_\d{6}_\d{6}[A-zЁёА-я]{1}\d{8}\.txt$

        /// <summary>
        /// Регулярное выражение для чтения содержимого 1С файлов
        /// </summary>
        [DataMember]
        public string RegexFileContent1C { get; set; } // Накладная\s(?<NAME>.+)\sзагружена\s(?<DATE>\d{2}\.\d{2}\.\d{4}\s\d{2}:\d{2})


        [OnDeserialized]
        internal void OnDeserialized(StreamingContext ctx) {
            Ftp = (Ftp == null) ? new Ftp() { Cwd = "/", Host = "localhost", Username = "username", Password = "password"} : Ftp;
            if (string.IsNullOrWhiteSpace(RegexFileName1C)) {
                RegexFileName1C = ".*";
            }
            if (string.IsNullOrWhiteSpace(RegexFileContent1C)) {
                RegexFileContent1C = ".*";
            }
            FileTypes.Insert(0, new FileType { Type = "_ALL_", Description = "Все", RowColor = "ffffff" });
        }

        [OnSerializing]
        internal void OnSerializing(StreamingContext ctx) {
            FileTypes.Remove(FileTypes.Find(e => e.Type == "_ALL_"));
        }
    }
}
