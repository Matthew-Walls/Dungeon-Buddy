﻿using System;
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
            set { _campaign = value; RefreshPlayerData(); RefreshMonsterData(); RefreshNoteData(); }
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

        // Method for refreshing the displayed monster data.
        public void RefreshMonsterData()
        {
            // TODO: This line of code loads data into the 'dungeonBuddyDataSet.Players' table. You can move, or remove it, as needed.
            try
            {
                this.monstersTableAdapter.FillByCampaign(this.dungeonBuddyDataSet.Monsters, Campaign.Id);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // Method for refreshing the displayed note data.
        public void RefreshNoteData()
        {
            // TODO: This line of code loads data into the 'dungeonBuddyDataSet.Players' table. You can move, or remove it, as needed.
            try
            {
                this.notesTableAdapter.FillByCampaign(this.dungeonBuddyDataSet.Notes, Campaign.Id);
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
            // Cancel method if blank space is selected.
            if(row == null)
            {
                return;
            }

            // Create player object from selected row.
            Player player = new Player();
            player.Id = row.Row.Field<int>("Id");
            player.CampaignId = row.Row.Field<int>("CampaignId");
            player.Name = row.Row.Field<string>("Name");
            player.Size = row.Row.Field<string>("Size");
            player.Allignment = row.Row.Field<string>("Alignment");
            player.Description = row.Row.Field<string>("Description");
            player.Tag = row.Row.Field<string>("Tag");
            player.Level = row.Row.Field<int>("Level");
            player.StartDate = row.Row.Field<DateTime>("StartDate");
            player.Race = row.Row.Field<string>("Race");
            player.Class = row.Row.Field<string>("Class");

            // Create a player form with loaded data and display it.
            FormPlayer formPlayer = new FormPlayer(this, player);
            formPlayer.Show();
        }

        // Method for deleting an existing player from the database.
        private void DeleteSelectedPlayer(DataRowView row)
        {
            // Cancel method if blank space is selected.
            if (row == null)
            {
                return;
            }

            // Confirm deletion with the user.
            if(MessageBox.Show("Are you sure you want to delete this Player? (This is PERMANENT!)", "Warning!",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
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
                player.Level = row.Row.Field<int>("Level");
                player.StartDate = row.Row.Field<DateTime>("StartDate");
                player.Race = row.Row.Field<string>("Race");
                player.Class = row.Row.Field<string>("Class");

                playersTableAdapter.Delete(player.Id, Campaign.Id, player.Name, player.Size, player.Allignment, player.Description, player.Tag,
                    player.Level, player.StartDate, player.Race, player.Class);

                // Refresh player data display.
                RefreshPlayerData();
            }
            else
            {
                return;
            }
        }

        // Method for selecting and loading an existing monster for
        // view or editing.
        private void GetSelectedMonster(DataRowView row)
        {
            // Cancel method if blank space is selected.
            if (row == null)
            {
                return;
            }

            // Create monster object from selected row.
            Monster monster = new Monster();
            monster.Id = row.Row.Field<int>("Id");
            monster.CampaignId = row.Row.Field<int>("CampaignId");
            monster.Name = row.Row.Field<string>("Name");
            monster.Size = row.Row.Field<string>("Size");
            monster.Allignment = row.Row.Field<string>("Alignment");
            monster.Description = row.Row.Field<string>("Description");
            monster.Tag = row.Row.Field<string>("Tag");
            monster.ChallengeRating = row.Row.Field<double>("ChallengeRating");
            monster.Xp = row.Row.Field<double>("Xp");
            monster.MonsterType = row.Row.Field<string>("Type");
            monster.Environment = row.Row.Field<string>("Environment");
            monster.Source = row.Row.Field<string>("Source");
            monster.Page = row.Row.Field<string>("Page");
            monster.Reference = row.Row.Field<string>("Reference");
            monster.Srd  = row.Row.Field<bool>("SRD");

            // Create a monster form with loaded data and display it.
            FormMonster formMonster = new FormMonster(this, monster);
            formMonster.Show();
        }

        // Method for deleting an existing monster from the database.
        private void DeleteSelectedMonster(DataRowView row)
        {
            // Cancel method if blank space is selected.
            if (row == null)
            {
                return;
            }

            // Confirm deletion with the user.
            if (MessageBox.Show("Are you sure you want to delete this Monster? (This is PERMANENT!)", "Warning!", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // Create monster object from selected row.
                Monster monster = new Monster();
                monster.Id = row.Row.Field<int>("Id");
                monster.CampaignId = row.Row.Field<int>("CampaignId");
                monster.Name = row.Row.Field<string>("Name");
                monster.Size = row.Row.Field<string>("Size");
                monster.Allignment = row.Row.Field<string>("Alignment");
                monster.Description = row.Row.Field<string>("Description");
                monster.Tag = row.Row.Field<string>("Tag");
                monster.ChallengeRating = row.Row.Field<double>("ChallengeRating");
                monster.Xp = row.Row.Field<double>("Xp");
                monster.MonsterType = row.Row.Field<string>("Type");
                monster.Environment = row.Row.Field<string>("Environment");
                monster.Source = row.Row.Field<string>("Source");
                monster.Page = row.Row.Field<string>("Page");
                monster.Reference = row.Row.Field<string>("Reference");
                monster.Srd = row.Row.Field<bool>("SRD");

                monstersTableAdapter.Delete(monster.Id, Campaign.Id, monster.Name, monster.Size, monster.Allignment, monster.Description, monster.Tag,
                    monster.ChallengeRating, monster.Xp, monster.MonsterType, monster.Environment, monster.Source, monster.Page, monster.Reference,
                    monster.Srd);

                // Refresh monster data display.
                RefreshMonsterData();
            }
            else
            {
                return;
            }
        }

        // Method for selecting and loading an existing note for
        // view or editing.
        private void GetSelectedNote(DataRowView row)
        {
            // Cancel method if blank space is selected.
            if (row == null)
            {
                return;
            }

            // Create note object from selected row.
            CampaignNote note = new CampaignNote();
            note.Id = row.Row.Field<int>("Id");
            note.CampaignId = row.Row.Field<int>("CampaignId");
            note.Title = row.Row.Field<string>("Title");
            note.Type = row.Row.Field<string>("Type");
            note.DateAdded = row.Row.Field<DateTime>("DateAdded").ToString();
            note.Note = row.Row.Field<string>("Note");

            // Create a monster form with loaded data and display it.
            FormNote formNote = new FormNote(this, note);
            formNote.Show();
        }

        // Method for deleting an existing monster from the database.
        private void DeleteSelectedNote(DataRowView row)
        {
            // Cancel method if blank space is selected.
            if (row == null)
            {
                return;
            }

            // Confirm deletion with the user.
            if (MessageBox.Show("Are you sure you want to delete this Note? (This is PERMANENT!)", "Warning!", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // Create note object from selected row.
                CampaignNote note = new CampaignNote();
                note.Id = row.Row.Field<int>("Id");
                note.CampaignId = row.Row.Field<int>("CampaignId");
                note.Title = row.Row.Field<string>("Title");
                note.Type = row.Row.Field<string>("Type");
                note.DateAdded = row.Row.Field<DateTime>("DateAdded").ToString();
                note.Note = row.Row.Field<string>("Note");

                notesTableAdapter.Delete(note.Id, Campaign.Id, note.Title,note.Type,DateTime.Parse(note.DateAdded),note.Note);

                // Refresh monster data display.
                RefreshNoteData();
            }
            else
            {
                return;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dungeonBuddyDataSet.Notes' table. You can move, or remove it, as needed.
            this.notesTableAdapter.Fill(this.dungeonBuddyDataSet.Notes);
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
        private void toolStripButtonEditPlayer_Click(object sender, EventArgs e)
        {
            // Store selected datarow as a DataRowView for easier access.
            // Found this through debugging that this object can be cast
            // as a DataRowView.
            DataRowView row = (DataRowView)playersBindingSource.Current;

            GetSelectedPlayer(row);
        }

        private void playersDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Utilize code from toolStripButtonEditPlayer.
            toolStripButtonEditPlayer.PerformClick();
        }

        private void toolStripButtonDeletePlayer_Click(object sender, EventArgs e)
        {
            // Store selected datarow as a DataRowView for easier access.
            // Found this through debugging that this object can be cast
            // as a DataRowView.
            DataRowView row = (DataRowView)playersBindingSource.Current;

            DeleteSelectedPlayer(row);
        }

        private void toolStripMenuItemNewPlayer_Click(object sender, EventArgs e)
        {
            toolStripButtonNewPlayer.PerformClick();
        }

        private void toolStripMenuItemEditPlayer_Click(object sender, EventArgs e)
        {
            toolStripButtonEditPlayer.PerformClick();
        }

        private void toolStripMenuItemDeletePlayer_Click(object sender, EventArgs e)
        {
            toolStripButtonDeletePlayer.PerformClick();
        }

        private void toolStripButtonNewMonster_Click(object sender, EventArgs e)
        {
            // Create a new, blank monster form and display it.
            FormMonster formMonster = new FormMonster(this);
            formMonster.Show();
        }

        private void toolStripButtonEditMonster_Click(object sender, EventArgs e)
        {
            // Store selected datarow as a DataRowView for easier access.
            // Found this through debugging that this object can be cast
            // as a DataRowView.
            DataRowView row = (DataRowView)monstersBindingSource.Current;

            GetSelectedMonster(row);
        }

        private void monstersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            // Utilize code from toolStripButtonEditPlayer.
            toolStripButtonEditMonster.PerformClick();
        }

        private void toolStripButtonDeleteMonster_Click(object sender, EventArgs e)
        {
            // Store selected datarow as a DataRowView for easier access.
            // Found this through debugging that this object can be cast
            // as a DataRowView.
            DataRowView row = (DataRowView)monstersBindingSource.Current;

            DeleteSelectedMonster(row);
        }

        private void toolStripMenuItemNewMonster_Click(object sender, EventArgs e)
        {
            toolStripButtonNewMonster.PerformClick();
        }

        private void toolStripMenuItemEditMonster_Click(object sender, EventArgs e)
        {
            toolStripButtonEditMonster.PerformClick();
        }

        private void toolStripMenuItemDeleteMonster_Click(object sender, EventArgs e)
        {
            toolStripButtonDeleteMonster.PerformClick();
        }

        private void toolStripButtonLoadMonster_Click(object sender, EventArgs e)
        {
            // Open monster catalog form.
            MonsterIndexForm1 formIndex = new MonsterIndexForm1(this);
            formIndex.Show();
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            // Check if campaign is loaded.
            if(Campaign == null)
            {
                MessageBox.Show("You must create or load a campaign first!");
                FormSplash formSplash = new FormSplash(this);
                formSplash.ShowDialog();
            }
        }

        private void toolStripButtonNewNote_Click(object sender, EventArgs e)
        {
            // Create a new, blank note form and display it.
            FormNote formNote = new FormNote(this);
            formNote.Show();
        }

        private void toolStripButtonEditNote_Click(object sender, EventArgs e)
        {
            // Store selected datarow as a DataRowView for easier access.
            // Found this through debugging that this object can be cast
            // as a DataRowView.
            DataRowView row = (DataRowView)notesBindingSource.Current;

            GetSelectedNote(row);
        }

        private void notesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            toolStripButtonEditNote.PerformClick();
        }

        private void toolStripButtonDeleteNote_Click(object sender, EventArgs e)
        {
            // Store selected datarow as a DataRowView for easier access.
            // Found this through debugging that this object can be cast
            // as a DataRowView.
            DataRowView row = (DataRowView)notesBindingSource.Current;

            DeleteSelectedNote(row);
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            // Show help message box when clicked.
            MessageBox.Show("Top menu options left to right"+System.Environment.NewLine+System.Environment.NewLine+ "Create a new Player"+System.Environment.NewLine+
                "View/Edit the currently selected Player"+System.Environment.NewLine+"Delete the currently selected Player", "Player Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Show help message box when clicked.
            MessageBox.Show("Top menu options left to right" + System.Environment.NewLine + System.Environment.NewLine+
                "Open the Monster Catalog" + System.Environment.NewLine +"Create a new Monster"+System.Environment.NewLine+
                "View/Edit the currently selected Monster" + System.Environment.NewLine+"Delete the currently selected Monster",
                "Monster Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // Show help message box when clicked.
            MessageBox.Show("Top menu options left to right" + System.Environment.NewLine + System.Environment.NewLine + "Record a new note"+
                System.Environment.NewLine + "View/Edit the currently selected note" + System.Environment.NewLine + 
                "Delete the currently selected note", "Campaign Note Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDiceRoller_Click(object sender, EventArgs e)
        {
            FormDice formDice = new FormDice();
            formDice.Show();
        }
    }
}
