using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGameINForm
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
            Application.Run(new Form1());
        }
    }
    private static void Swap(ref double num1,ref double num2)
    {
        double i = num1;
        num1 = num2;
        num2 = i;
    }
    private static double Multiplay(double num1, double num2)
    {
        return num1 * num2;
    }
}
