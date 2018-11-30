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
        private Player _currentPlayer;
        private Player _player = new Player();
        private bool _newPlayer = false;

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

                MessageBox.Show("Player updated!", "Success!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_newPlayer)
            {
                playersTableAdapter.Insert(_parentForm.Campaign.Id, player.Name, player.Size, player.Allignment,
                    player.Description, player.Tag, player.Level, player.StartDate, player.Race, player.Class);

                MessageBox.Show("Player added to the database!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unexpected error has occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                comboRaces.Items.Add(value);
            }

            foreach (var value in _player.GetClasses())
            {
                comboClass.Items.Add(value);
            }

            foreach (var value in _player.GetSizes())
            {
                comboSize.Items.Add(value);
            }

            foreach (var value in _player.GetAlignments())
            {
                comboAlignment.Items.Add(value);
            }

            // Set form fields from selected existing player if applicable.
            if (!_newPlayer)
            {
                txtBoxName.Text = _currentPlayer.Name;
                comboSize.SelectedIndex = comboSize.FindStringExact(_currentPlayer.Size);
                comboAlignment.SelectedIndex = comboAlignment.FindStringExact(_currentPlayer.Allignment); ;
                txtBoxDesc.Lines = _currentPlayer.Description.Split('|');
                txtBoxTags.Text = _currentPlayer.Tag;
                txtBoxLevel.Text = _currentPlayer.Level.ToString();
                dateTimeStartDate.Value = _currentPlayer.StartDate;
                comboRaces.SelectedIndex = comboRaces.FindStringExact(_currentPlayer.Race);
                comboClass.SelectedIndex = comboClass.FindStringExact(_currentPlayer.Class);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close form.
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate proper values have been entered into the form.
            // Ensure required fields are not null.
            if(txtBoxName.Text == null || txtBoxName.Text == "")
            {
                MessageBox.Show("Player Character Name cannot be blank!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtBoxName.Focus();
                return;
            }

            if (comboSize.SelectedIndex == -1)
            {
                MessageBox.Show("You must select the Player Character's size!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboSize.Focus();
                return;
            }

            if (comboAlignment.SelectedIndex == -1)
            {
                MessageBox.Show("You must select the Player Character's alignment!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboAlignment.Focus();
                return;
            }

            if (dateTimeStartDate.Value == null)
            {
                MessageBox.Show("You must select the Player Character's start date!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimeStartDate.Focus();
                return;
            }

            if (comboRaces.SelectedIndex == -1)
            {
                MessageBox.Show("You must select the Player Character's race!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboRaces.Focus();
                return;
            }

            if (comboClass.SelectedIndex == -1)
            {
                MessageBox.Show("You must select the Player Character's class!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboClass.Focus();
                return;
            }

            // Ensure int value entered for level.
            if (!int.TryParse(txtBoxLevel.Text, out int level))
            {
                MessageBox.Show("A valid integer must be entered for Player Character level!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxLevel.Focus();
                return;
            }

            if (level < 1)
            {
                MessageBox.Show("Player Character level cannot be less then 1!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxLevel.Focus();
                txtBoxLevel.SelectAll();
                return;
            }

            // Set player properties from form inputs if no validation issues.
            _player.Name = txtBoxName.Text;
            _player.Size = comboSize.SelectedItem.ToString();
            _player.Allignment = comboAlignment.SelectedItem.ToString();
            _player.Description = string.Join("|", txtBoxDesc.Lines);
            _player.Tag = txtBoxTags.Text;
            _player.Level = int.Parse(txtBoxLevel.Text);
            _player.StartDate = dateTimeStartDate.Value;
            _player.Race = comboRaces.SelectedItem.ToString();
            _player.Class = comboClass.SelectedItem.ToString();


            // Call SavePlayer method using local variable after validation.
            SavePlayer(_player);
        }
    }
}
