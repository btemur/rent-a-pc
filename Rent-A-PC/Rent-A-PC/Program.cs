﻿using System;
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
            Application.Run(new Form1(new TechConceptAsc(new DataManagementSQL())));
        }
    }
}
