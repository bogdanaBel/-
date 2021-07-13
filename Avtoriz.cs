using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Manager_project
{
    public partial class Avtoriz : Form
    {
        private Menu menu;
        public Avtoriz(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }
        private Int32 id_avtoriz, id_role;
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);

        private void btVhod_Click(object sender, EventArgs e)
        {
            // проверка на заполненность полей
            if ((TblLogin.Text == "") || (TblPassword.Text == ""))
            {
                if (TblLogin.Text == "")
                {
                    TblLogin.BackColor = System.Drawing.Color.Red;
                    LabelError1.Visible = true;
                    LabelError1.Text = "Пустой логин, введите логин";
                }
                else
                {
                    TblLogin.BackColor = System.Drawing.Color.White;
                    LabelError1.Visible = false;
                }

                if (TblPassword.Text == "")
                {
                    TblPassword.BackColor = System.Drawing.Color.Red;
                    LabelError2.Visible = true;
                    LabelError2.Text = "Пустой пароль, введите пароль";
                }
                else
                {
                    TblPassword.BackColor = System.Drawing.Color.White;
                    LabelError2.Visible = false;
                }
            }
            else
            {
                Authoriz(TblLogin.Text, TblPassword.Text);
            }
        }

        private void Authoriz(string login, string password)
        {
            // проверка на наличие логина и пароля в таблице
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.CommandText = "Select id_avtoriz " +
                "from avtoriz " +
                "where (login = '" + TblLogin.Text + "') " +
                "and (password = '" + TblPassword.Text + "')";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            if (command.ExecuteScalar() == null)
                id_avtoriz = 0;
            else id_avtoriz = Convert.ToInt32(command.ExecuteScalar().ToString());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

            // получение роли пользователя
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.CommandText = "Select id_role " +
                "from avtoriz " +
                "where (login = '" + TblLogin.Text + "') " +
                "and (password = '" + TblPassword.Text + "')";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            id_role = Convert.ToInt32(command.ExecuteScalar().ToString());

            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            
            switch (id_avtoriz)
            {
                case (0):
                    {
                        MessageBox.Show("Данного пользователя нет в системе!");
                    }
                    break;

                default:
                    {
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        command.CommandText = "Select id_employee " +
                            "from avtoriz " +
                            "where (id_avtoriz = '" + id_avtoriz.ToString() + "') ";
                        // получение зайденного пользователя
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                        Program.id_sel_employee = Convert.ToInt32(command.ExecuteScalar().ToString());
                           ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                        Program.avtoriz = true;
                        // проверка прав доступа к системе
                        check_access_user();
                        menu.CheckAccessUser();
                        this.Close();
                    }
                    break;
            }

        }

        private void check_access_user()
        {
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            // получение доступа к функциям и справочникам
            check_access("sprav_customer");
            Program.sprav_customer =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("sprav_fixed_project");
            Program.sprav_fixed_project =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("sprav_employee");
            Program.sprav_employee =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("sprav_staff_work_shedule");
            Program.sprav_staff_work_shedule =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("sprav_work_plan");
            Program.sprav_plan_work =
            Convert.ToInt32(command.ExecuteScalar().ToString());
            

            check_access("sprav_work_journal");
            Program.sprav_work_journal =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("Administration");
            Program.Administration =
            Convert.ToInt32(command.ExecuteScalar().ToString());
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.регистрацияToolStripMenuItem_Click(sender, e);
        }

        private void Avtoriz_Load(object sender, EventArgs e)
        {

        }

        private void check_access(string table)
        {
            // получение значения роли
            command.CommandText = "select [dbo].[role].[" + table + "] " +
            "from [dbo].[avtoriz] join [dbo].[role] " +
            "on [dbo].[avtoriz].[id_role] = [dbo].[role].[id_role] " +
            "where [dbo].[avtoriz].[id_role] = " + id_role.ToString();

        }
    }
}
