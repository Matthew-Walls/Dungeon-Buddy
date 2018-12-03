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
            this.panel1 = new System.Windows.Forms.Panel();
            campaignIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            alignmentLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            tagsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // campaignIdLabel
            // 
            campaignIdLabel.AutoSize = true;
            campaignIdLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            campaignIdLabel.ForeColor = System.Drawing.SystemColors.Info;
            campaignIdLabel.Location = new System.Drawing.Point(9, 10);
            campaignIdLabel.Name = "campaignIdLabel";
            campaignIdLabel.Size = new System.Drawing.Size(107, 22);
            campaignIdLabel.TabIndex = 34;
            campaignIdLabel.Text = "Campaign Id";
            campaignIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.Info;
            nameLabel.Location = new System.Drawing.Point(57, 62);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(54, 22);
            nameLabel.TabIndex = 28;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sizeLabel.ForeColor = System.Drawing.SystemColors.Info;
            sizeLabel.Location = new System.Drawing.Point(70, 91);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(41, 22);
            sizeLabel.TabIndex = 30;
            sizeLabel.Text = "Size";
            sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // alignmentLabel
            // 
            alignmentLabel.AutoSize = true;
            alignmentLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alignmentLabel.ForeColor = System.Drawing.SystemColors.Info;
            alignmentLabel.Location = new System.Drawing.Point(21, 122);
            alignmentLabel.Name = "alignmentLabel";
            alignmentLabel.Size = new System.Drawing.Size(90, 22);
            alignmentLabel.TabIndex = 31;
            alignmentLabel.Text = "Alignment";
            alignmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.SystemColors.Info;
            descriptionLabel.Location = new System.Drawing.Point(14, 226);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(97, 22);
            descriptionLabel.TabIndex = 32;
            descriptionLabel.Text = "Description";
            descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tagsLabel.ForeColor = System.Drawing.SystemColors.Info;
            tagsLabel.Location = new System.Drawing.Point(70, 388);
            tagsLabel.Name = "tagsLabel";
            tagsLabel.Size = new System.Drawing.Size(37, 22);
            tagsLabel.TabIndex = 33;
            tagsLabel.Text = "Tag";
            tagsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCampaignId
            // 
            this.lblCampaignId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCampaignId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCampaignId.Location = new System.Drawing.Point(112, 9);
            this.lblCampaignId.Name = "lblCampaignId";
            this.lblCampaignId.Size = new System.Drawing.Size(100, 23);
            this.lblCampaignId.TabIndex = 35;
            this.lblCampaignId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(117, 62);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(200, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(117, 229);
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
            this.txtBoxTags.Location = new System.Drawing.Point(117, 388);
            this.txtBoxTags.MaxLength = 255;
            this.txtBoxTags.Name = "txtBoxTags";
            this.txtBoxTags.Size = new System.Drawing.Size(200, 20);
            this.txtBoxTags.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(396, 475);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(211, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 43);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtboxChallenge
            // 
            this.txtboxChallenge.Location = new System.Drawing.Point(455, 73);
            this.txtboxChallenge.Name = "txtboxChallenge";
            this.txtboxChallenge.Size = new System.Drawing.Size(80, 20);
            this.txtboxChallenge.TabIndex = 6;
            // 
            // txtboxXP
            // 
            this.txtboxXP.Location = new System.Drawing.Point(455, 111);
            this.txtboxXP.Name = "txtboxXP";
            this.txtboxXP.Size = new System.Drawing.Size(80, 20);
            this.txtboxXP.TabIndex = 7;
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(455, 137);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(158, 21);
            this.comboType.TabIndex = 8;
            // 
            // txtboxSource
            // 
            this.txtboxSource.Location = new System.Drawing.Point(455, 264);
            this.txtboxSource.Name = "txtboxSource";
            this.txtboxSource.Size = new System.Drawing.Size(80, 20);
            this.txtboxSource.TabIndex = 10;
            // 
            // txtboxPage
            // 
            this.txtboxPage.Location = new System.Drawing.Point(455, 290);
            this.txtboxPage.Name = "txtboxPage";
            this.txtboxPage.Size = new System.Drawing.Size(80, 20);
            this.txtboxPage.TabIndex = 11;
            // 
            // txtboxRef
            // 
            this.txtboxRef.Location = new System.Drawing.Point(455, 316);
            this.txtboxRef.Name = "txtboxRef";
            this.txtboxRef.Size = new System.Drawing.Size(80, 20);
            this.txtboxRef.TabIndex = 12;
            // 
            // checkboxSRD
            // 
            this.checkboxSRD.AutoSize = true;
            this.checkboxSRD.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxSRD.ForeColor = System.Drawing.SystemColors.Info;
            this.checkboxSRD.Location = new System.Drawing.Point(469, 358);
            this.checkboxSRD.Name = "checkboxSRD";
            this.checkboxSRD.Size = new System.Drawing.Size(162, 26);
            this.checkboxSRD.TabIndex = 13;
            this.checkboxSRD.Text = "Available in SRD?";
            this.checkboxSRD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(364, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 44);
            this.label1.TabIndex = 46;
            this.label1.Text = "Challenge\r\nRating";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(416, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "XP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(399, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(340, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 49;
            this.label4.Text = "Environment";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(386, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "Source";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(405, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "Page";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(364, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 52;
            this.label7.Text = "Reference";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkedListBoxEnvironment
            // 
            this.checkedListBoxEnvironment.FormattingEnabled = true;
            this.checkedListBoxEnvironment.Location = new System.Drawing.Point(455, 164);
            this.checkedListBoxEnvironment.Name = "checkedListBoxEnvironment";
            this.checkedListBoxEnvironment.Size = new System.Drawing.Size(200, 94);
            this.checkedListBoxEnvironment.TabIndex = 9;
            // 
            // comboSize
            // 
            this.comboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSize.ItemHeight = 13;
            this.comboSize.Location = new System.Drawing.Point(117, 91);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(164, 21);
            this.comboSize.TabIndex = 54;
            // 
            // monstersTableAdapter
            // 
            this.monstersTableAdapter.ClearBeforeFill = true;
            // 
            // checkedListBoxAlignment
            // 
            this.checkedListBoxAlignment.FormattingEnabled = true;
            this.checkedListBoxAlignment.Location = new System.Drawing.Point(117, 123);
            this.checkedListBoxAlignment.Name = "checkedListBoxAlignment";
            this.checkedListBoxAlignment.Size = new System.Drawing.Size(200, 94);
            this.checkedListBoxAlignment.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(campaignIdLabel);
            this.panel1.Controls.Add(this.checkedListBoxEnvironment);
            this.panel1.Controls.Add(this.checkedListBoxAlignment);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBoxTags);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(tagsLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBoxDesc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(alignmentLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkboxSRD);
            this.panel1.Controls.Add(sizeLabel);
            this.panel1.Controls.Add(this.txtboxRef);
            this.panel1.Controls.Add(this.txtBoxName);
            this.panel1.Controls.Add(this.txtboxPage);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.txtboxSource);
            this.panel1.Controls.Add(this.lblCampaignId);
            this.panel1.Controls.Add(this.comboType);
            this.panel1.Controls.Add(this.txtboxChallenge);
            this.panel1.Controls.Add(this.txtboxXP);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(19, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 434);
            this.panel1.TabIndex = 55;
            // 
            // FormMonster
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(711, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMonster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monster Entry";
            this.Load += new System.EventHandler(this.FormMonster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}