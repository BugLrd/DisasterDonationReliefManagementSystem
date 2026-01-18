using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Forms;
using DisasterDonationReliefManagementSystem.Forms.signupPage;

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
            Application.Run(new HomePage(new Volunteer(1, 1, "john", true, "John Doe", "014235", "bike", "available", "")));
        }
    }
}