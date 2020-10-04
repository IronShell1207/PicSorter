namespace PicSorter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tbfolderpath = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.progss = new MetroFramework.Controls.MetroProgressBar();
            this.labelStatus = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSettings = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelC = new MetroFramework.Controls.MetroLabel();
            this.cbSq = new MetroFramework.Controls.MetroCheckBox();
            this.cbPort = new MetroFramework.Controls.MetroCheckBox();
            this.cbLand = new MetroFramework.Controls.MetroCheckBox();
            this.labelVer = new MetroFramework.Controls.MetroLabel();
            this.labelSettings = new MetroFramework.Controls.MetroLabel();
            this.buttonUpdate = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(362, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(103, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Select folder";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tbfolderpath
            // 
            // 
            // 
            // 
            this.tbfolderpath.CustomButton.Image = null;
            this.tbfolderpath.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.tbfolderpath.CustomButton.Name = "";
            this.tbfolderpath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbfolderpath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbfolderpath.CustomButton.TabIndex = 1;
            this.tbfolderpath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbfolderpath.CustomButton.UseSelectable = true;
            this.tbfolderpath.CustomButton.Visible = false;
            this.tbfolderpath.Lines = new string[0];
            this.tbfolderpath.Location = new System.Drawing.Point(23, 63);
            this.tbfolderpath.MaxLength = 32767;
            this.tbfolderpath.Name = "tbfolderpath";
            this.tbfolderpath.PasswordChar = '\0';
            this.tbfolderpath.PromptText = "Folder path";
            this.tbfolderpath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbfolderpath.SelectedText = "";
            this.tbfolderpath.SelectionLength = 0;
            this.tbfolderpath.SelectionStart = 0;
            this.tbfolderpath.ShortcutsEnabled = true;
            this.tbfolderpath.Size = new System.Drawing.Size(333, 23);
            this.tbfolderpath.Style = MetroFramework.MetroColorStyle.Silver;
            this.tbfolderpath.TabIndex = 1;
            this.tbfolderpath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbfolderpath.UseSelectable = true;
            this.tbfolderpath.WaterMark = "Folder path";
            this.tbfolderpath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbfolderpath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbfolderpath.TextChanged += new System.EventHandler(this.tbfolderpath_TextChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(374, 379);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(91, 24);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Start";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(23, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(442, 242);
            this.listBox1.TabIndex = 4;
            // 
            // progss
            // 
            this.progss.Location = new System.Drawing.Point(23, 350);
            this.progss.Name = "progss";
            this.progss.Size = new System.Drawing.Size(442, 23);
            this.progss.Style = MetroFramework.MetroColorStyle.Silver;
            this.progss.TabIndex = 5;
            this.progss.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(23, 382);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(50, 19);
            this.labelStatus.Style = MetroFramework.MetroColorStyle.Silver;
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status: ";
            this.labelStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(123, 382);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Time: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelSettings
            // 
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.buttonUpdate);
            this.panelSettings.Controls.Add(this.pictureBox2);
            this.panelSettings.Controls.Add(this.pictureBox1);
            this.panelSettings.Controls.Add(this.labelC);
            this.panelSettings.Controls.Add(this.cbSq);
            this.panelSettings.Controls.Add(this.cbPort);
            this.panelSettings.Controls.Add(this.cbLand);
            this.panelSettings.Controls.Add(this.labelVer);
            this.panelSettings.Controls.Add(this.labelSettings);
            this.panelSettings.HorizontalScrollbarBarColor = true;
            this.panelSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSettings.HorizontalScrollbarSize = 10;
            this.panelSettings.Location = new System.Drawing.Point(201, 248);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(167, 162);
            this.panelSettings.Style = MetroFramework.MetroColorStyle.Silver;
            this.panelSettings.TabIndex = 8;
            this.panelSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelSettings.VerticalScrollbarBarColor = true;
            this.panelSettings.VerticalScrollbarHighlightOnWheel = false;
            this.panelSettings.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PicSorter.Properties.Resources.arrowup;
            this.pictureBox2.Location = new System.Drawing.Point(106, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PicSorter.Properties.Resources.arrowup;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelC.Location = new System.Drawing.Point(30, 28);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(109, 15);
            this.labelC.TabIndex = 6;
            this.labelC.Text = "Sorting orientations:";
            this.labelC.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbSq
            // 
            this.cbSq.AutoSize = true;
            this.cbSq.Checked = true;
            this.cbSq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSq.Location = new System.Drawing.Point(48, 84);
            this.cbSq.Name = "cbSq";
            this.cbSq.Size = new System.Drawing.Size(59, 15);
            this.cbSq.TabIndex = 5;
            this.cbSq.Text = "Square";
            this.cbSq.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbSq.UseSelectable = true;
            // 
            // cbPort
            // 
            this.cbPort.AutoSize = true;
            this.cbPort.Checked = true;
            this.cbPort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPort.Location = new System.Drawing.Point(48, 65);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(62, 15);
            this.cbPort.TabIndex = 5;
            this.cbPort.Text = "Portrait";
            this.cbPort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbPort.UseSelectable = true;
            // 
            // cbLand
            // 
            this.cbLand.AutoSize = true;
            this.cbLand.Checked = true;
            this.cbLand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLand.Location = new System.Drawing.Point(48, 46);
            this.cbLand.Name = "cbLand";
            this.cbLand.Size = new System.Drawing.Size(79, 15);
            this.cbLand.TabIndex = 4;
            this.cbLand.Text = "Landscape";
            this.cbLand.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbLand.UseSelectable = true;
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelVer.Location = new System.Drawing.Point(-1, 145);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(70, 15);
            this.labelVer.TabIndex = 3;
            this.labelVer.Text = "metroLabel3";
            this.labelVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVer.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Location = new System.Drawing.Point(54, 3);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(54, 19);
            this.labelSettings.TabIndex = 2;
            this.labelSettings.Text = "Settings";
            this.labelSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.buttonUpdate.Location = new System.Drawing.Point(106, 133);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(57, 27);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Check\r\nupdates";
            this.buttonUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonUpdate.UseSelectable = true;
            this.buttonUpdate.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 411);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progss);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.tbfolderpath);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Picture sorter";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox tbfolderpath;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroProgressBar progss;
        private MetroFramework.Controls.MetroLabel labelStatus;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroPanel panelSettings;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel labelC;
        private MetroFramework.Controls.MetroCheckBox cbSq;
        private MetroFramework.Controls.MetroCheckBox cbPort;
        private MetroFramework.Controls.MetroCheckBox cbLand;
        private MetroFramework.Controls.MetroLabel labelVer;
        private MetroFramework.Controls.MetroLabel labelSettings;
        private MetroFramework.Controls.MetroButton buttonUpdate;
    }
}

