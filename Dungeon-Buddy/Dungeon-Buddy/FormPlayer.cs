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
    public partial class FormPlayer : Form
    {
        // Adjusted Constructor that includes argument for parentForm.
        public FormPlayer(FormMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;

            // On default constructor where no player is passed
            // set newPlayer to true.
            _newPlayer = true;
            _player = new Player();
        }

        // Adjusted Constructor that includes argument for parentForm.
        public FormPlayer(FormMain parentForm, Player selectedPlayer)
        {
            InitializeComponent();
            _parentForm = parentForm;

            // Pass selected player object to form.
            _currentPlayer = selectedPlayer;
        }

        // Initalize variable to hold parent form and
        // a selected player if editing.
        private FormMain _parentForm;
        Player _currentPlayer;
        Player _player = new Player();
        bool _newPlayer = false;

        // Method to save/add new players to the database.
        private void SavePlayer(Player player)
        {
            // Different business logic if new player variable
            // is set to false or true.
            if (!_newPlayer && _currentPlayer != null)
            {
                playersTableAdapter.Update(_parentForm.Campaign.Id, player.Name, player.Size, player.Allignment, player.Description,
                    player.Tag, player.Level, player.StartDate, player.Race, player.Class, _currentPlayer.Id, _currentPlayer.CampaignId,
                    _currentPlayer.Name, _currentPlayer.Size, _currentPlayer.Allignment, _currentPlayer.Description, _currentPlayer.Tag,
                    _currentPlayer.Level, _currentPlayer.StartDate, _currentPlayer.Race, _currentPlayer.Class);

                MessageBox.Show("Player updated!");
            }
            else if (_newPlayer)
            {
                playersTableAdapter.Insert(_parentForm.Campaign.Id, player.Name, player.Size, player.Allignment,
                    player.Description, player.Tag, player.Level, player.StartDate, player.Race, player.Class);

                MessageBox.Show("Player added to the database!");
            }
            else
            {
                MessageBox.Show("Unexpected error has occured!");
            }
            
            // Refresh player datagrid on parent form and close.
            _parentForm.RefreshPlayerData();
            this.Close();
        }

        private void FormPlayer_Load(object sender, EventArgs e)
        {
            // Set readonly campaign id on each load.
            lblCampaignId.Text = _parentForm.Campaign.Id.ToString();

            // Set list boxes from Player.Enums.
            foreach (var value in _player.GetRaces())
            {
                lstBoxRaces.Items.Add(value);
            }

            foreach (var value in _player.GetClasses())
            {
                lstBoxClasses.Items.Add(value);
            }

            foreach (var value in _player.GetSizes())
            {
                lstBoxSize.Items.Add(value);
            }

            foreach (var value in _player.GetAlignments())
            {
                lstBoxAlignment.Items.Add(value);
            }

            // Set form fields from selected existing player if applicable.
            if (!_newPlayer)
            {
                txtBoxName.Text = _currentPlayer.Name;
                lstBoxSize.SelectedIndex = lstBoxSize.FindStringExact(_currentPlayer.Size);
                lstBoxAlignment.SelectedIndex = lstBoxAlignment.FindStringExact(_currentPlayer.Allignment); ;
                txtBoxDesc.Text = _currentPlayer.Description;
                txtBoxTags.Text = _currentPlayer.Tag;
                txtBoxLevel.Text = _currentPlayer.Level.ToString();
                dateTimeStartDate.Value = _currentPlayer.StartDate;
                lstBoxRaces.SelectedIndex = lstBoxRaces.FindStringExact(_currentPlayer.Race);
                lstBoxClasses.SelectedIndex = lstBoxClasses.FindStringExact(_currentPlayer.Class);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close form.
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Set player properties from form inputs.
            _player.Name = txtBoxName.Text;
            _player.Size = lstBoxSize.SelectedItem.ToString();
            _player.Allignment = lstBoxAlignment.SelectedItem.ToString();
            _player.Description = txtBoxDesc.Text;
            _player.Tag = txtBoxTags.Text;
            _player.Level = int.Parse(txtBoxLevel.Text);
            _player.StartDate = dateTimeStartDate.Value;
            _player.Race = lstBoxRaces.SelectedItem.ToString();
            _player.Class = lstBoxClasses.SelectedItem.ToString();


            // Call SavePlayer method using local variable after validation.
            SavePlayer(_player);
        }
    }
}
