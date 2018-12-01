namespace Dungeon_Buddy
{
    partial class FormMonster
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label alignmentLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label tagsLabel;
            this.lblCampaignId = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.txtBoxTags = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtboxChallenge = new System.Windows.Forms.TextBox();
            this.txtboxXP = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.txtboxSource = new System.Windows.Forms.TextBox();
            this.txtboxPage = new System.Windows.Forms.TextBox();
            this.txtboxRef = new System.Windows.Forms.TextBox();
            this.checkboxSRD = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBoxEnvironment = new System.Windows.Forms.CheckedListBox();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.monstersTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.MonstersTableAdapter();
            this.checkedListBoxAlignment = new System.Windows.Forms.CheckedListBox();
            campaignIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            alignmentLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            tagsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // campaignIdLabel
            // 
            campaignIdLabel.AutoSize = true;
            campaignIdLabel.Location = new System.Drawing.Point(54, 8);
            campaignIdLabel.Name = "campaignIdLabel";
            campaignIdLabel.Size = new System.Drawing.Size(69, 13);
            campaignIdLabel.TabIndex = 34;
            campaignIdLabel.Text = "Campaign Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(67, 38);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 28;
            nameLabel.Text = "Name:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(67, 61);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 30;
            sizeLabel.Text = "Size:";
            // 
            // alignmentLabel
            // 
            alignmentLabel.AutoSize = true;
            alignmentLabel.Location = new System.Drawing.Point(67, 123);
            alignmentLabel.Name = "alignmentLabel";
            alignmentLabel.Size = new System.Drawing.Size(56, 13);
            alignmentLabel.TabIndex = 31;
            alignmentLabel.Text = "Alignment:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(67, 215);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 32;
            descriptionLabel.Text = "Description:";
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.Location = new System.Drawing.Point(67, 361);
            tagsLabel.Name = "tagsLabel";
            tagsLabel.Size = new System.Drawing.Size(29, 13);
            tagsLabel.TabIndex = 33;
            tagsLabel.Text = "Tag:";
            // 
            // lblCampaignId
            // 
            this.lblCampaignId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCampaignId.Location = new System.Drawing.Point(142, 9);
            this.lblCampaignId.Name = "lblCampaignId";
            this.lblCampaignId.Size = new System.Drawing.Size(100, 23);
            this.lblCampaignId.TabIndex = 35;
            this.lblCampaignId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(142, 35);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(200, 20);
            this.txtBoxName.TabIndex = 24;
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(142, 212);
            this.txtBoxDesc.MaxLength = 1000;
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(200, 140);
            this.txtBoxDesc.TabIndex = 27;
            this.txtBoxDesc.Text = "\r\n";
            // 
            // txtBoxTags
            // 
            this.txtBoxTags.Location = new System.Drawing.Point(142, 358);
            this.txtBoxTags.MaxLength = 255;
            this.txtBoxTags.Name = "txtBoxTags";
            this.txtBoxTags.Size = new System.Drawing.Size(200, 20);
            this.txtBoxTags.TabIndex = 29;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(439, 552);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(302, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 43);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtboxChallenge
            // 
            this.txtboxChallenge.Location = new System.Drawing.Point(516, 38);
            this.txtboxChallenge.Name = "txtboxChallenge";
            this.txtboxChallenge.Size = new System.Drawing.Size(100, 20);
            this.txtboxChallenge.TabIndex = 38;
            // 
            // txtboxXP
            // 
            this.txtboxXP.Location = new System.Drawing.Point(516, 86);
            this.txtboxXP.Name = "txtboxXP";
            this.txtboxXP.Size = new System.Drawing.Size(100, 20);
            this.txtboxXP.TabIndex = 39;
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(516, 134);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(121, 21);
            this.comboType.TabIndex = 40;
            // 
            // txtboxSource
            // 
            this.txtboxSource.Location = new System.Drawing.Point(516, 305);
            this.txtboxSource.Name = "txtboxSource";
            this.txtboxSource.Size = new System.Drawing.Size(100, 20);
            this.txtboxSource.TabIndex = 42;
            // 
            // txtboxPage
            // 
            this.txtboxPage.Location = new System.Drawing.Point(516, 331);
            this.txtboxPage.Name = "txtboxPage";
            this.txtboxPage.Size = new System.Drawing.Size(100, 20);
            this.txtboxPage.TabIndex = 43;
            // 
            // txtboxRef
            // 
            this.txtboxRef.Location = new System.Drawing.Point(516, 367);
            this.txtboxRef.Name = "txtboxRef";
            this.txtboxRef.Size = new System.Drawing.Size(100, 20);
            this.txtboxRef.TabIndex = 44;
            // 
            // checkboxSRD
            // 
            this.checkboxSRD.AutoSize = true;
            this.checkboxSRD.Location = new System.Drawing.Point(516, 420);
            this.checkboxSRD.Name = "checkboxSRD";
            this.checkboxSRD.Size = new System.Drawing.Size(112, 17);
            this.checkboxSRD.TabIndex = 45;
            this.checkboxSRD.Text = "Available in SRD?";
            this.checkboxSRD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Challenge Rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "XP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Environment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Source";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Page";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Reference";
            // 
            // checkedListBoxEnvironment
            // 
            this.checkedListBoxEnvironment.FormattingEnabled = true;
            this.checkedListBoxEnvironment.Location = new System.Drawing.Point(516, 188);
            this.checkedListBoxEnvironment.Name = "checkedListBoxEnvironment";
            this.checkedListBoxEnvironment.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxEnvironment.TabIndex = 53;
            // 
            // comboSize
            // 
            this.comboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSize.Location = new System.Drawing.Point(142, 61);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(121, 21);
            this.comboSize.TabIndex = 54;
            // 
            // monstersTableAdapter
            // 
            this.monstersTableAdapter.ClearBeforeFill = true;
            // 
            // checkedListBoxAlignment
            // 
            this.checkedListBoxAlignment.FormattingEnabled = true;
            this.checkedListBoxAlignment.Location = new System.Drawing.Point(142, 112);
            this.checkedListBoxAlignment.Name = "checkedListBoxAlignment";
            this.checkedListBoxAlignment.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxAlignment.TabIndex = 56;
            // 
            // FormMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 629);
            this.Controls.Add(this.checkedListBoxAlignment);
            this.Controls.Add(this.comboSize);
            this.Controls.Add(this.checkedListBoxEnvironment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkboxSRD);
            this.Controls.Add(this.txtboxRef);
            this.Controls.Add(this.txtboxPage);
            this.Controls.Add(this.txtboxSource);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.txtboxXP);
            this.Controls.Add(this.txtboxChallenge);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(campaignIdLabel);
            this.Controls.Add(this.lblCampaignId);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(alignmentLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(tagsLabel);
            this.Controls.Add(this.txtBoxTags);
            this.Name = "FormMonster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMonster";
            this.Load += new System.EventHandler(this.FormMonster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCampaignId;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.TextBox txtBoxTags;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtboxChallenge;
        private System.Windows.Forms.TextBox txtboxXP;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox txtboxSource;
        private System.Windows.Forms.TextBox txtboxPage;
        private System.Windows.Forms.TextBox txtboxRef;
        private System.Windows.Forms.CheckBox checkboxSRD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBoxEnvironment;
        private System.Windows.Forms.ComboBox comboSize;
        private DungeonBuddyDataSetTableAdapters.MonstersTableAdapter monstersTableAdapter;
        private System.Windows.Forms.CheckedListBox checkedListBoxAlignment;
    }
}