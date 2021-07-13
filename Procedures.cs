using System;
using System.Data.SqlClient;
namespace Manager_project
{
    class Procedures
    {

        public static SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
        private void spConfiguration(string spName)
        {
            command.CommandText = spName;
            command.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public void spCustomer_insert(string name_customer, string mail)
        {
            spConfiguration("customer_insert");

            command.Parameters.AddWithValue("@Name_customer", name_customer);
            command.Parameters.AddWithValue("@Mail_customer", mail);

            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spCustomer_update(string name_customer, string mail, Int32 id_customer)
        {
            spConfiguration("customer_update");

            command.Parameters.AddWithValue("@id_customer", id_customer);
            command.Parameters.AddWithValue("@Name_customer", name_customer);
            command.Parameters.AddWithValue("@Mail_customer", mail);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spCustomer_delete(Int32 id_customer)
        {
            spConfiguration("customer_delete");

            command.Parameters.AddWithValue("@id_customer", id_customer);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spCustomer_logical_delete(Int32 id_customer)
        {
            spConfiguration("customer_logical_delete");

            command.Parameters.AddWithValue("@id_customer", id_customer);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spFixedProject_insert(string Name_project, Int32 id_employee, Int32 id_customer)
        {
            spConfiguration("fixed_project_insert");

            command.Parameters.AddWithValue("@Name_project", Name_project);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_customer", id_customer);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spFixedProject_update(string Name_project, Int32 id_employee, Int32 id_customer, Int32 id_fixed_project)
        {
            spConfiguration("fixed_project_update");

            command.Parameters.AddWithValue("@id_customer", id_customer);
            command.Parameters.AddWithValue("@Name_project", Name_project);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_fixed_project", id_fixed_project);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spFixed_project_delete(Int32 id_fixed_project)
        {
            spConfiguration("fixed_project_delete");

            command.Parameters.AddWithValue("@id_fixed_project", id_fixed_project);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spFixed_project_logical_delete(Int32 id_fixed_project)
        {
            spConfiguration("fixed_project_logical_delete");

            command.Parameters.AddWithValue("@id_fixed_project", id_fixed_project);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spDolj_insert(string Name_dolj)
        {
            spConfiguration("dolj_insert");

            command.Parameters.AddWithValue("@Name_dolj", Name_dolj);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spDolj_update(string Name_dolj, Int32 id_dolj)
        {
            spConfiguration("dolj_update");

            command.Parameters.AddWithValue("@id_dolj", id_dolj);
            command.Parameters.AddWithValue("@Name_dolj", Name_dolj);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spDolj_delete(Int32 id_dolj)
        {
            spConfiguration("dolj_delete");

            command.Parameters.AddWithValue("@id_dolj", id_dolj);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spDolj_logical_delete(Int32 id_dolj)
        {
            spConfiguration("dolj_logical_delete");

            command.Parameters.AddWithValue("@id_dolj", id_dolj);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spStatus_insert(string Status)
        {
            spConfiguration("status_insert");

            command.Parameters.AddWithValue("@Status", Status);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spStatus_update(string Status, Int32 id_status)
        {
            spConfiguration("status_update");

            command.Parameters.AddWithValue("@id_status", id_status);
            command.Parameters.AddWithValue("@Status", Status);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spStatus_delete(Int32 id_status)
        {
            spConfiguration("status_delete");

            command.Parameters.AddWithValue("@id_status", id_status);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spStatus_logical_delete(Int32 id_status)
        {
            spConfiguration("status_logical_delete");

            command.Parameters.AddWithValue("@id_status", id_status);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spView_work_insert(string View_work)
        {
            spConfiguration("view_work_insert");

            command.Parameters.AddWithValue("@View_work", View_work);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spView_work_update(string View_work, Int32 id_view_work)
        {
            spConfiguration("view_work_update");

            command.Parameters.AddWithValue("@id_view_work", id_view_work);
            command.Parameters.AddWithValue("@View_work", View_work);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spView_work_delete(Int32 id_view_work)
        {
            spConfiguration("view_work_delete");

            command.Parameters.AddWithValue("@id_view_work", id_view_work);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spView_work_logical_delete(Int32 id_view_work)
        {
            spConfiguration("view_work_logical_delete");

            command.Parameters.AddWithValue("@id_view_work", id_view_work);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spRole_insert(string Name_role, Int32 Sprav_customer, Int32 Sprav_fixed_project, 
             Int32 Sprav_employee, Int32 Sprav_staff_work_schedule,
             Int32 Sprav_work_plan, Int32 Sprav_work_journal, Int32 Administration, Int32 ConfigDoc, Int32 Config_org)
        {
            spConfiguration("role_insert");

            command.Parameters.AddWithValue("@Name_role", Name_role);
            command.Parameters.AddWithValue("@Sprav_customer", Sprav_customer);
            command.Parameters.AddWithValue("@Sprav_fixed_project", Sprav_fixed_project);
            command.Parameters.AddWithValue("@Sprav_employee", Sprav_employee);
            command.Parameters.AddWithValue("@Sprav_staff_work_shedule", Sprav_staff_work_schedule);
            command.Parameters.AddWithValue("@Sprav_work_plan", Sprav_work_plan);
            command.Parameters.AddWithValue("@Sprav_work_journal", Sprav_work_journal);
            command.Parameters.AddWithValue("@Administration", Administration);
            command.Parameters.AddWithValue("@Config_doc", ConfigDoc);
            command.Parameters.AddWithValue("@Config_org", Config_org);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spRole_update(string Name_role, Int32 Sprav_customer, Int32 Sprav_fixed_project,
             Int32 Sprav_employee, Int32 Sprav_staff_work_schedule,
             Int32 Sprav_work_plan, Int32 Sprav_work_journal, Int32 id_role, Int32 Admininstration,
             Int32 ConfigDoc, Int32 Config_org)
        {
            spConfiguration("role_update");

            command.Parameters.AddWithValue("@id_role", id_role);
            command.Parameters.AddWithValue("@Name_role", Name_role);
            command.Parameters.AddWithValue("@Sprav_customer", Sprav_customer);
            command.Parameters.AddWithValue("@Sprav_fixed_project", Sprav_fixed_project);
            command.Parameters.AddWithValue("@Sprav_employee", Sprav_employee);
            command.Parameters.AddWithValue("@Sprav_staff_work_shedule", Sprav_staff_work_schedule);
            command.Parameters.AddWithValue("@Sprav_work_plan", Sprav_work_plan);
            command.Parameters.AddWithValue("@Sprav_work_journal", Sprav_work_journal);
            command.Parameters.AddWithValue("@Admininstration", Admininstration);
            command.Parameters.AddWithValue("@Config_doc", ConfigDoc);
            command.Parameters.AddWithValue("@Config_org", Config_org);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spRole_delete(Int32 id_role)
        {
            spConfiguration("role_delete");

            command.Parameters.AddWithValue("@id_role", id_role);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spAvtoriz_insert(string Login, string Password, Int32 id_employee, Int32 id_role)
        {
            spConfiguration("avtoriz_insert");

            command.Parameters.AddWithValue("@Login", Login);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_role", id_role);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spAvtoriz_update(string Login, string Password, Int32 id_employee, Int32 id_role,
            Int32 id_avtoriz)
        {
            spConfiguration("avtoriz_update");

            command.Parameters.AddWithValue("@Login", Login);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_role", id_role);
            command.Parameters.AddWithValue("@id_avtoriz", id_avtoriz);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spAvtoriz_delete(Int32 id_avtoriz)
        {
            spConfiguration("avtoriz_delete");

            command.Parameters.AddWithValue("@id_avtoriz", id_avtoriz);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spEmployee_insert(string F_employee, string I_employee, string O_employee,
            string Date_of_birthday, Int32 Experience, Int32 id_dolj)
        {
            spConfiguration("employee_insert");

            command.Parameters.AddWithValue("@F_employee", F_employee);
            command.Parameters.AddWithValue("@I_employee", I_employee);
            command.Parameters.AddWithValue("@O_employee", O_employee);
            command.Parameters.AddWithValue("@Date_of_birthday", Date_of_birthday);
            command.Parameters.AddWithValue("@Experience", Experience);
            command.Parameters.AddWithValue("@id_dolj", id_dolj);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spEmployee_update(string F_employee, string I_employee, string O_employee,
            string Date_of_birthday, Int32 Experience, Int32 id_dolj, Int32 id_employee)
        {
            spConfiguration("employee_update");

            command.Parameters.AddWithValue("@F_employee", F_employee);
            command.Parameters.AddWithValue("@I_employee", I_employee);
            command.Parameters.AddWithValue("@O_employee", O_employee);
            command.Parameters.AddWithValue("@Date_of_birthday", Date_of_birthday);
            command.Parameters.AddWithValue("@Experience", Experience);
            command.Parameters.AddWithValue("@id_dolj", id_dolj);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spEmployee_delete(Int32 id_employee)
        { 
            spConfiguration("employee_delete");

            command.Parameters.AddWithValue("@id_employee", id_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spEmployee_logical_delete(Int32 id_employee)
        {
            spConfiguration("employee_logical_delete");

            command.Parameters.AddWithValue("@id_employee", id_employee);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spStaff_work_shedule_insert(string Date, Int32 id_employee, Int32 id_status)
        {
            spConfiguration("staff_work_shedule_insert");

            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_status", id_status);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
            command.CommandType = System.Data.CommandType.Text;
        }

        public void spStaff_work_shedule_update(string Date, Int32 id_employee, Int32 id_status, Int32 id_staff_work_shedule)
        {
            spConfiguration("staff_work_shedule_update");

            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_status", id_status);
            command.Parameters.AddWithValue("@id_staff_work_shedule", id_staff_work_shedule);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
            command.CommandType = System.Data.CommandType.Text;
        }

        public void spPlanWork_insert(string Date_of_start, string Date_of_finish, 
            Int32 id_view_work, Int32 id_employee, Int32 id_fixed_project)
        {
            spConfiguration("work_plan_insert");

            command.Parameters.AddWithValue("@Date_of_start", Date_of_start);
            command.Parameters.AddWithValue("@Date_of_finish", Date_of_finish);
            command.Parameters.AddWithValue("@id_view_work", id_view_work);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_fixed_project", id_fixed_project);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spPlanWork_update(string Date_of_start, string Date_of_finish,
            Int32 id_view_work, Int32 id_employee, Int32 id_fixed_project, Int32 id_work_plan)
        {
            spConfiguration("work_plan_update");
            
            command.Parameters.AddWithValue("@Date_of_start", Date_of_start);
            command.Parameters.AddWithValue("@Date_of_finish", Date_of_finish);
            command.Parameters.AddWithValue("@id_view_work", id_view_work);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_fixed_project", id_fixed_project);
            command.Parameters.AddWithValue("@id_work_plan", id_work_plan);
            //ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            //ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spPlanWork_delete(Int32 id_work_plan)
        {
            spConfiguration("work_plan_delete");

            command.Parameters.AddWithValue("@id_work_plan", id_work_plan);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spPlanWork_logical_delete(Int32 id_work_plan)
        {
            spConfiguration("work_plan_logical_delete");

            command.Parameters.AddWithValue("@id_work_plan", id_work_plan);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spWorkJournal_insert(string Date_of_start, string Date_of_finish, string Note,
            Int32 id_view_work, Int32 id_employee, Int32 id_fixed_project)
        {
            spConfiguration("work_journal_insert");
            command.Parameters.AddWithValue("@Date_of_start", Date_of_start);
            command.Parameters.AddWithValue("@Date_of_finish", Date_of_finish);
            command.Parameters.AddWithValue("@Note", Note);
            command.Parameters.AddWithValue("@id_view_work", id_view_work);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_fixed_project", id_fixed_project);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spWorkJournal_update(string Date_of_start, string Date_of_finish, string Note,
            Int32 id_view_work, Int32 id_employee, Int32 id_fixed_project, Int32 id_work_journal)
        {
            spConfiguration("work_journal_update");
       
            command.Parameters.AddWithValue("@Date_of_start", Date_of_start);
            command.Parameters.AddWithValue("@Date_of_finish", Date_of_finish);
            command.Parameters.AddWithValue("@Note", Note);
            command.Parameters.AddWithValue("@id_view_work", id_view_work);
            command.Parameters.AddWithValue("@id_employee", id_employee);
            command.Parameters.AddWithValue("@id_fixed_project", id_fixed_project);
            command.Parameters.AddWithValue("@id_work_journal", id_work_journal);
           // ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            //ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spWorkJournal_delete(Int32 id_work_journal)
        {
            spConfiguration("work_journal_delete");

            command.Parameters.AddWithValue("@id_work_journal", id_work_journal);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }

        public void spWorkJournal_logical_delete(Int32 id_work_journal)
        {
            spConfiguration("work_journal_logical_delete");

            command.Parameters.AddWithValue("@id_work_journal", id_work_journal);
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            command.ExecuteNonQuery();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            command.Parameters.Clear();
        }
    }
}
