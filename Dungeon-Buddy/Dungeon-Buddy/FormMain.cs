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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // Initialize variable to hold the selected campaign.
        private Campaign _campaign;

        // Define properties.
        public Campaign Campaign
        { 
            set { _campaign = value; }
            get { return _campaign; }
        }

        // Method for creating and displaying the FormSplash form.
        private void DisplayFormSplash()
        {
            FormSplash formSplash = new FormSplash(this);
            formSplash.ShowDialog();
        }

        // Method for creating and displaying the FormEditCampaign form.
        private void DisplayFormEditCampaign()
        {
            FormEditCampaign formEditCampaign = new FormEditCampaign(this);
            formEditCampaign.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DisplayFormSplash();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DisplayFormSplash();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DisplayFormEditCampaign();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
