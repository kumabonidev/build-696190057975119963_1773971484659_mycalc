using System;
using System.Windows.Forms;

namespace MyCalc
{
    static class Program
    {
        /// <summary>
        /// النقطة الرئيسية للدخول إلى التطبيق.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}