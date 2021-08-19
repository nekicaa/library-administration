﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;

namespace View
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            while (true)
            {
                try
                {
                    Application.Run(new FrmLogin());

                    //                    Application.Run();
                }
                catch (ServerException se)
                {
                    MessageBox.Show("Server je prekinuo sa radom!");
                    Console.WriteLine(se.Message);
                }
            }
        }
    }
}
