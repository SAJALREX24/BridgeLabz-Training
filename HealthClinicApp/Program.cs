using HealthClinicApp.Menu;

namespace HealthClinicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This tells the application to launch your menu!
            MainMenu menu = new MainMenu();
            menu.Start();
        }
    }
}