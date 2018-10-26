﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nursery_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Sign signForm = new Sign();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(/*new Sign()*/ signForm);
            // Application.Run(new signIn());
            // Application.Run(new signUp());
            //System.Environment.Exit(1);
            Application.Run(new signUp());
            Application.Run(new ParentForm());
            Application.Run(new Child());
        }
    }
}
