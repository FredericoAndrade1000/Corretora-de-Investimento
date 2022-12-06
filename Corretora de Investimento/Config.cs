using Corretora_de_Investimento.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corretora_de_Investimento
{
    public partial class Config : Form
    {
        private bool LogOut;

        public Config()
        {
            InitializeComponent();
            if (Translate.language == "pt") LanguageComboBox.Text = "Português";
            else if (Translate.language == "en") LanguageComboBox.Text = "Inglês";
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogOut = true;
            Close();
        }

        private void Config_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (LogOut && e.CloseReason != CloseReason.FormOwnerClosing)
            {
                (Owner as Corretora_Investimentos).moveToScreen = new MoveToScreen(new LoginScreen());
                Owner.Close();
            }
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LanguageComboBox.Text == "Português") Translate.language = "pt";
            else if (LanguageComboBox.Text == "Inglês") Translate.language = "en";
        }
    }
}
