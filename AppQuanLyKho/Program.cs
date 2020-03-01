using AppQuanLyKho.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyKho
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new GiaoDienChinh());
=======
            Application.Run(new DangNhap());
>>>>>>> 29002583a44238912415c3c1089bac2f529ad113
        }
    }
}
