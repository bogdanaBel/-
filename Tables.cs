using System.Data;
using System.Data.SqlClient;

namespace Manager_project
{
    class Tables
    {
        public SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
        public DataTable dtCustomer = new DataTable("Customer");
        public DataTable dtDolj= new DataTable("Dolj");
        public DataTable dtRole = new DataTable("Role");
        public DataTable dtFixedProject = new DataTable("Fixed_project");
        public DataTable dtAvtoriz = new DataTable("Avtoriz");
        public DataTable dtEmployee = new DataTable("Employee");
        public DataTable dtStatus = new DataTable("Status");
        public DataTable dtStaffWorkSchedule = new DataTable("Staff_work_schedule");
        public DataTable dtViewWork = new DataTable("View_work");
        public DataTable dtWorkPlan = new DataTable("Work_plan");
        public DataTable dtWorkJournal = new DataTable("Work_journal");
        public DataTable dtHistory = new DataTable("History");
        public DataTable dtProject = new DataTable("Project");

        public string qrCustomer = "Select id_customer, name_customer as 'Заказчик', mail_customer as 'Электронная почта' from Customer",
                      qrDolj = "Select id_dolj, name_dolj as 'Должность' from Dolj",
            qrStatus = "Select id_status, status as 'Статус' from Status",
            qrViewWork = "Select id_view_work, view_work as 'Вид работы' from View_work",
            qrFixedProject = "Select id_fixed_project, id_customer, id_employee, Name_project as 'Проект'," +
            " Name_customer as 'Заказчик', " +
            " Employee as 'Руководитель проекта' from View_fixed_project",
            qrRole = "Select name_role, sprav_customer, sprav_fixed_project, sprav_authorization," +
            "sprav_role, sprav_employee, sprav_staff_work_shedule, sprav_work_plan, sprav_work_journal," +
            "BackUpBD, History from Role",
            qrAvtoriz = "Select id_avtoriz, id_role,  id_employee, Employee as 'Сотрудник', name_role as 'Название роли', login as 'Логин', password as 'Пароль'  from View_avtoriz",
            qrEmployee = "Select id_employee, id_dolj, FIO_employee as 'ФИО сотрудника', Date_of_birthday as 'Дата рождения', Age as 'Возраст', Experience as 'Стаж', " +
            " Name_dolj as 'Должность' from View_employee",
            qrHistory = "Select id_history, time_of_update as 'Время изменений', action as 'Действие' ,[table] as 'Запись', id_table as 'Ключ записи' from History",

            qrPlanWork = "Select id_work_plan, id_employee, id_view_work," +
            "Date_of_start as 'Дата начала', Date_of_finish as 'Дата окончания', View_work  as 'Вид работы', Employee as 'Исполнитель' from View_work_plan",

        qrWorkJournal = "Select id_work_journal, id_employee, id_view_work," +
            "Date_of_start as 'Дата начала', Date_of_finish as 'Дата окончания', View_work  as 'Вид работы', Employee as 'Исполнитель', Note as 'Примечание' from View_work_journal";

        public void dtFill(DataTable table, string query)
        {
            command.Notification = null;
            command.CommandText = query;
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
            ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
            table.Load(command.ExecuteReader());

            ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
        }
        
        public void dtCustomerFill()
        {
            dtFill(dtCustomer, qrCustomer);
        }

       

    }
}
