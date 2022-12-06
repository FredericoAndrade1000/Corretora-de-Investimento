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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Corretora_de_Investimento
{
    public partial class SingOnScreen : Form
    {
        public MoveToScreen moveToScreen;
        private DatabaseConnection connection = new DatabaseConnection();
        public SingOnScreen()
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
            if(connection.ValidateUserName(UserNameTextBox.Text))
            {
                MessageBox.Show("Já existe um usuário com este nome!");
                return;
            }
            connection.SingOnUser(UserNameTextBox.Text, PasswordTextBox.Text);
            MessageBox.Show("Usuário cadastrado com sucesso!");
            moveToScreen = new MoveToScreen(new LoginScreen());
            Dispose(true);
            Close();
        }

        private void linkLabelSingOn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            moveToScreen = new MoveToScreen(new LoginScreen());
            Dispose(true);
            Close();
        }
    }
}
