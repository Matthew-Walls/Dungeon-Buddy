using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Buddy
{
    public partial class FormSplash : Form
    {
        // Adjusted Constructor that includes argument for parentForm.
        public FormSplash(FormMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        // Initalize variable to hold parent form.
        private FormMain _parentForm;

        // Method to create and pass a campaign to FormMain.
        private void PassCampaign(int id, string name, List<string> desc, string dm, DateTime startDate, bool newCampaign)
        {
            // Create campaign from local variables.
            Campaign campaign = new Campaign(id, name, desc, dm, startDate);

            // Set campaign in Parent Form.
            _parentForm.Campaign = campaign;

            // If campaign is new add record into database.
            if (newCampaign)
            {
                campaignTableAdapter.Insert(campaign.CampaignTitle, string.Join("|", campaign.Description), campaign.DungeonMaster, campaign.StartDate);
            }

            // Close FormSplash.
            this.Close();
        }

        private void radioLoad_CheckedChanged(object sender, EventArgs e)
        {
            // When radio Load is checked adjust displayed form.
            panelLoad.Visible = true;
            panelNew.Visible = false;
        }

        private void radioNew_CheckedChanged(object sender, EventArgs e)
        {
            // When radio New is checked adjust displayed form.
            panelNew.Visible = true;
            panelLoad.Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Get select campaign data from database and
            // store in local variables.

            // Store selected datarow as a DataRowView for easier access.
            // Found this through debugging that this object can be cast
            // as a DataRowView.
            DataRowView row = (DataRowView)campaignBindingSource.Current;

            // Initialize a local variable to id based off the selected
            // row Id field.
            int id = row.Row.Field<int>("Id");

            // Store row fields in local variables.
            string name = campaignTableAdapter.GetCampaignTitle(id);
            List<string> desc = campaignTableAdapter.GetCampaignDescription(id).Split('|').ToList();
            string dm = campaignTableAdapter.GetCampaignDungeonMaster(id);
            DateTime startDate = (DateTime)campaignTableAdapter.GetCampaignStartDate(id);
            bool newCampaign = false;

            // Test that name isn't null.
            if (name == "")
            {
                MessageBox.Show("Campaign name cannot be blank!");
                txtBoxName.Focus();
                return;
            }

            // Call PassCampaign.
            PassCampaign(id, name, desc, dm, startDate, newCampaign);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Store form values into local variables.
            string name = txtBoxName.Text;
            List<string> desc = txtBoxDesc.Lines.ToList();
            string dm = txtBoxDM.Text;
            DateTime startDate = dateStartDate.Value;
            bool newCampaign = true;

            // Test that name isn't null.
            if (name == "")
            {
                MessageBox.Show("Campaign name cannot be blank!");
                txtBoxName.Focus();
                return;
            }

            // Call PassCampaign.
            PassCampaign(int.Parse(campaignTableAdapter.GetNextId().ToString()), name, desc, dm, startDate,newCampaign);
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            // This refreshes the campaign listbox on load.
            this.campaignTableAdapter.Fill(this.dungeonBuddyDataSet.Campaign);
        }
    }
}
