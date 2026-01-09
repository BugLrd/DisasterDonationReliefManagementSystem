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
            Application.Run(new HomePage(new Donator(1, 1, "dsf", true, "23534", "fg", "dsf", "")));
        }
    }
}