using Controller.Controllers;

namespace Controller
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            MainController mainController = new MainController();
            mainController.init();

        }
    }
}