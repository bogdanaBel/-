using System;
using System.Windows.Forms;

namespace Manager_project
{
    public static class Program
    {
        public static  bool avtoriz = false;
        public static Int32 id_fixed_project = 0;
        public static Int32 id_sel_employee = 1;
        public static string strSelectedTab = "";
        public static Int32 sprav_customer,
        sprav_fixed_project, sprav_authorization,
        sprav_role, sprav_employee, sprav_staff_work_shedule,
        sprav_plan_work, sprav_work_journal, Administration,
            Config_org, Config_doc;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConnectionForm());
        }
    }
}
