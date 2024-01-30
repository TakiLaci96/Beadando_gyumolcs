using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando_gyumolcs
{
    internal static class Program
    {
        public static Form1 nyitoForm = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            nyitoForm = new Form1();
            Application.Run(nyitoForm);
        }
    }
}
