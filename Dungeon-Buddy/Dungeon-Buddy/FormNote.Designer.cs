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
            this.panel1 = new System.Windows.Forms.Panel();
            campaignIdLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // campaignIdLabel
            // 
            campaignIdLabel.AutoSize = true;
            campaignIdLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            campaignIdLabel.ForeColor = System.Drawing.SystemColors.Info;
            campaignIdLabel.Location = new System.Drawing.Point(6, 5);
            campaignIdLabel.Name = "campaignIdLabel";
            campaignIdLabel.Size = new System.Drawing.Size(107, 22);
            campaignIdLabel.TabIndex = 26;
            campaignIdLabel.Text = "Campaign Id";
            campaignIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.ForeColor = System.Drawing.SystemColors.Info;
            titleLabel.Location = new System.Drawing.Point(76, 50);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(45, 22);
            titleLabel.TabIndex = 25;
            titleLabel.Text = "Title";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noteLabel.ForeColor = System.Drawing.SystemColors.Info;
            noteLabel.Location = new System.Drawing.Point(75, 130);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(46, 22);
            noteLabel.TabIndex = 29;
            noteLabel.Text = "Note";
            noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            typeLabel.ForeColor = System.Drawing.SystemColors.Info;
            typeLabel.Location = new System.Drawing.Point(73, 75);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(48, 22);
            typeLabel.TabIndex = 30;
            typeLabel.Text = "Type";
            typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.ForeColor = System.Drawing.SystemColors.Info;
            dateLabel.Location = new System.Drawing.Point(23, 103);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(98, 22);
            dateLabel.TabIndex = 32;
            dateLabel.Text = "Create Date";
            dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(286, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCampaignId
            // 
            this.lblCampaignId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCampaignId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCampaignId.Location = new System.Drawing.Point(112, 6);
            this.lblCampaignId.Name = "lblCampaignId";
            this.lblCampaignId.Size = new System.Drawing.Size(100, 23);
            this.lblCampaignId.TabIndex = 27;
            this.lblCampaignId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(127, 52);
            this.txtBoxTitle.MaxLength = 255;
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(345, 20);
            this.txtBoxTitle.TabIndex = 1;
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.Location = new System.Drawing.Point(127, 130);
            this.txtBoxNote.MaxLength = 5000;
            this.txtBoxNote.Multiline = true;
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxNote.Size = new System.Drawing.Size(345, 191);
            this.txtBoxNote.TabIndex = 3;
            this.txtBoxNote.Text = "\r\n";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(127, 78);
            this.comboType.MaxLength = 50;
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(179, 21);
            this.comboType.TabIndex = 2;
            // 
            // labelCreateDate
            // 
            this.labelCreateDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCreateDate.Location = new System.Drawing.Point(127, 102);
            this.labelCreateDate.Name = "labelCreateDate";
            this.labelCreateDate.Size = new System.Drawing.Size(100, 23);
            this.labelCreateDate.TabIndex = 33;
            this.labelCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notesTableAdapter
            // 
            this.notesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtBoxTitle);
            this.panel1.Controls.Add(campaignIdLabel);
            this.panel1.Controls.Add(typeLabel);
            this.panel1.Controls.Add(dateLabel);
            this.panel1.Controls.Add(this.txtBoxNote);
            this.panel1.Controls.Add(this.comboType);
            this.panel1.Controls.Add(titleLabel);
            this.panel1.Controls.Add(noteLabel);
            this.panel1.Controls.Add(this.lblCampaignId);
            this.panel1.Controls.Add(this.labelCreateDate);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 362);
            this.panel1.TabIndex = 34;
            // 
            // FormNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campaign Note Entry";
            this.Load += new System.EventHandler(this.FormNote_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}