﻿using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Random_Number_Plus
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
