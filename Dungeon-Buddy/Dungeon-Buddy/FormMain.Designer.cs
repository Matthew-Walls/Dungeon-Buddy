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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDiceRoller = new System.Windows.Forms.Button();
            this.tabControlData = new System.Windows.Forms.TabControl();
            this.tabPagePlayers = new System.Windows.Forms.TabPage();
            this.toolStripPlayers = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.contextMenuStripPlayers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemNewPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeletePlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dungeonBuddyDataSet = new Dungeon_Buddy.DungeonBuddyDataSet();
            this.tabPageMonsters = new System.Windows.Forms.TabPage();
            this.monstersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStripMonsters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemNewMonster = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditMonster = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteMonster = new System.Windows.Forms.ToolStripMenuItem();
            this.monstersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripMonsters = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPageNotes = new System.Windows.Forms.TabPage();
            this.notesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dungeonBuddyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.TableAdapterManager();
            this.playersTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.PlayersTableAdapter();
            this.campaignTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.CampaignTableAdapter();
            this.monstersTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.MonstersTableAdapter();
            this.notesTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.NotesTableAdapter();
            this.toolStripButtonNewPlayer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditPlayer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeletePlayer = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoadMonster = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNewMonster = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditMonster = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteMonster = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNewNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tabControlData.SuspendLayout();
            this.tabPagePlayers.SuspendLayout();
            this.toolStripPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).BeginInit();
            this.contextMenuStripPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSet)).BeginInit();
            this.tabPageMonsters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monstersDataGridView)).BeginInit();
            this.contextMenuStripMonsters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monstersBindingSource)).BeginInit();
            this.toolStripMonsters.SuspendLayout();
            this.tabPageNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 569);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(171, 497);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 38);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Campaign";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(339, 497);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(90, 38);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change Campaign";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDiceRoller
            // 
            this.btnDiceRoller.Location = new System.Drawing.Point(507, 497);
            this.btnDiceRoller.Name = "btnDiceRoller";
            this.btnDiceRoller.Size = new System.Drawing.Size(90, 38);
            this.btnDiceRoller.TabIndex = 4;
            this.btnDiceRoller.Text = "Dice Roller";
            this.btnDiceRoller.UseVisualStyleBackColor = true;
            this.btnDiceRoller.Click += new System.EventHandler(this.btnDiceRoller_Click);
            // 
            // tabControlData
            // 
            this.tabControlData.Controls.Add(this.tabPagePlayers);
            this.tabControlData.Controls.Add(this.tabPageMonsters);
            this.tabControlData.Controls.Add(this.tabPageNotes);
            this.tabControlData.Location = new System.Drawing.Point(12, 12);
            this.tabControlData.Name = "tabControlData";
            this.tabControlData.SelectedIndex = 0;
            this.tabControlData.Size = new System.Drawing.Size(745, 459);
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
            this.tabPagePlayers.Size = new System.Drawing.Size(737, 433);
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
            this.toolStripPlayers.Size = new System.Drawing.Size(731, 25);
            this.toolStripPlayers.TabIndex = 1;
            this.toolStripPlayers.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.playersDataGridView.ContextMenuStrip = this.contextMenuStripPlayers;
            this.playersDataGridView.DataSource = this.playersBindingSource;
            this.playersDataGridView.Location = new System.Drawing.Point(6, 31);
            this.playersDataGridView.Name = "playersDataGridView";
            this.playersDataGridView.ReadOnly = true;
            this.playersDataGridView.Size = new System.Drawing.Size(725, 396);
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
            this.dataGridViewTextBoxColumn6.Width = 300;
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
            // contextMenuStripPlayers
            // 
            this.contextMenuStripPlayers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNewPlayer,
            this.toolStripMenuItemEditPlayer,
            this.toolStripMenuItemDeletePlayer});
            this.contextMenuStripPlayers.Name = "contextMenuStripPlayers";
            this.contextMenuStripPlayers.ShowImageMargin = false;
            this.contextMenuStripPlayers.Size = new System.Drawing.Size(118, 70);
            // 
            // toolStripMenuItemNewPlayer
            // 
            this.toolStripMenuItemNewPlayer.Name = "toolStripMenuItemNewPlayer";
            this.toolStripMenuItemNewPlayer.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemNewPlayer.Text = "New Player";
            this.toolStripMenuItemNewPlayer.Click += new System.EventHandler(this.toolStripMenuItemNewPlayer_Click);
            // 
            // toolStripMenuItemEditPlayer
            // 
            this.toolStripMenuItemEditPlayer.Name = "toolStripMenuItemEditPlayer";
            this.toolStripMenuItemEditPlayer.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemEditPlayer.Text = "Edit Player";
            this.toolStripMenuItemEditPlayer.Click += new System.EventHandler(this.toolStripMenuItemEditPlayer_Click);
            // 
            // toolStripMenuItemDeletePlayer
            // 
            this.toolStripMenuItemDeletePlayer.Name = "toolStripMenuItemDeletePlayer";
            this.toolStripMenuItemDeletePlayer.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemDeletePlayer.Text = "Delete Player";
            this.toolStripMenuItemDeletePlayer.Click += new System.EventHandler(this.toolStripMenuItemDeletePlayer_Click);
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
            this.tabPageMonsters.Controls.Add(this.monstersDataGridView);
            this.tabPageMonsters.Controls.Add(this.toolStripMonsters);
            this.tabPageMonsters.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonsters.Name = "tabPageMonsters";
            this.tabPageMonsters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonsters.Size = new System.Drawing.Size(737, 433);
            this.tabPageMonsters.TabIndex = 1;
            this.tabPageMonsters.Text = "Monsters";
            this.tabPageMonsters.UseVisualStyleBackColor = true;
            // 
            // monstersDataGridView
            // 
            this.monstersDataGridView.AllowUserToAddRows = false;
            this.monstersDataGridView.AllowUserToDeleteRows = false;
            this.monstersDataGridView.AllowUserToOrderColumns = true;
            this.monstersDataGridView.AutoGenerateColumns = false;
            this.monstersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monstersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewCheckBoxColumn1});
            this.monstersDataGridView.ContextMenuStrip = this.contextMenuStripMonsters;
            this.monstersDataGridView.DataSource = this.monstersBindingSource;
            this.monstersDataGridView.Location = new System.Drawing.Point(6, 31);
            this.monstersDataGridView.Name = "monstersDataGridView";
            this.monstersDataGridView.ReadOnly = true;
            this.monstersDataGridView.Size = new System.Drawing.Size(725, 396);
            this.monstersDataGridView.TabIndex = 2;
            this.monstersDataGridView.DoubleClick += new System.EventHandler(this.monstersDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn14.HeaderText = "Name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn15.HeaderText = "Size";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Alignment";
            this.dataGridViewTextBoxColumn16.HeaderText = "Alignment";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn17.HeaderText = "Description";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 300;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn18.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ChallengeRating";
            this.dataGridViewTextBoxColumn19.HeaderText = "ChallengeRating";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "XP";
            this.dataGridViewTextBoxColumn20.HeaderText = "XP";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn21.HeaderText = "Type";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Environment";
            this.dataGridViewTextBoxColumn22.HeaderText = "Environment";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Source";
            this.dataGridViewTextBoxColumn23.HeaderText = "Source";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Page";
            this.dataGridViewTextBoxColumn24.HeaderText = "Page";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Reference";
            this.dataGridViewTextBoxColumn25.HeaderText = "Reference";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "SRD";
            this.dataGridViewCheckBoxColumn1.HeaderText = "SRD";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // contextMenuStripMonsters
            // 
            this.contextMenuStripMonsters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNewMonster,
            this.toolStripMenuItemEditMonster,
            this.toolStripMenuItemDeleteMonster});
            this.contextMenuStripMonsters.Name = "contextMenuStripPlayers";
            this.contextMenuStripMonsters.ShowImageMargin = false;
            this.contextMenuStripMonsters.Size = new System.Drawing.Size(130, 70);
            // 
            // toolStripMenuItemNewMonster
            // 
            this.toolStripMenuItemNewMonster.Name = "toolStripMenuItemNewMonster";
            this.toolStripMenuItemNewMonster.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItemNewMonster.Text = "New Monster";
            this.toolStripMenuItemNewMonster.Click += new System.EventHandler(this.toolStripMenuItemNewMonster_Click);
            // 
            // toolStripMenuItemEditMonster
            // 
            this.toolStripMenuItemEditMonster.Name = "toolStripMenuItemEditMonster";
            this.toolStripMenuItemEditMonster.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItemEditMonster.Text = "Edit Monster";
            this.toolStripMenuItemEditMonster.Click += new System.EventHandler(this.toolStripMenuItemEditMonster_Click);
            // 
            // toolStripMenuItemDeleteMonster
            // 
            this.toolStripMenuItemDeleteMonster.Name = "toolStripMenuItemDeleteMonster";
            this.toolStripMenuItemDeleteMonster.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItemDeleteMonster.Text = "Delete Monster";
            this.toolStripMenuItemDeleteMonster.Click += new System.EventHandler(this.toolStripMenuItemDeleteMonster_Click);
            // 
            // monstersBindingSource
            // 
            this.monstersBindingSource.DataMember = "Monsters";
            this.monstersBindingSource.DataSource = this.dungeonBuddyDataSet;
            // 
            // toolStripMonsters
            // 
            this.toolStripMonsters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoadMonster,
            this.toolStripButtonNewMonster,
            this.toolStripButtonEditMonster,
            this.toolStripButtonDeleteMonster,
            this.toolStripSeparator2,
            this.toolStripButton4});
            this.toolStripMonsters.Location = new System.Drawing.Point(3, 3);
            this.toolStripMonsters.Name = "toolStripMonsters";
            this.toolStripMonsters.Size = new System.Drawing.Size(731, 25);
            this.toolStripMonsters.TabIndex = 2;
            this.toolStripMonsters.Text = "toolStripMonsters";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPageNotes
            // 
            this.tabPageNotes.AutoScroll = true;
            this.tabPageNotes.Controls.Add(this.notesDataGridView);
            this.tabPageNotes.Controls.Add(this.toolStrip1);
            this.tabPageNotes.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotes.Name = "tabPageNotes";
            this.tabPageNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotes.Size = new System.Drawing.Size(737, 433);
            this.tabPageNotes.TabIndex = 2;
            this.tabPageNotes.Text = "Campaign Notes";
            this.tabPageNotes.UseVisualStyleBackColor = true;
            // 
            // notesDataGridView
            // 
            this.notesDataGridView.AllowUserToAddRows = false;
            this.notesDataGridView.AllowUserToDeleteRows = false;
            this.notesDataGridView.AllowUserToOrderColumns = true;
            this.notesDataGridView.AutoGenerateColumns = false;
            this.notesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29});
            this.notesDataGridView.DataSource = this.notesBindingSource;
            this.notesDataGridView.Location = new System.Drawing.Point(6, 31);
            this.notesDataGridView.Name = "notesDataGridView";
            this.notesDataGridView.ReadOnly = true;
            this.notesDataGridView.Size = new System.Drawing.Size(725, 396);
            this.notesDataGridView.TabIndex = 2;
            this.notesDataGridView.DoubleClick += new System.EventHandler(this.notesDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn26.HeaderText = "Title";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 180;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn27.HeaderText = "Type";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "DateAdded";
            this.dataGridViewTextBoxColumn28.HeaderText = "DateAdded";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn29.HeaderText = "Note";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Width = 300;
            // 
            // notesBindingSource
            // 
            this.notesBindingSource.DataMember = "Notes";
            this.notesBindingSource.DataSource = this.dungeonBuddyDataSet;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewNote,
            this.toolStripButtonEditNote,
            this.toolStripButtonDeleteNote,
            this.toolStripSeparator3,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(731, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // dungeonBuddyDataSetBindingSource
            // 
            this.dungeonBuddyDataSetBindingSource.DataSource = this.dungeonBuddyDataSet;
            this.dungeonBuddyDataSetBindingSource.Position = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampaignTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MonsterIndexTableAdapter = null;
            this.tableAdapterManager.MonstersTableAdapter = null;
            this.tableAdapterManager.NotesTableAdapter = null;
            this.tableAdapterManager.PlayersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // campaignTableAdapter
            // 
            this.campaignTableAdapter.ClearBeforeFill = true;
            // 
            // monstersTableAdapter
            // 
            this.monstersTableAdapter.ClearBeforeFill = true;
            // 
            // notesTableAdapter
            // 
            this.notesTableAdapter.ClearBeforeFill = true;
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
            this.toolStripButtonEditPlayer.Image = global::Dungeon_Buddy.Properties.Resources.edit;
            this.toolStripButtonEditPlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditPlayer.Name = "toolStripButtonEditPlayer";
            this.toolStripButtonEditPlayer.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditPlayer.Text = "Edit Player";
            this.toolStripButtonEditPlayer.ToolTipText = "View/Edit the selected player.";
            this.toolStripButtonEditPlayer.Click += new System.EventHandler(this.toolStripButtonEditPlayer_Click);
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
            this.toolStripButtonDeletePlayer.Click += new System.EventHandler(this.toolStripButtonDeletePlayer_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripButtonLoadMonster
            // 
            this.toolStripButtonLoadMonster.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLoadMonster.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadMonster.Image")));
            this.toolStripButtonLoadMonster.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadMonster.Name = "toolStripButtonLoadMonster";
            this.toolStripButtonLoadMonster.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLoadMonster.Text = "Monster Catalog";
            this.toolStripButtonLoadMonster.Click += new System.EventHandler(this.toolStripButtonLoadMonster_Click);
            // 
            // toolStripButtonNewMonster
            // 
            this.toolStripButtonNewMonster.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewMonster.Image = global::Dungeon_Buddy.Properties.Resources.plus_297823_960_720;
            this.toolStripButtonNewMonster.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewMonster.Name = "toolStripButtonNewMonster";
            this.toolStripButtonNewMonster.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewMonster.Text = "New Monster";
            this.toolStripButtonNewMonster.ToolTipText = "Add a new monster to the campaign.";
            this.toolStripButtonNewMonster.Click += new System.EventHandler(this.toolStripButtonNewMonster_Click);
            // 
            // toolStripButtonEditMonster
            // 
            this.toolStripButtonEditMonster.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditMonster.Image = global::Dungeon_Buddy.Properties.Resources.edit;
            this.toolStripButtonEditMonster.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditMonster.Name = "toolStripButtonEditMonster";
            this.toolStripButtonEditMonster.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditMonster.Text = "Edit Monster";
            this.toolStripButtonEditMonster.ToolTipText = "View/Edit the selected monster.";
            this.toolStripButtonEditMonster.Click += new System.EventHandler(this.toolStripButtonEditMonster_Click);
            // 
            // toolStripButtonDeleteMonster
            // 
            this.toolStripButtonDeleteMonster.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteMonster.Image = global::Dungeon_Buddy.Properties.Resources._256_256_6148db914e2614b0fba3d2bd94211f61;
            this.toolStripButtonDeleteMonster.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteMonster.Name = "toolStripButtonDeleteMonster";
            this.toolStripButtonDeleteMonster.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleteMonster.Text = "Delete Monster";
            this.toolStripButtonDeleteMonster.ToolTipText = "Delete selected monster.";
            this.toolStripButtonDeleteMonster.Click += new System.EventHandler(this.toolStripButtonDeleteMonster_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "He&lp";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButtonNewNote
            // 
            this.toolStripButtonNewNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewNote.Image = global::Dungeon_Buddy.Properties.Resources.plus_297823_960_720;
            this.toolStripButtonNewNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewNote.Name = "toolStripButtonNewNote";
            this.toolStripButtonNewNote.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewNote.Text = "New Note";
            this.toolStripButtonNewNote.ToolTipText = "Add a new note to the campaign.";
            this.toolStripButtonNewNote.Click += new System.EventHandler(this.toolStripButtonNewNote_Click);
            // 
            // toolStripButtonEditNote
            // 
            this.toolStripButtonEditNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditNote.Image = global::Dungeon_Buddy.Properties.Resources.edit;
            this.toolStripButtonEditNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditNote.Name = "toolStripButtonEditNote";
            this.toolStripButtonEditNote.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditNote.Text = "Edit Note";
            this.toolStripButtonEditNote.ToolTipText = "View/Edit the selected note.";
            this.toolStripButtonEditNote.Click += new System.EventHandler(this.toolStripButtonEditNote_Click);
            // 
            // toolStripButtonDeleteNote
            // 
            this.toolStripButtonDeleteNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteNote.Image = global::Dungeon_Buddy.Properties.Resources._256_256_6148db914e2614b0fba3d2bd94211f61;
            this.toolStripButtonDeleteNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteNote.Name = "toolStripButtonDeleteNote";
            this.toolStripButtonDeleteNote.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleteNote.Text = "Delete Note";
            this.toolStripButtonDeleteNote.ToolTipText = "Delete selected note.";
            this.toolStripButtonDeleteNote.Click += new System.EventHandler(this.toolStripButtonDeleteNote_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "He&lp";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 619);
            this.Controls.Add(this.tabControlData);
            this.Controls.Add(this.btnDiceRoller);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeon Buddy";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlData.ResumeLayout(false);
            this.tabPagePlayers.ResumeLayout(false);
            this.tabPagePlayers.PerformLayout();
            this.toolStripPlayers.ResumeLayout(false);
            this.toolStripPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).EndInit();
            this.contextMenuStripPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSet)).EndInit();
            this.tabPageMonsters.ResumeLayout(false);
            this.tabPageMonsters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monstersDataGridView)).EndInit();
            this.contextMenuStripMonsters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monstersBindingSource)).EndInit();
            this.toolStripMonsters.ResumeLayout(false);
            this.toolStripMonsters.PerformLayout();
            this.tabPageNotes.ResumeLayout(false);
            this.tabPageNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDiceRoller;
        private System.Windows.Forms.BindingSource dungeonBuddyDataSetBindingSource;
        private DungeonBuddyDataSet dungeonBuddyDataSet;
        private System.Windows.Forms.TabControl tabControlData;
        private System.Windows.Forms.TabPage tabPagePlayers;
        private System.Windows.Forms.TabPage tabPageMonsters;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPlayers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewPlayer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditPlayer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeletePlayer;
        private System.Windows.Forms.ToolStrip toolStripMonsters;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadMonster;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewMonster;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditMonster;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteMonster;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private DungeonBuddyDataSetTableAdapters.CampaignTableAdapter campaignTableAdapter;
        private DungeonBuddyDataSetTableAdapters.MonstersTableAdapter monstersTableAdapter;
        private System.Windows.Forms.DataGridView monstersDataGridView;
        private System.Windows.Forms.BindingSource monstersBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMonsters;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewMonster;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditMonster;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteMonster;
        private System.Windows.Forms.TabPage tabPageNotes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewNote;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditNote;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.BindingSource notesBindingSource;
        private DungeonBuddyDataSetTableAdapters.NotesTableAdapter notesTableAdapter;
        private System.Windows.Forms.DataGridView notesDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
    }
}