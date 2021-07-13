using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Manager_project
{
    public partial class InfoofDoc : Form
    {
        string patMail = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
        private string Domen;
        public InfoofDoc()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            OrgSave();
        }

        private void InfoofDoc_Load(object sender, EventArgs e)
        {
            // получение данных из реестра об организации
            RegistryLibrary.RegistryClass.OrgConfigurationGet();
            tbShortNameOrg.Text = RegistryLibrary.RegistryClass.ShortName;
            tbFullNameOrg.Text = RegistryLibrary.RegistryClass.FullName;
            tbUridAddress.Text = RegistryLibrary.RegistryClass.UrAddress;
            tbFIODirector.Text = RegistryLibrary.RegistryClass.Director;
            tbINN.Text = RegistryLibrary.RegistryClass.INN;
            tbPhone.Text = RegistryLibrary.RegistryClass.Phone;
            tbMailOrg.Text = RegistryLibrary.RegistryClass.Mail;
            tbPodpis.Text = RegistryLibrary.RegistryClass.Podpis;
            tbPassword.Text = RegistryLibrary.RegistryClass.Password;
            switch (RegistryLibrary.RegistryClass.Domen)
            {
                case ("mail.ru"):
                    rbMail.Checked = true;
                    break;
                case ("yandex.ru"):
                    rbYandex.Checked = true;
                    break;
                case ("gmail.com"):
                    rbGmail.Checked = true;
                    break;
            }
        }

        private void OrgSave()
        {
            // проверка на заполнение полей
            switch (tbPhone.Text == "" | tbFullNameOrg.Text == "" |
                tbShortNameOrg.Text == ""| tbUridAddress.Text == "" |
                tbINN.Text == "" | tbFIODirector.Text == ""| tbMailOrg.Text == ""
                | tbPodpis.Text == "" | tbPassword.Text == "")
            {
                case (true):
                    MessageBox.Show("Не все поля заполнены!", "Пустые поля",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case (false):
                    if (rbMail.Checked) Domen = "mail.ru";
                    if (rbYandex.Checked) Domen = "yandex.ru";
                    if (rbGmail.Checked) Domen = "gmail.com";
                    if ((Domen == "mail.ru") || (Domen == "yandex.ru") || (Domen == "gmail.com"))
                    {
                        // проверка на введенную почту
                        switch (Regex.IsMatch(tbMailOrg.Text, patMail, RegexOptions.IgnoreCase))
                        {
                            case (true):
                                try
                                {
                                    // сохранение сведений об организации в реестр
                                    RegistryLibrary.RegistryClass.OrgConfigurationSet(tbShortNameOrg.Text, tbFullNameOrg.Text, tbFIODirector.Text,
                                    tbINN.Text, tbPhone.Text, tbUridAddress.Text, tbMailOrg.Text, tbPassword.Text, Domen, tbPodpis.Text);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                break;
                            case (false):
                                MessageBox.Show("Введен некорректный адрес почты. Варианты ошибок: \n1. Вы не указали символ @; \n2. Вы не написали домен почты после знака @",
                                                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        // проверка на выбор домена
                        MessageBox.Show("Сохранение не выполнено. Укажите домен почты!",
                        "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btApplye_Click(object sender, EventArgs e)
        {
            OrgSave();
        }
    }
}
