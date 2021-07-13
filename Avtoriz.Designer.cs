namespace Manager_project
{
    partial class Avtoriz
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
            this.btCancel = new System.Windows.Forms.Button();
            this.LabelError2 = new System.Windows.Forms.Label();
            this.LabelError1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btReg = new System.Windows.Forms.Button();
            this.btVhod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TblPassword = new System.Windows.Forms.TextBox();
            this.TblLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(99, 272);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(225, 35);
            this.btCancel.TabIndex = 29;
            this.btCancel.Text = "Назад";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // LabelError2
            // 
            this.LabelError2.AutoSize = true;
            this.LabelError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelError2.Location = new System.Drawing.Point(102, 139);
            this.LabelError2.Name = "LabelError2";
            this.LabelError2.Size = new System.Drawing.Size(44, 15);
            this.LabelError2.TabIndex = 28;
            this.LabelError2.Text = "Логин:";
            this.LabelError2.Visible = false;
            // 
            // LabelError1
            // 
            this.LabelError1.AutoSize = true;
            this.LabelError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelError1.Location = new System.Drawing.Point(102, 74);
            this.LabelError1.Name = "LabelError1";
            this.LabelError1.Size = new System.Drawing.Size(44, 15);
            this.LabelError1.TabIndex = 27;
            this.LabelError1.Text = "Логин:";
            this.LabelError1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Введите логин и пароль для входа в систему:";
            // 
            // btReg
            // 
            this.btReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReg.Location = new System.Drawing.Point(99, 234);
            this.btReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(225, 34);
            this.btReg.TabIndex = 25;
            this.btReg.Text = "Регистрация";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // btVhod
            // 
            this.btVhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btVhod.Location = new System.Drawing.Point(99, 198);
            this.btVhod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVhod.Name = "btVhod";
            this.btVhod.Size = new System.Drawing.Size(225, 32);
            this.btVhod.TabIndex = 24;
            this.btVhod.Text = "Вход";
            this.btVhod.UseVisualStyleBackColor = true;
            this.btVhod.Click += new System.EventHandler(this.btVhod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(98, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(98, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Логин:";
            // 
            // TblPassword
            // 
            this.TblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TblPassword.Location = new System.Drawing.Point(99, 157);
            this.TblPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TblPassword.Name = "TblPassword";
            this.TblPassword.Size = new System.Drawing.Size(225, 27);
            this.TblPassword.TabIndex = 21;
            this.TblPassword.UseSystemPasswordChar = true;
            // 
            // TblLogin
            // 
            this.TblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TblLogin.Location = new System.Drawing.Point(99, 92);
            this.TblLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TblLogin.Name = "TblLogin";
            this.TblLogin.Size = new System.Drawing.Size(225, 27);
            this.TblLogin.TabIndex = 20;
            // 
            // Avtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 319);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.LabelError2);
            this.Controls.Add(this.LabelError1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.btVhod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TblPassword);
            this.Controls.Add(this.TblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Avtoriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Avtoriz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label LabelError2;
        private System.Windows.Forms.Label LabelError1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.Button btVhod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TblPassword;
        private System.Windows.Forms.TextBox TblLogin;
    }
}