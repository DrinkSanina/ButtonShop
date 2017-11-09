using System;
using System.Windows.Forms;

namespace PHPShop
{
    static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Authorization());
=======
            Application.Run(new Assortment());
>>>>>>> 0557884... Merge pull request #1 from San32x/Dev
        }
    }
}
