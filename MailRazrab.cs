using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Manager_project
{
    public partial class MailRazrab : Form
    {
        string Domen, Mail, password, nameOrg;

        private void MailRazrab_Load(object sender, EventArgs e)
        {

        }

        public MailRazrab()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            RegistryLibrary.RegistryClass.OrgConfigurationGet();
            // получение данных из реестра
            Domen = RegistryLibrary.RegistryClass.Domen;
            Mail = RegistryLibrary.RegistryClass.Mail;
            password = RegistryLibrary.RegistryClass.Password;
            nameOrg = RegistryLibrary.RegistryClass.FullName;
            MySendMail(tbMessage.Text, Mail, tbTema.Text);
        }

        public void MySendMail(string bodyMail, string mailOrg, string subject)
        {
            try
            {
                var from = new MailAddress(mailOrg, nameOrg);
                var to = new MailAddress("bogdanabelyakova@gmail.com");
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
                // отправление сообщения
                smtp.Send(mail);
                MessageBox.Show("Сообщение было отправлено!", "Информационное письмо",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMessage.Clear();
                tbTema.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
