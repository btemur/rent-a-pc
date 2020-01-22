using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rent_A_PC.DataManagement;
using Rent_A_PC.TechConcepts;

namespace Rent_A_PC
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Form1.GetInstance(Fachkonzept.GetInstance(DataManagementSQL.GetInstance(), new ReverseStrategy())));
        }
    }
}
