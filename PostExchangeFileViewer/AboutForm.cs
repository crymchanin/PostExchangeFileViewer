using Feodosiya.Lib.IO;
using System;
using System.Reflection;
using System.Windows.Forms;


namespace PostExchangeFileViewer {
    public partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();

            try {
                VersionLabel.Text = string.Format("v.{0}", IOHelper.GetExeVersion(Assembly.GetExecutingAssembly()));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AboutForm_MouseClick(object sender, MouseEventArgs e) {
            Close();
        }
    }
}
