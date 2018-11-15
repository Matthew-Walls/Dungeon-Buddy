namespace Dungeon_Buddy
{
    partial class MonsterIndexForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.lbl_challenge = new System.Windows.Forms.Label();
            this.lbl_filters = new System.Windows.Forms.Label();
            this.UpDown_CR_MIN = new System.Windows.Forms.NumericUpDown();
            this.UpDown_CR_MAX = new System.Windows.Forms.NumericUpDown();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.tabControl_Side = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.challengeRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.environmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npcNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monsterTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monsterIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monsterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_AddMonsters = new System.Windows.Forms.Button();
            this.btn_ClearMonsters = new System.Windows.Forms.Button();
            this.typeCB = new CheckComboBoxTest.CheckedComboBox();
            this.sizeCB = new CheckComboBoxTest.CheckedComboBox();
            this.environmentCB = new CheckComboBoxTest.CheckedComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CR_MIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CR_MAX)).BeginInit();
            this.tabControl_Side.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(622, 480);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(219, 481);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(15, 7);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(100, 20);
            this.searchTB.TabIndex = 7;
            this.searchTB.Text = "Search";
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            this.searchTB.Enter += new System.EventHandler(this.searchTB_Enter);
            this.searchTB.Leave += new System.EventHandler(this.searchTB_Leave);
            // 
            // lbl_challenge
            // 
            this.lbl_challenge.AutoSize = true;
            this.lbl_challenge.Location = new System.Drawing.Point(523, 7);
            this.lbl_challenge.Name = "lbl_challenge";
            this.lbl_challenge.Size = new System.Drawing.Size(88, 13);
            this.lbl_challenge.TabIndex = 14;
            this.lbl_challenge.Text = "Challenge Rating";
            // 
            // lbl_filters
            // 
            this.lbl_filters.AutoEllipsis = true;
            this.lbl_filters.Location = new System.Drawing.Point(96, 540);
            this.lbl_filters.Name = "lbl_filters";
            this.lbl_filters.Size = new System.Drawing.Size(539, 13);
            this.lbl_filters.TabIndex = 15;
            this.lbl_filters.Text = "Filters";
            // 
            // UpDown_CR_MIN
            // 
            this.UpDown_CR_MIN.DecimalPlaces = 3;
            this.UpDown_CR_MIN.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.UpDown_CR_MIN.Location = new System.Drawing.Point(501, 23);
            this.UpDown_CR_MIN.Name = "UpDown_CR_MIN";
            this.UpDown_CR_MIN.Size = new System.Drawing.Size(64, 20);
            this.UpDown_CR_MIN.TabIndex = 16;
            this.UpDown_CR_MIN.ValueChanged += new System.EventHandler(this.UpDown_CR_MIN_ValueChanged);
            // 
            // UpDown_CR_MAX
            // 
            this.UpDown_CR_MAX.DecimalPlaces = 3;
            this.UpDown_CR_MAX.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.UpDown_CR_MAX.Location = new System.Drawing.Point(571, 23);
            this.UpDown_CR_MAX.Name = "UpDown_CR_MAX";
            this.UpDown_CR_MAX.Size = new System.Drawing.Size(64, 20);
            this.UpDown_CR_MAX.TabIndex = 17;
            this.UpDown_CR_MAX.Value = new decimal(new int[] {
            1000,
            0,
            0,
            65536});
            this.UpDown_CR_MAX.ValueChanged += new System.EventHandler(this.UpDown_CR_MAX_ValueChanged);
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(12, 30);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(48, 13);
            this.lbl_Count.TabIndex = 18;
            this.lbl_Count.Text = "Showing";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(15, 536);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 20);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear Filters";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // tabControl_Side
            // 
            this.tabControl_Side.Controls.Add(this.tabPage1);
            this.tabControl_Side.Controls.Add(this.tabPage2);
            this.tabControl_Side.Location = new System.Drawing.Point(644, 30);
            this.tabControl_Side.Name = "tabControl_Side";
            this.tabControl_Side.SelectedIndex = 0;
            this.tabControl_Side.Size = new System.Drawing.Size(228, 503);
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
            this.tabPage1.Size = new System.Drawing.Size(220, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Description";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(220, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Monsters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.challengeRatingDataGridViewTextBoxColumn,
            this.xPDataGridViewTextBoxColumn,
            this.environmentDataGridViewTextBoxColumn,
            this.npcNameDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn,
            this.srdDataGridViewTextBoxColumn,
            this.monsterTypeDataGridViewTextBoxColumn,
            this.monsterIndexDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.allignmentDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.monsterBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(213, 475);
            this.dataGridView2.TabIndex = 0;
            // 
            // challengeRatingDataGridViewTextBoxColumn
            // 
            this.challengeRatingDataGridViewTextBoxColumn.DataPropertyName = "ChallengeRating";
            this.challengeRatingDataGridViewTextBoxColumn.HeaderText = "ChallengeRating";
            this.challengeRatingDataGridViewTextBoxColumn.Name = "challengeRatingDataGridViewTextBoxColumn";
            // 
            // xPDataGridViewTextBoxColumn
            // 
            this.xPDataGridViewTextBoxColumn.DataPropertyName = "XP";
            this.xPDataGridViewTextBoxColumn.HeaderText = "XP";
            this.xPDataGridViewTextBoxColumn.Name = "xPDataGridViewTextBoxColumn";
            // 
            // environmentDataGridViewTextBoxColumn
            // 
            this.environmentDataGridViewTextBoxColumn.DataPropertyName = "Environment";
            this.environmentDataGridViewTextBoxColumn.HeaderText = "Environment";
            this.environmentDataGridViewTextBoxColumn.Name = "environmentDataGridViewTextBoxColumn";
            // 
            // npcNameDataGridViewTextBoxColumn
            // 
            this.npcNameDataGridViewTextBoxColumn.DataPropertyName = "NpcName";
            this.npcNameDataGridViewTextBoxColumn.HeaderText = "NpcName";
            this.npcNameDataGridViewTextBoxColumn.Name = "npcNameDataGridViewTextBoxColumn";
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            // 
            // pageDataGridViewTextBoxColumn
            // 
            this.pageDataGridViewTextBoxColumn.DataPropertyName = "Page";
            this.pageDataGridViewTextBoxColumn.HeaderText = "Page";
            this.pageDataGridViewTextBoxColumn.Name = "pageDataGridViewTextBoxColumn";
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "Reference";
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            // 
            // srdDataGridViewTextBoxColumn
            // 
            this.srdDataGridViewTextBoxColumn.DataPropertyName = "Srd";
            this.srdDataGridViewTextBoxColumn.HeaderText = "Srd";
            this.srdDataGridViewTextBoxColumn.Name = "srdDataGridViewTextBoxColumn";
            // 
            // monsterTypeDataGridViewTextBoxColumn
            // 
            this.monsterTypeDataGridViewTextBoxColumn.DataPropertyName = "MonsterType";
            this.monsterTypeDataGridViewTextBoxColumn.HeaderText = "MonsterType";
            this.monsterTypeDataGridViewTextBoxColumn.Name = "monsterTypeDataGridViewTextBoxColumn";
            // 
            // monsterIndexDataGridViewTextBoxColumn
            // 
            this.monsterIndexDataGridViewTextBoxColumn.DataPropertyName = "MonsterIndex";
            this.monsterIndexDataGridViewTextBoxColumn.HeaderText = "MonsterIndex";
            this.monsterIndexDataGridViewTextBoxColumn.Name = "monsterIndexDataGridViewTextBoxColumn";
            this.monsterIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // allignmentDataGridViewTextBoxColumn
            // 
            this.allignmentDataGridViewTextBoxColumn.DataPropertyName = "Allignment";
            this.allignmentDataGridViewTextBoxColumn.HeaderText = "Allignment";
            this.allignmentDataGridViewTextBoxColumn.Name = "allignmentDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            // 
            // monsterBindingSource
            // 
           // this.monsterBindingSource.DataSource = typeof(Dungeon_Buddy.Monster);
            // 
            // btn_AddMonsters
            // 
            this.btn_AddMonsters.Location = new System.Drawing.Point(702, 536);
            this.btn_AddMonsters.Name = "btn_AddMonsters";
            this.btn_AddMonsters.Size = new System.Drawing.Size(82, 20);
            this.btn_AddMonsters.TabIndex = 21;
            this.btn_AddMonsters.Text = "Add Selected";
            this.btn_AddMonsters.UseVisualStyleBackColor = true;
            this.btn_AddMonsters.Click += new System.EventHandler(this.btn_AddMonsters_Click);
            // 
            // btn_ClearMonsters
            // 
            this.btn_ClearMonsters.Location = new System.Drawing.Point(790, 536);
            this.btn_ClearMonsters.Name = "btn_ClearMonsters";
            this.btn_ClearMonsters.Size = new System.Drawing.Size(82, 20);
            this.btn_ClearMonsters.TabIndex = 22;
            this.btn_ClearMonsters.Text = "Clear List";
            this.btn_ClearMonsters.UseVisualStyleBackColor = true;
            this.btn_ClearMonsters.Click += new System.EventHandler(this.btn_ClearMonsters_Click);
            // 
            // typeCB
            // 
            this.typeCB.CheckOnClick = true;
            this.typeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.typeCB.DropDownHeight = 1;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.IntegralHeight = false;
            this.typeCB.Location = new System.Drawing.Point(281, 22);
            this.typeCB.MaxDropDownItems = 14;
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(104, 21);
            this.typeCB.TabIndex = 13;
            this.typeCB.Text = "Type";
            this.typeCB.ValueSeparator = ", ";
            this.typeCB.DropDownClosed += new System.EventHandler(this.typeCB_DropDownClosed);
            // 
            // sizeCB
            // 
            this.sizeCB.CheckOnClick = true;
            this.sizeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sizeCB.DropDownHeight = 1;
            this.sizeCB.FormattingEnabled = true;
            this.sizeCB.IntegralHeight = false;
            this.sizeCB.Location = new System.Drawing.Point(182, 22);
            this.sizeCB.MaxDropDownItems = 11;
            this.sizeCB.Name = "sizeCB";
            this.sizeCB.Size = new System.Drawing.Size(93, 21);
            this.sizeCB.TabIndex = 12;
            this.sizeCB.Text = "Size";
            this.sizeCB.ValueSeparator = ", ";
            this.sizeCB.DropDownClosed += new System.EventHandler(this.sizeCB_DropDownClosed);
            // 
            // environmentCB
            // 
            this.environmentCB.CheckOnClick = true;
            this.environmentCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.environmentCB.DropDownHeight = 1;
            this.environmentCB.FormattingEnabled = true;
            this.environmentCB.IntegralHeight = false;
            this.environmentCB.Location = new System.Drawing.Point(391, 22);
            this.environmentCB.MaxDropDownItems = 11;
            this.environmentCB.Name = "environmentCB";
            this.environmentCB.Size = new System.Drawing.Size(104, 21);
            this.environmentCB.TabIndex = 9;
            this.environmentCB.Text = "Environment";
            this.environmentCB.ValueSeparator = ", ";
            this.environmentCB.DropDownClosed += new System.EventHandler(this.environmentCB_DropDownClosed);
            // 
            // MonsterIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btn_ClearMonsters);
            this.Controls.Add(this.btn_AddMonsters);
            this.Controls.Add(this.tabControl_Side);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.UpDown_CR_MAX);
            this.Controls.Add(this.UpDown_CR_MIN);
            this.Controls.Add(this.lbl_filters);
            this.Controls.Add(this.lbl_challenge);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.sizeCB);
            this.Controls.Add(this.environmentCB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MonsterIndexForm";
            this.Text = "Monster Index";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CR_MIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CR_MAX)).EndInit();
            this.tabControl_Side.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox searchTB;
        private CheckComboBoxTest.CheckedComboBox environmentCB;
        private CheckComboBoxTest.CheckedComboBox sizeCB;
        private CheckComboBoxTest.CheckedComboBox typeCB;
        private System.Windows.Forms.Label lbl_challenge;
        private System.Windows.Forms.Label lbl_filters;
        private System.Windows.Forms.NumericUpDown UpDown_CR_MIN;
        private System.Windows.Forms.NumericUpDown UpDown_CR_MAX;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TabControl tabControl_Side;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_AddMonsters;
        private System.Windows.Forms.Button btn_ClearMonsters;
        private System.Windows.Forms.DataGridViewTextBoxColumn challengeRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn environmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn npcNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monsterTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monsterIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource monsterBindingSource;
    }
}

