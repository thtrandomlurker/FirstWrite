
namespace FirstWrite
{
    partial class RBDBForm
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
            this.ExportActiveRobDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterItemEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomizeItemEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.ACCTRobDatabases = new System.Windows.Forms.ListBox();
            this.RBDBExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.AddRBDBButton = new System.Windows.Forms.Button();
            this.RemoveRBDBButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(160, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportActiveRobDatabase});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ExportActiveRobDatabase
            // 
            this.ExportActiveRobDatabase.Name = "ExportActiveRobDatabase";
            this.ExportActiveRobDatabase.Size = new System.Drawing.Size(176, 22);
            this.ExportActiveRobDatabase.Text = "Export Active RBDB";
            this.ExportActiveRobDatabase.Click += new System.EventHandler(this.ExportActiveRobDatabase_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CharacterItemEditor,
            this.CustomizeItemEditor});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // CharacterItemEditor
            // 
            this.CharacterItemEditor.Name = "CharacterItemEditor";
            this.CharacterItemEditor.Size = new System.Drawing.Size(188, 22);
            this.CharacterItemEditor.Text = "Character Item Editor";
            this.CharacterItemEditor.Click += new System.EventHandler(this.CharacterItemEditor_Click);
            // 
            // CustomizeItemEditor
            // 
            this.CustomizeItemEditor.Name = "CustomizeItemEditor";
            this.CustomizeItemEditor.Size = new System.Drawing.Size(188, 22);
            this.CustomizeItemEditor.Text = "Customize Item Editor";
            // 
            // ACCTRobDatabases
            // 
            this.ACCTRobDatabases.FormattingEnabled = true;
            this.ACCTRobDatabases.ItemHeight = 12;
            this.ACCTRobDatabases.Location = new System.Drawing.Point(14, 26);
            this.ACCTRobDatabases.Name = "ACCTRobDatabases";
            this.ACCTRobDatabases.Size = new System.Drawing.Size(130, 124);
            this.ACCTRobDatabases.TabIndex = 1;
            // 
            // AddRBDBButton
            // 
            this.AddRBDBButton.Location = new System.Drawing.Point(14, 156);
            this.AddRBDBButton.Name = "AddRBDBButton";
            this.AddRBDBButton.Size = new System.Drawing.Size(130, 23);
            this.AddRBDBButton.TabIndex = 2;
            this.AddRBDBButton.Text = "Add";
            this.AddRBDBButton.UseVisualStyleBackColor = true;
            this.AddRBDBButton.Click += new System.EventHandler(this.AddRBDBButton_Click);
            // 
            // RemoveRBDBButton
            // 
            this.RemoveRBDBButton.Location = new System.Drawing.Point(14, 185);
            this.RemoveRBDBButton.Name = "RemoveRBDBButton";
            this.RemoveRBDBButton.Size = new System.Drawing.Size(130, 23);
            this.RemoveRBDBButton.TabIndex = 2;
            this.RemoveRBDBButton.Text = "Remove";
            this.RemoveRBDBButton.UseVisualStyleBackColor = true;
            this.RemoveRBDBButton.Click += new System.EventHandler(this.RemoveRBDBButton_Click);
            // 
            // RBDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 225);
            this.Controls.Add(this.RemoveRBDBButton);
            this.Controls.Add(this.AddRBDBButton);
            this.Controls.Add(this.ACCTRobDatabases);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RBDBForm";
            this.Text = "RBDBForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportActiveRobDatabase;
        private System.Windows.Forms.ListBox ACCTRobDatabases;
        private System.Windows.Forms.SaveFileDialog RBDBExportDialog;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CharacterItemEditor;
        private System.Windows.Forms.ToolStripMenuItem CustomizeItemEditor;
        private System.Windows.Forms.Button AddRBDBButton;
        private System.Windows.Forms.Button RemoveRBDBButton;
    }
}