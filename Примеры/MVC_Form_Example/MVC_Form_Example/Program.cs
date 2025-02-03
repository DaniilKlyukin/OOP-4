using MVC_Form_Example.Controller;
using MVC_Form_Example.Interfaces;

namespace MVC_Form_Example
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IContactView view = new MainForm();
            IContactController controller = new ContactController(view);

            Application.Run((Form)view);

        }
    }
}