namespace Manager_project
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.pnControl = new System.Windows.Forms.Panel();
            this.btConect = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.statusConect = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIPServer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDataSource = new System.Windows.Forms.ComboBox();
            this.cbInitialCatalog = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnControl.SuspendLayout();
            this.statusConect.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btConect);
            this.pnControl.Controls.Add(this.btCancel);
            this.pnControl.Controls.Add(this.btCheck);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControl.Location = new System.Drawing.Point(0, 215);
            this.pnControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(479, 39);
            this.pnControl.TabIndex = 56;
            // 
            // btConect
            // 
            this.btConect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConect.Enabled = false;
            this.btConect.Location = new System.Drawing.Point(100, 0);
            this.btConect.Margin = new System.Windows.Forms.Padding(4);
            this.btConect.Name = "btConect";
            this.btConect.Size = new System.Drawing.Size(279, 39);
            this.btConect.TabIndex = 13;
            this.btConect.Text = "Подключить";
            this.btConect.UseVisualStyleBackColor = true;
            this.btConect.Click += new System.EventHandler(this.btConect_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(379, 0);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 39);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btCheck
            // 
            this.btCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCheck.Enabled = false;
            this.btCheck.Location = new System.Drawing.Point(0, 0);
            this.btCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(100, 39);
            this.btCheck.TabIndex = 10;
            this.btCheck.Text = "Проверка";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // statusConect
            // 
            this.statusConect.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusConect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusConect.Location = new System.Drawing.Point(0, 254);
            this.statusConect.Name = "statusConect";
            this.statusConect.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusConect.Size = new System.Drawing.Size(479, 25);
            this.statusConect.TabIndex = 55;
            this.statusConect.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(15, 20);
            this.tsslStatus.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Адрес сервера:";
            // 
            // cbIPServer
            // 
            this.cbIPServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbIPServer.FormattingEnabled = true;
            this.cbIPServer.Location = new System.Drawing.Point(0, 17);
            this.cbIPServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIPServer.Name = "cbIPServer";
            this.cbIPServer.Size = new System.Drawing.Size(479, 24);
            this.cbIPServer.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Название сервера:";
            // 
            // cbDataSource
            // 
            this.cbDataSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDataSource.FormattingEnabled = true;
            this.cbDataSource.Location = new System.Drawing.Point(0, 58);
            this.cbDataSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDataSource.Name = "cbDataSource";
            this.cbDataSource.Size = new System.Drawing.Size(479, 24);
            this.cbDataSource.TabIndex = 60;
            this.cbDataSource.SelectionChangeCommitted += new System.EventHandler(this.cbdataSource_SelectionChangeCommitted);
            // 
            // cbInitialCatalog
            // 
            this.cbInitialCatalog.FormattingEnabled = true;
            this.cbInitialCatalog.Location = new System.Drawing.Point(0, 180);
            this.cbInitialCatalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbInitialCatalog.Name = "cbInitialCatalog";
            this.cbInitialCatalog.Size = new System.Drawing.Size(479, 24);
            this.cbInitialCatalog.TabIndex = 61;
            this.cbInitialCatalog.SelectedIndexChanged += new System.EventHandler(this.cbInitialCatalog_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Пользователь сервера:";
            // 
            // tbUserID
            // 
            this.tbUserID.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUserID.Enabled = false;
            this.tbUserID.Location = new System.Drawing.Point(0, 99);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.PasswordChar = '*';
            this.tbUserID.Size = new System.Drawing.Size(479, 22);
            this.tbUserID.TabIndex = 64;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(0, 121);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(157, 17);
            this.lblPassword.TabIndex = 65;
            this.lblPassword.Text = "Пароль пользователя:";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(0, 138);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(479, 22);
            this.tbPassword.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Список источников данных:";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 279);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbInitialCatalog);
            this.Controls.Add(this.cbDataSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbIPServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.statusConect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Соединение с сервером базы данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionForm_FormClosing);
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.pnControl.ResumeLayout(false);
            this.statusConect.ResumeLayout(false);
            this.statusConect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btConect;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.StatusStrip statusConect;
        public System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIPServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDataSource;
        private System.Windows.Forms.ComboBox cbInitialCatalog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
    }
}

