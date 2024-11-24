
namespace FirstWrite
{
    partial class STRAForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportActiveSTRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ACCTStringArraysLabel = new System.Windows.Forms.Label();
            this.ACCTStringArrays = new System.Windows.Forms.ListBox();
            this.STRAStringsLabel = new System.Windows.Forms.Label();
            this.STRAStrings = new System.Windows.Forms.ListBox();
            this.STRAStringBox = new System.Windows.Forms.TextBox();
            this.STRAStringLabel = new System.Windows.Forms.Label();
            this.STRAIdLabel = new System.Windows.Forms.Label();
            this.STRAStringId = new System.Windows.Forms.TextBox();
            this.STRAExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.AddSTRA = new System.Windows.Forms.Button();
            this.RemoveSTRA = new System.Windows.Forms.Button();
            this.RemoveString = new System.Windows.Forms.Button();
            this.AddString = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportActiveSTRAToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportActiveSTRAToolStripMenuItem
            // 
            this.exportActiveSTRAToolStripMenuItem.Name = "exportActiveSTRAToolStripMenuItem";
            this.exportActiveSTRAToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exportActiveSTRAToolStripMenuItem.Text = "Export Active STRA";
            this.exportActiveSTRAToolStripMenuItem.Click += new System.EventHandler(this.exportActiveSTRAToolStripMenuItem_Click);
            // 
            // ACCTStringArraysLabel
            // 
            this.ACCTStringArraysLabel.AutoSize = true;
            this.ACCTStringArraysLabel.Location = new System.Drawing.Point(13, 28);
            this.ACCTStringArraysLabel.Name = "ACCTStringArraysLabel";
            this.ACCTStringArraysLabel.Size = new System.Drawing.Size(69, 13);
            this.ACCTStringArraysLabel.TabIndex = 1;
            this.ACCTStringArraysLabel.Text = "String Arrays:";
            // 
            // ACCTStringArrays
            // 
            this.ACCTStringArrays.FormattingEnabled = true;
            this.ACCTStringArrays.Location = new System.Drawing.Point(13, 45);
            this.ACCTStringArrays.Name = "ACCTStringArrays";
            this.ACCTStringArrays.Size = new System.Drawing.Size(120, 173);
            this.ACCTStringArrays.TabIndex = 2;
            this.ACCTStringArrays.SelectedIndexChanged += new System.EventHandler(this.ACCTStringArrays_SelectedIndexChanged);
            // 
            // STRAStringsLabel
            // 
            this.STRAStringsLabel.AutoSize = true;
            this.STRAStringsLabel.Location = new System.Drawing.Point(157, 28);
            this.STRAStringsLabel.Name = "STRAStringsLabel";
            this.STRAStringsLabel.Size = new System.Drawing.Size(42, 13);
            this.STRAStringsLabel.TabIndex = 3;
            this.STRAStringsLabel.Text = "Strings:";
            // 
            // STRAStrings
            // 
            this.STRAStrings.FormattingEnabled = true;
            this.STRAStrings.Location = new System.Drawing.Point(160, 44);
            this.STRAStrings.Name = "STRAStrings";
            this.STRAStrings.Size = new System.Drawing.Size(120, 173);
            this.STRAStrings.TabIndex = 4;
            this.STRAStrings.SelectedIndexChanged += new System.EventHandler(this.STRAStrings_SelectedIndexChanged);
            // 
            // STRAStringBox
            // 
            this.STRAStringBox.Location = new System.Drawing.Point(285, 100);
            this.STRAStringBox.Multiline = true;
            this.STRAStringBox.Name = "STRAStringBox";
            this.STRAStringBox.Size = new System.Drawing.Size(203, 117);
            this.STRAStringBox.TabIndex = 5;
            this.STRAStringBox.TextChanged += new System.EventHandler(this.STRAStringBox_TextChanged);
            // 
            // STRAStringLabel
            // 
            this.STRAStringLabel.AutoSize = true;
            this.STRAStringLabel.Location = new System.Drawing.Point(286, 84);
            this.STRAStringLabel.Name = "STRAStringLabel";
            this.STRAStringLabel.Size = new System.Drawing.Size(37, 13);
            this.STRAStringLabel.TabIndex = 6;
            this.STRAStringLabel.Text = "String:";
            // 
            // STRAIdLabel
            // 
            this.STRAIdLabel.AutoSize = true;
            this.STRAIdLabel.Location = new System.Drawing.Point(286, 45);
            this.STRAIdLabel.Name = "STRAIdLabel";
            this.STRAIdLabel.Size = new System.Drawing.Size(51, 13);
            this.STRAIdLabel.TabIndex = 8;
            this.STRAIdLabel.Text = "String ID:";
            // 
            // STRAStringId
            // 
            this.STRAStringId.Location = new System.Drawing.Point(285, 61);
            this.STRAStringId.MaxLength = 10;
            this.STRAStringId.Name = "STRAStringId";
            this.STRAStringId.Size = new System.Drawing.Size(67, 20);
            this.STRAStringId.TabIndex = 7;
            this.STRAStringId.TextChanged += new System.EventHandler(this.STRAStringId_TextChanged);
            // 
            // AddSTRA
            // 
            this.AddSTRA.Location = new System.Drawing.Point(13, 224);
            this.AddSTRA.Name = "AddSTRA";
            this.AddSTRA.Size = new System.Drawing.Size(54, 23);
            this.AddSTRA.TabIndex = 9;
            this.AddSTRA.Text = "Add";
            this.AddSTRA.UseVisualStyleBackColor = true;
            this.AddSTRA.Click += new System.EventHandler(this.AddSTRA_Click);
            // 
            // RemoveSTRA
            // 
            this.RemoveSTRA.Location = new System.Drawing.Point(73, 224);
            this.RemoveSTRA.Name = "RemoveSTRA";
            this.RemoveSTRA.Size = new System.Drawing.Size(60, 23);
            this.RemoveSTRA.TabIndex = 10;
            this.RemoveSTRA.Text = "Remove";
            this.RemoveSTRA.UseVisualStyleBackColor = true;
            this.RemoveSTRA.Click += new System.EventHandler(this.RemoveSTRA_Click);
            // 
            // RemoveString
            // 
            this.RemoveString.Location = new System.Drawing.Point(220, 224);
            this.RemoveString.Name = "RemoveString";
            this.RemoveString.Size = new System.Drawing.Size(60, 23);
            this.RemoveString.TabIndex = 12;
            this.RemoveString.Text = "Remove";
            this.RemoveString.UseVisualStyleBackColor = true;
            this.RemoveString.Click += new System.EventHandler(this.RemoveString_Click);
            // 
            // AddString
            // 
            this.AddString.Location = new System.Drawing.Point(160, 224);
            this.AddString.Name = "AddString";
            this.AddString.Size = new System.Drawing.Size(54, 23);
            this.AddString.TabIndex = 11;
            this.AddString.Text = "Add";
            this.AddString.UseVisualStyleBackColor = true;
            this.AddString.Click += new System.EventHandler(this.AddString_Click);
            // 
            // STRAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 254);
            this.Controls.Add(this.RemoveString);
            this.Controls.Add(this.AddString);
            this.Controls.Add(this.RemoveSTRA);
            this.Controls.Add(this.AddSTRA);
            this.Controls.Add(this.STRAIdLabel);
            this.Controls.Add(this.STRAStringId);
            this.Controls.Add(this.STRAStringLabel);
            this.Controls.Add(this.STRAStringBox);
            this.Controls.Add(this.STRAStrings);
            this.Controls.Add(this.STRAStringsLabel);
            this.Controls.Add(this.ACCTStringArrays);
            this.Controls.Add(this.ACCTStringArraysLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "STRAForm";
            this.Text = "STRAForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportActiveSTRAToolStripMenuItem;
        private System.Windows.Forms.Label ACCTStringArraysLabel;
        private System.Windows.Forms.ListBox ACCTStringArrays;
        private System.Windows.Forms.Label STRAStringsLabel;
        private System.Windows.Forms.ListBox STRAStrings;
        private System.Windows.Forms.TextBox STRAStringBox;
        private System.Windows.Forms.Label STRAStringLabel;
        private System.Windows.Forms.Label STRAIdLabel;
        private System.Windows.Forms.TextBox STRAStringId;
        private System.Windows.Forms.SaveFileDialog STRAExportDialog;
        private System.Windows.Forms.Button AddSTRA;
        private System.Windows.Forms.Button RemoveSTRA;
        private System.Windows.Forms.Button RemoveString;
        private System.Windows.Forms.Button AddString;
    }
}