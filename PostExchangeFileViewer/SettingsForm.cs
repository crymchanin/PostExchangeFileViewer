using System;
using System.Windows.Forms;


namespace PostExchangeFileViewer {
    public partial class SettingsForm : Form {
        public SettingsForm() {
            InitializeComponent();

            try {
                DBDataSourceBox.Text = AppHelper.Configuration.Sql.DataSource;
                DBDatabaseBox.Text = AppHelper.Configuration.Sql.Database;
                DBUsernameBox.Text = AppHelper.Configuration.Sql.Username;
                DBPasswordBox.Text = AppHelper.Configuration.Sql.Password;

                FtpHostBox.Text = AppHelper.Configuration.Ftp.Host;
                FtpCwdBox.Text = AppHelper.Configuration.Ftp.Cwd;
                FtpUsernameBox.Text = AppHelper.Configuration.Ftp.Username;
                FtpPasswordBox.Text = AppHelper.Configuration.Ftp.Password;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {

            try {
                AppHelper.Configuration.Sql.DataSource = DBDataSourceBox.Text;
                AppHelper.Configuration.Sql.Database = DBDatabaseBox.Text;
                AppHelper.Configuration.Sql.Username = DBUsernameBox.Text;
                AppHelper.Configuration.Sql.Password = DBPasswordBox.Text;

                AppHelper.Configuration.Ftp.Host = FtpHostBox.Text;
                AppHelper.Configuration.Ftp.Cwd = FtpCwdBox.Text;
                AppHelper.Configuration.Ftp.Username = FtpUsernameBox.Text;
                AppHelper.Configuration.Ftp.Password = FtpPasswordBox.Text;

                AppHelper.ConfHelper.SaveConfig(AppHelper.Configuration, System.Text.Encoding.UTF8, true);

                MessageBox.Show("Настройки сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
