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
    public partial class FormNote : Form
    {
        // Define fields.
        private FormMain _parentForm;
        private CampaignNote _currentNote;
        private CampaignNote _note = new CampaignNote();
        private bool _newNote = false;

        // Adjusted Constructor that includes argument for parentForm.
        public FormNote(FormMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;

            _newNote = true;
        }


        // Adjusted Constructor that includes argument for parentForm.
        public FormNote(FormMain parentForm, CampaignNote selectedNote)
        {
            InitializeComponent();
            _parentForm = parentForm;

            // Pass selected player object to form.
            _currentNote = selectedNote;
        }

        // Method to save/add new note to the database.
        private void SaveNote(CampaignNote note)
        {
            // Different business logic if new player variable
            // is set to false or true.
            if (!_newNote && _currentNote != null)
            {
                notesTableAdapter.Update(_parentForm.Campaign.Id,note.Title,note.Type,DateTime.Parse(note.DateAdded),note.Note,_currentNote.Id,_currentNote.CampaignId,
                    _currentNote.Title,_currentNote.Type,DateTime.Parse(_currentNote.DateAdded),_currentNote.Note);

                MessageBox.Show("Note updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_newNote)
            {
                notesTableAdapter.Insert(_parentForm.Campaign.Id, note.Title, note.Type, DateTime.Parse(note.DateAdded), note.Note);

                MessageBox.Show("Note added to the database!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unexpected error has occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh player datagrid on parent form and close.
            _parentForm.RefreshNoteData();
            this.Close();
        }

        private void FormNote_Load(object sender, EventArgs e)
        {
            // Set readonly campaign id on each load.
            lblCampaignId.Text = _parentForm.Campaign.Id.ToString();

            // Set create date to current. Will be overridden if loading saved note.
            labelCreateDate.Text = DateTime.Today.ToString();

            // Set comboType based on previously used Types saved across campaigns from DB.
            // Query database and set to variable for ease of use.
            DataRow[] types = notesTableAdapter.GetData().Select();

            foreach(DataRow d in types)
            {
                bool found = false;

                foreach(string s in comboType.Items)
                {
                    if(s == d.Field<String>("Type"))
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    comboType.Items.Add(d.Field<String>("Type"));
                }
            }

            // Set form fields from selected existing player if applicable.
            if (!_newNote)
            {
                txtBoxTitle.Text = _currentNote.Title;
                comboType.Text = _currentNote.Type;
                labelCreateDate.Text = _currentNote.DateAdded.ToString();
                txtBoxNote.Lines = _currentNote.Note.Split('|');
            }
            else
            {
                // Remove carriage return when creating new note.
                // Couldn't figure out cause so bandaid for now.
                txtBoxNote.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate form entries.
            if (txtBoxTitle.Text == null || txtBoxTitle.Text == "")
            {
                MessageBox.Show("Note Title cannot be blank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxTitle.Focus();
                return;
            }          
            
            if (comboType.Text == null || comboType.Text == "")
            {
                MessageBox.Show("Note Type cannot be blank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboType.Focus();
                return;
            }

            if (txtBoxNote.Lines.Length == 0)
            {
                MessageBox.Show("Note cannot be blank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNote.Focus();
                return;
            }

            // Set note properties from form inputs if no validation issues.
            _note.Title = txtBoxTitle.Text;
            _note.Type = comboType.Text;
            _note.DateAdded = labelCreateDate.Text;
            _note.Note = string.Join("|", txtBoxNote.Lines);
            
            // Call SaveNote method using local variable after validation.
            SaveNote(_note);
        }
    }
}
