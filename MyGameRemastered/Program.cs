using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGameRemastered
{
    internal static class Program
    {
        public static int[] teams_scores = { 0, 0, 0, 0, 0, 0, 0};// счета клманд
        public static int queqe = 0; // очередность команд
        public static bool random_queue = false;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Registration start = new Registration();
            Application.Run(start);
            
        }
    }
}
