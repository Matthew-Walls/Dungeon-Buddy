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
            set { _campaign = value; RefreshPlayerData(); }
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

        // Method for refreshing the displayed player data.
        public void RefreshPlayerData()
        {
            // TODO: This line of code loads data into the 'dungeonBuddyDataSet.Players' table. You can move, or remove it, as needed.
            try
            {
                this.playersTableAdapter.FillByCampaign(this.dungeonBuddyDataSet.Players, Campaign.Id);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // Method for selecting and loading an existing player for
        // view or editing.
        private void GetSelectedPlayer(DataRowView row)
        {
            // Create player object from selected row.
            Player player = new Player();
            player.Id = row.Row.Field<int>("Id");
            player.CampaignId = row.Row.Field<int>("CampaignId");
            player.Name = row.Row.Field<string>("Name");
            player.Size = row.Row.Field<string>("Size");
            player.Allignment = row.Row.Field<string>("Alignment");
            player.Description = row.Row.Field<string>("Description");
            player.Tag = row.Row.Field<string>("Tag");
            player.StartDate = row.Row.Field<DateTime>("StartDate");
            player.Race = row.Row.Field<string>("Race");
            player.Class = row.Row.Field<string>("Class");

            // Create a player form with loaded data and display it.
            FormPlayer formPlayer = new FormPlayer(this, player);
            formPlayer.Show();
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dungeonBuddyDataSet.Campaign' table. You can move, or remove it, as needed.
            this.campaignTableAdapter.Fill(this.dungeonBuddyDataSet.Campaign);
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

        private void toolStripButtonNewPlayer_Click(object sender, EventArgs e)
        {
            // Create a new, blank player form and display it.
            FormPlayer formPlayer = new FormPlayer(this);
            formPlayer.Show();
        }

        private void playersDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Store selected datarow as a DataRowView for easier access.
            // Found this through debugging that this object can be cast
            // as a DataRowView.
            DataRowView row = (DataRowView)playersBindingSource.Current;

            GetSelectedPlayer(row);
        }
    }
}
