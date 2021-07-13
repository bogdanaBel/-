namespace Manager_project
{
    partial class MailRazrab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailRazrab));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbTema = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Тема:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(125, 234);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(124, 46);
            this.buttonSend.TabIndex = 21;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(15, 55);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(336, 162);
            this.tbMessage.TabIndex = 20;
            // 
            // tbTema
            // 
            this.tbTema.Location = new System.Drawing.Point(87, 14);
            this.tbTema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTema.Name = "tbTema";
            this.tbTema.Size = new System.Drawing.Size(251, 22);
            this.tbTema.TabIndex = 19;
            // 
            // MailRazrab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbTema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MailRazrab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отзыв о программе";
            this.Load += new System.EventHandler(this.MailRazrab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbTema;
    }
}