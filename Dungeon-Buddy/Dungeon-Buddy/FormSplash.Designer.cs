namespace Dungeon_Buddy
{
    partial class FormSplash
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
            this.components = new System.ComponentModel.Container();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioLoad = new System.Windows.Forms.RadioButton();
            this.radioNew = new System.Windows.Forms.RadioButton();
            this.panelNew = new System.Windows.Forms.Panel();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxDM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.lstBoxCampaignList = new System.Windows.Forms.ListBox();
            this.campaignBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dungeonBuddyDataSet = new Dungeon_Buddy.DungeonBuddyDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.campaignTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.CampaignTableAdapter();
            this.tableAdapterManager = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.TableAdapterManager();
            this.panelNew.SuspendLayout();
            this.panelLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaignBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(177, 275);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 46);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Campaign";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(63, 34);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(336, 20);
            this.txtBoxName.TabIndex = 2;
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(63, 83);
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(336, 91);
            this.txtBoxDesc.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(177, 339);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(108, 46);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New Campaign";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Campaign Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Campaign Description (optional)";
            // 
            // radioLoad
            // 
            this.radioLoad.AutoSize = true;
            this.radioLoad.Checked = true;
            this.radioLoad.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLoad.Location = new System.Drawing.Point(55, 13);
            this.radioLoad.Name = "radioLoad";
            this.radioLoad.Size = new System.Drawing.Size(364, 34);
            this.radioLoad.TabIndex = 1;
            this.radioLoad.Text = "Load a previously created campaign...";
            this.radioLoad.UseVisualStyleBackColor = true;
            this.radioLoad.CheckedChanged += new System.EventHandler(this.radioLoad_CheckedChanged);
            // 
            // radioNew
            // 
            this.radioNew.AutoSize = true;
            this.radioNew.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNew.Location = new System.Drawing.Point(55, 53);
            this.radioNew.Name = "radioNew";
            this.radioNew.Size = new System.Drawing.Size(253, 34);
            this.radioNew.TabIndex = 2;
            this.radioNew.Text = "Create a new campaign...";
            this.radioNew.UseVisualStyleBackColor = true;
            this.radioNew.CheckedChanged += new System.EventHandler(this.radioNew_CheckedChanged);
            // 
            // panelNew
            // 
            this.panelNew.Controls.Add(this.dateStartDate);
            this.panelNew.Controls.Add(this.label5);
            this.panelNew.Controls.Add(this.txtBoxDM);
            this.panelNew.Controls.Add(this.label2);
            this.panelNew.Controls.Add(this.txtBoxDesc);
            this.panelNew.Controls.Add(this.txtBoxName);
            this.panelNew.Controls.Add(this.label3);
            this.panelNew.Controls.Add(this.btnNew);
            this.panelNew.Controls.Add(this.label4);
            this.panelNew.Location = new System.Drawing.Point(12, 93);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(462, 397);
            this.panelNew.TabIndex = 12;
            this.panelNew.Visible = false;
            // 
            // dateStartDate
            // 
            this.dateStartDate.Location = new System.Drawing.Point(131, 298);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateStartDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Campaign Start Date (optional)";
            // 
            // txtBoxDM
            // 
            this.txtBoxDM.Location = new System.Drawing.Point(63, 224);
            this.txtBoxDM.Name = "txtBoxDM";
            this.txtBoxDM.Size = new System.Drawing.Size(336, 20);
            this.txtBoxDM.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dungeon Master (optional)";
            // 
            // panelLoad
            // 
            this.panelLoad.Controls.Add(this.lstBoxCampaignList);
            this.panelLoad.Controls.Add(this.label1);
            this.panelLoad.Controls.Add(this.btnLoad);
            this.panelLoad.Location = new System.Drawing.Point(12, 93);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(462, 397);
            this.panelLoad.TabIndex = 13;
            // 
            // lstBoxCampaignList
            // 
            this.lstBoxCampaignList.DataSource = this.campaignBindingSource;
            this.lstBoxCampaignList.DisplayMember = "Title";
            this.lstBoxCampaignList.FormattingEnabled = true;
            this.lstBoxCampaignList.Location = new System.Drawing.Point(81, 112);
            this.lstBoxCampaignList.Name = "lstBoxCampaignList";
            this.lstBoxCampaignList.Size = new System.Drawing.Size(301, 147);
            this.lstBoxCampaignList.TabIndex = 3;
            this.lstBoxCampaignList.TabStop = false;
            this.lstBoxCampaignList.UseTabStops = false;
            // 
            // campaignBindingSource
            // 
            this.campaignBindingSource.DataMember = "Campaign";
            this.campaignBindingSource.DataSource = this.dungeonBuddyDataSet;
            // 
            // dungeonBuddyDataSet
            // 
            this.dungeonBuddyDataSet.DataSetName = "DungeonBuddyDataSet";
            this.dungeonBuddyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Campaign List";
            // 
            // campaignTableAdapter
            // 
            this.campaignTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampaignTableAdapter = this.campaignTableAdapter;
            this.tableAdapterManager.MonsterIndexTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 500);
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.panelNew);
            this.Controls.Add(this.radioNew);
            this.Controls.Add(this.radioLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a Campaign";
            this.Load += new System.EventHandler(this.FormSplash_Load);
            this.panelNew.ResumeLayout(false);
            this.panelNew.PerformLayout();
            this.panelLoad.ResumeLayout(false);
            this.panelLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaignBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioLoad;
        private System.Windows.Forms.RadioButton radioNew;
        private System.Windows.Forms.Panel panelNew;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxDM;
        private System.Windows.Forms.Label label2;
        private DungeonBuddyDataSet dungeonBuddyDataSet;
        private System.Windows.Forms.BindingSource campaignBindingSource;
        private DungeonBuddyDataSetTableAdapters.CampaignTableAdapter campaignTableAdapter;
        private System.Windows.Forms.ListBox lstBoxCampaignList;
        private DungeonBuddyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}