using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Manager_project
{
    public partial class SelectProject : Form
    {
      
        SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
        private Menu menu;
        public SelectProject(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectProject_Load(object sender, EventArgs e)
        {
            cbProjectFill();
        }

        private void cbProjectFill()
        {
            // заполнение выпадающего списка проектами
            try
            {
                Tables dtProject = new Tables();
                command.CommandText = "Select id_fixed_project, Name_project from" +
                    " View_fixed_project where fixed_project_logical_delete = 0 " +
                    "and id_employee=" + Program.id_sel_employee;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtProject.dtFill(dtProject.dtFixedProject, command.CommandText);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbProject.DataSource = dtProject.dtFixedProject;
                cbProject.ValueMember = "id_fixed_project";
                cbProject.DisplayMember = "Name_project";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.id_fixed_project != null)
            {
                this.Close();
                
                switch (Program.strSelectedTab)
                {
                    case ("tpPlanWork"):
                        menu.listBoxViewWorkFill();
                        menu.listBoxIspolnitelFill();
                        menu.cbView_workFill();
                        menu.dgvPlanWorkFill();
                        break;
                    case ("tpJournalWork"):
                        menu.listBoxViewWorkinJournalFill();
                        menu.listBoxIspolnitelinJournalFill();
                        menu.cbView_workinJournalFill();
                        menu.dgvJournalFill();
                        break;
                }
            }
        }

        private void cbProject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Program.id_fixed_project = Convert.ToInt32(cbProject.SelectedValue.ToString());
            
        }
    }
}
