using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Manager_project
{
    public partial class RegForm : Form
    {
        Int32 id_dolj, id_employee;
        private Menu menu;
        public RegForm(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }
        string RegPass = @"[^!@%$*&~`'/\|()?]$";
        SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);

        private void btVhod_Click(object sender, EventArgs e)
        {
            if (tbFam.Text == "" | tbIm.Text == "" | tbOtchestvo.Text == "" | tbDate.Text == "")
                MessageBox.Show("Не все поля заполнены!");
            if (tbFam.Text == "") tbFam.BackColor = Color.Red;
            if (tbIm.Text == "") tbIm.BackColor = Color.Red;
            if (tbOtchestvo.Text == "") tbOtchestvo.BackColor = Color.Red;
            if (tbDate.Text == "") tbDate.BackColor = Color.Red;
            else
            {
                tbFam.BackColor = Color.White;
                tbIm.BackColor = Color.White;
                tbOtchestvo.BackColor = Color.White;
                tbDate.BackColor = Color.White;
                switch (TxbNewLogin.Text == "")
                {
                    case (true):
                        TxbNewLogin.BackColor = System.Drawing.Color.Red;
                        LabelError1.Visible = true;
                        LabelError1.Text = "Логин пуст, введите логин";
                        break;

                    case (false):
                        LabelError1.Visible = false;
                        TxbNewLogin.BackColor = System.Drawing.Color.White;

                        switch (TxbNewPass.Text == "")
                        {
                            case (true):
                                TxbNewPass.BackColor = System.Drawing.Color.Red;
                                LabelError2.Visible = true;
                                LabelError2.Text = "Пароль пуст, введите пароль";
                                if (TxbConfPass.Text == "")
                                {
                                    TxbConfPass.BackColor = System.Drawing.Color.Red;
                                    LabelError3.Visible = true;
                                    LabelError3.Text = "Повторите пароль";
                                }
                                break;

                            case (false):
                                LabelError2.Visible = false;
                                TxbNewPass.BackColor = System.Drawing.Color.White;
                                switch (TxbConfPass.Text == "")
                                {
                                    case (true):
                                        TxbConfPass.BackColor = System.Drawing.Color.Red;
                                        LabelError3.Visible = true;
                                        LabelError3.Text = "Повторите пароль";
                                        break;

                                    case (false):
                                        LabelError3.Visible = false;
                                        TxbConfPass.BackColor = System.Drawing.Color.White;
                                        Int32 haveID = 0;
                                        switch (TxbNewPass.Text == TxbConfPass.Text)
                                        {

                                            case (true):
                                                switch (TxbNewLogin.Text.Length > 15)
                                                {
                                                    case (true):
                                                        LabelError1.Visible = true;
                                                        LabelError1.Text = "Длина логина должна быть меньше 15 символов!";
                                                        TxbNewLogin.BackColor = System.Drawing.Color.Red;
                                                        break;

                                                    case (false):
                                                        LabelError1.Visible = false;
                                                        TxbNewLogin.BackColor = System.Drawing.Color.White;

                                                        switch (TxbNewPass.Text.Length > 15)
                                                        {
                                                            case (true):
                                                                LabelError2.Visible = true;
                                                                LabelError2.Text = "Длина пароля должна быть меньше 15 символов!";
                                                                TxbNewPass.BackColor = System.Drawing.Color.Red;
                                                                break;

                                                            case (false):
                                                                TxbNewPass.BackColor = System.Drawing.Color.White;
                                                                TxbConfPass.BackColor = System.Drawing.Color.White;
                                                                LabelError3.Visible = false;


                                                                command.CommandText = "Select count(*) from [dbo].[avtoriz]" +
                                                                    "where login='" + TxbNewLogin.Text + "' and password='"+TxbNewPass.Text + "'";
                                                                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                                                                if (command.ExecuteScalar() != null)
                                                                    haveID = 0;
                                                                else haveID = 1;
                                                                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                                                                switch (haveID)
                                                                {
                                                                    case (1):

                                                                        LabelError1.Text = "Пользователь с таким логином уже существует в системе! Введите другой";
                                                                        TxbNewLogin.BackColor = System.Drawing.Color.Red;
                                                                        LabelError1.Visible = true;
                                                                        break;

                                                                    case (0):

                                                                        switch (Regex.IsMatch(TxbNewPass.Text, RegPass))
                                                                        {
                                                                            case (true):
                                                                                TxbNewPass.BackColor = System.Drawing.Color.White;
                                                                                LabelError1.Visible = false;
                                                                                NewUser();

                                                                                break;

                                                                            case (false):
                                                                                LabelError2.Text = "В пароле присутствуют спец символы, которые нельзя использовать! То есть такие как !?@#$%^&*()";
                                                                                TxbNewPass.BackColor = System.Drawing.Color.Red;
                                                                                LabelError2.Visible = true;
                                                                                break;
                                                                        }

                                                                        break;
                                                                }
                                                                
                                                                break;
                                                        }
                                                        break;
                                                }
                                                
                                                break;
                                            case (false):
                                                TxbNewPass.BackColor = System.Drawing.Color.Orange;
                                                TxbConfPass.BackColor = System.Drawing.Color.Orange;
                                                LabelError3.Visible = true;
                                                LabelError3.Text = "Пароли не совпадают!";
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;


                }
                
            }
        }

        private void NewUser()
        {
            // добавление сотрудника в таблицу
            command.CommandText = "Insert into [dbo].[employee] " +
                      "(F_employee, I_employee, O_employee, Date_of_birthday, id_dolj, employee_logical_delete, Experience) " +
                      "values ('" + tbFam.Text + "','" + tbIm.Text + "','" + tbOtchestvo.Text + "','" + tbDate.Text + "'," + id_dolj.ToString() + ",0,0)";

            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

            // поиск ключа созданного сотрудника
            command.CommandText = "Select max(id_employee) from Employee";

            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            id_employee = Convert.ToInt32(command.ExecuteScalar().ToString());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();


            command.CommandText = "Insert into [dbo].[avtoriz] " +
                       "(login, password, id_role, id_employee) " +
                       "values ('" + TxbNewLogin.Text + "','" + TxbNewPass.Text + "', 3," + id_employee.ToString() +")";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            Program.avtoriz = true;
            menu.CheckAccessUser();
            if ((Program.sprav_customer == 0) && (Program.sprav_plan_work == 0) && (Program.sprav_staff_work_shedule == 0)
                && (Program.sprav_fixed_project == 0) && (Program.sprav_employee == 0) && (Program.sprav_work_journal == 0))
            MessageBox.Show("Данная учетная запись проверяется администратором. Как только запись будет подтверждена," +
                " вы получите доступ к справочникам.", "Нет доступа!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
            
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            cbDoljFill();
            LabelError1.Visible = false;
            LabelError2.Visible = false;
            LabelError3.Visible = false;
        }

        private void cbDoljFill()
        {
            try
            {
                // заполнение таблицы
                Tables data = new Tables();
                string query = data.qrDolj + " where dolj_logical_delete = 0";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                data.dtFill(data.dtDolj, query);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbDolj.DataSource = data.dtDolj;
                cbDolj.ValueMember = "id_dolj";
                cbDolj.DisplayMember = "Должность";
            }

            // предусмотрение ошибок
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbDolj_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_dolj = Convert.ToInt32(cbDolj.SelectedValue.ToString());
        }
    }
}
