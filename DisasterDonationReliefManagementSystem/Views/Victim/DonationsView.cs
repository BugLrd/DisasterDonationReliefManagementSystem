using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views.Victim
{
    public partial class DonationsView : UserControl
    {
        Entities.Victim v;
        public DonationsView(Entities.Victim victim)
        {
            InitializeComponent();
            v = victim;
        }

        private void DonationsView_Load(object sender, EventArgs e)
        {
            string select_query =
                $"SELECT del.DeliveryID AS DeliveryID, del.DeliveryStatus AS DeliveryStatus, del.PickupLocation AS PickupLocation, del.DeliveryLocation AS DeliveryLocation, d.DonationID AS DonationID, d.DonationType AS DonationType, d.ItemDetails AS ItemDetails, d.DonationDate AS DonationDate, dn.DonatorID AS DonatorID, ld.Username AS DonatorUsername, dn.Phone AS DonatorPhone " +
                "FROM DisasterRequest dr " +
                "INNER JOIN Donation d ON dr.RequestID = d.RequestID " +
                "LEFT JOIN Delivery del ON d.DonationID = del.DonationID " +
                "INNER JOIN Donator dn ON d.DonatorID = dn.DonatorID " +
                "INNER JOIN Login ld ON dn.LoginID = ld.LoginID " +
                $"WHERE dr.VictimID = {v.VictimID} ORDER BY d.DonationDate;";

            var data = Query.GetDataTable(select_query);

            // Bind the data to the DataGridView
            detailsTable.AutoGenerateColumns = true;
            detailsTable.DataSource = data;

            // Optional: improve headers and visibility
            if (detailsTable.Columns.Contains("DeliveryID"))
                detailsTable.Columns["DeliveryID"].HeaderText = "Delivery ID";
            if (detailsTable.Columns.Contains("DeliveryStatus"))
                detailsTable.Columns["DeliveryStatus"].HeaderText = "Status";
            if (detailsTable.Columns.Contains("PickupLocation"))
                detailsTable.Columns["PickupLocation"].HeaderText = "Pickup";
            if (detailsTable.Columns.Contains("DeliveryLocation"))
                detailsTable.Columns["DeliveryLocation"].HeaderText = "Delivery";
            if (detailsTable.Columns.Contains("DonationID"))
                detailsTable.Columns["DonationID"].HeaderText = "Donation ID";
            if (detailsTable.Columns.Contains("DonationType"))
                detailsTable.Columns["DonationType"].HeaderText = "Type";
            if (detailsTable.Columns.Contains("ItemDetails"))
                detailsTable.Columns["ItemDetails"].HeaderText = "Items";
            if (detailsTable.Columns.Contains("DonationDate"))
                detailsTable.Columns["DonationDate"].HeaderText = "Date";
            if (detailsTable.Columns.Contains("DonatorID"))
                detailsTable.Columns["DonatorID"].Visible = false; // hide internal IDs if not needed
            if (detailsTable.Columns.Contains("DonatorUsername"))
                detailsTable.Columns["DonatorUsername"].HeaderText = "Donator";
            if (detailsTable.Columns.Contains("DonatorPhone"))
                detailsTable.Columns["DonatorPhone"].HeaderText = "Phone";

            detailsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            detailsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            detailsTable.ReadOnly = true;
        }
    }
}
