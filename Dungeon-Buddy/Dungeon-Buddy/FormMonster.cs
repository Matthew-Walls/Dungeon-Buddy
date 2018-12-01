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
    public partial class FormMonster : Form
    {
        // Adjusted Constructor that includes argument for parentForm.
        public FormMonster(FormMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;

            // On default constructor where no monster is passed
            // set newMonster to true.
            _newMonster = true;
        }

        // Adjusted Constructor that includes argument for parentForm.
        public FormMonster(FormMain parentForm, Monster selectedMonster)
        {
            InitializeComponent();
            _parentForm = parentForm;

            // Pass selected monster object to form.
            _currentMonster = selectedMonster;
        }

        // Initalize variable to hold parent form and
        // a selected monster if editing.
        private FormMain _parentForm;
        private Monster _currentMonster;
        private Monster _monster = new Monster();
        private bool _newMonster = false;

        // Method to save/add new monsters to the database.
        private void SaveMonster(Monster monster)
        {
            // Different business logic if new player variable
            // is set to false or true.
            if (!_newMonster && _currentMonster != null)
            {
                monstersTableAdapter.Update(_parentForm.Campaign.Id, _monster.Name, _monster.Size, _monster.Allignment, _monster.Description,
                    _monster.Tag, _monster.ChallengeRating, _monster.Xp, _monster.MonsterType, _monster.Environment, _monster.Source,
                    _monster.Page, _monster.Reference, _monster.Srd,_currentMonster.Id,_currentMonster.CampaignId, _currentMonster.Name, _currentMonster.Size, _currentMonster.Allignment,
                    _currentMonster.Description, _currentMonster.Tag, _currentMonster.ChallengeRating, _currentMonster.Xp, _currentMonster.MonsterType,
                    _currentMonster.Environment, _currentMonster.Source, _currentMonster.Page, _currentMonster.Reference, _currentMonster.Srd);

                MessageBox.Show("Monster updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_newMonster)
            {
                monstersTableAdapter.Insert(_parentForm.Campaign.Id, _monster.Name, _monster.Size, _monster.Allignment, _monster.Description,
                    _monster.Tag, _monster.ChallengeRating, _monster.Xp, _monster.MonsterType, _monster.Environment, _monster.Source,
                    _monster.Page, _monster.Reference, _monster.Srd);

                MessageBox.Show("Monster added to the database!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unexpected error has occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh player datagrid on parent form and close.
            _parentForm.RefreshMonsterData();
            this.Close();
        }

        private void FormMonster_Load(object sender, EventArgs e)
        {
            // Set readonly campaign id on each load.
            lblCampaignId.Text = _parentForm.Campaign.Id.ToString();

            // Set list boxes from Monster.Enums.
            foreach (var value in _monster.GetTypes())
            {
                comboType.Items.Add(value);
            }

            foreach (var value in _monster.GetEnvironments())
            {
                checkedListBoxEnvironment.Items.Add(value);
            }

            foreach (var value in _monster.GetSizes())
            {
                comboSize.Items.Add(value);
            }

            foreach (var value in _monster.GetAlignments())
            {
                checkedListBoxAlignment.Items.Add(value);
            }

            // Set form fields from selected existing monster if applicable.
            if (!_newMonster)
            {
                txtBoxName.Text = _currentMonster.Name;
                comboSize.SelectedIndex = comboSize.FindStringExact(_currentMonster.Size);

                // Loop through tokenized alignment and check each one.
                foreach (string env in _currentMonster.Allignment.Split('|'))
                {
                    int selectedIndex = checkedListBoxAlignment.FindStringExact(env);
                    checkedListBoxAlignment.SetItemChecked(selectedIndex, true);
                }

                txtBoxDesc.Lines = _currentMonster.Description.Split('|');
                txtBoxTags.Text = _currentMonster.Tag;
                txtboxChallenge.Text = _currentMonster.ChallengeRating.ToString();
                txtboxXP.Text = _currentMonster.Xp.ToString();
                comboType.SelectedIndex = comboType.FindStringExact(_currentMonster.MonsterType);

                // Loop through tokenized environments and check each one.
                foreach(string env in _currentMonster.Environment.Split('|'))
                {
                    int selectedIndex = checkedListBoxEnvironment.FindStringExact(env);
                    checkedListBoxEnvironment.SetItemChecked(selectedIndex, true);
                }

                txtboxSource.Text = _currentMonster.Source;
                txtboxPage.Text = _currentMonster.Page.ToString();
                txtboxRef.Text = _currentMonster.Reference;
                checkboxSRD.Checked = _currentMonster.Srd;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate form entries.
            if (txtBoxName.Text == null || txtBoxName.Text == "")
            {
                MessageBox.Show("Monster Name cannot be blank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxName.Focus();
                return;
            }

            if (comboSize.SelectedIndex == -1)
            {
                MessageBox.Show("You must select the Monster's size!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboSize.Focus();
                return;
            }

            if (checkedListBoxAlignment.CheckedIndices.Count == 0)
            {
                MessageBox.Show("You must set the Monster's alignment!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkedListBoxAlignment.Focus();
                return;
            }

            // Ensure double value entered to ChallengeRating and XP.
            if (!double.TryParse(txtboxChallenge.Text, out double challenge))
            {
                MessageBox.Show("A valid number must be entered for the Monster's Challenge Rating!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxChallenge.Focus();
                return;
            }

            if (!double.TryParse(txtboxXP.Text, out double xp))
            {
                MessageBox.Show("A valid number must be entered for the Monster's XP!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxXP.Focus();
                return;
            }

            if (comboType.SelectedIndex == -1)
            {
                MessageBox.Show("You must select the Monster's type!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboType.Focus();
                return;
            }

            if (checkedListBoxEnvironment.CheckedIndices.Count == 0)
            {
                MessageBox.Show("You must set the Monster's environment!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkedListBoxEnvironment.Focus();
                return;
            }

            // Set monster properties from form inputs if no validation issues.
            _monster.Name = txtBoxName.Text;
            _monster.Size = comboSize.SelectedItem.ToString();

            // Loop through checked alignments and pass to Monster using a string list.
            List<string> alignments = new List<string>();
            for (int i = 0; i < checkedListBoxAlignment.CheckedItems.Count; i++)
            {
                alignments.Add(checkedListBoxAlignment.CheckedItems[i].ToString());
            }
            _monster.Allignment = string.Join("|", alignments);
            
            _monster.Description = string.Join("|", txtBoxDesc.Lines);
            _monster.Tag = txtBoxTags.Text;
            _monster.ChallengeRating = int.Parse(txtboxChallenge.Text);
            _monster.Xp = double.Parse(txtboxXP.Text);
            _monster.MonsterType = comboType.SelectedItem.ToString();

            // Loop through checked environments and pass to Monster using a string list.
            List<string> environments = new List<string>();
            for(int i=0; i < checkedListBoxEnvironment.CheckedItems.Count; i++)
            {
                environments.Add(checkedListBoxEnvironment.CheckedItems[i].ToString());
            }
            _monster.Environment = string.Join("|", environments);

            _monster.Source = txtboxSource.Text;
            _monster.Page = txtboxPage.Text;
            _monster.Reference = txtboxRef.Text;
            _monster.Srd = checkboxSRD.Checked;


            // Call SaveMonster method using local variable after validation.
            SaveMonster(_monster);
        }
    }
}
