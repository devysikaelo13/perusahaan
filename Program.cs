using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perusahaan
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
            Application.Run(new Form_Menu());
            //Application.Run(new Form_Tambah_Pegawai());
            //Application.Run(new Form_Tambah_Departemen());
            //Application.Run(new Form_Tambah_Proyek());
            //Application.Run(new Form_Penugasan());
            //Application.Run(new Form_View_Pegawai());
        }
    }
}
