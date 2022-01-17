namespace PostExchangeFileViewer {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.DBPage = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.DBDataSourceBox = new System.Windows.Forms.TextBox();
            this.DBUsernameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DBDatabaseBox = new System.Windows.Forms.TextBox();
            this.DBPasswordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FtpPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.FtpCwdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FtpHostBox = new System.Windows.Forms.TextBox();
            this.FtpUsernameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FtpPasswordBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.DBPage.SuspendLayout();
            this.FtpPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.DBPage);
            this.MainTabControl.Controls.Add(this.FtpPage);
            this.MainTabControl.Location = new System.Drawing.Point(2, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(340, 232);
            this.MainTabControl.TabIndex = 9;
            // 
            // DBPage
            // 
            this.DBPage.Controls.Add(this.label8);
            this.DBPage.Controls.Add(this.DBDataSourceBox);
            this.DBPage.Controls.Add(this.DBUsernameBox);
            this.DBPage.Controls.Add(this.label7);
            this.DBPage.Controls.Add(this.label4);
            this.DBPage.Controls.Add(this.DBDatabaseBox);
            this.DBPage.Controls.Add(this.DBPasswordBox);
            this.DBPage.Controls.Add(this.label5);
            this.DBPage.Location = new System.Drawing.Point(4, 25);
            this.DBPage.Name = "DBPage";
            this.DBPage.Padding = new System.Windows.Forms.Padding(3);
            this.DBPage.Size = new System.Drawing.Size(332, 203);
            this.DBPage.TabIndex = 0;
            this.DBPage.Text = "DB";
            this.DBPage.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Сервер";
            // 
            // DBDataSourceBox
            // 
            this.DBDataSourceBox.BackColor = System.Drawing.Color.AliceBlue;
            this.DBDataSourceBox.Location = new System.Drawing.Point(13, 21);
            this.DBDataSourceBox.Name = "DBDataSourceBox";
            this.DBDataSourceBox.Size = new System.Drawing.Size(309, 22);
            this.DBDataSourceBox.TabIndex = 9;
            // 
            // DBUsernameBox
            // 
            this.DBUsernameBox.BackColor = System.Drawing.Color.AliceBlue;
            this.DBUsernameBox.Location = new System.Drawing.Point(13, 109);
            this.DBUsernameBox.Name = "DBUsernameBox";
            this.DBUsernameBox.Size = new System.Drawing.Size(309, 22);
            this.DBUsernameBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Пользователь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Пароль";
            // 
            // DBDatabaseBox
            // 
            this.DBDatabaseBox.BackColor = System.Drawing.Color.AliceBlue;
            this.DBDatabaseBox.Location = new System.Drawing.Point(13, 65);
            this.DBDatabaseBox.Name = "DBDatabaseBox";
            this.DBDatabaseBox.Size = new System.Drawing.Size(309, 22);
            this.DBDatabaseBox.TabIndex = 10;
            // 
            // DBPasswordBox
            // 
            this.DBPasswordBox.BackColor = System.Drawing.Color.AliceBlue;
            this.DBPasswordBox.Location = new System.Drawing.Point(13, 153);
            this.DBPasswordBox.Name = "DBPasswordBox";
            this.DBPasswordBox.Size = new System.Drawing.Size(309, 22);
            this.DBPasswordBox.TabIndex = 13;
            this.DBPasswordBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Путь к файлу БД";
            // 
            // FtpPage
            // 
            this.FtpPage.Controls.Add(this.label6);
            this.FtpPage.Controls.Add(this.FtpCwdBox);
            this.FtpPage.Controls.Add(this.label1);
            this.FtpPage.Controls.Add(this.FtpHostBox);
            this.FtpPage.Controls.Add(this.FtpUsernameBox);
            this.FtpPage.Controls.Add(this.label2);
            this.FtpPage.Controls.Add(this.label3);
            this.FtpPage.Controls.Add(this.FtpPasswordBox);
            this.FtpPage.Location = new System.Drawing.Point(4, 22);
            this.FtpPage.Name = "FtpPage";
            this.FtpPage.Padding = new System.Windows.Forms.Padding(3);
            this.FtpPage.Size = new System.Drawing.Size(332, 206);
            this.FtpPage.TabIndex = 1;
            this.FtpPage.Text = "FTP";
            this.FtpPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Корневая директория";
            // 
            // FtpCwdBox
            // 
            this.FtpCwdBox.BackColor = System.Drawing.Color.AliceBlue;
            this.FtpCwdBox.Location = new System.Drawing.Point(13, 65);
            this.FtpCwdBox.Name = "FtpCwdBox";
            this.FtpCwdBox.Size = new System.Drawing.Size(309, 22);
            this.FtpCwdBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Сервер";
            // 
            // FtpHostBox
            // 
            this.FtpHostBox.BackColor = System.Drawing.Color.AliceBlue;
            this.FtpHostBox.Location = new System.Drawing.Point(13, 21);
            this.FtpHostBox.Name = "FtpHostBox";
            this.FtpHostBox.Size = new System.Drawing.Size(309, 22);
            this.FtpHostBox.TabIndex = 18;
            // 
            // FtpUsernameBox
            // 
            this.FtpUsernameBox.BackColor = System.Drawing.Color.AliceBlue;
            this.FtpUsernameBox.Location = new System.Drawing.Point(13, 109);
            this.FtpUsernameBox.Name = "FtpUsernameBox";
            this.FtpUsernameBox.Size = new System.Drawing.Size(309, 22);
            this.FtpUsernameBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Пользователь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Пароль";
            // 
            // FtpPasswordBox
            // 
            this.FtpPasswordBox.BackColor = System.Drawing.Color.AliceBlue;
            this.FtpPasswordBox.Location = new System.Drawing.Point(13, 153);
            this.FtpPasswordBox.Name = "FtpPasswordBox";
            this.FtpPasswordBox.Size = new System.Drawing.Size(309, 22);
            this.FtpPasswordBox.TabIndex = 22;
            this.FtpPasswordBox.UseSystemPasswordChar = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(216, 248);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(118, 28);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 285);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры";
            this.MainTabControl.ResumeLayout(false);
            this.DBPage.ResumeLayout(false);
            this.DBPage.PerformLayout();
            this.FtpPage.ResumeLayout(false);
            this.FtpPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage DBPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DBDataSourceBox;
        private System.Windows.Forms.TextBox DBUsernameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DBDatabaseBox;
        private System.Windows.Forms.TextBox DBPasswordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage FtpPage;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FtpHostBox;
        private System.Windows.Forms.TextBox FtpUsernameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FtpPasswordBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FtpCwdBox;
    }
}