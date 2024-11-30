namespace FirstWrite
{
    partial class CostumeEditorForm
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
            this.Costumes = new System.Windows.Forms.ListBox();
            this.CostumeItems = new System.Windows.Forms.ListBox();
            this.CostumesLabel = new System.Windows.Forms.Label();
            this.CostumeItemsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddCostumeButton = new System.Windows.Forms.Button();
            this.RemoveCostumeButton = new System.Windows.Forms.Button();
            this.CostumeIDLabel = new System.Windows.Forms.Label();
            this.CostumeID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Costumes
            // 
            this.Costumes.FormattingEnabled = true;
            this.Costumes.ItemHeight = 12;
            this.Costumes.Items.AddRange(new object[] {
            ""});
            this.Costumes.Location = new System.Drawing.Point(14, 24);
            this.Costumes.Name = "Costumes";
            this.Costumes.Size = new System.Drawing.Size(120, 304);
            this.Costumes.TabIndex = 0;
            this.Costumes.SelectedIndexChanged += new System.EventHandler(this.Costumes_SelectedIndexChanged);
            // 
            // CostumeItems
            // 
            this.CostumeItems.FormattingEnabled = true;
            this.CostumeItems.ItemHeight = 12;
            this.CostumeItems.Location = new System.Drawing.Point(140, 24);
            this.CostumeItems.Name = "CostumeItems";
            this.CostumeItems.Size = new System.Drawing.Size(120, 304);
            this.CostumeItems.TabIndex = 0;
            this.CostumeItems.SelectedIndexChanged += new System.EventHandler(this.CostumeItems_SelectedIndexChanged);
            // 
            // CostumesLabel
            // 
            this.CostumesLabel.AutoSize = true;
            this.CostumesLabel.Location = new System.Drawing.Point(12, 9);
            this.CostumesLabel.Name = "CostumesLabel";
            this.CostumesLabel.Size = new System.Drawing.Size(56, 12);
            this.CostumesLabel.TabIndex = 1;
            this.CostumesLabel.Text = "Costumes";
            // 
            // CostumeItemsLabel
            // 
            this.CostumeItemsLabel.AutoSize = true;
            this.CostumeItemsLabel.Location = new System.Drawing.Point(138, 9);
            this.CostumeItemsLabel.Name = "CostumeItemsLabel";
            this.CostumeItemsLabel.Size = new System.Drawing.Size(82, 12);
            this.CostumeItemsLabel.TabIndex = 1;
            this.CostumeItemsLabel.Text = "Costume Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Number";
            // 
            // ItemNumberTextBox
            // 
            this.ItemNumberTextBox.Location = new System.Drawing.Point(268, 39);
            this.ItemNumberTextBox.Name = "ItemNumberTextBox";
            this.ItemNumberTextBox.Size = new System.Drawing.Size(172, 19);
            this.ItemNumberTextBox.TabIndex = 3;
            this.ItemNumberTextBox.TextChanged += new System.EventHandler(this.ItemNumberTextBox_TextChanged);
            // 
            // AddCostumeButton
            // 
            this.AddCostumeButton.Location = new System.Drawing.Point(14, 334);
            this.AddCostumeButton.Name = "AddCostumeButton";
            this.AddCostumeButton.Size = new System.Drawing.Size(120, 23);
            this.AddCostumeButton.TabIndex = 4;
            this.AddCostumeButton.Text = "Add";
            this.AddCostumeButton.UseVisualStyleBackColor = true;
            this.AddCostumeButton.Click += new System.EventHandler(this.AddCostumeButton_Click);
            // 
            // RemoveCostumeButton
            // 
            this.RemoveCostumeButton.Location = new System.Drawing.Point(14, 363);
            this.RemoveCostumeButton.Name = "RemoveCostumeButton";
            this.RemoveCostumeButton.Size = new System.Drawing.Size(120, 23);
            this.RemoveCostumeButton.TabIndex = 4;
            this.RemoveCostumeButton.Text = "Remove";
            this.RemoveCostumeButton.UseVisualStyleBackColor = true;
            this.RemoveCostumeButton.Click += new System.EventHandler(this.RemoveCostumeButton_Click);
            // 
            // CostumeIDLabel
            // 
            this.CostumeIDLabel.AutoSize = true;
            this.CostumeIDLabel.Location = new System.Drawing.Point(267, 65);
            this.CostumeIDLabel.Name = "CostumeIDLabel";
            this.CostumeIDLabel.Size = new System.Drawing.Size(65, 12);
            this.CostumeIDLabel.TabIndex = 5;
            this.CostumeIDLabel.Text = "Costume ID";
            // 
            // CostumeID
            // 
            this.CostumeID.Location = new System.Drawing.Point(268, 81);
            this.CostumeID.Name = "CostumeID";
            this.CostumeID.Size = new System.Drawing.Size(170, 19);
            this.CostumeID.TabIndex = 6;
            this.CostumeID.TextChanged += new System.EventHandler(this.CostumeID_TextChanged);
            // 
            // CostumeEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 388);
            this.Controls.Add(this.CostumeID);
            this.Controls.Add(this.CostumeIDLabel);
            this.Controls.Add(this.RemoveCostumeButton);
            this.Controls.Add(this.AddCostumeButton);
            this.Controls.Add(this.ItemNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CostumeItemsLabel);
            this.Controls.Add(this.CostumesLabel);
            this.Controls.Add(this.CostumeItems);
            this.Controls.Add(this.Costumes);
            this.Name = "CostumeEditorForm";
            this.Text = "CostumeEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Costumes;
        private System.Windows.Forms.ListBox CostumeItems;
        private System.Windows.Forms.Label CostumesLabel;
        private System.Windows.Forms.Label CostumeItemsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemNumberTextBox;
        private System.Windows.Forms.Button AddCostumeButton;
        private System.Windows.Forms.Button RemoveCostumeButton;
        private System.Windows.Forms.Label CostumeIDLabel;
        private System.Windows.Forms.TextBox CostumeID;
    }
}