namespace Manager_project
{
    partial class RoleForm
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
            this.btAdd = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.CheckBox();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.cbPlanWork = new System.Windows.Forms.CheckBox();
            this.cbStaffWork = new System.Windows.Forms.CheckBox();
            this.cbSotr = new System.Windows.Forms.CheckBox();
            this.cbJournalWork = new System.Windows.Forms.CheckBox();
            this.cbRole = new System.Windows.Forms.CheckBox();
            this.cbFixedProject = new System.Windows.Forms.CheckBox();
            this.cbAvtoriz = new System.Windows.Forms.CheckBox();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.btAdd, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbCustomer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvRole, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbPlanWork, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbStaffWork, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbSotr, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbJournalWork, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbFixedProject, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbAvtoriz, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbRole, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbRole, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btUpdate, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btDelete, 3, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAdd.Location = new System.Drawing.Point(40, 356);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(216, 60);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // cbCustomer
            // 
            this.cbCustomer.AutoSize = true;
            this.cbCustomer.Location = new System.Drawing.Point(40, 47);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(100, 21);
            this.cbCustomer.TabIndex = 1;
            this.cbCustomer.Text = "Заказчики";
            this.cbCustomer.UseVisualStyleBackColor = true;
            // 
            // dgvRole
            // 
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvRole, 3);
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.Location = new System.Drawing.Point(40, 223);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowTemplate.Height = 24;
            this.dgvRole.Size = new System.Drawing.Size(660, 127);
            this.dgvRole.TabIndex = 2;
            // 
            // cbPlanWork
            // 
            this.cbPlanWork.AutoSize = true;
            this.cbPlanWork.Location = new System.Drawing.Point(40, 91);
            this.cbPlanWork.Name = "cbPlanWork";
            this.cbPlanWork.Size = new System.Drawing.Size(107, 21);
            this.cbPlanWork.TabIndex = 3;
            this.cbPlanWork.Text = "План работ";
            this.cbPlanWork.UseVisualStyleBackColor = true;
            // 
            // cbStaffWork
            // 
            this.cbStaffWork.AutoSize = true;
            this.cbStaffWork.Location = new System.Drawing.Point(40, 135);
            this.cbStaffWork.Name = "cbStaffWork";
            this.cbStaffWork.Size = new System.Drawing.Size(210, 21);
            this.cbStaffWork.TabIndex = 4;
            this.cbStaffWork.Text = "График работ сотрудников";
            this.cbStaffWork.UseVisualStyleBackColor = true;
            // 
            // cbSotr
            // 
            this.cbSotr.AutoSize = true;
            this.cbSotr.Location = new System.Drawing.Point(40, 179);
            this.cbSotr.Name = "cbSotr";
            this.cbSotr.Size = new System.Drawing.Size(108, 21);
            this.cbSotr.TabIndex = 5;
            this.cbSotr.Text = "Сотрудники";
            this.cbSotr.UseVisualStyleBackColor = true;
            // 
            // cbJournalWork
            // 
            this.cbJournalWork.AutoSize = true;
            this.cbJournalWork.Location = new System.Drawing.Point(262, 47);
            this.cbJournalWork.Name = "cbJournalWork";
            this.cbJournalWork.Size = new System.Drawing.Size(125, 21);
            this.cbJournalWork.TabIndex = 6;
            this.cbJournalWork.Text = "Журнал работ";
            this.cbJournalWork.UseVisualStyleBackColor = true;
            // 
            // cbRole
            // 
            this.cbRole.AutoSize = true;
            this.cbRole.Location = new System.Drawing.Point(262, 135);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(63, 21);
            this.cbRole.TabIndex = 7;
            this.cbRole.Text = "Роли";
            this.cbRole.UseVisualStyleBackColor = true;
            // 
            // cbFixedProject
            // 
            this.cbFixedProject.AutoSize = true;
            this.cbFixedProject.Location = new System.Drawing.Point(262, 91);
            this.cbFixedProject.Name = "cbFixedProject";
            this.cbFixedProject.Size = new System.Drawing.Size(188, 21);
            this.cbFixedProject.TabIndex = 7;
            this.cbFixedProject.Text = "Закрепленные проекты";
            this.cbFixedProject.UseVisualStyleBackColor = true;
            // 
            // cbAvtoriz
            // 
            this.cbAvtoriz.AutoSize = true;
            this.cbAvtoriz.Location = new System.Drawing.Point(262, 179);
            this.cbAvtoriz.Name = "cbAvtoriz";
            this.cbAvtoriz.Size = new System.Drawing.Size(116, 21);
            this.cbAvtoriz.TabIndex = 8;
            this.cbAvtoriz.Text = "Авторизация";
            this.cbAvtoriz.UseVisualStyleBackColor = true;
            // 
            // tbRole
            // 
            this.tbRole.Location = new System.Drawing.Point(484, 135);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(100, 22);
            this.tbRole.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя роли:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btUpdate
            // 
            this.btUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btUpdate.Location = new System.Drawing.Point(262, 356);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(216, 60);
            this.btUpdate.TabIndex = 11;
            this.btUpdate.Text = "Изменить";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDelete.Location = new System.Drawing.Point(484, 356);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(216, 60);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(757, 342);
            this.Name = "RoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник \"Права доступа\"";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.CheckBox cbCustomer;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.CheckBox cbPlanWork;
        private System.Windows.Forms.CheckBox cbStaffWork;
        private System.Windows.Forms.CheckBox cbSotr;
        private System.Windows.Forms.CheckBox cbJournalWork;
        private System.Windows.Forms.CheckBox cbFixedProject;
        private System.Windows.Forms.CheckBox cbAvtoriz;
        private System.Windows.Forms.CheckBox cbRole;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
    }
}