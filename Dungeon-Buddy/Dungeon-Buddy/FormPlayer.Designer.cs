namespace Dungeon_Buddy
{
    partial class FormPlayer
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label alignmentLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label tagsLabel;
            System.Windows.Forms.Label levelLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label racesLabel;
            System.Windows.Forms.Label classesLabel;
            System.Windows.Forms.Label campaignIdLabel;
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lstBoxSize = new System.Windows.Forms.ListBox();
            this.lstBoxAlignment = new System.Windows.Forms.ListBox();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.txtBoxTags = new System.Windows.Forms.TextBox();
            this.txtBoxLevel = new System.Windows.Forms.TextBox();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblCampaignId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.playersTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.PlayersTableAdapter();
            this.lstBoxRaces = new System.Windows.Forms.ListBox();
            this.lstBoxClasses = new System.Windows.Forms.ListBox();
            nameLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            alignmentLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            tagsLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            racesLabel = new System.Windows.Forms.Label();
            classesLabel = new System.Windows.Forms.Label();
            campaignIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(62, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(62, 62);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 7;
            sizeLabel.Text = "Size:";
            // 
            // alignmentLabel
            // 
            alignmentLabel.AutoSize = true;
            alignmentLabel.Location = new System.Drawing.Point(62, 124);
            alignmentLabel.Name = "alignmentLabel";
            alignmentLabel.Size = new System.Drawing.Size(56, 13);
            alignmentLabel.TabIndex = 9;
            alignmentLabel.Text = "Alignment:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(62, 189);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.Location = new System.Drawing.Point(62, 335);
            tagsLabel.Name = "tagsLabel";
            tagsLabel.Size = new System.Drawing.Size(29, 13);
            tagsLabel.TabIndex = 13;
            tagsLabel.Text = "Tag:";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new System.Drawing.Point(62, 361);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(36, 13);
            levelLabel.TabIndex = 15;
            levelLabel.Text = "Level:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(62, 388);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 17;
            startDateLabel.Text = "Start Date:";
            // 
            // racesLabel
            // 
            racesLabel.AutoSize = true;
            racesLabel.Location = new System.Drawing.Point(62, 410);
            racesLabel.Name = "racesLabel";
            racesLabel.Size = new System.Drawing.Size(36, 13);
            racesLabel.TabIndex = 19;
            racesLabel.Text = "Race:";
            // 
            // classesLabel
            // 
            classesLabel.AutoSize = true;
            classesLabel.Location = new System.Drawing.Point(62, 472);
            classesLabel.Name = "classesLabel";
            classesLabel.Size = new System.Drawing.Size(35, 13);
            classesLabel.TabIndex = 21;
            classesLabel.Text = "Class:";
            // 
            // campaignIdLabel
            // 
            campaignIdLabel.AutoSize = true;
            campaignIdLabel.Location = new System.Drawing.Point(49, 9);
            campaignIdLabel.Name = "campaignIdLabel";
            campaignIdLabel.Size = new System.Drawing.Size(69, 13);
            campaignIdLabel.TabIndex = 22;
            campaignIdLabel.Text = "Campaign Id:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(137, 36);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(200, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // lstBoxSize
            // 
            this.lstBoxSize.FormattingEnabled = true;
            this.lstBoxSize.Location = new System.Drawing.Point(137, 62);
            this.lstBoxSize.Name = "lstBoxSize";
            this.lstBoxSize.Size = new System.Drawing.Size(200, 56);
            this.lstBoxSize.TabIndex = 2;
            // 
            // lstBoxAlignment
            // 
            this.lstBoxAlignment.FormattingEnabled = true;
            this.lstBoxAlignment.Location = new System.Drawing.Point(137, 124);
            this.lstBoxAlignment.Name = "lstBoxAlignment";
            this.lstBoxAlignment.Size = new System.Drawing.Size(200, 56);
            this.lstBoxAlignment.TabIndex = 3;
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(137, 186);
            this.txtBoxDesc.MaxLength = 1000;
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(200, 140);
            this.txtBoxDesc.TabIndex = 4;
            this.txtBoxDesc.Text = "\r\n";
            // 
            // txtBoxTags
            // 
            this.txtBoxTags.Location = new System.Drawing.Point(137, 332);
            this.txtBoxTags.MaxLength = 255;
            this.txtBoxTags.Name = "txtBoxTags";
            this.txtBoxTags.Size = new System.Drawing.Size(200, 20);
            this.txtBoxTags.TabIndex = 5;
            // 
            // txtBoxLevel
            // 
            this.txtBoxLevel.Location = new System.Drawing.Point(137, 358);
            this.txtBoxLevel.MaxLength = 2;
            this.txtBoxLevel.Name = "txtBoxLevel";
            this.txtBoxLevel.Size = new System.Drawing.Size(46, 20);
            this.txtBoxLevel.TabIndex = 6;
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.Location = new System.Drawing.Point(137, 384);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeStartDate.TabIndex = 7;
            // 
            // lblCampaignId
            // 
            this.lblCampaignId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCampaignId.Location = new System.Drawing.Point(137, 10);
            this.lblCampaignId.Name = "lblCampaignId";
            this.lblCampaignId.Size = new System.Drawing.Size(100, 23);
            this.lblCampaignId.TabIndex = 23;
            this.lblCampaignId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 577);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 43);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(179, 577);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // lstBoxRaces
            // 
            this.lstBoxRaces.FormattingEnabled = true;
            this.lstBoxRaces.Location = new System.Drawing.Point(137, 410);
            this.lstBoxRaces.Name = "lstBoxRaces";
            this.lstBoxRaces.Size = new System.Drawing.Size(200, 56);
            this.lstBoxRaces.TabIndex = 8;
            // 
            // lstBoxClasses
            // 
            this.lstBoxClasses.FormattingEnabled = true;
            this.lstBoxClasses.Location = new System.Drawing.Point(137, 472);
            this.lstBoxClasses.Name = "lstBoxClasses";
            this.lstBoxClasses.Size = new System.Drawing.Size(200, 56);
            this.lstBoxClasses.TabIndex = 9;
            // 
            // FormPlayer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(411, 632);
            this.Controls.Add(this.lstBoxClasses);
            this.Controls.Add(this.lstBoxRaces);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(campaignIdLabel);
            this.Controls.Add(this.lblCampaignId);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.lstBoxSize);
            this.Controls.Add(alignmentLabel);
            this.Controls.Add(this.lstBoxAlignment);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(tagsLabel);
            this.Controls.Add(this.txtBoxTags);
            this.Controls.Add(levelLabel);
            this.Controls.Add(this.txtBoxLevel);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.dateTimeStartDate);
            this.Controls.Add(racesLabel);
            this.Controls.Add(classesLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPlayer";
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.ListBox lstBoxSize;
        private System.Windows.Forms.ListBox lstBoxAlignment;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.TextBox txtBoxTags;
        private System.Windows.Forms.TextBox txtBoxLevel;
        private System.Windows.Forms.DateTimePicker dateTimeStartDate;
        private System.Windows.Forms.Label lblCampaignId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private DungeonBuddyDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.ListBox lstBoxRaces;
        private System.Windows.Forms.ListBox lstBoxClasses;
    }
}