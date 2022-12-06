using Org.BouncyCastle.Asn1.Esf;
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
    public partial class ModifyDialog : Form
    {
        public List<Control> selection = new List<Control>();    
        public bool validated = false;
        public ModifyDialog()
        {
            InitializeComponent();
        }
        private bool ValidateSend()
        {
            foreach (Control c in this.Controls)
            {
                if (c is GroupBox && (c as GroupBox).Controls.Count != 0)
                {
                    if ((c as GroupBox).Controls[0].Text=="") return false;
                }
            }
            return true;
        }
        private void SetSenderValues()
        {
            foreach (Control c in this.Controls)
            {
                if (c is GroupBox && (c as GroupBox).Controls.Count!=0)
                {
                    selection.Add((c as GroupBox).Controls[0].Clone());
                }
            }
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateSend())
            {
                SetSenderValues();
                validated = true;
                this.Close();
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
