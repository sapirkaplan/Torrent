using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FileSharing_FTP_Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("blbla");
            Console.WriteLine("hihihi");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Client());
        }
    }
}
