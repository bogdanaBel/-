namespace Manager_project
{
    partial class SelectProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProject));
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbProject
            // 
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(34, 49);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(228, 24);
            this.cbProject.TabIndex = 0;
            this.cbProject.SelectionChangeCommitted += new System.EventHandler(this.cbProject_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Продолжить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите проект для редактирования:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SelectProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор проекта";
            this.Load += new System.EventHandler(this.SelectProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}