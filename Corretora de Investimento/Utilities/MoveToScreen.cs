using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corretora_de_Investimento.Utilities
{
    public class MoveToScreen
    {
        public MoveToScreen(Form form)
        {
            moveForm = form;
            move = true;
        }
        private Form moveForm;
        private bool move = false;
        public Form MoveForm { get { return moveForm; } }
        public bool Move { get { return move; } }
    }
}
