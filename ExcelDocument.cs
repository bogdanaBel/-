using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using excel = Microsoft.Office.Interop.Excel;

namespace Manager_project
{
    class ExcelDocument
    {
        SqlCommand command = new SqlCommand("", ConnectionLibrary.ConnectionLibrary.sqlConnection);
        SqlConnection sql = ConnectionLibrary.ConnectionLibrary.sqlConnection;
        public void JournalWorkExcel(DataGridView dgv, string NameProject, string Rucovoditel)
        {
            try
            {
                RegistryLibrary.RegistryClass.DocConfigurationGet();
                excel.Application application = new excel.Application();
                excel.Workbook workbook = application.Workbooks.Add();
                excel.Worksheet worksheet =
                    (excel.Worksheet)workbook.ActiveSheet;
               
                worksheet.Name = "Журнал работ";
                worksheet.Cells.Font.Name = RegistryLibrary.RegistryClass.SFF;
                worksheet.Cells.Font.Size = 10;

                worksheet.Cells[1, 1] = "Журнал работ проекта " + NameProject;
                worksheet.Cells[2, 1] = "Руководитель проекта: " + Rucovoditel;
                // заполнение названий столбцов
                for (int k = 1; k < dgv.ColumnCount - 2; k++)
                {
                    worksheet.Cells[3, k] = dgv.Columns[k + 2].HeaderText;

                }

                // заполнение таблицы бд
                for (int j = 1; j <= dgv.Rows.Count; j++)
                {
                    for (int i = 4; i <= dgv.Columns.Count; i++)
                    {
                        //MessageBox.Show(dgv.Rows[j - 1].Cells[i - 1].Value.ToString());
                        worksheet.Cells[j + 3, i - 3] = dgv.Rows[j - 1].Cells[i - 1].Value.ToString();
                    }
                }

                worksheet.StandardWidth = 15;
                worksheet.Columns[3].ColumnWidth = 50;
                worksheet.Columns[4].ColumnWidth = 40;

                workbook.SaveAs(Filename: "Журнал работ проекта " + NameProject + " " + DateTime.Now.ToShortDateString() + ".xlsx", FileFormat: excel.XlFileFormat.xlWorkbookDefault);
                workbook.Close();
                application.Quit();
                MessageBox.Show("Документ сформирован.");
                ProcessKill(application);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ProcessKill(excel.Application app)
        {
            // закрытие процессы Excel из диспетчера задач
            System.Diagnostics.Process excelProc = System.Diagnostics.Process.GetProcessesByName("EXCEL").Last();
            app.Application.Quit();
            excelProc.Kill();
        }

        public void PlanWorkExcel(DataGridView dgv, string NameProject, string Rucovoditel)
        {
            try
            {
                RegistryLibrary.RegistryClass.DocConfigurationGet();
                excel.Application application = new excel.Application();
                excel.Workbook workbook = application.Workbooks.Add();
                excel.Worksheet worksheet =
                    (excel.Worksheet)workbook.ActiveSheet;

                worksheet.Name = "План работ";
                worksheet.Cells.Font.Name = RegistryLibrary.RegistryClass.SFF;
                worksheet.Cells.Font.Size = 10;

                worksheet.Cells[1, 1] = "План работ проекта " + NameProject;
                worksheet.Cells[2, 1] = "Руководитель проекта: " + Rucovoditel;
                // заполнение названий столбцов
                for (int k = 1; k < dgv.ColumnCount - 2; k++)
                {
                    worksheet.Cells[3, k] = dgv.Columns[k + 2].HeaderText;

                }

                // заполнение таблицы бд
                for (int j = 1; j <= dgv.Rows.Count; j++)
                {
                    for (int i = 4; i <= dgv.Columns.Count; i++)
                    {
                        //MessageBox.Show(dgv.Rows[j - 1].Cells[i - 1].Value.ToString());
                        worksheet.Cells[j + 3, i - 3] = dgv.Rows[j - 1].Cells[i - 1].Value.ToString();
                    }
                }

                worksheet.StandardWidth = 15;
                worksheet.Columns[3].ColumnWidth = 50;
                worksheet.Columns[4].ColumnWidth = 40;

                workbook.SaveAs(Filename: "План работ проекта " + NameProject + " " + DateTime.Now.ToShortDateString() + ".xlsx", FileFormat: excel.XlFileFormat.xlWorkbookDefault);
                workbook.Close();
                application.Quit();
                MessageBox.Show("Документ сформирован.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
