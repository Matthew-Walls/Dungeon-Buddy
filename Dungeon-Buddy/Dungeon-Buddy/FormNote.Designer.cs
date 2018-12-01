namespace Dungeon_Buddy
{
    partial class FormNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label campaignIdLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label dateLabel;
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCampaignId = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxNote = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.labelCreateDate = new System.Windows.Forms.Label();
            this.notesTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.NotesTableAdapter();
            campaignIdLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(282, 434);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(145, 434);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 43);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // campaignIdLabel
            // 
            campaignIdLabel.AutoSize = true;
            campaignIdLabel.Location = new System.Drawing.Point(120, 58);
            campaignIdLabel.Name = "campaignIdLabel";
            campaignIdLabel.Size = new System.Drawing.Size(69, 13);
            campaignIdLabel.TabIndex = 26;
            campaignIdLabel.Text = "Campaign Id:";
            // 
            // lblCampaignId
            // 
            this.lblCampaignId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCampaignId.Location = new System.Drawing.Point(208, 53);
            this.lblCampaignId.Name = "lblCampaignId";
            this.lblCampaignId.Size = new System.Drawing.Size(100, 23);
            this.lblCampaignId.TabIndex = 27;
            this.lblCampaignId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(133, 88);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 25;
            titleLabel.Text = "Title:";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(208, 85);
            this.txtBoxTitle.MaxLength = 255;
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(200, 20);
            this.txtBoxTitle.TabIndex = 24;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(111, 219);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(33, 13);
            noteLabel.TabIndex = 29;
            noteLabel.Text = "Note:";
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.Location = new System.Drawing.Point(186, 216);
            this.txtBoxNote.MaxLength = 5000;
            this.txtBoxNote.Multiline = true;
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.Size = new System.Drawing.Size(200, 140);
            this.txtBoxNote.TabIndex = 28;
            this.txtBoxNote.Text = "\r\n";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(208, 122);
            this.comboType.MaxLength = 50;
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(121, 21);
            this.comboType.TabIndex = 31;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(142, 125);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 30;
            typeLabel.Text = "Type:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(129, 167);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(67, 13);
            dateLabel.TabIndex = 32;
            dateLabel.Text = "Create Date:";
            // 
            // labelCreateDate
            // 
            this.labelCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCreateDate.Location = new System.Drawing.Point(208, 162);
            this.labelCreateDate.Name = "labelCreateDate";
            this.labelCreateDate.Size = new System.Drawing.Size(100, 23);
            this.labelCreateDate.TabIndex = 33;
            this.labelCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notesTableAdapter
            // 
            this.notesTableAdapter.ClearBeforeFill = true;
            // 
            // FormNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 519);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.labelCreateDate);
            this.Controls.Add(this.comboType);
            this.Controls.Add(typeLabel);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.txtBoxNote);
            this.Controls.Add(campaignIdLabel);
            this.Controls.Add(this.lblCampaignId);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "FormNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNote";
            this.Load += new System.EventHandler(this.FormNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCampaignId;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.TextBox txtBoxNote;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label labelCreateDate;
        private DungeonBuddyDataSetTableAdapters.NotesTableAdapter notesTableAdapter;
    }
}