using Corretora_de_Investimento.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corretora_de_Investimento
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        private static Form currentForm;
        public static Form nextForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            currentForm = new LoginScreen();
            Application.Run(currentForm);
            while (GetNextForm(ref currentForm) != null && GetNextForm(ref currentForm).Move)
            {
                currentForm = GetNextForm(ref currentForm).MoveForm;
                Application.Run(currentForm);
            }
        }
        static MoveToScreen GetNextForm(ref Form form)
        {
            if (form == null) return null;
            if (form is LoginScreen) return (form as LoginScreen).moveToScreen;
            else if (form is SingOnScreen) return (form as SingOnScreen).moveToScreen;
            else if (form is Corretora_Investimentos) return (form as Corretora_Investimentos).moveToScreen;
            return null;
        }
    }
}
