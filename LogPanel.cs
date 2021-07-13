using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_project
{
    public partial class LogPanel : Form
    {
        Int32 id_table;
        public LogPanel()
        {
            InitializeComponent();
        }

        private void LogPanel_Load(object sender, EventArgs e)
        {
            cbSpravFill();
            
        }

        private void cbSpravFill()
        {
            
        }

        private void dgvHistoryFill(string table)
        {
            try
            {
                // заполнение таблицы
                Tables data = new Tables();
                string query = "Select * from " + table;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                data.dtFill(data.dtHistory, query);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                dgvHistory.DataSource = data.dtHistory;
                //невидимость первичного ключа
                
            }

            // предусмотрение ошибок
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbSprav_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cbSprav.SelectedText)
            {
                case ("Заказчики"):
                    dgvHistoryFill("View_customer_log");
                    dgvHistory.Columns[0].Visible = false;
                    dgvHistory.Columns[1].Visible = false;
                    dgvHistory.Columns[3].Visible = false;
                    dgvHistory.Columns[4].Visible = false;
                    break;
                case ("Должности"):
                    dgvHistoryFill("View_dolj_log");
                    dgvHistory.Columns[0].Visible = false;
                    dgvHistory.Columns[1].Visible = false;
                    dgvHistory.Columns[3].Visible = false;
                    dgvHistory.Columns[4].Visible = false;
                    break;
                case ("Вид работ"):
                    dgvHistoryFill("View_view_work_log");
                    dgvHistory.Columns[0].Visible = false;
                    dgvHistory.Columns[1].Visible = false;
                    dgvHistory.Columns[3].Visible = false;
                    dgvHistory.Columns[4].Visible = false;
                    break;
                case ("Статус"):
                    dgvHistoryFill("View_status_log");
                    dgvHistory.Columns[0].Visible = false;
                    dgvHistory.Columns[1].Visible = false;
                    dgvHistory.Columns[3].Visible = false;
                    dgvHistory.Columns[4].Visible = false;
                    break;
                case ("План работ"):
                    dgvHistoryFill("work_plan");
                    break;
                case ("Сотрудники"):
                    dgvHistoryFill("View_employee_log");
                    break;
                case ("Закрепленные проекты"):
                    dgvHistoryFill("fixed_project");
                    break;
                case ("Журнал работ проекта"):
                    dgvHistoryFill("work_journal");
                    break;
            }
        }
    }
}
