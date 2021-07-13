using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Manager_project
{
    public static class Manipulation
    {
        

        public static void AddCustomer(string NameCustomer, string MailCustomer, string patMail)
        {
            switch (NameCustomer == "" | MailCustomer == "")
            {
                case (true):
                    
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    switch (Regex.IsMatch(MailCustomer, patMail, RegexOptions.IgnoreCase))
                    {
                        case (true):
                            try
                            {
                                Procedures procedure = new Procedures();
                                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                                procedure.spCustomer_insert(NameCustomer, MailCustomer);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            
                            break;
                        case (false):
                            MessageBox.Show("Введен некорректный адрес почты. Варианты ошибок: \n1. Вы не указали символ @; \n2. Вы не указали домен почты",
                                            "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    break;
            }
        }

        public static void UpdateCustomer(string NameCustomer, string MailCustomer, Int32 id_customer, string patMail)
        {
            switch (NameCustomer == "" | MailCustomer == "")
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    switch (Regex.IsMatch(MailCustomer, patMail, RegexOptions.IgnoreCase))
                    {
                        case (true):
                            try
                            {
                                Procedures procedure = new Procedures();
                                procedure.spCustomer_update(NameCustomer, MailCustomer, id_customer);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            break;
                        case (false):
                            MessageBox.Show("Введен некорректный адрес почты. Варианты ошибок: \n1. Вы не указали символ @; \n2. Вы не указали домен почты",
                                            "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    break;
            }
        }

        public static void LogDeleteCustomer(string NameCustomer, string MailCustomer, Int32 id_customer)
        {
            switch (NameCustomer == "" | MailCustomer == "")
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spCustomer_logical_delete(id_customer);
                        }
                    }
                    catch (Exception ex)
                    {
                       MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void DeleteCustomer(string NameCustomer, string MailCustomer, Int32 id_customer)
        {
            switch (NameCustomer == "" | MailCustomer == "")
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spCustomer_delete(id_customer);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void AddFixedProject(string Name_project, Int32 id_customer, Int32 id_employee)
        {
            switch (Name_project == "" | id_customer == 0 | id_employee == 0)
            {
                case (true):
                    
                    MessageBox.Show("Не все поля заполнены и выбраны!");
                    break;
                case (false):
                    try
                    { 
                            Procedures procedure = new Procedures();
                            procedure.spFixedProject_insert(Name_project, id_employee, id_customer);
                    }
                    catch (Exception ex)
                    {
                            MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void UpdateFixedProject(string Name_project, Int32 id_customer, Int32 id_employee,
            Int32 id_fixed_project)
        {
            switch (Name_project == "" | id_customer == 0 | id_employee == 0)
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spFixedProject_update(Name_project, id_employee, id_customer, id_fixed_project);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void LogDeleteFixedProject(string Name_project, Int32 id_customer, Int32 id_employee,
            Int32 id_fixed_project)
        {
            switch (Name_project == "" | id_customer == 0 | id_employee == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spFixed_project_logical_delete(id_fixed_project);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void DeleteFixedProject(string Name_project, Int32 id_customer, Int32 id_employee,
            Int32 id_fixed_project)
        {
            switch (Name_project == "" | id_customer == 0 | id_employee == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spFixed_project_delete(id_fixed_project);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void AddDolj(string Name_dolj)
        {
            switch (Name_dolj == "")
            {
                case (true):

                    MessageBox.Show("Введите должность!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spDolj_insert(Name_dolj);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void UpdateDolj(string Name_dolj, Int32 id_dolj)
        {
            switch (Name_dolj == "")
            {
                case (true):
                    MessageBox.Show("Выберите должность и введите ее значение!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spDolj_update(Name_dolj, id_dolj);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void LogDeleteDolj(string Name_project, Int32 id_dolj)
        {
            switch (Name_project == "")
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spDolj_logical_delete(id_dolj);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void DeleteDolj(string Name_project, Int32 id_dolj)
        {
            switch (Name_project == "" | id_dolj == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spDolj_delete(id_dolj);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void AddStatus(string Status)
        {
            switch (Status == "")
            {
                case (true):

                    MessageBox.Show("Введите статус!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spStatus_insert(Status);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void UpdateStatus(string Status, Int32 id_status)
        {
            switch (Status == "")
            {
                case (true):
                    MessageBox.Show("Выберите статус и введите ее значение!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spStatus_update(Status, id_status);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void LogDeleteStatus(string Status, Int32 id_status)
        {
            switch (Status == "")
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spStatus_logical_delete(id_status);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void DeleteStatus(string Status, Int32 id_status)
        {
            switch (Status == "" | id_status == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spStatus_delete(id_status);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void AddViewWork(string ViewWork)
        {
            switch (ViewWork == "")
            {
                case (true):

                    MessageBox.Show("Введите статус!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spView_work_insert(ViewWork);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void UpdateViewWork(string ViewWork, Int32 id_view_work)
        {
            switch (ViewWork == "")
            {
                case (true):
                    MessageBox.Show("Выберите вид работы и введите ее значение!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spView_work_update(ViewWork, id_view_work);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void LogDeleteViewWork(string ViewWork, Int32 id_view_work)
        {
            switch (ViewWork == "")
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spView_work_logical_delete(id_view_work);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void DeleteViewWork(string ViewWork, Int32 id_view_work)
        {
            switch (ViewWork == "" | id_view_work == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spView_work_delete(id_view_work);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void AddRole(string Role, Int32 sprav_customer, Int32 sprav_fixed_project,
            Int32 sprav_employee, Int32 sprav_staff_work_shedule, Int32 sprav_work_plan, Int32 sprav_work_journal,
            Int32 Administration, Int32 ConfigDoc, Int32 Config_org)
        {
            switch (Role == "")
            {
                case (true):

                    MessageBox.Show("Введите имя роли!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spRole_insert(Role, sprav_customer, sprav_fixed_project,
                            sprav_employee, sprav_staff_work_shedule, sprav_work_plan, sprav_work_journal, Administration,
                             ConfigDoc, Config_org);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void UpdateRole(string Role, Int32 id_role, Int32 sprav_customer, Int32 sprav_fixed_project, Int32 sprav_employee, Int32 sprav_staff_work_shedule, Int32 sprav_work_plan,
         Int32 sprav_work_journal, Int32 Admininstration, Int32 Config_doc, Int32 Config_org)
        {
            switch (Role == "")
            {
                case (true):
                    MessageBox.Show("Выберите роль!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spRole_update(Role, sprav_customer, sprav_fixed_project,
                            sprav_employee, sprav_staff_work_shedule, sprav_work_plan, sprav_work_journal, id_role, Admininstration, Config_doc, Config_org);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void DeleteRole(string Role, Int32 id_role)
        {
            switch (Role == "" | id_role == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spRole_delete(id_role);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void AddEmployee(string F_sotr, string I_sotr, string O_sotr,
            string Date, Int32 Experience, Int32 id_dolj)
        {
            switch (F_sotr == "" | I_sotr == "" | O_sotr == "" | Date == "" |
                Experience == 0 | id_dolj == 0)
            {
                case (true):

                    MessageBox.Show("Введите данные о сотрудники и выберите должность!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spEmployee_insert(F_sotr, I_sotr, O_sotr, Date,
                            Experience, id_dolj);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void UpdateEmployee(string F_sotr, string I_sotr, string O_sotr,
            string Date, Int32 Experience, Int32 id_dolj, Int32 id_employee)
        {
            switch (F_sotr == "" | I_sotr == "" | O_sotr == "" | Date == "" |
                Experience == 0 | id_dolj == 0)
            {
                case (true):
                    MessageBox.Show("Выберите сотрудника и введите его значения!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spEmployee_update(F_sotr, I_sotr, O_sotr, Date,
                            Experience, id_dolj, id_employee);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void LogDeleteEmployee(string F_sotr, string I_sotr, string O_sotr,
            string Date, Int32 Experience, Int32 id_dolj, Int32 id_employee)
        {
            switch (F_sotr == "" | I_sotr == "" | O_sotr == "" | Date == "" |
                Experience == 0 | id_dolj == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spEmployee_logical_delete(id_employee);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void DeleteEmployee(string F_sotr, string I_sotr, string O_sotr,
            string Date, Int32 Experience, Int32 id_dolj, Int32 id_employee)
        {
            switch (F_sotr == "" | I_sotr == "" | O_sotr == "" | Date == "" |
                Experience == 0 | id_dolj == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spEmployee_delete(id_employee);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void AddAvtoriz(string login, string password, Int32 id_role, Int32 id_employee)
        {
            switch (login == "" | password == "" | id_role == 0 | id_employee == 0)
            {
                case (true):

                    MessageBox.Show("Введите данные об учтеной записи и выберите сотрудника и должность!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spAvtoriz_insert(login, password, id_employee, id_role);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void UpdateAvtoriz(string login, string password, Int32 id_role, Int32 id_employee, Int32 id_avtoriz)
        {
            switch (login == "" | password == "" | id_role == 0 | id_employee == 0)
            {
                case (true):
                    MessageBox.Show("Выберите учетную запись и введите ее значения!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spAvtoriz_update(login, password, id_employee, id_role, id_avtoriz);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }
        

        public static void DeleteAvtoriz(string login, string password, Int32 id_role, Int32 id_employee, Int32 id_avtoriz)
        {
            switch (login == "" | password == "" | id_role == 0 | id_employee == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spAvtoriz_delete(id_avtoriz);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void AddStaffWorkShedule(string Date, Int32 id_status, Int32 id_employee)
        {
            switch (Date == "" | id_status == 0 | id_employee == 0)
            {
                case (true):

                    MessageBox.Show("Не все поля заполнены и выбраны!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spStaff_work_shedule_insert(Date, id_employee, id_status);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void UpdateStaffWorkShedule(string Date, Int32 id_status, Int32 id_employee,
            Int32 id_staff_work_shedule)
        {
            switch (Date == "" | id_status == 0 | id_employee == 0)
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!");
                    break;
                case (false):
                    try
                    {
                        Procedures procedure = new Procedures();
                        procedure.spStaff_work_shedule_update(Date, id_employee, id_status, id_staff_work_shedule);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void AddPlanWork(string Date_of_start,
string Date_of_finish, Int32 id_employee, Int32 id_fixed_project,
Int32 id_view_work, Int32 id_work_plan)
        {
            switch (Date_of_start == "" | Date_of_finish == "" | id_employee == 0 |
                id_view_work == 0)
            {
                case (true):

                    MessageBox.Show("Введите полные данные о задаче!");
                    break;
                case (false):
                    try
                    {
                        SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
                        DateTime dtStart = DateTime.Parse(Date_of_start);
                        DateTime dtFinish = DateTime.Parse(Date_of_finish);
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                        string ErrorDates = "";
                        Procedures procedure = new Procedures();
                        for (DateTime i = dtStart; i <= dtFinish; i = i.AddDays(1))
                        {
                            command.CommandText = "Select status from View_staff_work_shedule where staff_work_shedule_logical_delete = 0 " +
                                "and id_employee=" + id_employee.ToString() + " and Date='" + i.ToString().Substring(0, i.ToString().Length - 8) + "'";

                            if ((command.ExecuteScalar().ToString() == "Работает") || (command.ExecuteScalar().ToString() == " "))
                            {
                                procedure.spPlanWork_insert(Date_of_start, Date_of_finish, id_view_work,
                                 id_employee, id_fixed_project);

                            }
                            else
                            {
                                ErrorDates += i.ToString().Substring(0, i.ToString().Length - 8) + ", ";
                            }

                        }

                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                        if (ErrorDates != "")
                        {
                            MessageBox.Show("Ресурс не имеет доступность на даты: " + ErrorDates.Substring(0, ErrorDates.Length - 2)
                                + ". Измените доступность ресурса в графика работ для доступа ресурса к задаче.");
                            ErrorDates = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }
        
        public static void UpdatePlanWork(string Date_of_start,
string Date_of_finish, Int32 id_employee, Int32 id_fixed_project,
Int32 id_view_work, Int32 id_work_plan)
        {
            switch (Date_of_start == "" | Date_of_finish == "" | id_employee == 0 | id_fixed_project == 0 |
                id_view_work == 0 | id_work_plan == 0)
            {
                case (true):
                    
                    MessageBox.Show("Выберите задачу и введите ее значения!");
                    break;
                case (false):
                    try
                    {
                        SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
                        DateTime dtStart = DateTime.Parse(Date_of_start);
                        DateTime dtFinish = DateTime.Parse(Date_of_finish);
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                        string ErrorDates = "";
                        Procedures procedure = new Procedures();
                        for (DateTime i = dtStart; i <= dtFinish; i = i.AddDays(1))
                        {
                            command.CommandText = "Select status from View_staff_work_shedule where staff_work_shedule_logical_delete = 0 " +
                                "and id_employee=" + id_employee.ToString() + " and Date='" + i.ToString().Substring(0, i.ToString().Length - 8) + "'";

                            if ((command.ExecuteScalar().ToString() == "Работает") || (command.ExecuteScalar().ToString() == " "))
                            {
                               procedure.spPlanWork_update(Date_of_start, Date_of_finish, id_view_work,
                                id_employee, id_fixed_project, id_work_plan);
                                
                            }
                            else
                            {
                                ErrorDates += i.ToString().Substring(0, i.ToString().Length - 8) + ", ";
                            }
                               
                        }

                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                        if (ErrorDates != "")
                        {
                            MessageBox.Show("Ресурс не имеет доступность на даты: " + ErrorDates.Substring(0, ErrorDates.Length - 2)
                                + ". Измените доступность ресурса в графика работ для доступа ресурса к задаче.");
                            ErrorDates = "";
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void LogDeletePlanWork(string Date_of_start,
string Date_of_finish, Int32 id_staff_work_shedule, Int32 id_fixed_project,
Int32 id_view_work, Int32 id_work_plan)
        {
            switch (Date_of_start == "" | Date_of_finish == "" | id_fixed_project == 0 |
                id_view_work == 0 | id_work_plan == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spPlanWork_logical_delete(id_work_plan);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void DeletePlanWork(string Date_of_start,
string Date_of_finish, Int32 id_staff_work_shedule, Int32 id_fixed_project,
Int32 id_view_work, Int32 id_work_plan)
        {
            switch (Date_of_start == "" | Date_of_finish == "" | id_staff_work_shedule == 0 | id_fixed_project == 0 |
                id_view_work == 0 | id_work_plan == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spPlanWork_logical_delete(id_work_plan);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }
        public static void AddJournal(string Date_of_start,
        string Date_of_finish, string Note, Int32 id_employee, Int32 id_fixed_project,
        Int32 id_view_work, Int32 id_work_plan)
        {
            switch (Date_of_start == "" | Date_of_finish == "" | id_employee == 0 |
                id_view_work == 0)
            {
                case (true):

                    MessageBox.Show("Введите полные данные о задаче!");
                    break;
                case (false):
                    try
                    {
                        SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
                        DateTime dtStart = DateTime.Parse(Date_of_start);
                        DateTime dtFinish = DateTime.Parse(Date_of_finish);
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                        string ErrorDates = "";
                        Procedures procedure = new Procedures();
                        for (DateTime i = dtStart; i <= dtFinish; i = i.AddDays(1))
                        {
                            command.CommandText = "Select status from View_staff_work_shedule where staff_work_shedule_logical_delete = 0 " +
                                "and id_employee=" + id_employee.ToString() + " and Date='" + i.ToString().Substring(0, i.ToString().Length - 8) + "'";

                            if ((command.ExecuteScalar().ToString() == "Работает") || (command.ExecuteScalar().ToString() == " "))
                            {
                                procedure.spWorkJournal_insert(Date_of_start, Date_of_finish, Note, id_view_work,
                                 id_employee, id_fixed_project);

                            }
                            else
                            {
                                ErrorDates += i.ToString().Substring(0, i.ToString().Length - 8) + ", ";
                            }

                        }

                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                        if (ErrorDates != "")
                        {
                            MessageBox.Show("Ресурс не имеет доступность на даты: " + ErrorDates.Substring(0, ErrorDates.Length - 2)
                                + ". Измените доступность ресурса в графика работ для доступа ресурса к задаче.");
                            ErrorDates = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void UpdateJournal(string Date_of_start,
string Date_of_finish, string Note, Int32 id_employee, Int32 id_fixed_project,
Int32 id_view_work, Int32 id_work_journal)
        {
            switch (Date_of_start == "" || Date_of_finish == "" || id_employee == 0 ||
                id_view_work == 0 || id_work_journal == 0)
            {
                case (true):
                    MessageBox.Show("Выберите задачу и введите ее значения!");
                    break;
                case (false):
                    try
                    {
                        SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
                        DateTime dtStart = DateTime.Parse(Date_of_start);
                        DateTime dtFinish = DateTime.Parse(Date_of_finish);
                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                        string ErrorDates = "";
                        Procedures procedure = new Procedures();
                        for (DateTime i = dtStart; i <= dtFinish; i = i.AddDays(1))
                        {
                            command.CommandText = "Select status from View_staff_work_shedule where staff_work_shedule_logical_delete = 0 " +
                                "and id_employee=" + id_employee.ToString() + " and Date='" + i.ToString().Substring(0, i.ToString().Length - 8) + "'";
                           
                            if ((command.ExecuteScalar().ToString() == "Работает") || (command.ExecuteScalar().ToString() == " "))
                            {
                                procedure.spWorkJournal_update(Date_of_start, Date_of_finish, Note, id_view_work,
                                id_employee, id_fixed_project, id_work_journal);
                            }
                            else
                            {
                                ErrorDates += i.ToString().Substring(0, i.ToString().Length - 8) + ", ";
                            }

                        }

                        ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();

                        if (ErrorDates != "")
                        {
                            MessageBox.Show("Ресурс не имеет доступность на даты: " + ErrorDates.Substring(0, ErrorDates.Length - 2)
                                + ". Измените доступность ресурса в графика работ для доступа ресурса к задаче.");
                            ErrorDates = "";
                        }

                   
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

            }
        }

        public static void LogDeleteJournal(string Date_of_start,
string Date_of_finish, Int32 id_employee, Int32 id_fixed_project,
Int32 id_view_work, Int32 id_work_plan)
        {
            switch (Date_of_start == "" | Date_of_finish == "" | id_employee == 0 |
                id_view_work == 0 | id_work_plan == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spWorkJournal_logical_delete(id_work_plan);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public static void DeleteJournal(string Date_of_start,
string Date_of_finish, Int32 id_employee, Int32 id_fixed_project,
Int32 id_view_work, Int32 id_work_plan)
        {
            switch (Date_of_start == "" | Date_of_finish == "" | id_employee == 0 | id_fixed_project == 0 |
                id_view_work == 0 | id_work_plan == 0)
            {
                case (true):
                    MessageBox.Show("Выберите запись для удаления!");
                    break;
                case (false):
                    try
                    {
                        if (MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение удаления",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Procedures procedure = new Procedures();
                            procedure.spWorkJournal_logical_delete(id_work_plan);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

    }
}
