// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Лабораторная работа №3.
//   Испольозвание ListBox и TabControl
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab3Tabs
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Лабораторная работа №3.
    /// Испольозвание ListBox и TabControl
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
