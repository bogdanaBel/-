namespace Manager_project
{
    partial class SendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMail));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbTema = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Тема:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(460, 254);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(124, 46);
            this.buttonSend.TabIndex = 11;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(19, 86);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(564, 162);
            this.tbMessage.TabIndex = 10;
            // 
            // tbTema
            // 
            this.tbTema.Location = new System.Drawing.Point(84, 48);
            this.tbTema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTema.Name = "tbTema";
            this.tbTema.Size = new System.Drawing.Size(251, 22);
            this.tbTema.TabIndex = 9;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(341, 18);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(46, 17);
            this.lblPath.TabIndex = 18;
            this.lblPath.Text = "label4";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(19, 254);
            this.btOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(159, 42);
            this.btOpen.TabIndex = 17;
            this.btOpen.Text = "Выбрать документ...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Кому:";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(84, 18);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(251, 24);
            this.cbCustomer.TabIndex = 16;
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 309);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbTema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправка файла по электронной почте";
            this.Load += new System.EventHandler(this.SendMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbTema;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCustomer;
    }
}