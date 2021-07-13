namespace Manager_project
{
    partial class AvtorizForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAvtoriz = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbSotr = new System.Windows.Forms.ComboBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvtoriz)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.dgvAvtoriz, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbFilter, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btAdd, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.btUpdate, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.btDelete, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.cbRole, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbSotr, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbLogin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 422);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dgvAvtoriz
            // 
            this.dgvAvtoriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvAvtoriz, 3);
            this.dgvAvtoriz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvtoriz.Location = new System.Drawing.Point(28, 168);
            this.dgvAvtoriz.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dgvAvtoriz.Name = "dgvAvtoriz";
            this.tableLayoutPanel1.SetRowSpan(this.dgvAvtoriz, 2);
            this.dgvAvtoriz.Size = new System.Drawing.Size(453, 126);
            this.dgvAvtoriz.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(28, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(453, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Поиск и фильтрация:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFilter
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbFilter, 3);
            this.tbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFilter.Location = new System.Drawing.Point(28, 147);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(453, 22);
            this.tbFilter.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(270, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сотрудник:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(28, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassword.Location = new System.Drawing.Point(28, 87);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(211, 22);
            this.tbPassword.TabIndex = 5;
            // 
            // btAdd
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btAdd, 3);
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAdd.Location = new System.Drawing.Point(28, 297);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(453, 36);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btUpdate, 3);
            this.btUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btUpdate.Location = new System.Drawing.Point(28, 339);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(453, 36);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.Text = "Изменить";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btDelete, 3);
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDelete.Location = new System.Drawing.Point(28, 381);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(453, 38);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // cbRole
            // 
            this.cbRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(269, 86);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(213, 24);
            this.cbRole.TabIndex = 12;
            // 
            // cbSotr
            // 
            this.cbSotr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSotr.FormattingEnabled = true;
            this.cbSotr.Location = new System.Drawing.Point(269, 44);
            this.cbSotr.Margin = new System.Windows.Forms.Padding(2);
            this.cbSotr.Name = "cbSotr";
            this.cbSotr.Size = new System.Drawing.Size(213, 24);
            this.cbSotr.TabIndex = 13;
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogin.Location = new System.Drawing.Point(28, 45);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(211, 22);
            this.tbLogin.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(270, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Роль:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvtorizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(530, 469);
            this.Name = "AvtorizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник \"Логины и пароли пользователей\"";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvtoriz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvAvtoriz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbSotr;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label5;
    }
}