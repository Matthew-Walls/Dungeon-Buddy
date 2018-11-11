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
            this.lstBoxCampaigns = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioLoad = new System.Windows.Forms.RadioButton();
            this.radioNew = new System.Windows.Forms.RadioButton();
            this.panelNew = new System.Windows.Forms.Panel();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNew.SuspendLayout();
            this.panelLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxCampaigns
            // 
            this.lstBoxCampaigns.FormattingEnabled = true;
            this.lstBoxCampaigns.Location = new System.Drawing.Point(63, 34);
            this.lstBoxCampaigns.Name = "lstBoxCampaigns";
            this.lstBoxCampaigns.Size = new System.Drawing.Size(336, 160);
            this.lstBoxCampaigns.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(177, 211);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 46);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Campaign";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(63, 29);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(336, 20);
            this.txtBoxName.TabIndex = 2;
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(63, 78);
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(336, 91);
            this.txtBoxDesc.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(177, 211);
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
            this.label3.Location = new System.Drawing.Point(168, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Campaign Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 55);
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
            this.radioLoad.TabIndex = 9;
            this.radioLoad.TabStop = true;
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
            this.radioNew.TabIndex = 10;
            this.radioNew.Text = "Create a new campaign...";
            this.radioNew.UseVisualStyleBackColor = true;
            this.radioNew.CheckedChanged += new System.EventHandler(this.radioNew_CheckedChanged);
            // 
            // panelNew
            // 
            this.panelNew.Controls.Add(this.txtBoxDesc);
            this.panelNew.Controls.Add(this.txtBoxName);
            this.panelNew.Controls.Add(this.label3);
            this.panelNew.Controls.Add(this.btnNew);
            this.panelNew.Controls.Add(this.label4);
            this.panelNew.Location = new System.Drawing.Point(12, 93);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(462, 283);
            this.panelNew.TabIndex = 12;
            this.panelNew.Visible = false;
            // 
            // panelLoad
            // 
            this.panelLoad.Controls.Add(this.label1);
            this.panelLoad.Controls.Add(this.lstBoxCampaigns);
            this.panelLoad.Controls.Add(this.btnLoad);
            this.panelLoad.Location = new System.Drawing.Point(12, 93);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(462, 283);
            this.panelLoad.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Campaign List";
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 385);
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
            this.panelNew.ResumeLayout(false);
            this.panelNew.PerformLayout();
            this.panelLoad.ResumeLayout(false);
            this.panelLoad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxCampaigns;
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
    }
}