using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Manager_project
{
    public partial class Menu : Form
    {
        DateTime time = new DateTime();
        ConnectionForm data = new ConnectionForm();
        // массив для вывода графика работ сотрудников
        string[] months = new string[12] {"Январь","Февраль","Март","Апрель","Май","Июнь","Июль","Август",
        "Сентябрь","Октябрь", "Ноябрь", "Декабрь" };
        // массив для фамилий сотрудников
        List<string> FIO = new List<string>();
        // шаблон для электронной почты
        string patMail = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
        Int32 id_customer, id_dolj, id_fixed_project, id_employee, id_status, id_view_work,
            id_role, id_avtoriz, id_staff_work_shedule, id_plan_work, id_journal;
        Int32 sprav_customer, sprav_fixed_project, sprav_authorization,
        sprav_role, sprav_employee, sprav_staff_work_shedule, sprav_work_plan, sprav_work_journal,
            Administration, ConfigDoc, Config_org;
        string strSelectedTab = "";
        Procedures procedure = new Procedures();
        SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
        
        public Menu()
        {
            InitializeComponent();
        }
        
        private void SelectPageOnControl(TabPage tp)
        {
            // переход на вкладку
            tp.Parent = tabControl;
            tabControl.SelectTab(tp);
        }

        private void labelWinConnection_Click(object sender, EventArgs e)
        {
            // настройка соединения с сервером
            ConnectionForm f = new ConnectionForm();
            f.Show();
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            // переход на вкладку Администрирование
            SelectPageOnControl(tpAdmin);
        }
        
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // выход из приложения
            Application.Exit();
        }

        private void btSpravochnik_Click(object sender, EventArgs e)
        {
            // переход на вкладку Справочники
            SelectPageOnControl(tpSprav);
        }

       

        private void btSettings_Click(object sender, EventArgs e)
        {
            // переход на вкладку Настройки
            SelectPageOnControl(tpSetting);

        }

        private void labelWinSotr_Click(object sender, EventArgs e)
        {
            // переход на вкладку Сотрудники
            SelectPageOnControl(tpEmployee);
        }

        private void labelWinFixedProject_Click(object sender, EventArgs e)
        {
            // переход на вкладку Закрепленные проекты
            SelectPageOnControl(tpFixedProject);
        }

     

        private void labelWinJournalWork_Click(object sender, EventArgs e)
        {
            // переход на вкладку Журнал работ
            SelectPageOnControl(tpJournalWork);
        }

        private void labelWinCustomer_Click(object sender, EventArgs e)
        {
            // переход на вкладку Заказчики
            SelectPageOnControl(tpCustomer);
        }

        private void labelWinSettingDoc_Click(object sender, EventArgs e)
        {
            
            SettingDoc f = new SettingDoc();
            f.Show();
        }

        private void labelWinAvtoriz_Click(object sender, EventArgs e)
        {
            // переход на вкладку учетных записей
           SelectPageOnControl(tpAvtoriz);
        }

        private void labelWinRole_Click(object sender, EventArgs e)
        {
            // переход на вкладку прав доступа
            SelectPageOnControl(tpRole);
        }

        private void labelWinSettingOrg_Click(object sender, EventArgs e)
        {
            // переход на вкладку Информация об организации
            InfoofDoc f = new InfoofDoc();
            f.Show();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CloseAll()
        {
            //скрытие вкладок
            foreach (var tp in tabControl.Controls.OfType<TabPage>())
            {
                
                tp.Parent = null;
            }
          
        
        }

        private void btCancelTabPage_Click(object sender, EventArgs e)
        {
            CloseAll();
            CloseAll();
            CloseAll();
            CloseAll();
            CloseAll();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // отображение статуса подключение к серверу
            tsslCon.Visible = true;
            tsslCon.Text = "Определение сервера...";
            timerTsslTime.Start();
            data.conState += constate;
            Thread thread = new Thread(data.Connection_check);
            thread.Start();

            btSpravochnik.Enabled = false;
            btAdmin.Enabled = false;
            AdminToolStripMenuItem.Enabled = false;
            spravToolStripMenuItem.Enabled = false;
            NastrToolStripMenuItem.Enabled = false;
            SvyazToolStripMenuItem.Enabled = false;
            SvyazToolStripMenuItem.Visible = false;
            btSettings.Enabled = false;
            btEdit.Enabled = false;

            DoubleBuffered = true;
            CloseAll();
            CloseAll();
            CloseAll();
            CloseAll();
            CloseAll();
        }



        private void constate(bool value)
        {
            // отображение статуса подключения к серверу БД
            Action action = () =>
            {
                switch (value)
                {
                    case (true):
                        tsslCon.Text = ConnectionLibrary.ConnectionLibrary.DSIP + "\\" + ConnectionLibrary.ConnectionLibrary.DSSN + " - "
                        + ConnectionLibrary.ConnectionLibrary.IC;
                        break;
                    case (false):
                        ConnectionForm conection = new ConnectionForm();
                        tsslCon.Text = "Подключение отсутвует!";
                        //conection.Show(this);
                        break;
                }
            };
            Invoke(action);
        }

        private void labelWinSotr_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Firebrick;
        }

        private void labelWinSotr_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Black;
        }
        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // переход по вкладкам
            if (tabControl.SelectedTab != null)
            {
                Program.strSelectedTab = tabControl.SelectedTab.Name;
            }


            switch (Program.strSelectedTab)
            {
                case ("tpCustomer"):
                    dgvCustomerFill();
                    break;
                case ("tpEmployee"):
                    listBoxDoljFill();
                    dgvEmployeeFill();
                    cbDoljFill();
                    break;
                case ("tpFixedProject"):
                    dgvFixedProjectFill();
                    cbCustomerFill();
                    cbRucovoditelFill();
                    break;
                case ("tpStaffWorkShedule"):
                    listBoxStatusFill();
                    listBoxWeekDayFill();
                    cbSotrFill();
                    cbStatusFill();
                    break;
                case ("tpPlanWork"):
                    if (Program.avtoriz)
                    {
                        SelectProject f = new SelectProject(this);

                        f.Show();
                    }
                    //listBoxViewWorkFill();
                    //listBoxIspolnitelFill();
                    //cbView_workFill();
                    //dgvPlanWorkFill();
                    break;
                case ("tpJournalWork"):
                    if (Program.avtoriz)
                    {
                        SelectProject t = new SelectProject(this);
                       
                        t.Show();
                    }
                    //listBoxViewWorkinJournalFill();
                    // listBoxIspolnitelinJournalFill();
                    // cbView_workinJournalFill();
                    // dgvJournalFill();
                    break;
                case ("tpRole"):
                    listBoxRoleFill();
                    break;
                case ("tpHistory"):
                    dgvHistoryFill();
                    break;
                case ("tpAvtoriz"):
                    listBoxEmployeeFill();
                    cbRoleFill();
                    dgvAvtorizFill();
                    break;
            }
        }


        public void cbView_workFill()
        {
            // заполнение выпадающего списка видами работ
            try
            {
                Tables dtViewWork = new Tables();
                command.CommandText = "Select id_view_work, view_work from view_work where view_work_logical_delete = 0";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtViewWork.dtFill(dtViewWork.dtViewWork, command.CommandText);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbViewWorkPlanWork.DataSource = dtViewWork.dtViewWork;
                cbViewWorkPlanWork.ValueMember = "id_view_work";
                cbViewWorkPlanWork.DisplayMember = "view_work";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cbView_workinJournalFill()
        {
            // заполнение выпадающего списка видами работ
            try
            {
                Tables dtViewWork = new Tables();
                command.CommandText = "Select id_view_work, view_work from view_work where view_work_logical_delete = 0";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtViewWork.dtFill(dtViewWork.dtViewWork, command.CommandText);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbViewWorkinJournal.DataSource = dtViewWork.dtViewWork;
                cbViewWorkinJournal.ValueMember = "id_view_work";
                cbViewWorkinJournal.DisplayMember = "view_work";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void cbRoleFill()
        {
            // заполнение выпадающего списка ролями
            try
            {
                Tables dtRole = new Tables();
                command.CommandText = "Select id_role, name_role from role";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtRole.dtFill(dtRole.dtRole, command.CommandText);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbRole.DataSource = dtRole.dtRole;
                cbRole.ValueMember = "id_role";
                cbRole.DisplayMember = "name_role";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCustomerFill()
        {
            // заполнение выпадающего списка заказчиками
            try
            {
                Tables dtCustomer = new Tables();
                command.CommandText = "Select id_customer, Name_customer as 'Заказчик' from customer where customer_logical_delete = 0";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtCustomer.dtFill(dtCustomer.dtCustomer, command.CommandText);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbCustomer.DataSource = dtCustomer.dtCustomer;
                cbCustomer.ValueMember = "id_customer";
                cbCustomer.DisplayMember = "Заказчик";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxEmployeeFill()
        {

            // заполнение имен ролей
            Tables data = new Tables();
            string query = "Select id_employee, dbo.Employee.F_employee +' '+ dbo.Employee.I_employee +' '+ " +
                  "dbo.Employee.O_employee as Employee from Employee where employee_logical_delete = 0";
            data.dtFill(data.dtEmployee, query);

            listBoxEmployee.DataSource = data.dtEmployee;
            listBoxEmployee.ValueMember = "id_employee";
            listBoxEmployee.DisplayMember = "Employee";

        }

        public void listBoxIspolnitelFill()
        {
            
            // заполнение имен ролей
            Tables data = new Tables();
            string query = "Select id_employee, dbo.Employee.F_employee +' '+ dbo.Employee.I_employee +' '+ " +
                "dbo.Employee.O_employee + ' - ' + dbo.Dolj.Name_dolj as Employee, " +
                "dbo.Employee.id_dolj " +
                "FROM     dbo.Employee INNER JOIN " +
                "Dolj ON dbo.Dolj.id_dolj = dbo.Employee.id_dolj " +
                "where employee_logical_delete = 0";
            data.dtFill(data.dtEmployee, query);

            listBoxIspolnitelPlanWork.DataSource = data.dtEmployee;
            listBoxIspolnitelPlanWork.ValueMember = "id_employee";
            listBoxIspolnitelPlanWork.DisplayMember = "Employee";

        }

        public void listBoxIspolnitelinJournalFill()
        {

            // заполнение имен ролей
            Tables data = new Tables();
            string query = "Select id_employee, dbo.Employee.F_employee +' '+ dbo.Employee.I_employee +' '+ " +
                "dbo.Employee.O_employee + ' - ' + dbo.Dolj.Name_dolj as Employee, " +
                "dbo.Employee.id_dolj " +
                "FROM     dbo.Employee INNER JOIN " +
                "Dolj ON dbo.Dolj.id_dolj = dbo.Employee.id_dolj " +
                "where employee_logical_delete = 0";
            data.dtFill(data.dtEmployee, query);

            listBoxIspolnitelinJournal.DataSource = data.dtEmployee;
            listBoxIspolnitelinJournal.ValueMember = "id_employee";
            listBoxIspolnitelinJournal.DisplayMember = "Employee";

        }

        

        private void cbDoljFill()
        {
            // заполнение выпадающего списка должностми
            try
            {
                Tables dtDolj = new Tables();
                command.CommandText = dtDolj.qrDolj + " where dolj_logical_delete = 0";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtDolj.dtFill(dtDolj.dtDolj, command.CommandText);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbDolj.DataSource = dtDolj.dtDolj;
                cbDolj.ValueMember = "id_dolj";
                cbDolj.DisplayMember = "Должность";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbRucovoditelFill()
        {
            // заполнение выпадающего списка руководителями проекта из таблицы сотрдуников
            try
            {
                Tables dtEmployee = new Tables();
                command.CommandText = "Select id_dolj from dolj where (name_dolj = 'Руководитель проекта') and (Dolj_logical_delete = 0)";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                id_dolj = Convert.ToInt32(command.ExecuteScalar().ToString());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                command.CommandText = "Select id_employee, dbo.Employee.F_employee +' '+ SUBSTRING(dbo.Employee.I_employee,1,1) +'. '+ " +
                  "SUBSTRING(dbo.Employee.O_employee, 1, 1) +'.' as Employee from Employee where id_dolj = " + id_dolj + " and (Employee_logical_delete = 0)";

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtEmployee.dtFill(dtEmployee.dtEmployee, command.CommandText);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbRucovoditel.DataSource = dtEmployee.dtEmployee;
                cbRucovoditel.ValueMember = "id_employee";
                cbRucovoditel.DisplayMember = "Employee";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmployeeFill()
        {
            try
            {
                // заполнение таблицы
                Tables data = new Tables();
                string query = data.qrEmployee + " where employee_logical_delete = 0";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                data.dtFill(data.dtEmployee, query);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                dgvEmployee.DataSource = data.dtEmployee;
                //невидимость первичного ключа
                dgvEmployee.Columns[0].Visible = false;
                dgvEmployee.Columns[1].Visible = false;
            }

            // предусмотрение ошибок
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvPlanWorkFill()
        {
            try
            {
                // заполнение таблицы
                Tables data = new Tables();
                
                string query = data.qrPlanWork + " where work_plan_logical_delete = 0 and id_fixed_project = " + Program.id_fixed_project;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                data.dtFill(data.dtWorkPlan, query);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                dgvPlanWork.DataSource = data.dtWorkPlan;
                //невидимость первичного ключа
                dgvPlanWork.Columns[0].Visible = false;
                dgvPlanWork.Columns[1].Visible = false;
                dgvPlanWork.Columns[2].Visible = false;
            }

            // предусмотрение ошибок
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvJournalFill()
        {
            try
            {
                // заполнение таблицы
                Tables data = new Tables();
                id_fixed_project = 1;
                string query = data.qrWorkJournal + " where work_journal_logical_delete = 0 and id_fixed_project = " + id_fixed_project;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                data.dtFill(data.dtWorkJournal, query);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                dataGridViewJournal.DataSource = data.dtWorkJournal;
                //невидимость первичного ключа
                dataGridViewJournal.Columns[0].Visible = false;
                dataGridViewJournal.Columns[1].Visible = false;
                dataGridViewJournal.Columns[2].Visible = false;
            }

            // предусмотрение ошибок
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void dgvAvtorizFill()
        {
            try
            {
                // заполнение таблицы
                Tables data = new Tables();
      
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                data.dtFill(data.dtAvtoriz, data.qrAvtoriz);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                dgvAvtoriz.DataSource = data.dtAvtoriz;
                //невидимость первичного ключа
                dgvAvtoriz.Columns[0].Visible = false;
                dgvAvtoriz.Columns[1].Visible = false;
                dgvAvtoriz.Columns[2].Visible = false;
            }

            // предусмотрение ошибок
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFixedProjectFill()
        {
            try
            {
                // заполнение таблицы
                Tables data = new Tables();
                string query = data.qrFixedProject + " where Fixed_project_logical_delete = 0";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                data.dtFill(data.dtFixedProject, query);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                dgvFixedProject.DataSource = data.dtFixedProject;
                //невидимость первичного ключа
                dgvFixedProject.Columns[0].Visible = false;
                dgvFixedProject.Columns[1].Visible = false;
                dgvFixedProject.Columns[2].Visible = false;
            }

            // предусмотрение ошибок
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHistoryFill()
        {
            try
            {
                // заполнение таблицы
                Tables data = new Tables();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                data.dtFill(data.dtHistory, data.qrHistory);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                dgvHistory.DataSource = data.dtHistory;
                //невидимость первичного ключа
                dgvHistory.Columns[0].Visible = false;
            }

            // предусмотрение ошибок
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxWeekDayFill()
        {

            
            // заполнение номеров неделю и дат
            DataTable dtYears = new DataTable();
            command.CommandText = "Select distinct(SUBSTRING(date,7,4)) as date from Staff_work_shedule" +
                " where staff_work_shedule_logical_delete=0";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            dtYears.Load(command.ExecuteReader());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            foreach (DataRow row in dtYears.Rows)
            {
                foreach (string months in months)
                    listBoxWeekDay.Items.Add(months + " " + row["date"].ToString());
            }
           
        }

        private void cbSotrFill()
        {
            // заполнение выпадающего списка сотрудниками
            try
            {
                DataTable dtEmployee = new DataTable();
                command.CommandText = "Select id_employee, FIO_employee from view_employee where employee_logical_delete = 0";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtEmployee.Load(command.ExecuteReader());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbSotr.DataSource = dtEmployee;
                cbSotr.ValueMember = "id_employee";
                cbSotr.DisplayMember = "FIO_employee";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbStatusFill()
        {
            // заполнение выпадающего списка статусами сотрудников
            try
            {
                DataTable dtStatus = new DataTable();
                command.CommandText = "Select id_status, Status from Status where status_logical_delete = 0";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dtStatus.Load(command.ExecuteReader());
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbStatus.DataSource = dtStatus;
                cbStatus.ValueMember = "id_status";
                cbStatus.DisplayMember = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxRoleFill()
        {
            // заполнение имен ролей
            Tables data = new Tables();
            string query = "select id_role, name_role from Role";
            data.dtFill(data.dtRole, query);

            listBoxRole.DataSource = data.dtRole;
            listBoxRole.ValueMember = "id_role";
            listBoxRole.DisplayMember = "name_role";
        }

      

        private void listBoxDoljFill()
        {
            // заполнение должностей
            Tables data = new Tables();
            string query = data.qrDolj + " where Dolj_logical_delete = 0";
            data.dtFill(data.dtDolj, query);
            
            listBoxDolj.DataSource = data.dtDolj;
            listBoxDolj.ValueMember = "id_dolj";
            listBoxDolj.DisplayMember = "Должность";
        }

        private void listBoxStatusFill()
        {
            // заполнение статусов сотрудников
            Tables data = new Tables();
            string query = data.qrStatus + " where Status_logical_delete = 0";
            data.dtFill(data.dtStatus, query);

            listBoxStatus.DataSource = data.dtStatus;
            listBoxStatus.ValueMember = "id_status";
            listBoxStatus.DisplayMember = "Статус";
        }

        public void listBoxViewWorkFill()
        {
            // заполнение статусов сотрудников
            Tables data = new Tables();
            string query = data.qrViewWork + " where View_work_logical_delete = 0";
            data.dtFill(data.dtViewWork, query);

            listBoxViewWork.DataSource = data.dtViewWork;
            listBoxViewWork.ValueMember = "id_view_work";
            listBoxViewWork.DisplayMember = "Вид работы";
        }

        public void listBoxViewWorkinJournalFill()
        {
            // заполнение статусов сотрудников
            Tables data = new Tables();
            string query = data.qrViewWork + " where View_work_logical_delete = 0";
            data.dtFill(data.dtViewWork, query);

            listBoxViewWorkinJournal.DataSource = data.dtViewWork;
            listBoxViewWorkinJournal.ValueMember = "id_view_work";
            listBoxViewWorkinJournal.DisplayMember = "Вид работы";
        }

        

        private void dgvCustomerFill()
        {
            try
            {
                // заполнение таблицы
                Tables data = new Tables();
                string query = data.qrCustomer + " where Customer_logical_delete = 0";
                data.dtFill(data.dtCustomer, query);
                dgvCustomer.DataSource = data.dtCustomer;
                //невидимость первичного ключа
                dgvCustomer.Columns[0].Visible = false;
            }

            // предусмотрение ошибок
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // получение данных из таблицы в поля ввода
                id_customer = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[0].Value.ToString());
                tbNameCustomer.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                tbMailCustomer.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RefreshWinCustomer()
        {
            // обновление данных справочника заказчики
            dgvCustomerFill();
            tbNameCustomer.Clear();
            tbMailCustomer.Clear();
            id_customer = 0;
        }

        private void RefreshWinFixedProject()
        {
            // обновление данных справочника закрепленных проектов
            dgvFixedProjectFill();
            tbNameProject.Clear();
            id_fixed_project = 0;
            id_employee = 0;
            id_customer = 0;
        }

        private void RefreshWinAvtoriz()
        {
            // обновление данных справочника закрепленных проектов
            dgvAvtorizFill();
            cbRoleFill();
            listBoxEmployeeFill();
            tbLogin.Clear();
            tbPassword.Clear();
            id_avtoriz = 0;
            id_employee = 0;
            id_role = 0;
        }

        private void RefreshWinRole()
        {
            // обновление данных справочника прав доступа к справочникам
            listBoxRoleFill();
            tbRole.Clear();
            id_role = 0;
            checkedCheckBoxRole(checkBoxFixedProject, sprav_fixed_project);
            checkedCheckBoxRole(checkBoxJournalWork, sprav_work_journal);
            checkedCheckBoxRole(checkBoxEmployee, sprav_employee);
            checkedCheckBoxRole(checkBoxStaffWork, sprav_staff_work_shedule);
            checkedCheckBoxRole(checkBoxPlanWork, sprav_work_plan);
            checkedCheckBoxRole(checkBoxCustomer, sprav_customer);
            checkedCheckBoxRole(checkBoxAdministration, Administration);
        }

        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            // добавление заказчика
            Manipulation.AddCustomer(tbNameCustomer.Text, tbMailCustomer.Text, patMail);
            RefreshWinCustomer();
        }

        private void btUpdateCustomer_Click(object sender, EventArgs e)
        {
            //изменение заказчика
            Manipulation.UpdateCustomer(tbNameCustomer.Text, tbMailCustomer.Text, id_customer, patMail);
            RefreshWinCustomer();
        }

        private void tbFilterFixedProject_TextChanged(object sender, EventArgs e)
        {
            // поиск закрепленного проекта
            if (tbFilterFixedProject.Text == "")
            {
                dgvFixedProjectFill();
            }
            else
            {
                Tables query = new Tables();
                command.CommandText = query.qrFixedProject +
                    " where (fixed_project_logical_delete = 0) and ((Name_project like '%" + tbFilterFixedProject.Text + "%') " +
                "or (Employee like '%" + tbFilterFixedProject.Text + "%') "+
                "or(Name_customer like '%" + tbFilterFixedProject.Text + "%')) ";
                DataTable dt = new DataTable();

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                dgvFixedProject.DataSource = dt;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }

        private void cbRucovoditel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // получение ключа таблицы закрепленные проекты
            id_employee = Convert.ToInt32(cbRucovoditel.SelectedValue.ToString());
        }

        private void cbCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // получение первичного ключа таблицы заказчики
            id_customer = Convert.ToInt32(cbCustomer.SelectedValue.ToString());
        }

        private void btAddFixedProject_Click(object sender, EventArgs e)
        {
            // добавление хакрепленного проекта
            Manipulation.AddFixedProject(tbNameProject.Text, id_customer, id_employee);
            RefreshWinFixedProject();
           
        }

        private void btUpdateFixedProject_Click(object sender, EventArgs e)
        {
            // изменение закрепленного проекта
            Manipulation.UpdateFixedProject(tbNameProject.Text, id_customer, id_employee, id_fixed_project);
            RefreshWinFixedProject();
        }

        private void btDeleteFixedProject_Click(object sender, EventArgs e)
        {
            // удаление из закрепленных проектов
            Manipulation.LogDeleteFixedProject(tbNameProject.Text, id_customer, id_employee, id_fixed_project);
            RefreshWinFixedProject();
        }

        private void listBoxDolj_SelectedValueChanged(object sender, EventArgs e)
        {
            // выбор должности из справочника
            DataRowView drvDolj = (DataRowView)listBoxDolj.SelectedItem;
            tbDolj.Text = drvDolj["Должность"].ToString();
            id_dolj = Convert.ToInt32(drvDolj["id_dolj"].ToString());
             
        }


        private void RefreshWinDolj()
        {
            // обновление записей должностей
            listBoxDoljFill();
            tbDolj.Clear();
            id_dolj = 0;
        }

        private void RefreshWinStatus()
        {
            // обновление записей должностей
            listBoxStatusFill();
            tbStatus.Clear();
            id_status = 0;
        }

        private void RefreshWinViewWork()
        {
            // обновление записей должностей
            listBoxViewWorkFill();
            tbViewWork.Clear();
            id_view_work = 0;
        }

        private void btAddDolj_Click(object sender, EventArgs e)
        {
            // добавление должности
            Manipulation.AddDolj(tbDolj.Text);
            RefreshWinDolj();
        }

        private void btUpdateDolj_Click(object sender, EventArgs e)
        {
            // изменение должности
            Manipulation.UpdateDolj(tbDolj.Text, id_dolj);
            RefreshWinDolj();
        }

        private void btDeleteDolj_Click(object sender, EventArgs e)
        {
            // удаление должности
            Manipulation.LogDeleteDolj(tbDolj.Text, id_dolj);
            RefreshWinDolj();
        }

        private void tbFilterDolj_TextChanged(object sender, EventArgs e)
        {
            // поиск и фильтрация должности
            if (tbFilterDolj.Text == "")
            {
               listBoxDoljFill();
            }
            else
            {
                Tables query = new Tables();
                command.CommandText = query.qrDolj +
                    " where (dolj_logical_delete = 0) and (Name_dolj like '%" + tbFilterDolj.Text + "%') ";
                DataTable dt = new DataTable();

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                listBoxDolj.DataSource = dt;
                listBoxDolj.ValueMember = "id_dolj";
                listBoxDolj.DisplayMember = "Должность";

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }

        private void listBoxDolj_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btAddStatus_Click(object sender, EventArgs e)
        {
            // добавление статуса
            Manipulation.AddStatus(tbStatus.Text);
            RefreshWinStatus();
        }

        private void checkBoxCustomer_CheckedChanged(object sender, EventArgs e)
        {
            checkedCheckBoxRole(checkBoxCustomer, sprav_customer);
        }

        private void checkedCheckBoxRole(CheckBox checkBox, Int32 ValueSprav)
        {
            if (checkBox.Checked) ValueSprav = 1;
            else ValueSprav = 0;
        }

        private void checkBoxPlanWork_CheckedChanged(object sender, EventArgs e)
        {
            checkedCheckBoxRole(checkBoxPlanWork, sprav_work_plan);
        }

        private void checkBoxStaffWork_CheckedChanged(object sender, EventArgs e)
        {
            checkedCheckBoxRole(checkBoxStaffWork, sprav_staff_work_shedule);
        }

        private void checkBoxEmployee_CheckedChanged(object sender, EventArgs e)
        {
            checkedCheckBoxRole(checkBoxEmployee, sprav_employee);
        }

        private void checkBoxJournalWork_CheckedChanged(object sender, EventArgs e)
        {
            checkedCheckBoxRole(checkBoxJournalWork, sprav_work_journal);
        }

        private void checkBoxFixedProject_CheckedChanged(object sender, EventArgs e)
        {
            checkedCheckBoxRole(checkBoxFixedProject, sprav_fixed_project);
        }

        private void checkBoxRole_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBoxAvtoriz_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void CheckAccessUser()


        {

            if (Program.avtoriz == false)
            {
                NastrToolStripMenuItem.Enabled = false;
                SvyazToolStripMenuItem.Enabled = false;
                btSettings.Enabled = false;
            }
            else
            {
                NastrToolStripMenuItem.Enabled = true;
                SvyazToolStripMenuItem.Enabled = true;
                btSettings.Enabled = true;
            }

            if ((Program.sprav_customer == 0) && (Program.sprav_plan_work == 0) && (Program.sprav_staff_work_shedule == 0)
                && (Program.sprav_fixed_project == 0) && (Program.sprav_employee == 0) && (Program.sprav_work_journal == 0))
            {
                btSpravochnik.Enabled = false;
                spravToolStripMenuItem.Enabled = false;
            }
            else
            {
                btSpravochnik.Enabled = true;
                spravToolStripMenuItem.Enabled = true;
            }

            if (Program.sprav_customer == 1)
            {
                labelWinCustomer.Visible = true;
                CustomerToolStripMenuItem.Visible = true;
                SvyazToolStripMenuItem.Visible = true;
            }
            else
            {
                labelWinCustomer.Visible = false;
                CustomerToolStripMenuItem.Visible = false;
                SvyazToolStripMenuItem.Visible = false;
            }
                  
            if (Program.sprav_plan_work == 1)
            {
                labelWinPlanWork.Visible = true;
                PlanWorkToolStripMenuItem.Visible = true;
            }
            else
            {
                labelWinPlanWork.Visible = false;
                PlanWorkToolStripMenuItem.Visible = false;
            }

            if (Program.sprav_staff_work_shedule == 1)
            {
                labelWinStaffWorkShedule.Visible = true;
                StaffWorkSheduleToolStripMenuItem.Visible = true;
            }
            else
            {
                labelWinStaffWorkShedule.Visible = false;
                StaffWorkSheduleToolStripMenuItem.Visible = false;
            }

            if (Program.sprav_fixed_project == 1)
            {
                labelWinFixedProject.Visible = true;
                FixedProjectToolStripMenuItem.Visible = true;
            }
            else
            {
                labelWinFixedProject.Visible = false;
                FixedProjectToolStripMenuItem.Visible = false;
            }

            if (Program.sprav_employee == 1)
            {
                labelWinSotr.Visible = true;
                SotrToolStripMenuItem.Visible = true;
            }
            else
            {
                labelWinSotr.Visible = false;
                SotrToolStripMenuItem.Visible = false;
            }

            if (Program.sprav_work_journal == 1)
            {
                labelWinJournalWork.Visible = true;
                JournalWorkToolStripMenuItem.Visible = true;
            }
            else
            {
                labelWinJournalWork.Visible = false;
                JournalWorkToolStripMenuItem.Visible = false;
            }

            if (Program.Administration == 1)
            {
                AdminToolStripMenuItem.Enabled = true;
                btAdmin.Enabled = true;
            }
            else
            {
                AdminToolStripMenuItem.Enabled = false;
                btAdmin.Enabled = false;
            }
        }

      
      


        private void btAddRole_Click(object sender, EventArgs e)
        {
            // добавление роли
            Manipulation.AddRole(tbRole.Text, sprav_customer, sprav_fixed_project,
                sprav_employee, sprav_staff_work_shedule, sprav_work_plan, sprav_work_journal, Administration, ConfigDoc, Config_org);
            RefreshWinRole();
        }

        private void btUpdateRole_Click(object sender, EventArgs e)
        {
            GetValueListBoxRole("sprav_fixed_project", id_role, checkBoxFixedProject);
            GetValueListBoxRole("sprav_customer", id_role, checkBoxCustomer);
            GetValueListBoxRole("sprav_employee", id_role, checkBoxEmployee);
            GetValueListBoxRole("sprav_staff_work_shedule", id_role, checkBoxStaffWork);
            GetValueListBoxRole("sprav_work_plan", id_role, checkBoxPlanWork);
            GetValueListBoxRole("sprav_work_journal", id_role, checkBoxJournalWork);
            GetValueListBoxRole("Config_doc", id_role, cbConfigDoc);
            GetValueListBoxRole("Config_org", id_role, cbConfig_org);
            // изменение роли
            Manipulation.UpdateRole(tbRole.Text, id_role, sprav_customer, sprav_fixed_project,
                sprav_employee, sprav_staff_work_shedule, sprav_work_plan, sprav_work_journal, Administration,
                ConfigDoc, Config_org);
            RefreshWinRole();
        }

        private void btDeleteRole_Click(object sender, EventArgs e)
        {
            // удаление роли
            Manipulation.DeleteRole(tbRole.Text, id_role);
            RefreshWinRole();
        }

        private void labelWinHistory_Click(object sender, EventArgs e)
        {
            SelectPageOnControl(tpHistory);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            // очистка истории изменений
            command.CommandText = "truncate table History";
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            dgvHistoryFill();
        }

        private void tbFilterSotr_TextChanged(object sender, EventArgs e)
        {
            //поиск и фильтрация заказчиков
            if (tbFilterSotr.Text == "")
            {
                dgvEmployeeFill();
            }
            else
            {
                Tables query = new Tables();
                command.CommandText = query.qrEmployee +
                    " where (employee_logical_delete = 0) and ((Name_dolj like '%" + tbFilterSotr.Text + "%') " +
                "or (FIO_employee like '%" + tbFilterSotr.Text + "%') or (Date_of_birthday like '%" + tbFilterSotr.Text + "%') " +
                "or (Age like '%" + tbFilterSotr.Text + "%'))";
                DataTable dt = new DataTable();

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                dgvEmployee.DataSource = dt;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }

        private void RefreshWinEmployee()
        {
            dgvEmployeeFill();
            tbFSotr.Clear();
            tbISotr.Clear();
            tbOSotr.Clear();
            tbDateBirthday.Clear();
            numExperience.Value = 0;
            id_dolj = 0;

        }

        private void btAddSotr_Click(object sender, EventArgs e)
        {
            // добавление сотрудника
            Manipulation.AddEmployee(tbFSotr.Text, tbISotr.Text, tbOSotr.Text, 
                tbDateBirthday.Text, Convert.ToInt32(numExperience.Value), id_dolj);
            RefreshWinEmployee();
        }

        private void btUpdateSotr_Click(object sender, EventArgs e)
        {
            // изменение сотрудника
            Manipulation.UpdateEmployee(tbFSotr.Text, tbISotr.Text, tbOSotr.Text,
                tbDateBirthday.Text, Convert.ToInt32(numExperience.Value), id_dolj, id_employee);
            RefreshWinEmployee();
        }

        private void btDeleteSotr_Click(object sender, EventArgs e)
        {
            // удаление сотрудника
            Manipulation.LogDeleteEmployee(tbFSotr.Text, tbISotr.Text, tbOSotr.Text,
                tbDateBirthday.Text, Convert.ToInt32(numExperience.Value), id_dolj, id_employee);
            RefreshWinEmployee();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // выбор из таблицы сотрудников
            try
            {
                // получение данных из таблицы в поля ввода и выпадающие списки
                id_employee = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[0].Value.ToString());
                id_dolj = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[1].Value.ToString());
                command.CommandText = "Select F_employee from Employee where id_employee=" + id_employee;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                tbFSotr.Text = command.ExecuteScalar().ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                command.CommandText = "Select I_employee from Employee where id_employee=" + id_employee;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                tbISotr.Text = command.ExecuteScalar().ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                command.CommandText = "Select O_employee from Employee where id_employee=" + id_employee;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                tbOSotr.Text = command.ExecuteScalar().ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                tbDateBirthday.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
                numExperience.Value = Convert.ToDecimal(dgvEmployee.CurrentRow.Cells[5].Value.ToString());
                cbDolj.SelectedValue = id_dolj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbDolj_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // получение ключа должности
            id_dolj = Convert.ToInt32(cbDolj.SelectedValue.ToString());
        }

        private void listBoxEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            // выбор сотрудника из справочника
            DataRowView drvEmployee = (DataRowView)listBoxEmployee.SelectedItem;
            if(drvEmployee != null)
            id_employee = Convert.ToInt32(drvEmployee["id_employee"].ToString());
        }

        private void tbFilterEmployee_TextChanged(object sender, EventArgs e)
        {
            // поиск и фильтрация в списке сотрудников

            if (tbFilterEmployee.Text == "")
            {
                listBoxEmployeeFill();
            }
            else
            {
                Tables query = new Tables();
                command.CommandText = "Select id_employee, dbo.Employee.F_employee + ' ' + dbo.Employee.I_employee + ' ' + " +
                  "dbo.Employee.O_employee as Employee from Employee" +
                    " where (employee_logical_delete = 0) and ((F_employee like '%" + tbFilterEmployee.Text + "%') or (I_employee like '%" + tbFilterEmployee.Text + "%')" +
                    " or (O_employee like '%" + tbFilterEmployee.Text + "%'))";
                DataTable dt = new DataTable();

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                listBoxEmployee.DataSource = dt;
                listBoxEmployee.ValueMember = "id_employee";
                listBoxEmployee.DisplayMember = "Employee";

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }

        private void tbFilterAvtoriz_TextChanged(object sender, EventArgs e)
        {
            // поиск и фильтрация в справочнике авторизации

            if (tbFilterAvtoriz.Text == "")
            {
                dgvAvtorizFill();
            }
            else
            {
                Tables query = new Tables();
                DataTable dt = new DataTable();
                command.CommandText = query.qrAvtoriz + " where (login like '%" + tbFilterAvtoriz.Text + "%') or (password like '%" + tbFilterAvtoriz.Text + "%')" +
                     " or (Employee like '%" + tbFilterAvtoriz.Text + "%') or (name_role like '%" + tbFilterAvtoriz.Text + "%')";
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                query.dtFill(dt, command.CommandText);
                dgvAvtoriz.DataSource = dt;
                
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }

        private void cbRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // получение ключа роли
            id_role = Convert.ToInt32(cbRole.SelectedValue.ToString());
        }

        private void btAddAvtoriz_Click(object sender, EventArgs e)
        {
            // добавление учетной записи
            Manipulation.AddAvtoriz(tbLogin.Text, tbPassword.Text, id_role, id_employee);
            RefreshWinAvtoriz();
        }

        private void btUpdateAvtoriz_Click(object sender, EventArgs e)
        {
            // изменение учетной записи
            Manipulation.UpdateAvtoriz(tbLogin.Text, tbPassword.Text, id_role, id_employee, id_avtoriz);
            RefreshWinAvtoriz();
        }

        private void btDeleteAvtoriz_Click(object sender, EventArgs e)
        {
            // удаление учетной записи
            Manipulation.DeleteAvtoriz(tbLogin.Text, tbPassword.Text, id_role, id_employee, id_avtoriz);
            RefreshWinAvtoriz();
        }

        private void dgvAvtoriz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // выбор из таблицы учетной записи
            try
            {
                // получение данных из таблицы в поля ввода и выпадающие списки
                id_avtoriz = Convert.ToInt32(dgvAvtoriz.CurrentRow.Cells[0].Value.ToString());
                id_role = Convert.ToInt32(dgvAvtoriz.CurrentRow.Cells[1].Value.ToString());
                id_employee = Convert.ToInt32(dgvAvtoriz.CurrentRow.Cells[2].Value.ToString());
                tbLogin.Text = dgvAvtoriz.CurrentRow.Cells[5].Value.ToString();
                tbPassword.Text = dgvAvtoriz.CurrentRow.Cells[6].Value.ToString();
                cbRole.SelectedValue = id_role;
                // выбор сотрудника из справочника
                listBoxEmployee.SelectedValue = id_employee;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void timerTsslTime_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToString();
        }

        private void отключениеОтСервераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // отображение статуса подключение к серверу
            tsslCon.Visible = true;
            tsslCon.Text = "Определение сервера...";
            data.conState += constate;
            tsslTime.Visible = false;
            timerTsslTime.Stop();

            ConnectionLibrary.ConnectionLibrary.DSIP = "Empty";
            ConnectionLibrary.ConnectionLibrary.PW = "Empty";
            ConnectionLibrary.ConnectionLibrary.UI = "Empty";
            ConnectionLibrary.ConnectionLibrary.DSSN = "Empty";
        }

        private void labelWinPlanWork_Click(object sender, EventArgs e)
        {
            // переход на вкладку плана работ
            SelectPageOnControl(tpPlanWork);
        }

        private void резервированиеДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// FILE NAME WITH DATE DISTICNTION
            //string fileName = string.Format("SchoolBackup_{0}.bak", DateTime.Now.ToString("yyyy_MM_dd_h_mm_tt"));
            //try
            //{
            //    // YOUR SEREVER OR MACHINE NAME
            //    Server dbServer = new Server(new ServerConnection("DESKTOP"));
            //    Microsoft.SqlServer.Management.Smo.Backup dbBackup = new Microsoft.SqlServer.Management.Smo.Backup()
            //    {
            //        Action = BackupActionType.Database,
            //        Database = "School"
            //    };

            //    dbBackup.Devices.AddDevice(@backupDirectory() + "\\" + fileName, DeviceType.File);
            //    dbBackup.Initialize = true;
            //    dbBackup.SqlBackupAsync(dbServer);


            //    MessageBox.Show("Backup", "Backup Completed!");
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.ToString());
            //}
        }


        // THE DIRECTOTRY YOU WANT TO SAVE IN
        public string backupDirectory()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                var result = dialog.ShowDialog();
                return dialog.SelectedPath;
            }
        }

        private void listBoxWeekDay_SelectedValueChanged(object sender, EventArgs e)
        {

            string month = listBoxWeekDay.SelectedItem.ToString();
            Int32 SelectMonth = month.IndexOf(" ");
            string SelectYear = month.Substring(month.Length - 4, 4);
            string NumberMonth = "";
            tbData.Clear();
            switch (month.Substring(0, SelectMonth))
            {
                case ("Январь"):
                    dgvStaffWorkSheduleFill("01", SelectYear);
                    break;
                case ("Февраль"):
                    dgvStaffWorkSheduleFill("02", SelectYear);
                    break;
                case ("Март"):
                    dgvStaffWorkSheduleFill("03", SelectYear);
                    break;
                case ("Апрель"):
                    dgvStaffWorkSheduleFill("04", SelectYear);
                    break;
                case ("Май"):
                    dgvStaffWorkSheduleFill("05", SelectYear);
                    break;
                case ("Июнь"):
                    dgvStaffWorkSheduleFill("06", SelectYear);
                    break;
                case ("Июль"):
                    dgvStaffWorkSheduleFill("07", SelectYear);
                    break;
                case ("Август"):
                    dgvStaffWorkSheduleFill("08", SelectYear);
                    break;
                case ("Сентябрь"):
                    dgvStaffWorkSheduleFill("09", SelectYear);
                    break;
                case ("Октябрь"):
                    dgvStaffWorkSheduleFill("10", SelectYear);
                    break;
                case ("Ноябрь"):
                    dgvStaffWorkSheduleFill("11", SelectYear);
                    break;
                case ("Декабрь"):
                    dgvStaffWorkSheduleFill("12", SelectYear);
                    break;
            }
        }

        private void btUpdateStaffWorkShedule_Click(object sender, EventArgs e)
        {
            // изменение записи
            procedure.spStaff_work_shedule_update(tbData.Text, id_employee,
                            id_status, id_staff_work_shedule);
            // перезагрузка таблицы и выпадающих списков
            listBoxWeekDay_SelectedValueChanged(sender, e);
        }

        private void dgvStaffWorkShedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // выбор из графика работ сотрудников
            try
            {
                if (dgvStaffWorkShedule.CurrentCell.Value == null)
                {
                    dgvStaffWorkShedule.CurrentCell.Value.ToString();
                }

                // если выбран статус сотрудника
                if (dgvStaffWorkShedule.CurrentCell.Value.ToString() !=
                    dgvStaffWorkShedule.CurrentRow.Cells[0].Value.ToString())
                {   // обнаружение первичного ключа
                    Int32 indexColumn = dgvStaffWorkShedule.CurrentCell.ColumnIndex;
                    command.CommandText = "Select id_staff_work_shedule from View_staff_work_shedule where date='" +
                        dgvStaffWorkShedule.Columns[indexColumn].HeaderText + "' and Employee='" +
                    dgvStaffWorkShedule.CurrentRow.Cells[0].Value.ToString() + "'";
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                    id_staff_work_shedule = Convert.ToInt32(command.ExecuteScalar());
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                    // обнаружение ключа статуса
                    command.CommandText = "Select id_status from status where status='" +
                    dgvStaffWorkShedule.CurrentCell.Value.ToString() + "'";
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                    id_status = Convert.ToInt32(command.ExecuteScalar());
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                    cbStatus.SelectedValue = id_status;
                    // обнаружение клюа сотрудника
                    command.CommandText = "Select id_employee from View_employee where FIO_employee='" +
                    dgvStaffWorkShedule.CurrentRow.Cells[0].Value.ToString() + "'";
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                    id_employee = Convert.ToInt32(command.ExecuteScalar());
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                    cbSotr.SelectedValue = id_employee;

                    // вывод даты в поле
                    int columnIndex = dgvStaffWorkShedule.CurrentCell.ColumnIndex;
                    tbData.Text = dgvStaffWorkShedule.Columns[columnIndex].HeaderText;
                }
                else tbData.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSotr_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_employee = Convert.ToInt32(cbSotr.SelectedValue.ToString());
        }

        private void cbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_status = Convert.ToInt32(cbStatus.SelectedValue.ToString());
        }

        private void listBoxIspolnitelPlanWork_SelectedValueChanged(object sender, EventArgs e)
        {
            // выбор сотрудника из справочника
            DataRowView drvEmployee = (DataRowView)listBoxIspolnitelPlanWork.SelectedItem;
            if (drvEmployee != null)
               
                id_employee = Convert.ToInt32(drvEmployee["id_employee"].ToString());
        }

        private void cbViewWorkPlanWork_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btUpdatePlan_Click(object sender, EventArgs e)
        {
            Manipulation.UpdatePlanWork(tbDateStartPlanWork.Text, tbDateFinishPlanWork.Text, id_employee,
                id_fixed_project, id_view_work, id_plan_work);
            RefreshWinPlanWork();
        }

        private void RefreshWinPlanWork()
        {
            tbDateStartPlanWork.Clear();
            tbDateFinishPlanWork.Clear();
            id_plan_work = 0;
            id_fixed_project = 0;
            id_staff_work_shedule = 0;
            id_view_work = 0;
            dgvPlanWorkFill();
        }

        private void RefreshWinJournal()
        {
            tbDateStartinJournal.Clear();
            tbDateFinishinJournal.Clear();
            id_plan_work = 0;
            id_fixed_project = 0;
            id_employee = 0;
            id_view_work = 0;
            dgvJournalFill();
        }

        private void btAddPlan_Click(object sender, EventArgs e)
        {
            Manipulation.AddPlanWork(tbDateStartPlanWork.Text, tbDateFinishPlanWork.Text, id_employee,
                id_fixed_project, id_view_work, id_plan_work);
            RefreshWinPlanWork();
        }

        private void btDeletePlan_Click(object sender, EventArgs e)
        {
            Manipulation.LogDeletePlanWork(tbDateStartPlanWork.Text, tbDateFinishPlanWork.Text, id_staff_work_shedule,
                id_fixed_project, id_view_work, id_plan_work);
            RefreshWinPlanWork();
        }

        private void cbViewWorkPlanWork_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_view_work = Convert.ToInt32(cbViewWorkPlanWork.SelectedValue.ToString());
        }

        private void cbViewWorkinJournal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_view_work = Convert.ToInt32(cbViewWorkinJournal.SelectedValue.ToString());
        }

        private void listBoxIspolnitelinJournal_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView drvEmployee = (DataRowView)listBoxIspolnitelinJournal.SelectedItem;
            if (drvEmployee != null)

                id_employee = Convert.ToInt32(drvEmployee["id_employee"].ToString());
        }

        private void btUpdateJournal_Click(object sender, EventArgs e)
        {
            Manipulation.UpdateJournal(tbDateStartinJournal.Text,
                tbDateFinishinJournal.Text, tbNote.Text, id_employee, id_fixed_project, id_view_work,
                id_journal);
           
            RefreshWinJournal();
        }

        private void btAddJournal_Click(object sender, EventArgs e)
        {
            Manipulation.AddJournal(tbDateStartinJournal.Text, tbDateFinishinJournal.Text, tbNote.Text,
                id_employee, id_fixed_project, id_view_work, id_journal);
            RefreshWinJournal();
        }

        private void btDeleteJournal_Click(object sender, EventArgs e)
        {
            Manipulation.LogDeleteJournal(tbDateStartinJournal.Text, tbDateFinishinJournal.Text,
                id_employee, id_fixed_project, id_view_work, id_journal);
            RefreshWinJournal();
        }

        private void журналРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
         
        

        private void btExcel_Click(object sender, EventArgs e)
        {
            string NameProject = "";
            string Employee = "";
            try
            {
                command.CommandText = "Select Name_project from View_fixed_project where id_fixed_project = " + id_fixed_project;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                NameProject = command.ExecuteScalar().ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                command.CommandText = "Select Employee from View_fixed_project where id_fixed_project = " + id_fixed_project;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                Employee = command.ExecuteScalar().ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ExcelDocument excel = new ExcelDocument();
            excel.JournalWorkExcel(dataGridViewJournal, NameProject, Employee);
            
        }

        private void отправкаПроектаЗаказчикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMail send = new SendMail();
            send.Show();
        }

        private void связьСРазработчикомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailRazrab b = new MailRazrab();
            b.Show();
        }

        private void checkBoxBackUpBD_CheckedChanged(object sender, EventArgs e)
        {
            checkedCheckBoxRole(checkBoxAdministration, Administration);
        }

        private void checkBoxHistory_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void выходИзУчетнойЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.avtoriz = false;
            
            Program.sprav_customer = 0;
            Program.sprav_plan_work = 0;
            Program.sprav_staff_work_shedule = 0;
            Program.sprav_fixed_project = 0;
            Program.sprav_employee = 0;
            Program.sprav_work_journal = 0;
            Program.Administration = 0;
            Program.Config_doc = 0;
            Program.Config_org = 0;
            CheckAccessUser();

            CloseAll();
            CloseAll();
            CloseAll();
            CloseAll();
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void восстановлениеЗаписейБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogPanel h = new LogPanel();
            h.Show();
        }

        public void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegForm h = new RegForm(this);
            h.Show();
        }

        private void входВСистемуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Avtoriz f = new Avtoriz(this);
            f.Show();
        }

        private void cbConfigDoc_CheckedChanged(object sender, EventArgs e)
        {
            checkedCheckBoxRole(cbConfigDoc,ConfigDoc);
        }

        private void cbConfig_org_CheckedChanged(object sender, EventArgs e)
        {
            checkedCheckBoxRole(cbConfig_org, Config_org);
        }

        private void btExcelPlanWork_Click(object sender, EventArgs e)
        {
            string NameProject = "";
            string Employee = "";
            try
            {
                command.CommandText = "Select Name_project from View_fixed_project where id_fixed_project = " + id_fixed_project;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                NameProject = command.ExecuteScalar().ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                command.CommandText = "Select Employee from View_fixed_project where id_fixed_project = " + id_fixed_project;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                Employee = command.ExecuteScalar().ToString();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ExcelDocument excel = new ExcelDocument();
            excel.PlanWorkExcel(dgvPlanWork, NameProject, Employee);
        }

        private void dataGridViewJournal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // выбор из таблицы жунал работ
            try
            {
                // получение данных из таблицы в поля ввода и выпадающие списки
                id_journal = Convert.ToInt32(dataGridViewJournal.CurrentRow.Cells[0].Value.ToString());
                id_employee = Convert.ToInt32(dataGridViewJournal.CurrentRow.Cells[1].Value.ToString());
                id_view_work = Convert.ToInt32(dataGridViewJournal.CurrentRow.Cells[2].Value.ToString());
                tbNote.Text = dataGridViewJournal.CurrentRow.Cells[7].Value.ToString(); ;
                tbDateStartinJournal.Text = dataGridViewJournal.CurrentRow.Cells[3].Value.ToString();
                tbDateFinishinJournal.Text = dataGridViewJournal.CurrentRow.Cells[4].Value.ToString();
                cbViewWorkinJournal.SelectedValue = id_view_work;
                listBoxIspolnitelinJournal.SelectedValue = id_employee;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPlanWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // выбор из таблицы план работ
            try
            {
                // получение данных из таблицы в поля ввода и выпадающие списки
                id_plan_work = Convert.ToInt32(dgvPlanWork.CurrentRow.Cells[0].Value.ToString());
                id_employee = Convert.ToInt32(dgvPlanWork.CurrentRow.Cells[1].Value.ToString());
                id_view_work = Convert.ToInt32(dgvPlanWork.CurrentRow.Cells[2].Value.ToString());
                
                tbDateStartPlanWork.Text = dgvPlanWork.CurrentRow.Cells[3].Value.ToString();
                tbDateFinishPlanWork.Text = dgvPlanWork.CurrentRow.Cells[4].Value.ToString();
                cbViewWorkPlanWork.SelectedValue = id_view_work;
                listBoxIspolnitelPlanWork.SelectedValue = id_employee;


        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void dgvStaffWorkSheduleFill(string NumberMonth, string SelectYear)
        {
            // очистка таблицы
            while (dgvStaffWorkShedule.Rows.Count != 0)
            {
                dgvStaffWorkShedule.Rows.Remove(dgvStaffWorkShedule.Rows[dgvStaffWorkShedule.Rows.Count - 1]);
            }

            while (dgvStaffWorkShedule.Columns.Count != 0)
            {
                dgvStaffWorkShedule.Columns.Remove(dgvStaffWorkShedule.Columns[dgvStaffWorkShedule.Columns.Count - 1]);
            }

            command.CommandText = "Select CONCAT(F_employee,' ',I_employee,' ',O_employee) as Employee, id_employee" +
            " from Employee where employee_logical_delete=0";
            DataTable dtEmployee = new DataTable();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            dtEmployee.Load(command.ExecuteReader());
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            dgvStaffWorkShedule.Columns.Add("Сотрудники", "Сотрудники");
            FIO.Clear();
            foreach (DataRow row in dtEmployee.Rows)
            {
                FIO.Add(row[0].ToString());

            }
            // заполнение 1 столбца сотрудниками
            foreach (string str in FIO)
            {
                dgvStaffWorkShedule.Rows.Add(str);
            }

            // заполнение чисел месяца
            for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt32(SelectYear),
                Convert.ToInt32(NumberMonth)); i++)
            {
                if (i.ToString().Length < 2)
                {
                    dgvStaffWorkShedule.Columns.Add("0" + i.ToString() + "." + NumberMonth + "." + SelectYear,
                        "0" + i.ToString() + "." + NumberMonth + "." + SelectYear);
                }
                else
                {
                    dgvStaffWorkShedule.Columns.Add(i.ToString() + "." + NumberMonth + "." + SelectYear,
                        i.ToString() + "." + NumberMonth + "." + SelectYear);
                }
                dgvStaffWorkShedule.Columns[i].Width = 70;
                dgvStaffWorkShedule.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            }

            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            // заполнение статусов сотрудников
            for (int i = 0; i < dgvStaffWorkShedule.RowCount; i++)
            {
                for (int j = 1; j < dgvStaffWorkShedule.ColumnCount; j++)
                {
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                    command.CommandText = "use Manager_project Select [status] from View_staff_work_shedule where ([date]='" + dgvStaffWorkShedule.Columns[j].HeaderText.ToString() +
                        "') and (Employee='" + dgvStaffWorkShedule[0, i].Value + "')";
                   // MessageBox.Show(command.CommandText);
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                    ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                    if (command.ExecuteScalar() != null)
                    {

                        dgvStaffWorkShedule[j, i].Value = command.ExecuteScalar().ToString();
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                    }
                    else
                    {
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        command.CommandText = "use Manager_project Select id_employee from View_employee where FIO_employee='" + dgvStaffWorkShedule[0, i].Value + "'";
                        
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                        Int32 id_employee_for_create = Convert.ToInt32(command.ExecuteScalar().ToString());
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                        procedure.spStaff_work_shedule_insert(dgvStaffWorkShedule.Columns[j].HeaderText, id_employee_for_create, 5);
                        dgvStaffWorkShedule[j, i].Value = " ";
                    }
                }
            }
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
        }

        private void btUpdateStatus_Click(object sender, EventArgs e)
        {
            // изменение статуса
            Manipulation.UpdateStatus(tbStatus.Text, id_status);
            RefreshWinStatus();
        }

        private void btDeleteStatus_Click(object sender, EventArgs e)
        {
            // логическое удаление статуса
            Manipulation.LogDeleteStatus(tbStatus.Text, id_status);
            RefreshWinStatus();
        }

        private void listBoxViewWork_SelectedValueChanged(object sender, EventArgs e)
        {
            // выбор вида работ из справочника
            DataRowView drvViewWork = (DataRowView)listBoxViewWork.SelectedItem;
            tbViewWork.Text = drvViewWork["Вид работы"].ToString();
            id_view_work = Convert.ToInt32(drvViewWork["id_view_work"].ToString());
        }

        private void btDeleteViewWork_Click(object sender, EventArgs e)
        {
            // добавление вида работ
            Manipulation.LogDeleteViewWork(tbViewWork.Text,id_view_work);
            RefreshWinViewWork();
        }

        private void btUpdateViewWork_Click(object sender, EventArgs e)
        {
            // изменение вида работ
            Manipulation.UpdateViewWork(tbViewWork.Text, id_view_work);
            RefreshWinViewWork();
        }

        private void btAddViewWork_Click(object sender, EventArgs e)
        {
            // удаление вида работ
            Manipulation.AddViewWork(tbViewWork.Text);
            RefreshWinViewWork();
        }

        private void tbFilterViewWork_TextChanged(object sender, EventArgs e)
        {
            // поиск и фильтрация в српавочнике видов работ
          
            if (tbFilterViewWork.Text == "")
            {
                listBoxViewWorkFill();
            }
            else
            {
                Tables query = new Tables();
                command.CommandText = query.qrViewWork +
                    " where (view_work_logical_delete = 0) and (View_work like '%" + tbFilterViewWork.Text + "%') ";
                DataTable dt = new DataTable();

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                listBoxViewWork.DataSource = dt;
                listBoxViewWork.ValueMember = "id_view_work";
                listBoxViewWork.DisplayMember = "Вид работы";

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }

        private void listBoxRole_SelectedValueChanged(object sender, EventArgs e)
        {
            // выбор вида работ из справочника
            DataRowView drvRole = (DataRowView)listBoxRole.SelectedItem;
            tbRole.Text = drvRole["name_role"].ToString();
            id_role = Convert.ToInt32(drvRole["id_role"].ToString());

          
            GetValueListBoxRole("sprav_fixed_project", id_role, checkBoxFixedProject);
            GetValueListBoxRole("sprav_customer", id_role, checkBoxCustomer);
            GetValueListBoxRole("sprav_employee", id_role, checkBoxEmployee);
            GetValueListBoxRole("sprav_staff_work_shedule", id_role, checkBoxStaffWork);
            GetValueListBoxRole("sprav_work_plan", id_role, checkBoxPlanWork);
            GetValueListBoxRole("sprav_work_journal", id_role, checkBoxJournalWork);
            GetValueListBoxRole("Administration", id_role, checkBoxAdministration);
            GetValueListBoxRole("Config_doc", id_role, cbConfigDoc);
            GetValueListBoxRole("Config_org", id_role, cbConfig_org);

        }

        private void GetValueListBoxRole(string GetSprav, Int32 id_role, CheckBox checkBox)
        {
            try
            {
                command.CommandText = "Select " + GetSprav + " from Role where id_role=" + id_role;
          
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                Int32 ValueRole = Convert.ToInt32(command.ExecuteScalar().ToString());
         
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                if (ValueRole == 1) checkBox.Checked = true;
                if (ValueRole == 0) checkBox.Checked = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void labelWinStaffWorkShedule_Click(object sender, EventArgs e)
        {
            SelectPageOnControl(tpStaffWorkShedule);
        }

        private void listBoxStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            // выбор статуса из справочника
            DataRowView drvStatus = (DataRowView)listBoxStatus.SelectedItem;
            tbStatus.Text = drvStatus["Статус"].ToString();
            id_status = Convert.ToInt32(drvStatus["id_status"].ToString());
        }

        private void dgvFixedProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // выбор из таблицы заказчиков
            try
            {
                // получение данных из таблицы в поля ввода и выпадающие списки
                id_fixed_project = Convert.ToInt32(dgvFixedProject.CurrentRow.Cells[0].Value.ToString());
                id_customer = Convert.ToInt32(dgvFixedProject.CurrentRow.Cells[1].Value.ToString());
                id_employee = Convert.ToInt32(dgvFixedProject.CurrentRow.Cells[2].Value.ToString());
                tbNameProject.Text = dgvFixedProject.CurrentRow.Cells[3].Value.ToString();
                cbCustomer.SelectedValue = id_customer;
                cbRucovoditel.SelectedValue = id_employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDeleteCustomer_Click(object sender, EventArgs e)
        {
            // удаление заказчика
            Manipulation.LogDeleteCustomer(tbNameCustomer.Text, tbMailCustomer.Text, id_customer);
            RefreshWinCustomer();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            //поиск и фильтрация заказчиков
            if (tbFilter.Text == "")
            {
                dgvCustomerFill();
            }
            else
            {
                Tables query = new Tables();
                command.CommandText = query.qrCustomer +
                    " where (customer_logical_delete = 0) and ((Name_customer like '%" + tbFilter.Text + "%') " +
                "or (Mail_customer like '%" + tbFilter.Text + "%')) ";
                DataTable dt = new DataTable();

                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.Load(command.ExecuteReader());
                dgvCustomer.DataSource = dt;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            }
        }
    }
}
