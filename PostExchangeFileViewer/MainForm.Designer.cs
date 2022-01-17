namespace PostExchangeFileViewer {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainAppMenuStrip = new System.Windows.Forms.MenuStrip();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DBSetiingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.FileTypeBox = new System.Windows.Forms.ComboBox();
            this.PostOfficesBox = new System.Windows.Forms.CheckedListBox();
            this.PostOfficesLabel = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainImageList = new System.Windows.Forms.ImageList(this.components);
            this.DateBeginLabel = new System.Windows.Forms.Label();
            this.DateEndLabel = new System.Windows.Forms.Label();
            this.DateBeginPicker = new System.Windows.Forms.DateTimePicker();
            this.DateEndPicker = new System.Windows.Forms.DateTimePicker();
            this.CheckAllBox = new System.Windows.Forms.CheckBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CopyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyFileNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainAppMenuStrip.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.CopyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainAppMenuStrip
            // 
            this.MainAppMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenuItem,
            this.HelpMenuItem});
            this.MainAppMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainAppMenuStrip.Name = "MainAppMenuStrip";
            this.MainAppMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MainAppMenuStrip.TabIndex = 0;
            this.MainAppMenuStrip.Text = "menuStrip1";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DBSetiingsMenuItem});
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsMenuItem.Text = "Настройки";
            // 
            // DBSetiingsMenuItem
            // 
            this.DBSetiingsMenuItem.Image = global::PostExchangeFileViewer.Properties.Resources.settings_img;
            this.DBSetiingsMenuItem.Name = "DBSetiingsMenuItem";
            this.DBSetiingsMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            this.DBSetiingsMenuItem.Size = new System.Drawing.Size(253, 22);
            this.DBSetiingsMenuItem.Text = "Параметры программы";
            this.DBSetiingsMenuItem.Click += new System.EventHandler(this.DBSetiingsMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpMenuItem.Text = "Справка";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.ShortcutKeyDisplayString = "F1";
            this.AboutMenuItem.Size = new System.Drawing.Size(168, 22);
            this.AboutMenuItem.Text = "О программе";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.AutoSize = true;
            this.FileTypeLabel.Location = new System.Drawing.Point(12, 37);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(87, 16);
            this.FileTypeLabel.TabIndex = 1;
            this.FileTypeLabel.Text = "Тип файлов";
            // 
            // FileTypeBox
            // 
            this.FileTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileTypeBox.FormattingEnabled = true;
            this.FileTypeBox.Location = new System.Drawing.Point(15, 56);
            this.FileTypeBox.Name = "FileTypeBox";
            this.FileTypeBox.Size = new System.Drawing.Size(522, 24);
            this.FileTypeBox.TabIndex = 0;
            // 
            // PostOfficesBox
            // 
            this.PostOfficesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostOfficesBox.CheckOnClick = true;
            this.PostOfficesBox.FormattingEnabled = true;
            this.PostOfficesBox.IntegralHeight = false;
            this.PostOfficesBox.Location = new System.Drawing.Point(552, 82);
            this.PostOfficesBox.Name = "PostOfficesBox";
            this.PostOfficesBox.Size = new System.Drawing.Size(220, 474);
            this.PostOfficesBox.TabIndex = 3;
            // 
            // PostOfficesLabel
            // 
            this.PostOfficesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostOfficesLabel.AutoSize = true;
            this.PostOfficesLabel.Location = new System.Drawing.Point(549, 33);
            this.PostOfficesLabel.Name = "PostOfficesLabel";
            this.PostOfficesLabel.Size = new System.Drawing.Size(87, 16);
            this.PostOfficesLabel.TabIndex = 4;
            this.PostOfficesLabel.Text = "Список ОПС";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.MainTabControl.ImageList = this.MainImageList;
            this.MainTabControl.Location = new System.Drawing.Point(16, 140);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(521, 416);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.MainTabControl.TabIndex = 7;
            this.MainTabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainTabControl_MouseClick);
            // 
            // MainImageList
            // 
            this.MainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainImageList.ImageStream")));
            this.MainImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MainImageList.Images.SetKeyName(0, "stamp.png");
            this.MainImageList.Images.SetKeyName(1, "bad.png");
            // 
            // DateBeginLabel
            // 
            this.DateBeginLabel.AutoSize = true;
            this.DateBeginLabel.Location = new System.Drawing.Point(13, 93);
            this.DateBeginLabel.Name = "DateBeginLabel";
            this.DateBeginLabel.Size = new System.Drawing.Size(78, 16);
            this.DateBeginLabel.TabIndex = 6;
            this.DateBeginLabel.Text = "Начиная с:";
            // 
            // DateEndLabel
            // 
            this.DateEndLabel.AutoSize = true;
            this.DateEndLabel.Location = new System.Drawing.Point(223, 93);
            this.DateEndLabel.Name = "DateEndLabel";
            this.DateEndLabel.Size = new System.Drawing.Size(89, 16);
            this.DateEndLabel.TabIndex = 7;
            this.DateEndLabel.Text = "заканчивая:";
            // 
            // DateBeginPicker
            // 
            this.DateBeginPicker.Location = new System.Drawing.Point(15, 112);
            this.DateBeginPicker.Name = "DateBeginPicker";
            this.DateBeginPicker.Size = new System.Drawing.Size(193, 22);
            this.DateBeginPicker.TabIndex = 1;
            // 
            // DateEndPicker
            // 
            this.DateEndPicker.Location = new System.Drawing.Point(226, 112);
            this.DateEndPicker.Name = "DateEndPicker";
            this.DateEndPicker.Size = new System.Drawing.Size(193, 22);
            this.DateEndPicker.TabIndex = 2;
            // 
            // CheckAllBox
            // 
            this.CheckAllBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckAllBox.AutoSize = true;
            this.CheckAllBox.Location = new System.Drawing.Point(553, 562);
            this.CheckAllBox.Name = "CheckAllBox";
            this.CheckAllBox.Size = new System.Drawing.Size(109, 20);
            this.CheckAllBox.TabIndex = 4;
            this.CheckAllBox.Text = "Выбрать все";
            this.CheckAllBox.UseVisualStyleBackColor = true;
            this.CheckAllBox.CheckedChanged += new System.EventHandler(this.CheckAllBox_CheckedChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.MaxLength = 256;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(197, 20);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.SearchBox);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Location = new System.Drawing.Point(552, 54);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(220, 24);
            this.SearchPanel.TabIndex = 10;
            // 
            // SearchButton
            // 
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = global::PostExchangeFileViewer.Properties.Resources.search;
            this.SearchButton.Location = new System.Drawing.Point(200, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Padding = new System.Windows.Forms.Padding(0, 0, 4, 2);
            this.SearchButton.Size = new System.Drawing.Size(18, 22);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.TabStop = false;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CopyMenuStrip
            // 
            this.CopyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyFileNameMenuItem});
            this.CopyMenuStrip.Name = "CopyMenuStrip";
            this.CopyMenuStrip.Size = new System.Drawing.Size(203, 26);
            this.CopyMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.CopyMenuStrip_Opening);
            // 
            // CopyFileNameMenuItem
            // 
            this.CopyFileNameMenuItem.Image = global::PostExchangeFileViewer.Properties.Resources.copy;
            this.CopyFileNameMenuItem.Name = "CopyFileNameMenuItem";
            this.CopyFileNameMenuItem.Size = new System.Drawing.Size(202, 22);
            this.CopyFileNameMenuItem.Text = "Копировать имя файла";
            this.CopyFileNameMenuItem.Click += new System.EventHandler(this.CopyFileNameMenuItem_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewButton.Image = global::PostExchangeFileViewer.Properties.Resources.download;
            this.ViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewButton.Location = new System.Drawing.Point(16, 562);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(220, 28);
            this.ViewButton.TabIndex = 6;
            this.ViewButton.Text = "     Загрузить информацию";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(238, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "(F5)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(664, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "(Ctrl + A)";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.CheckAllBox);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.DateEndPicker);
            this.Controls.Add(this.DateBeginPicker);
            this.Controls.Add(this.DateEndLabel);
            this.Controls.Add(this.DateBeginLabel);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.PostOfficesLabel);
            this.Controls.Add(this.PostOfficesBox);
            this.Controls.Add(this.FileTypeBox);
            this.Controls.Add(this.FileTypeLabel);
            this.Controls.Add(this.MainAppMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обозреватель файлов с отделений";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainAppMenuStrip.ResumeLayout(false);
            this.MainAppMenuStrip.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.CopyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainAppMenuStrip;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.ComboBox FileTypeBox;
        private System.Windows.Forms.CheckedListBox PostOfficesBox;
        private System.Windows.Forms.Label PostOfficesLabel;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.Label DateBeginLabel;
        private System.Windows.Forms.Label DateEndLabel;
        private System.Windows.Forms.DateTimePicker DateBeginPicker;
        private System.Windows.Forms.DateTimePicker DateEndPicker;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DBSetiingsMenuItem;
        private System.Windows.Forms.CheckBox CheckAllBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.ContextMenuStrip CopyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyFileNameMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList MainImageList;
    }
}

