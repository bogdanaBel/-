using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Manager_project
{
    public partial class SendMail : Form
    {
        SqlCommand command = new SqlCommand("",ConnectionLibrary.ConnectionLibrary.sqlConnection);
        Int32 numberFiles = 0;
        string FilesList = "";
        string Domen, Podpis, Mail, nameOrg, password;
        public SendMail()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            // выбор файла для прикрепления
            RegistryLibrary.RegistryClass.DocConfigurationGet();
            openFileDialog1.InitialDirectory = RegistryLibrary.RegistryClass.DirPath;
            openFileDialog1.Filter = "(*.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (numberFiles <= 4)
                {
                    FilesList += openFileDialog1.FileName + "\r\n";
                    numberFiles++;
                    lblPath.Text = "Файлов прикреплено: \r\n" + FilesList.ToString();
                }
                else
                    MessageBox.Show("Невозможно прикрепить столько файлов!");
            }
        }

        private void SendMail_Load(object sender, EventArgs e)
        {
            lblPath.Text = "Файлов прикреплено: 0";
            cbCustomerFill();
        }

        private void cbCustomerFill()
        {
            // заполнение выпадающего списка заказчиками
            try
            {
                Tables dt = new Tables();
                command.CommandText = "Select id_fixed_project, Mail_customer from View_fixed_project where fixed_project_logical_delete = 0 " +
                    "and id_employee=" + Program.id_sel_employee;
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Open();
                dt.dtFill(dt.dtProject, command.CommandText);
                ConnectionLibrary.ConnectionLibrary.sqlConnection.Close();
                cbCustomer.DataSource = dt.dtProject;
                cbCustomer.ValueMember = "id_fixed_project";
                cbCustomer.DisplayMember = "Mail_customer";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MySendMail(string bodyMail, string mailOrg, string nameOrg, string subject, string MailTo)
        {
            try
            {
                var from = new MailAddress(mailOrg, nameOrg);
                var to = new MailAddress(MailTo);
                SmtpClient smtp = new SmtpClient();
                switch (Domen)
                {
                    case ("mail.ru"):
                       
                        smtp.Host = "smtp.mail.ru";
                        smtp.Port = 25;
                        break;
                    case ("yandex.ru"):
                        smtp.Host = "smtp.yandex.ru";
                        smtp.Port = 25;
                        break;
                    case ("gmail.com"):
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 25;
                        break;
                }
                
                
                // авторизация в почте
                smtp.Credentials = new NetworkCredential(mailOrg, password);
                // указание протокола
                smtp.EnableSsl = true;

                // отправление от кого кому сообщение
                MailMessage mail = new MailMessage(from, to);
                mail.Subject = subject;
                // задаем письму формат html 
                mail.IsBodyHtml = true;
                // задаем визуальное оформление
                mail.Body = "<html>" +
                    "<body>" +
                    bodyMail +
                    "<br>" +
                    Podpis +
                    "</body>" +
                    "</html>";
                mail.Attachments.Add(new Attachment(openFileDialog1.FileName));
                // отправление сообщения
                smtp.Send(mail);
                MessageBox.Show("Сообщение было отправлено!", "Информационное письмо",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMessage.Clear();
                tbTema.Clear();
                lblPath.Text = "Файлов прикреплено: 0";
                cbCustomerFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            RegistryLibrary.RegistryClass.OrgConfigurationGet();

            Domen = RegistryLibrary.RegistryClass.Domen;
            Podpis = RegistryLibrary.RegistryClass.Podpis;
            Mail = RegistryLibrary.RegistryClass.Mail;
            nameOrg = RegistryLibrary.RegistryClass.FullName;
            password = RegistryLibrary.RegistryClass.Password;
            MySendMail(tbMessage.Text, Mail, nameOrg, tbTema.Text, cbCustomer.Text);
        }
    }
}
