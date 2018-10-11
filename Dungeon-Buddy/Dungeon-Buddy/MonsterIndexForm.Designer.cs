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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.CR_TB1 = new System.Windows.Forms.TextBox();
            this.CR_TB2 = new System.Windows.Forms.TextBox();
            this.lbl_challenge = new System.Windows.Forms.Label();
            this.typeCB = new CheckComboBoxTest.CheckedComboBox();
            this.sizeCB = new CheckComboBoxTest.CheckedComboBox();
            this.environmentCB = new CheckComboBoxTest.CheckedComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(622, 500);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(641, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(231, 500);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(13, 4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(100, 20);
            this.searchTB.TabIndex = 7;
            this.searchTB.Text = "Search";
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            this.searchTB.Enter += new System.EventHandler(this.searchTB_Enter);
            this.searchTB.Leave += new System.EventHandler(this.searchTB_Leave);
            // 
            // CR_TB1
            // 
            this.CR_TB1.Location = new System.Drawing.Point(541, 23);
            this.CR_TB1.Name = "CR_TB1";
            this.CR_TB1.Size = new System.Drawing.Size(44, 20);
            this.CR_TB1.TabIndex = 10;
            this.CR_TB1.Text = "0.00";
            this.CR_TB1.TextChanged += new System.EventHandler(this.CR_TB1_TextChanged);
            // 
            // CR_TB2
            // 
            this.CR_TB2.Location = new System.Drawing.Point(591, 23);
            this.CR_TB2.Name = "CR_TB2";
            this.CR_TB2.Size = new System.Drawing.Size(44, 20);
            this.CR_TB2.TabIndex = 11;
            this.CR_TB2.Text = "100.00";
            this.CR_TB2.TextChanged += new System.EventHandler(this.CR_TB2_TextChanged);
            // 
            // lbl_challenge
            // 
            this.lbl_challenge.AutoSize = true;
            this.lbl_challenge.Location = new System.Drawing.Point(547, 7);
            this.lbl_challenge.Name = "lbl_challenge";
            this.lbl_challenge.Size = new System.Drawing.Size(88, 13);
            this.lbl_challenge.TabIndex = 14;
            this.lbl_challenge.Text = "Challenge Rating";
            // 
            // typeCB
            // 
            this.typeCB.CheckOnClick = true;
            this.typeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.typeCB.DropDownHeight = 1;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.IntegralHeight = false;
            this.typeCB.Location = new System.Drawing.Point(321, 22);
            this.typeCB.MaxDropDownItems = 14;
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(104, 21);
            this.typeCB.TabIndex = 13;
            this.typeCB.Text = "Type";
            this.typeCB.ValueSeparator = ", ";
            // 
            // sizeCB
            // 
            this.sizeCB.CheckOnClick = true;
            this.sizeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sizeCB.DropDownHeight = 1;
            this.sizeCB.FormattingEnabled = true;
            this.sizeCB.IntegralHeight = false;
            this.sizeCB.Location = new System.Drawing.Point(222, 22);
            this.sizeCB.MaxDropDownItems = 11;
            this.sizeCB.Name = "sizeCB";
            this.sizeCB.Size = new System.Drawing.Size(93, 21);
            this.sizeCB.TabIndex = 12;
            this.sizeCB.Text = "Size";
            this.sizeCB.ValueSeparator = ", ";
            // 
            // environmentCB
            // 
            this.environmentCB.CheckOnClick = true;
            this.environmentCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.environmentCB.DropDownHeight = 1;
            this.environmentCB.FormattingEnabled = true;
            this.environmentCB.IntegralHeight = false;
            this.environmentCB.Location = new System.Drawing.Point(431, 22);
            this.environmentCB.MaxDropDownItems = 11;
            this.environmentCB.Name = "environmentCB";
            this.environmentCB.Size = new System.Drawing.Size(104, 21);
            this.environmentCB.TabIndex = 9;
            this.environmentCB.Text = "Environment";
            this.environmentCB.ValueSeparator = ", ";
            // 
            // MonsterIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lbl_challenge);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.sizeCB);
            this.Controls.Add(this.CR_TB2);
            this.Controls.Add(this.CR_TB1);
            this.Controls.Add(this.environmentCB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MonsterIndexForm";
            this.Text = "Monster Index";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox searchTB;
        private CheckComboBoxTest.CheckedComboBox environmentCB;
        private System.Windows.Forms.TextBox CR_TB1;
        private System.Windows.Forms.TextBox CR_TB2;
        private CheckComboBoxTest.CheckedComboBox sizeCB;
        private CheckComboBoxTest.CheckedComboBox typeCB;
        private System.Windows.Forms.Label lbl_challenge;
    }
}

