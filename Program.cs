using Trabalho2.Interfaces;

namespace Trabalho2
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuPrincipal());
        }
    }
}