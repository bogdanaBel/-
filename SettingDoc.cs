using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using RegistryLibrary;

namespace Manager_project
{
    public partial class SettingDoc : Form
    {
        public SettingDoc()
        {
            InitializeComponent();
        }
        decimal TM, RM, BM, LM;

        private void nudTopMerg_ValueChanged(object sender, EventArgs e)
        {
            TM = nudTopMerg.Value;
        }

        private void nudRightMerg_ValueChanged(object sender, EventArgs e)
        {
            RM = nudRightMerg.Value;
        }

        private void nudBottomMerg_ValueChanged(object sender, EventArgs e)
        {
            BM = nudBottomMerg.Value;
        }
        
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudLeftMerg_ValueChanged(object sender, EventArgs e)
        {
            LM = nudLeftMerg.Value;
        }

        private void btApplye_Click(object sender, EventArgs e)
        {
            // сохранение
            DocumentSave();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // выбор папки для сохранения отчетов
            folderBrowserDialog1.ShowDialog();
            tbPath.Text = folderBrowserDialog1.SelectedPath + "\\Отчёты\\";
        }

        string SFF;
        public static System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();

        private void ComboBoxFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            // выбор шрифта текста
            SFF = ComboBoxFontStyle.SelectedItem.ToString();
        }

        private void SettingDoc_Load(object sender, EventArgs e)
        {
            // загрукза данных из реестра в компоненты
            FillComboBoxFont();
            tbPath.Text = RegistryClass.DirPath;
            RegistryClass.DocConfigurationGet();
            nudTopMerg.Value = (decimal)RegistryClass.DocTM;
            nudRightMerg.Value = (decimal)RegistryClass.DocRM;
            nudBottomMerg.Value = (decimal)RegistryClass.DocBM;
            nudLeftMerg.Value = (decimal)RegistryClass.DocLM;
            ComboBoxFontStyle.SelectedItem = RegistryClass.SFF;
            TM = nudTopMerg.Value;
            RM = nudRightMerg.Value;
            BM = nudBottomMerg.Value;
            LM = nudLeftMerg.Value;
            ComboBoxFontStyle.SelectedItem = SFF;
        }

        private void FillComboBoxFont()
        {
            // загрузка стилей шрифта в ComboBox
            foreach (FontFamily font in fonts.Families)
            {
                ComboBoxFontStyle.Items.Add(font.Name);
            }

        }
        
        private void DocumentSave()
        {
            // сохранение данных документа в реестр
            string document_default_path = "";
            switch (tbPath.Text == "")
            {
                case (true):
                    // установление пути по умолчанию
                    document_default_path =
                        "C:\\Users\\" + SystemInformation.UserName
                        + "\\Documents\\Отчёты";
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
                case (false):
                    document_default_path = tbPath.Text;
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
            }
            RegistryClass.DocConfigurationSet(tbPath.Text, nudLeftMerg.Value,
                nudTopMerg.Value,
                nudRightMerg.Value, nudBottomMerg.Value, SFF);
        }
    }
}
