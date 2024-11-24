
namespace FirstWrite
{
    partial class CharacterItemEditorForm
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
            this.CharacterItemTables = new System.Windows.Forms.ListBox();
            this.KeepInFile = new System.Windows.Forms.CheckBox();
            this.ItemButton = new System.Windows.Forms.Button();
            this.CostumeButton = new System.Windows.Forms.Button();
            this.AdjustButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CharacterItemTables
            // 
            this.CharacterItemTables.FormattingEnabled = true;
            this.CharacterItemTables.Items.AddRange(new object[] {
            "Miku",
            "Rin",
            "Len",
            "Luka",
            "Neru",
            "Haku",
            "Kaito",
            "Meiko",
            "Sakine",
            "Teto"});
            this.CharacterItemTables.Location = new System.Drawing.Point(12, 35);
            this.CharacterItemTables.Name = "CharacterItemTables";
            this.CharacterItemTables.Size = new System.Drawing.Size(194, 134);
            this.CharacterItemTables.TabIndex = 0;
            this.CharacterItemTables.SelectedIndexChanged += new System.EventHandler(this.CharacterItems_SelectedIndexChanged);
            // 
            // KeepInFile
            // 
            this.KeepInFile.AutoSize = true;
            this.KeepInFile.Location = new System.Drawing.Point(12, 12);
            this.KeepInFile.Name = "KeepInFile";
            this.KeepInFile.Size = new System.Drawing.Size(82, 17);
            this.KeepInFile.TabIndex = 1;
            this.KeepInFile.Text = "Keep In File";
            this.KeepInFile.UseVisualStyleBackColor = true;
            // 
            // ItemButton
            // 
            this.ItemButton.Location = new System.Drawing.Point(12, 175);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(61, 23);
            this.ItemButton.TabIndex = 2;
            this.ItemButton.Text = "Items";
            this.ItemButton.UseVisualStyleBackColor = true;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // CostumeButton
            // 
            this.CostumeButton.Location = new System.Drawing.Point(145, 175);
            this.CostumeButton.Name = "CostumeButton";
            this.CostumeButton.Size = new System.Drawing.Size(61, 23);
            this.CostumeButton.TabIndex = 3;
            this.CostumeButton.Text = "Costumes";
            this.CostumeButton.UseVisualStyleBackColor = true;
            // 
            // AdjustButton
            // 
            this.AdjustButton.Location = new System.Drawing.Point(78, 175);
            this.AdjustButton.Name = "AdjustButton";
            this.AdjustButton.Size = new System.Drawing.Size(61, 23);
            this.AdjustButton.TabIndex = 4;
            this.AdjustButton.Text = "Adjusts";
            this.AdjustButton.UseVisualStyleBackColor = true;
            // 
            // CharacterItemEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 208);
            this.Controls.Add(this.AdjustButton);
            this.Controls.Add(this.CostumeButton);
            this.Controls.Add(this.ItemButton);
            this.Controls.Add(this.KeepInFile);
            this.Controls.Add(this.CharacterItemTables);
            this.Name = "CharacterItemEditorForm";
            this.Text = "CharacterItemEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CharacterItemTables;
        private System.Windows.Forms.CheckBox KeepInFile;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button CostumeButton;
        private System.Windows.Forms.Button AdjustButton;
    }
}