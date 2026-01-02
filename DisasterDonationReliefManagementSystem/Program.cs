using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Forms;

namespace DisasterDonationReliefManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomePage(new Admin(1, 1, "admin1", true, "System Admin", "admin@mail.com")));
        }
    }
}