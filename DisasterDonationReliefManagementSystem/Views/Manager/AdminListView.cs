using DisasterDonationReliefManagementSystem.Services;
using DisasterDonationReliefManagementSystem.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views.Manager
{
    public partial class AdminListView : ManageUserView
    {
        public AdminListView()
        {
            InitializeComponent();
        }



        public override void LoadUsers()
        {
            // Admins
            string adminQuery = "SELECT a.*, l.Username, l.Status, l.Message FROM Admin a INNER JOIN Login l ON a.LoginID = l.LoginID";
            foreach (var a in Query.GetAdmins(adminQuery))
            {
                _users.Add(new UserItem
                {
                    LoginID = a.LoginID,
                    Role = "Admin",
                    Username = a.Username,
                    FullName = a.FullName,
                    Status = a.Status,
                    Contact = a.Email,
                    Extra = string.Empty,
                    Message = a.Message ?? string.Empty
                });
            }
        }
    }
}
