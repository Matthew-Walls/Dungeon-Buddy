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
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.txtBoxTags = new System.Windows.Forms.TextBox();
            this.txtBoxLevel = new System.Windows.Forms.TextBox();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblCampaignId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.playersTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.PlayersTableAdapter();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.comboAlignment = new System.Windows.Forms.ComboBox();
            this.comboRaces = new System.Windows.Forms.ComboBox();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.Info;
            nameLabel.Location = new System.Drawing.Point(83, 53);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(54, 22);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sizeLabel.ForeColor = System.Drawing.SystemColors.Info;
            sizeLabel.Location = new System.Drawing.Point(96, 79);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(41, 22);
            sizeLabel.TabIndex = 7;
            sizeLabel.Text = "Size";
            sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // alignmentLabel
            // 
            alignmentLabel.AutoSize = true;
            alignmentLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alignmentLabel.ForeColor = System.Drawing.SystemColors.Info;
            alignmentLabel.Location = new System.Drawing.Point(47, 106);
            alignmentLabel.Name = "alignmentLabel";
            alignmentLabel.Size = new System.Drawing.Size(90, 22);
            alignmentLabel.TabIndex = 9;
            alignmentLabel.Text = "Alignment";
            alignmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.SystemColors.Info;
            descriptionLabel.Location = new System.Drawing.Point(40, 136);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(97, 22);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description";
            descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tagsLabel.ForeColor = System.Drawing.SystemColors.Info;
            tagsLabel.Location = new System.Drawing.Point(100, 279);
            tagsLabel.Name = "tagsLabel";
            tagsLabel.Size = new System.Drawing.Size(37, 22);
            tagsLabel.TabIndex = 13;
            tagsLabel.Text = "Tag";
            tagsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            levelLabel.ForeColor = System.Drawing.SystemColors.Info;
            levelLabel.Location = new System.Drawing.Point(87, 308);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(50, 22);
            levelLabel.TabIndex = 15;
            levelLabel.Text = "Level";
            levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startDateLabel.ForeColor = System.Drawing.SystemColors.Info;
            startDateLabel.Location = new System.Drawing.Point(51, 334);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(86, 22);
            startDateLabel.TabIndex = 17;
            startDateLabel.Text = "Start Date";
            startDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // racesLabel
            // 
            racesLabel.AutoSize = true;
            racesLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            racesLabel.ForeColor = System.Drawing.SystemColors.Info;
            racesLabel.Location = new System.Drawing.Point(93, 360);
            racesLabel.Name = "racesLabel";
            racesLabel.Size = new System.Drawing.Size(44, 22);
            racesLabel.TabIndex = 19;
            racesLabel.Text = "Race";
            racesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // classesLabel
            // 
            classesLabel.AutoSize = true;
            classesLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            classesLabel.ForeColor = System.Drawing.SystemColors.Info;
            classesLabel.Location = new System.Drawing.Point(88, 387);
            classesLabel.Name = "classesLabel";
            classesLabel.Size = new System.Drawing.Size(49, 22);
            classesLabel.TabIndex = 21;
            classesLabel.Text = "Class";
            classesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // campaignIdLabel
            // 
            campaignIdLabel.AutoSize = true;
            campaignIdLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            campaignIdLabel.ForeColor = System.Drawing.SystemColors.Info;
            campaignIdLabel.Location = new System.Drawing.Point(2, 7);
            campaignIdLabel.Name = "campaignIdLabel";
            campaignIdLabel.Size = new System.Drawing.Size(107, 22);
            campaignIdLabel.TabIndex = 22;
            campaignIdLabel.Text = "Campaign Id";
            campaignIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(143, 56);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(200, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(143, 136);
            this.txtBoxDesc.MaxLength = 1000;
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDesc.Size = new System.Drawing.Size(200, 140);
            this.txtBoxDesc.TabIndex = 4;
            this.txtBoxDesc.Text = "\r\n";
            // 
            // txtBoxTags
            // 
            this.txtBoxTags.Location = new System.Drawing.Point(143, 282);
            this.txtBoxTags.MaxLength = 255;
            this.txtBoxTags.Name = "txtBoxTags";
            this.txtBoxTags.Size = new System.Drawing.Size(200, 20);
            this.txtBoxTags.TabIndex = 5;
            // 
            // txtBoxLevel
            // 
            this.txtBoxLevel.Location = new System.Drawing.Point(143, 308);
            this.txtBoxLevel.MaxLength = 2;
            this.txtBoxLevel.Name = "txtBoxLevel";
            this.txtBoxLevel.Size = new System.Drawing.Size(46, 20);
            this.txtBoxLevel.TabIndex = 6;
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.Location = new System.Drawing.Point(143, 334);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeStartDate.TabIndex = 7;
            // 
            // lblCampaignId
            // 
            this.lblCampaignId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCampaignId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCampaignId.Location = new System.Drawing.Point(105, 5);
            this.lblCampaignId.Name = "lblCampaignId";
            this.lblCampaignId.Size = new System.Drawing.Size(100, 23);
            this.lblCampaignId.TabIndex = 23;
            this.lblCampaignId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(85, 463);
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
            this.btnCancel.Location = new System.Drawing.Point(222, 463);
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
            // comboSize
            // 
            this.comboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Location = new System.Drawing.Point(143, 82);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(121, 21);
            this.comboSize.TabIndex = 24;
            // 
            // comboAlignment
            // 
            this.comboAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlignment.FormattingEnabled = true;
            this.comboAlignment.Location = new System.Drawing.Point(143, 109);
            this.comboAlignment.Name = "comboAlignment";
            this.comboAlignment.Size = new System.Drawing.Size(121, 21);
            this.comboAlignment.TabIndex = 25;
            // 
            // comboRaces
            // 
            this.comboRaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRaces.FormattingEnabled = true;
            this.comboRaces.Location = new System.Drawing.Point(143, 360);
            this.comboRaces.Name = "comboRaces";
            this.comboRaces.Size = new System.Drawing.Size(121, 21);
            this.comboRaces.TabIndex = 26;
            // 
            // comboClass
            // 
            this.comboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Location = new System.Drawing.Point(143, 387);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(121, 21);
            this.comboClass.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCampaignId);
            this.panel1.Controls.Add(this.comboClass);
            this.panel1.Controls.Add(classesLabel);
            this.panel1.Controls.Add(this.comboRaces);
            this.panel1.Controls.Add(racesLabel);
            this.panel1.Controls.Add(this.comboAlignment);
            this.panel1.Controls.Add(this.dateTimeStartDate);
            this.panel1.Controls.Add(this.comboSize);
            this.panel1.Controls.Add(startDateLabel);
            this.panel1.Controls.Add(this.txtBoxLevel);
            this.panel1.Controls.Add(levelLabel);
            this.panel1.Controls.Add(campaignIdLabel);
            this.panel1.Controls.Add(this.txtBoxTags);
            this.panel1.Controls.Add(tagsLabel);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.txtBoxDesc);
            this.panel1.Controls.Add(this.txtBoxName);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(sizeLabel);
            this.panel1.Controls.Add(alignmentLabel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 434);
            this.panel1.TabIndex = 28;
            // 
            // FormPlayer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(411, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Entry";
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.TextBox txtBoxTags;
        private System.Windows.Forms.TextBox txtBoxLevel;
        private System.Windows.Forms.DateTimePicker dateTimeStartDate;
        private System.Windows.Forms.Label lblCampaignId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private DungeonBuddyDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.ComboBox comboAlignment;
        private System.Windows.Forms.ComboBox comboRaces;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.Panel panel1;
    }
}