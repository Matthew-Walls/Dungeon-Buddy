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
        private void PassCampaign(int id, string name, string desc)
        {
            // Create campaign from local variables.
            Campaign campaign = new Campaign(name, desc);

            // Set campaign in Parent Form.
            _parentForm.Campaign = campaign;

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
            // In future this will set local variables from
            // database.
            // Store form values into local variables.
            string name = "Campaign of truth!";
            string desc = "Cool test campaign.";

            // Test that name isn't null.
            if (name == "")
            {
                MessageBox.Show("Campaign name cannot be blank!");
                txtBoxName.Focus();
                return;
            }

            // Call PassCampaign.
            PassCampaign(2, name, desc);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Store form values into local variables.
            string name = txtBoxName.Text;
            string desc = txtBoxDesc.Text;

            // Test that name isn't null.
            if (name == "")
            {
                MessageBox.Show("Campaign name cannot be blank!");
                txtBoxName.Focus();
                return;
            }

            // Call PassCampaign.
            PassCampaign(1, name, desc);
        }
    }
}
