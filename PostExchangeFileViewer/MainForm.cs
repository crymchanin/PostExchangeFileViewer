using Feodosiya.Lib.InteropServices;
using Feodosiya.Lib.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;


namespace PostExchangeFileViewer {
    public partial class MainForm : Form {

        private Dictionary<int, string> GetFormatedPostOfficesList(Dictionary<int, string> source) {
            Dictionary<int, string> temp = new Dictionary<int, string>();
            foreach (int key in source.Keys) {
                temp.Add(key, string.Format("{0} ({1})", key, source[key]));
            }

            return temp;
        }

        private void AddPostOfficesToBox(Dictionary<int, string> postoffices) {
            PostOfficesBox.DataSource = null;
            PostOfficesBox.DataSource = (postoffices.Count > 0) ? new BindingSource(postoffices, null) : null;
            PostOfficesBox.DisplayMember = "Value";
            PostOfficesBox.ValueMember = "Key";
            PostOfficesBox.Refresh();
        }

        private void AddFileTypesToBox(List<Configuration.FileType> fileTypes) {
            FileTypeBox.DataSource = null;
            FileTypeBox.DataSource = (fileTypes.Count > 0) ? new BindingSource(fileTypes, null) : null;
            FileTypeBox.DisplayMember = "Description";
            FileTypeBox.ValueMember = "Type";
            FileTypeBox.Refresh();

            FileTypeBox.SelectedIndex = 0;
        }

        public MainForm() {
            InitializeComponent();

            if (!AppHelper.InitConfiguration()) {
                Load += (s, e) => Application.Exit();
                return;
            }

            try {
                DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                DateBeginPicker.Value = date;
                date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
                DateEndPicker.Value = date;

                AddFileTypesToBox(AppHelper.Configuration.FileTypes);

                AddPostOfficesToBox(GetFormatedPostOfficesList(AppHelper.Configuration.PostOffices));

                Win32ApiHelper.SendMessageW(SearchBox.Handle, Win32ApiHelper.EM_SETCUEBANNER, Win32ApiHelper.Nullhandle, "Поиск...  (Ctrl + F)");
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при загрузке конфигурации:\r\n" + ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewFiles() {
            if (PostOfficesBox.CheckedItems.Count <= 0) {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            try {
                List<TabPage> pages = new List<TabPage>();
                Configuration.FileType fType = FileTypeBox.SelectedItem as Configuration.FileType;
                DateTime dateBegin = DateBeginPicker.Value;
                DateTime dateEnd = DateEndPicker.Value;
                MainTabControl.Visible = false;
                MainTabControl.TabPages.Clear();
                MainTabControl.Visible = true;

                Thread thread = new Thread(delegate () {
                    try {
                        ViewButton.InvokeIfRequired(() => ViewButton.Enabled = false);
                        MainAppMenuStrip.InvokeIfRequired(() => MainAppMenuStrip.Enabled = false);
                        SearchPanel.InvokeIfRequired(() => SearchPanel.Enabled = false);
                        CheckAllBox.InvokeIfRequired(() => CheckAllBox.Enabled = false);
                        PostOfficesBox.InvokeIfRequired(() => PostOfficesBox.Enabled = false);
                        FileTypeBox.InvokeIfRequired(() => FileTypeBox.Enabled = false);
                        DateBeginPicker.InvokeIfRequired(() => DateBeginPicker.Enabled = false);
                        DateEndPicker.InvokeIfRequired(() => DateEndPicker.Enabled = false);

                        foreach (KeyValuePair<int, string> pair in PostOfficesBox.CheckedItems) {
                            TabPage page = new TabPage();
                            page.Text = pair.Value;
                            page.BackColor = Color.White;

                            ListViewEx lv = new ListViewEx();
                            lv.Location = new Point(0, 0);
                            lv.Size = new Size(page.Width, page.Height - 32);
                            lv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                            lv.HeaderStyle = ColumnHeaderStyle.Clickable;
                            ColumnHeader ch1 = lv.Columns.Add((fType.Type == "1C") ? "Накладная" : "Имя файла", 400);
                            ColumnHeader ch2 = lv.Columns.Add((fType.Type == "1C") ? "Дата загрузки" : "Дата получения", 300);
                            if (fType.Type == "_ALL_") {
                                ch1.Text += " / Накладная";
                                ch2.Text += " / Дата загрузки";
                                lv.Columns.Add("Тип файла", 300);
                            }
                            lv.View = View.Details;
                            lv.GridLines = true;
                            lv.FullRowSelect = true;
                            lv.MultiSelect = false;
                            lv.Scrollable = true;
                            lv.ContextMenuStrip = CopyMenuStrip;

                            ListViewItem[] data = AppHelper.GetFileInfos(pair.Key, fType.Type, dateBegin, dateEnd).ToArray();
                            lv.Items.AddRange(data);

                            /*Button closeTabButton = new Button();
                            closeTabButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                            closeTabButton.Image = Properties.Resources.delete;
                            closeTabButton.ImageAlign = ContentAlignment.MiddleLeft;
                            closeTabButton.Size = new Size(158, 28);
                            closeTabButton.Location = new Point(page.Width - closeTabButton.Size.Width, page.Height - closeTabButton.Size.Height - 2);
                            closeTabButton.TabIndex = 8;
                            closeTabButton.Text = "    Закрыть вкладку";
                            closeTabButton.UseVisualStyleBackColor = true;
                            closeTabButton.Click += delegate (object s, EventArgs e) {
                                CloseTabPage();
                            };*/

                            Button closeAllTabButton = new Button();
                            closeAllTabButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                            closeAllTabButton.Image = Properties.Resources.delete;
                            closeAllTabButton.ImageAlign = ContentAlignment.MiddleLeft;
                            closeAllTabButton.Size = new Size(180, 28);
                            closeAllTabButton.Location = new Point(page.Width - closeAllTabButton.Size.Width, page.Height - closeAllTabButton.Size.Height - 2);
                            closeAllTabButton.TabIndex = 8;
                            closeAllTabButton.Text = "    Закрыть все вкладки";
                            closeAllTabButton.UseVisualStyleBackColor = true;
                            closeAllTabButton.Click += delegate(object s, EventArgs e) {
                                MainTabControl.InvokeIfRequired(delegate () {
                                    MainTabControl.Visible = false;
                                    MainTabControl.TabPages.Clear();
                                    MainTabControl.Visible = true;
                                });
                            };

                            page.ImageIndex = (data.Length > 0) ? 0 : 1;
                            page.Controls.Add(lv);
                            //page.Controls.Add(closeTabButton);
                            page.Controls.Add(closeAllTabButton);
                            pages.Add(page);
                        }

                        MainTabControl.InvokeIfRequired(delegate() {
                            MainTabControl.Visible = false;
                            MainTabControl.TabPages.AddRange(pages.ToArray());
                            MainTabControl.Visible = true;
                        });
                    }
                    catch (Exception ex) {
                        this.InvokeIfRequired(() => MessageBox.Show(this, "Ошибка при загрузке конфигурации:\r\n" + ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    }
                    finally {
                        ViewButton.InvokeIfRequired(() => ViewButton.Enabled = true);
                        MainAppMenuStrip.InvokeIfRequired(() => MainAppMenuStrip.Enabled = true);
                        SearchPanel.InvokeIfRequired(() => SearchPanel.Enabled = true);
                        CheckAllBox.InvokeIfRequired(() => CheckAllBox.Enabled = true);
                        PostOfficesBox.InvokeIfRequired(() => PostOfficesBox.Enabled = true);
                        FileTypeBox.InvokeIfRequired(() => FileTypeBox.Enabled = true);
                        DateBeginPicker.InvokeIfRequired(() => DateBeginPicker.Enabled = true);
                        DateEndPicker.InvokeIfRequired(() => DateEndPicker.Enabled = true);
                    }
                });
                thread.Start();
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при загрузке конфигурации:\r\n" + ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewButton_Click(object sender, EventArgs e) {
            ViewFiles();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e) {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void DBSetiingsMenuItem_Click(object sender, EventArgs e) {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        private void CloseTabPage() {
            TabPage page = MainTabControl.SelectedTab;
            int index = MainTabControl.SelectedIndex;
            if (page == null) {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            MainTabControl.TabPages.Remove(page);
            int pagesCount = MainTabControl.TabPages.Count;
            if (pagesCount > 0) {
                MainTabControl.SelectedIndex = (index > pagesCount - 1) ? Math.Max(0, pagesCount - 1) : index;
            }
        }

        private void CheckAll(bool flag) {
            if (PostOfficesBox.Items.Count > 0) {
                for (int index = 0; index < PostOfficesBox.Items.Count; index++) {
                    PostOfficesBox.SetItemChecked(index, flag);
                }
            }
        }

        private void CheckAllBox_CheckedChanged(object sender, EventArgs e) {
            CheckAll(CheckAllBox.Checked);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e) {
            try {
                string searchString = SearchBox.Text;
                if (string.IsNullOrEmpty(searchString)) {
                    SearchButton.Image = Properties.Resources.search;

                    AddPostOfficesToBox(GetFormatedPostOfficesList(AppHelper.Configuration.PostOffices));
                }
                else {
                    SearchButton.Image = Properties.Resources.clear;

                    Dictionary<int, string> selected = (from postoffice in AppHelper.Configuration.PostOffices
                                                        where (Regex.IsMatch(postoffice.Value, ".*" + searchString + ".*", RegexOptions.IgnoreCase) ||
                                                        Regex.IsMatch(postoffice.Key.ToString(), ".*" + searchString + ".*", RegexOptions.IgnoreCase))
                                                        orderby postoffice.Key ascending
                                                        select postoffice).ToDictionary(x => x.Key, x => x.Value);

                    AddPostOfficesToBox(GetFormatedPostOfficesList(selected));
                }
                CheckAllBox.Checked = false;
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при загрузке конфигурации:\r\n" + ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            try {
                string searchString = SearchBox.Text;
                if (!string.IsNullOrEmpty(searchString)) {
                    SearchBox.Text = string.Empty;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при загрузке конфигурации:\r\n" + ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyFileName(ListView lv) {
            try {
                if (lv == null) {
                    return;
                }
                if (lv.SelectedItems.Count > 0) {
                    ListViewItem item = lv.SelectedItems[0];
                    Clipboard.SetText(item.Text);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при загрузке конфигурации:\r\n" + ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyFileNameMenuItem_Click(object sender, EventArgs e) {
            try {
                ListView lv = (ListView)CopyMenuStrip.SourceControl;
                CopyFileName(lv);
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при загрузке конфигурации:\r\n" + ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CopyMenuStrip_Opening(object sender, CancelEventArgs e) {
            try {
                ListView lv = (ListView)CopyMenuStrip.SourceControl;
                CopyFileNameMenuItem.Enabled = (lv.SelectedItems.Count > 0);
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при загрузке конфигурации:\r\n" + ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.F1) {
                AboutForm form = new AboutForm();
                form.ShowDialog();
                return true;
            }
            if (keyData == Keys.F5) {
                ViewFiles();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.A)) {
                CheckAllBox.Checked = !CheckAllBox.Checked;
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D)) {
                CloseTabPage();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.F)) {
                SearchBox.Focus();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S)) {
                SettingsForm form = new SettingsForm();
                form.ShowDialog();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MainTabControl_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Right) {
                return;
            }

            for (int index = 0; index < MainTabControl.TabCount; index++) {
                if (MainTabControl.GetTabRect(index).Contains(e.Location)) {
                    MainTabControl.TabPages.RemoveAt(index);
                    break;
                }
            }
        }
    }
}
