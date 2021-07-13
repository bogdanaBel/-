namespace Manager_project
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.btCancel = new System.Windows.Forms.Button();
            this.lbloi = new System.Windows.Forms.Label();
            this.lbhg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOtchestvo = new System.Windows.Forms.TextBox();
            this.tbIm = new System.Windows.Forms.TextBox();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelError3 = new System.Windows.Forms.Label();
            this.TxbConfPass = new System.Windows.Forms.TextBox();
            this.LabelError2 = new System.Windows.Forms.Label();
            this.LabelError1 = new System.Windows.Forms.Label();
            this.btVhod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbNewPass = new System.Windows.Forms.TextBox();
            this.TxbNewLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.cbDolj = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(303, 299);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(202, 46);
            this.btCancel.TabIndex = 49;
            this.btCancel.Text = "Назад";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // lbloi
            // 
            this.lbloi.AutoSize = true;
            this.lbloi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbloi.Location = new System.Drawing.Point(8, 155);
            this.lbloi.Name = "lbloi";
            this.lbloi.Size = new System.Drawing.Size(96, 20);
            this.lbloi.TabIndex = 46;
            this.lbloi.Text = "Отчество:";
            // 
            // lbhg
            // 
            this.lbhg.AutoSize = true;
            this.lbhg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbhg.Location = new System.Drawing.Point(8, 87);
            this.lbhg.Name = "lbhg";
            this.lbhg.Size = new System.Drawing.Size(47, 20);
            this.lbhg.TabIndex = 45;
            this.lbhg.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Фамилия:";
            // 
            // tbOtchestvo
            // 
            this.tbOtchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOtchestvo.Location = new System.Drawing.Point(12, 178);
            this.tbOtchestvo.Name = "tbOtchestvo";
            this.tbOtchestvo.Size = new System.Drawing.Size(226, 27);
            this.tbOtchestvo.TabIndex = 42;
            // 
            // tbIm
            // 
            this.tbIm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIm.Location = new System.Drawing.Point(12, 113);
            this.tbIm.Name = "tbIm";
            this.tbIm.Size = new System.Drawing.Size(226, 27);
            this.tbIm.TabIndex = 40;
            // 
            // tbFam
            // 
            this.tbFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFam.Location = new System.Drawing.Point(12, 43);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(226, 27);
            this.tbFam.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(279, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Повторите пароль:";
            // 
            // LabelError3
            // 
            this.LabelError3.AutoSize = true;
            this.LabelError3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelError3.Location = new System.Drawing.Point(285, 230);
            this.LabelError3.Name = "LabelError3";
            this.LabelError3.Size = new System.Drawing.Size(44, 15);
            this.LabelError3.TabIndex = 37;
            this.LabelError3.Text = "Логин:";
            // 
            // TxbConfPass
            // 
            this.TxbConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbConfPass.Location = new System.Drawing.Point(280, 248);
            this.TxbConfPass.Name = "TxbConfPass";
            this.TxbConfPass.Size = new System.Drawing.Size(225, 27);
            this.TxbConfPass.TabIndex = 36;
            this.TxbConfPass.UseSystemPasswordChar = true;
            // 
            // LabelError2
            // 
            this.LabelError2.AutoSize = true;
            this.LabelError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelError2.Location = new System.Drawing.Point(285, 162);
            this.LabelError2.Name = "LabelError2";
            this.LabelError2.Size = new System.Drawing.Size(44, 15);
            this.LabelError2.TabIndex = 35;
            this.LabelError2.Text = "Логин:";
            // 
            // LabelError1
            // 
            this.LabelError1.AutoSize = true;
            this.LabelError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelError1.Location = new System.Drawing.Point(285, 94);
            this.LabelError1.Name = "LabelError1";
            this.LabelError1.Size = new System.Drawing.Size(44, 15);
            this.LabelError1.TabIndex = 34;
            this.LabelError1.Text = "Логин:";
            // 
            // btVhod
            // 
            this.btVhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btVhod.Location = new System.Drawing.Point(41, 301);
            this.btVhod.Name = "btVhod";
            this.btVhod.Size = new System.Drawing.Size(197, 42);
            this.btVhod.TabIndex = 33;
            this.btVhod.Text = "Вход";
            this.btVhod.UseVisualStyleBackColor = true;
            this.btVhod.Click += new System.EventHandler(this.btVhod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(279, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Логин:";
            // 
            // TxbNewPass
            // 
            this.TxbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbNewPass.Location = new System.Drawing.Point(281, 179);
            this.TxbNewPass.Name = "TxbNewPass";
            this.TxbNewPass.Size = new System.Drawing.Size(225, 27);
            this.TxbNewPass.TabIndex = 30;
            this.TxbNewPass.UseSystemPasswordChar = true;
            // 
            // TxbNewLogin
            // 
            this.TxbNewLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbNewLogin.Location = new System.Drawing.Point(280, 113);
            this.TxbNewLogin.Name = "TxbNewLogin";
            this.TxbNewLogin.Size = new System.Drawing.Size(226, 27);
            this.TxbNewLogin.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Дата рождения:";
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDate.Location = new System.Drawing.Point(12, 248);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(226, 27);
            this.tbDate.TabIndex = 50;
            // 
            // cbDolj
            // 
            this.cbDolj.FormattingEnabled = true;
            this.cbDolj.Location = new System.Drawing.Point(280, 43);
            this.cbDolj.Name = "cbDolj";
            this.cbDolj.Size = new System.Drawing.Size(226, 24);
            this.cbDolj.TabIndex = 52;
            this.cbDolj.SelectionChangeCommitted += new System.EventHandler(this.cbDolj_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(280, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Должность:";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 378);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDolj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbloi);
            this.Controls.Add(this.lbhg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOtchestvo);
            this.Controls.Add(this.tbIm);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelError3);
            this.Controls.Add(this.TxbConfPass);
            this.Controls.Add(this.LabelError2);
            this.Controls.Add(this.LabelError1);
            this.Controls.Add(this.btVhod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbNewPass);
            this.Controls.Add(this.TxbNewLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbloi;
        private System.Windows.Forms.Label lbhg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOtchestvo;
        private System.Windows.Forms.TextBox tbIm;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelError3;
        private System.Windows.Forms.TextBox TxbConfPass;
        private System.Windows.Forms.Label LabelError2;
        private System.Windows.Forms.Label LabelError1;
        private System.Windows.Forms.Button btVhod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbNewPass;
        private System.Windows.Forms.TextBox TxbNewLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.ComboBox cbDolj;
        private System.Windows.Forms.Label label6;
    }
}