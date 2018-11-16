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
    public partial class FormEditCampaign : Form
    {
        // Adjusted Constructor that includes argument for parentForm.
        public FormEditCampaign(FormMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        // Initalize variable to hold parent form.
        private FormMain _parentForm;

        // Method to save current changes to the database
        // and FormMain campaign object.
        private void SaveChanges(string name, List<string> desc)
        {
            _parentForm.Campaign.Name = name;
            _parentForm.Campaign.Description = desc;
        }

        private void FormEditCampaign_Load(object sender, EventArgs e)
        {
            // Sets form objects to current campaign values.
            lblId.Text = _parentForm.Campaign.Id.ToString();
            txtBoxName.Text = _parentForm.Campaign.Name;
            txtBoxDesc.Lines = _parentForm.Campaign.Description.ToArray();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Store form values into local variables.
            string name = txtBoxName.Text;
            List<string> desc = txtBoxDesc.Lines.ToList();

            // Test that name isn't null.
            if (name == "")
            {
                MessageBox.Show("Campaign name cannot be blank!");
                txtBoxName.Focus();
                return;
            }

            // Call method to save changes.
            SaveChanges(name, desc);

            // Close edit form.
            this.Close();
        }
    }
}
