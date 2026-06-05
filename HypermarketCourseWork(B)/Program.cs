using System;
using System.Windows.Forms;

namespace HypermarketCourseWork_A_;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        // Запуск WinForms-додатку
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}