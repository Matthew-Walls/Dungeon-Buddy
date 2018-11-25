namespace Dungeon_Buddy
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDiceRoller = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.btnMonsters = new System.Windows.Forms.Button();
            this.tabControlData = new System.Windows.Forms.TabControl();
            this.tabPagePlayers = new System.Windows.Forms.TabPage();
            this.toolStripPlayers = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewPlayer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditPlayer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeletePlayer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.playersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Race = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dungeonBuddyDataSet = new Dungeon_Buddy.DungeonBuddyDataSet();
            this.tabPageMonsters = new System.Windows.Forms.TabPage();
            this.dungeonBuddyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campaignTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.CampaignTableAdapter();
            this.tableAdapterManager = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.TableAdapterManager();
            this.playersTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.PlayersTableAdapter();
            this.tabControlData.SuspendLayout();
            this.tabPagePlayers.SuspendLayout();
            this.toolStripPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(111, 95);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(90, 38);
            this.btnNotes.TabIndex = 0;
            this.btnNotes.Text = "Campaign Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(223, 544);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(262, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 38);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Campaign";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(111, 24);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(90, 38);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change Campaign";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDiceRoller
            // 
            this.btnDiceRoller.Location = new System.Drawing.Point(262, 164);
            this.btnDiceRoller.Name = "btnDiceRoller";
            this.btnDiceRoller.Size = new System.Drawing.Size(90, 38);
            this.btnDiceRoller.TabIndex = 4;
            this.btnDiceRoller.Text = "Dice Roller";
            this.btnDiceRoller.UseVisualStyleBackColor = true;
            // 
            // btnPlayers
            // 
            this.btnPlayers.Location = new System.Drawing.Point(262, 95);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(90, 38);
            this.btnPlayers.TabIndex = 5;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = true;
            // 
            // btnMonsters
            // 
            this.btnMonsters.Location = new System.Drawing.Point(111, 164);
            this.btnMonsters.Name = "btnMonsters";
            this.btnMonsters.Size = new System.Drawing.Size(90, 38);
            this.btnMonsters.TabIndex = 6;
            this.btnMonsters.Text = "Monsters";
            this.btnMonsters.UseVisualStyleBackColor = true;
            // 
            // tabControlData
            // 
            this.tabControlData.Controls.Add(this.tabPagePlayers);
            this.tabControlData.Controls.Add(this.tabPageMonsters);
            this.tabControlData.Location = new System.Drawing.Point(12, 208);
            this.tabControlData.Name = "tabControlData";
            this.tabControlData.SelectedIndex = 0;
            this.tabControlData.Size = new System.Drawing.Size(526, 330);
            this.tabControlData.TabIndex = 7;
            // 
            // tabPagePlayers
            // 
            this.tabPagePlayers.AutoScroll = true;
            this.tabPagePlayers.Controls.Add(this.toolStripPlayers);
            this.tabPagePlayers.Controls.Add(this.playersDataGridView);
            this.tabPagePlayers.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayers.Name = "tabPagePlayers";
            this.tabPagePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayers.Size = new System.Drawing.Size(518, 304);
            this.tabPagePlayers.TabIndex = 0;
            this.tabPagePlayers.Text = "Players";
            this.tabPagePlayers.UseVisualStyleBackColor = true;
            // 
            // toolStripPlayers
            // 
            this.toolStripPlayers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewPlayer,
            this.toolStripButtonEditPlayer,
            this.toolStripButtonDeletePlayer,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStripPlayers.Location = new System.Drawing.Point(3, 3);
            this.toolStripPlayers.Name = "toolStripPlayers";
            this.toolStripPlayers.Size = new System.Drawing.Size(512, 25);
            this.toolStripPlayers.TabIndex = 1;
            this.toolStripPlayers.Text = "toolStrip1";
            // 
            // toolStripButtonNewPlayer
            // 
            this.toolStripButtonNewPlayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewPlayer.Image = global::Dungeon_Buddy.Properties.Resources.plus_297823_960_720;
            this.toolStripButtonNewPlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewPlayer.Name = "toolStripButtonNewPlayer";
            this.toolStripButtonNewPlayer.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewPlayer.Text = "New Player";
            this.toolStripButtonNewPlayer.ToolTipText = "Add a new player to the campaign.";
            this.toolStripButtonNewPlayer.Click += new System.EventHandler(this.toolStripButtonNewPlayer_Click);
            // 
            // toolStripButtonEditPlayer
            // 
            this.toolStripButtonEditPlayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditPlayer.Image = global::Dungeon_Buddy.Properties.Resources.floppy_512;
            this.toolStripButtonEditPlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditPlayer.Name = "toolStripButtonEditPlayer";
            this.toolStripButtonEditPlayer.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditPlayer.Text = "Edit Player";
            this.toolStripButtonEditPlayer.ToolTipText = "Edit the selected player.";
            // 
            // toolStripButtonDeletePlayer
            // 
            this.toolStripButtonDeletePlayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeletePlayer.Image = global::Dungeon_Buddy.Properties.Resources._256_256_6148db914e2614b0fba3d2bd94211f61;
            this.toolStripButtonDeletePlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeletePlayer.Name = "toolStripButtonDeletePlayer";
            this.toolStripButtonDeletePlayer.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeletePlayer.Text = "Delete Player";
            this.toolStripButtonDeletePlayer.ToolTipText = "Delete selected player.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // playersDataGridView
            // 
            this.playersDataGridView.AllowUserToAddRows = false;
            this.playersDataGridView.AllowUserToDeleteRows = false;
            this.playersDataGridView.AllowUserToOrderColumns = true;
            this.playersDataGridView.AutoGenerateColumns = false;
            this.playersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Tag,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Race,
            this.Class});
            this.playersDataGridView.DataSource = this.playersBindingSource;
            this.playersDataGridView.Location = new System.Drawing.Point(6, 31);
            this.playersDataGridView.Name = "playersDataGridView";
            this.playersDataGridView.ReadOnly = true;
            this.playersDataGridView.Size = new System.Drawing.Size(509, 267);
            this.playersDataGridView.TabIndex = 0;
            this.playersDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playersDataGridView_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CampaignId";
            this.dataGridViewTextBoxColumn2.HeaderText = "CampaignId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn4.HeaderText = "Size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Alignment";
            this.dataGridViewTextBoxColumn5.HeaderText = "Alignment";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Tag
            // 
            this.Tag.DataPropertyName = "Tag";
            this.Tag.HeaderText = "Tag";
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Level";
            this.dataGridViewTextBoxColumn8.HeaderText = "Level";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Race
            // 
            this.Race.DataPropertyName = "Race";
            this.Race.HeaderText = "Race";
            this.Race.Name = "Race";
            this.Race.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.DataPropertyName = "Class";
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.dungeonBuddyDataSet;
            // 
            // dungeonBuddyDataSet
            // 
            this.dungeonBuddyDataSet.DataSetName = "DungeonBuddyDataSet";
            this.dungeonBuddyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageMonsters
            // 
            this.tabPageMonsters.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonsters.Name = "tabPageMonsters";
            this.tabPageMonsters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonsters.Size = new System.Drawing.Size(518, 304);
            this.tabPageMonsters.TabIndex = 1;
            this.tabPageMonsters.Text = "Monsters";
            this.tabPageMonsters.UseVisualStyleBackColor = true;
            // 
            // dungeonBuddyDataSetBindingSource
            // 
            this.dungeonBuddyDataSetBindingSource.DataSource = this.dungeonBuddyDataSet;
            this.dungeonBuddyDataSetBindingSource.Position = 0;
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
            this.tableAdapterManager.PlayersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 619);
            this.Controls.Add(this.tabControlData);
            this.Controls.Add(this.btnMonsters);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.btnDiceRoller);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeon Buddy";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlData.ResumeLayout(false);
            this.tabPagePlayers.ResumeLayout(false);
            this.tabPagePlayers.PerformLayout();
            this.toolStripPlayers.ResumeLayout(false);
            this.toolStripPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDiceRoller;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Button btnMonsters;
        private System.Windows.Forms.BindingSource dungeonBuddyDataSetBindingSource;
        private DungeonBuddyDataSet dungeonBuddyDataSet;
        private System.Windows.Forms.TabControl tabControlData;
        private System.Windows.Forms.TabPage tabPagePlayers;
        private System.Windows.Forms.TabPage tabPageMonsters;
        private DungeonBuddyDataSetTableAdapters.CampaignTableAdapter campaignTableAdapter;
        private DungeonBuddyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private DungeonBuddyDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.DataGridView playersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStrip toolStripPlayers;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewPlayer;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditPlayer;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeletePlayer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Race;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
    }
}