namespace Dungeon_Buddy
{
    partial class MonsterIndexForm1
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
            this.dgv_Monsters = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.lbl_challenge = new System.Windows.Forms.Label();
            this.lbl_filters = new System.Windows.Forms.Label();
            this.UpDown_CR_MIN = new System.Windows.Forms.NumericUpDown();
            this.UpDown_CR_MAX = new System.Windows.Forms.NumericUpDown();
            this.tabControl_Side = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_SelectedMonsters = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campaignIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.challengeRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.environmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sRDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.monstersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dungeonBuddyDataSet = new Dungeon_Buddy.DungeonBuddyDataSet();
            this.monsterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_AddMonsters = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.environmentCB = new CheckComboBoxTest.CheckedComboBox();
            this.sizeCB = new CheckComboBoxTest.CheckedComboBox();
            this.typeCB = new CheckComboBoxTest.CheckedComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.monsterIndexTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.MonsterIndexTableAdapter();
            this.monstersTableAdapter = new Dungeon_Buddy.DungeonBuddyDataSetTableAdapters.MonstersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Monsters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CR_MIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CR_MAX)).BeginInit();
            this.tabControl_Side.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectedMonsters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monstersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Monsters
            // 
            this.dgv_Monsters.AllowUserToAddRows = false;
            this.dgv_Monsters.AllowUserToDeleteRows = false;
            this.dgv_Monsters.AllowUserToResizeRows = false;
            this.dgv_Monsters.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Monsters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Monsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Monsters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Monsters.Location = new System.Drawing.Point(3, 63);
            this.dgv_Monsters.Name = "dgv_Monsters";
            this.dgv_Monsters.ReadOnly = true;
            this.dgv_Monsters.RowHeadersVisible = false;
            this.dgv_Monsters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Monsters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Monsters.Size = new System.Drawing.Size(557, 465);
            this.dgv_Monsters.TabIndex = 3;
            this.dgv_Monsters.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(197, 429);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // searchTB
            // 
            this.searchTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTB.Location = new System.Drawing.Point(3, 3);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(81, 20);
            this.searchTB.TabIndex = 7;
            this.searchTB.Text = "Search";
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            this.searchTB.Enter += new System.EventHandler(this.searchTB_Enter);
            this.searchTB.Leave += new System.EventHandler(this.searchTB_Leave);
            // 
            // lbl_challenge
            // 
            this.lbl_challenge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_challenge.Location = new System.Drawing.Point(409, 0);
            this.lbl_challenge.Name = "lbl_challenge";
            this.lbl_challenge.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbl_challenge.Size = new System.Drawing.Size(139, 21);
            this.lbl_challenge.TabIndex = 14;
            this.lbl_challenge.Text = "Challenge Rating";
            // 
            // lbl_filters
            // 
            this.lbl_filters.AutoEllipsis = true;
            this.lbl_filters.Location = new System.Drawing.Point(3, 0);
            this.lbl_filters.Name = "lbl_filters";
            this.lbl_filters.Size = new System.Drawing.Size(551, 18);
            this.lbl_filters.TabIndex = 15;
            this.lbl_filters.Text = "Filters";
            // 
            // UpDown_CR_MIN
            // 
            this.UpDown_CR_MIN.DecimalPlaces = 3;
            this.UpDown_CR_MIN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UpDown_CR_MIN.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.UpDown_CR_MIN.Location = new System.Drawing.Point(351, 3);
            this.UpDown_CR_MIN.Name = "UpDown_CR_MIN";
            this.UpDown_CR_MIN.Size = new System.Drawing.Size(94, 20);
            this.UpDown_CR_MIN.TabIndex = 16;
            this.UpDown_CR_MIN.ValueChanged += new System.EventHandler(this.UpDown_CR_MIN_ValueChanged);
            // 
            // UpDown_CR_MAX
            // 
            this.UpDown_CR_MAX.DecimalPlaces = 3;
            this.UpDown_CR_MAX.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UpDown_CR_MAX.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.UpDown_CR_MAX.Location = new System.Drawing.Point(451, 3);
            this.UpDown_CR_MAX.Name = "UpDown_CR_MAX";
            this.UpDown_CR_MAX.Size = new System.Drawing.Size(97, 20);
            this.UpDown_CR_MAX.TabIndex = 17;
            this.UpDown_CR_MAX.Value = new decimal(new int[] {
            1000,
            0,
            0,
            65536});
            this.UpDown_CR_MAX.ValueChanged += new System.EventHandler(this.UpDown_CR_MAX_ValueChanged);
            // 
            // tabControl_Side
            // 
            this.tabControl_Side.Controls.Add(this.tabPage1);
            this.tabControl_Side.Controls.Add(this.tabPage2);
            this.tabControl_Side.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Side.Location = new System.Drawing.Point(566, 63);
            this.tabControl_Side.Name = "tabControl_Side";
            this.tabControl_Side.SelectedIndex = 0;
            this.tabControl_Side.Size = new System.Drawing.Size(215, 465);
            this.tabControl_Side.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(207, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Description";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_SelectedMonsters);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(207, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Monsters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_SelectedMonsters
            // 
            this.dgv_SelectedMonsters.AllowUserToAddRows = false;
            this.dgv_SelectedMonsters.AllowUserToDeleteRows = false;
            this.dgv_SelectedMonsters.AutoGenerateColumns = false;
            this.dgv_SelectedMonsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectedMonsters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.campaignIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.alignmentDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.challengeRatingDataGridViewTextBoxColumn,
            this.xPDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.environmentDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn,
            this.sRDDataGridViewCheckBoxColumn});
            this.dgv_SelectedMonsters.DataSource = this.monstersBindingSource;
            this.dgv_SelectedMonsters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SelectedMonsters.Location = new System.Drawing.Point(3, 3);
            this.dgv_SelectedMonsters.Name = "dgv_SelectedMonsters";
            this.dgv_SelectedMonsters.ReadOnly = true;
            this.dgv_SelectedMonsters.RowHeadersVisible = false;
            this.dgv_SelectedMonsters.Size = new System.Drawing.Size(201, 433);
            this.dgv_SelectedMonsters.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // campaignIdDataGridViewTextBoxColumn
            // 
            this.campaignIdDataGridViewTextBoxColumn.DataPropertyName = "CampaignId";
            this.campaignIdDataGridViewTextBoxColumn.HeaderText = "CampaignId";
            this.campaignIdDataGridViewTextBoxColumn.Name = "campaignIdDataGridViewTextBoxColumn";
            this.campaignIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alignmentDataGridViewTextBoxColumn
            // 
            this.alignmentDataGridViewTextBoxColumn.DataPropertyName = "Alignment";
            this.alignmentDataGridViewTextBoxColumn.HeaderText = "Alignment";
            this.alignmentDataGridViewTextBoxColumn.Name = "alignmentDataGridViewTextBoxColumn";
            this.alignmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // challengeRatingDataGridViewTextBoxColumn
            // 
            this.challengeRatingDataGridViewTextBoxColumn.DataPropertyName = "ChallengeRating";
            this.challengeRatingDataGridViewTextBoxColumn.HeaderText = "ChallengeRating";
            this.challengeRatingDataGridViewTextBoxColumn.Name = "challengeRatingDataGridViewTextBoxColumn";
            this.challengeRatingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xPDataGridViewTextBoxColumn
            // 
            this.xPDataGridViewTextBoxColumn.DataPropertyName = "XP";
            this.xPDataGridViewTextBoxColumn.HeaderText = "XP";
            this.xPDataGridViewTextBoxColumn.Name = "xPDataGridViewTextBoxColumn";
            this.xPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // environmentDataGridViewTextBoxColumn
            // 
            this.environmentDataGridViewTextBoxColumn.DataPropertyName = "Environment";
            this.environmentDataGridViewTextBoxColumn.HeaderText = "Environment";
            this.environmentDataGridViewTextBoxColumn.Name = "environmentDataGridViewTextBoxColumn";
            this.environmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pageDataGridViewTextBoxColumn
            // 
            this.pageDataGridViewTextBoxColumn.DataPropertyName = "Page";
            this.pageDataGridViewTextBoxColumn.HeaderText = "Page";
            this.pageDataGridViewTextBoxColumn.Name = "pageDataGridViewTextBoxColumn";
            this.pageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "Reference";
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            this.referenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sRDDataGridViewCheckBoxColumn
            // 
            this.sRDDataGridViewCheckBoxColumn.DataPropertyName = "SRD";
            this.sRDDataGridViewCheckBoxColumn.HeaderText = "SRD";
            this.sRDDataGridViewCheckBoxColumn.Name = "sRDDataGridViewCheckBoxColumn";
            this.sRDDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // monstersBindingSource
            // 
            this.monstersBindingSource.DataMember = "Monsters";
            this.monstersBindingSource.DataSource = this.dungeonBuddyDataSet;
            // 
            // dungeonBuddyDataSet
            // 
            this.dungeonBuddyDataSet.DataSetName = "DungeonBuddyDataSet";
            this.dungeonBuddyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_AddMonsters
            // 
            this.btn_AddMonsters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddMonsters.Location = new System.Drawing.Point(3, 30);
            this.btn_AddMonsters.Name = "btn_AddMonsters";
            this.btn_AddMonsters.Size = new System.Drawing.Size(101, 21);
            this.btn_AddMonsters.TabIndex = 21;
            this.btn_AddMonsters.Text = "Add Selected";
            this.btn_AddMonsters.UseVisualStyleBackColor = true;
            this.btn_AddMonsters.Click += new System.EventHandler(this.btn_AddMonsters_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.93877F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.06123F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl_Side, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Monsters, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(557, 54);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel3.Controls.Add(this.environmentCB, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.UpDown_CR_MAX, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.searchTB, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.UpDown_CR_MIN, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.sizeCB, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.typeCB, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(551, 21);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // environmentCB
            // 
            this.environmentCB.CheckOnClick = true;
            this.environmentCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.environmentCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.environmentCB.DropDownHeight = 1;
            this.environmentCB.FormattingEnabled = true;
            this.environmentCB.IntegralHeight = false;
            this.environmentCB.Location = new System.Drawing.Point(264, 3);
            this.environmentCB.MaxDropDownItems = 11;
            this.environmentCB.Name = "environmentCB";
            this.environmentCB.Size = new System.Drawing.Size(81, 21);
            this.environmentCB.TabIndex = 9;
            this.environmentCB.Text = "Environment";
            this.environmentCB.ValueSeparator = ", ";
            this.environmentCB.DropDownClosed += new System.EventHandler(this.environmentCB_DropDownClosed);
            // 
            // sizeCB
            // 
            this.sizeCB.CheckOnClick = true;
            this.sizeCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sizeCB.DropDownHeight = 1;
            this.sizeCB.FormattingEnabled = true;
            this.sizeCB.IntegralHeight = false;
            this.sizeCB.Location = new System.Drawing.Point(90, 3);
            this.sizeCB.MaxDropDownItems = 11;
            this.sizeCB.Name = "sizeCB";
            this.sizeCB.Size = new System.Drawing.Size(81, 21);
            this.sizeCB.TabIndex = 12;
            this.sizeCB.Text = "Size";
            this.sizeCB.ValueSeparator = ", ";
            this.sizeCB.DropDownClosed += new System.EventHandler(this.sizeCB_DropDownClosed);
            // 
            // typeCB
            // 
            this.typeCB.CheckOnClick = true;
            this.typeCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.typeCB.DropDownHeight = 1;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.IntegralHeight = false;
            this.typeCB.Location = new System.Drawing.Point(177, 3);
            this.typeCB.MaxDropDownItems = 14;
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(81, 21);
            this.typeCB.TabIndex = 13;
            this.typeCB.Text = "Type";
            this.typeCB.ValueSeparator = ", ";
            this.typeCB.DropDownClosed += new System.EventHandler(this.typeCB_DropDownClosed);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_Count, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_challenge, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(551, 21);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(3, 0);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbl_Count.Size = new System.Drawing.Size(48, 18);
            this.lbl_Count.TabIndex = 18;
            this.lbl_Count.Text = "Showing";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.clearButton2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btn_AddMonsters, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(566, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(215, 54);
            this.tableLayoutPanel5.TabIndex = 22;
            // 
            // clearButton2
            // 
            this.clearButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton2.Location = new System.Drawing.Point(110, 30);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(102, 21);
            this.clearButton2.TabIndex = 25;
            this.clearButton2.Text = "Clear Filters";
            this.clearButton2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.clearButton, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(566, 534);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(215, 24);
            this.tableLayoutPanel6.TabIndex = 23;
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Location = new System.Drawing.Point(110, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 21);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "Clear Filters";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.63734F));
            this.tableLayoutPanel7.Controls.Add(this.lbl_filters, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 534);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(557, 24);
            this.tableLayoutPanel7.TabIndex = 24;
            // 
            // monsterIndexTableAdapter
            // 
            this.monsterIndexTableAdapter.ClearBeforeFill = true;
            // 
            // monstersTableAdapter
            // 
            this.monstersTableAdapter.ClearBeforeFill = true;
            // 
            // MonsterIndexForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MonsterIndexForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monster Catalog";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MonsterIndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Monsters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CR_MIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CR_MAX)).EndInit();
            this.tabControl_Side.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectedMonsters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monstersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonBuddyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Monsters;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox searchTB;
        private CheckComboBoxTest.CheckedComboBox environmentCB;
        private CheckComboBoxTest.CheckedComboBox sizeCB;
        private CheckComboBoxTest.CheckedComboBox typeCB;
        private System.Windows.Forms.Label lbl_challenge;
        private System.Windows.Forms.Label lbl_filters;
        private System.Windows.Forms.NumericUpDown UpDown_CR_MIN;
        private System.Windows.Forms.NumericUpDown UpDown_CR_MAX;
        private System.Windows.Forms.TabControl tabControl_Side;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_AddMonsters;
        private System.Windows.Forms.DataGridViewTextBoxColumn npcNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monsterTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monsterIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource monsterBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Button clearButton;
        private DungeonBuddyDataSetTableAdapters.MonsterIndexTableAdapter monsterIndexTableAdapter;
        private DungeonBuddyDataSet dungeonBuddyDataSet;
        private System.Windows.Forms.BindingSource monstersBindingSource;
        private DungeonBuddyDataSetTableAdapters.MonstersTableAdapter monstersTableAdapter;
        private System.Windows.Forms.Button clearButton2;
        private System.Windows.Forms.DataGridView dgv_SelectedMonsters;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campaignIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn challengeRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn environmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sRDDataGridViewCheckBoxColumn;
    }
}

