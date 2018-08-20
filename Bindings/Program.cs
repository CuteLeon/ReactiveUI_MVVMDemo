using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ReactiveUI;
using Bindings.ViewModels;

namespace Bindings
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PersonViewModel person = new PersonViewModel();
            MainForm form1 = new MainForm();
            MainForm form2 = new MainForm();
            form1.ViewModel = person;
            form2.ViewModel = person;
            form1.Show();
            form2.Show();

            Application.Run(new MainForm() { ViewModel = person });
        }
    }
}
