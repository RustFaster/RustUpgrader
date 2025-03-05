using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engine
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBox.Show("Let's go 1");
            Application.EnableVisualStyles();
            MessageBox.Show("Let's go 2");
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBox.Show("Let's go 3");
            Application.Run(new Form1());
            MessageBox.Show("Let's go 4");
        }
    }
}
