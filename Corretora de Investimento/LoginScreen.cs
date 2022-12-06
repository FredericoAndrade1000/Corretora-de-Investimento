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
using static System.Net.Mime.MediaTypeNames;

namespace Corretora_de_Investimento
{
    public partial class LoginScreen : Form
    {
        public MoveToScreen moveToScreen;
        private DatabaseConnection connection = new DatabaseConnection();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Preencha os campos usuário e senha!");
                return;
            }
            if (connection.ValidateLogin(UserNameTextBox.Text, PasswordTextBox.Text))
            {
                moveToScreen = new MoveToScreen(new Corretora_Investimentos());
                Dispose();
                Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }

        private void linkLabelSingOn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            moveToScreen = new MoveToScreen(new SingOnScreen());
            Dispose();
            Close();
        }
    }
}
