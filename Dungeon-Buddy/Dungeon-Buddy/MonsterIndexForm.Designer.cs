﻿namespace Dungeon_Buddy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.lbl_challenge = new System.Windows.Forms.Label();
            this.lbl_filters = new System.Windows.Forms.Label();
            this.UpDown_CR_MIN = new System.Windows.Forms.NumericUpDown();
            this.UpDown_CR_MAX = new System.Windows.Forms.NumericUpDown();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.typeCB = new CheckComboBoxTest.CheckedComboBox();
            this.sizeCB = new CheckComboBoxTest.CheckedComboBox();
            this.environmentCB = new CheckComboBoxTest.CheckedComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.tabControl_Side = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAddMonsters = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CR_MIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CR_MAX)).BeginInit();
            this.tabControl_Side.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabPage1.Size = new System.Drawing.Size(220, 481);
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
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(213, 475);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnAddMonsters
            // 
            this.btnAddMonsters.Location = new System.Drawing.Point(702, 536);
            this.btnAddMonsters.Name = "btnAddMonsters";
            this.btnAddMonsters.Size = new System.Drawing.Size(82, 20);
            this.btnAddMonsters.TabIndex = 21;
            this.btnAddMonsters.Text = "Add Selected";
            this.btnAddMonsters.UseVisualStyleBackColor = true;
            this.btnAddMonsters.Click += new System.EventHandler(this.btnAddMonsters_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(790, 536);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(82, 20);
            this.btn_Clear.TabIndex = 22;
            this.btn_Clear.Text = "Clear List";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // MonsterIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btnAddMonsters);
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
        private System.Windows.Forms.Button btnAddMonsters;
        private System.Windows.Forms.Button btn_Clear;
    }
}

