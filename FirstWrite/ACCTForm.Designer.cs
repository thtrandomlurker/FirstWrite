
namespace FirstWrite
{
    partial class ACCTForm
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
            this.ACCTNameLabel = new System.Windows.Forms.Label();
            this.ACCTPaths = new System.Windows.Forms.ListBox();
            this.ACCTPathsLabel = new System.Windows.Forms.Label();
            this.ACCTMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ACCTFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ACCTExportMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ACCTCloseMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringArrayEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robDatabaseEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterDatabaseEditorUnderConstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ACCTPathLabel = new System.Windows.Forms.Label();
            this.ACCTPath = new System.Windows.Forms.TextBox();
            this.ACCTFile = new System.Windows.Forms.TextBox();
            this.ACCTFileLabel = new System.Windows.Forms.Label();
            this.ACCTExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.ACCTPathsAddButton = new System.Windows.Forms.Button();
            this.ACCTPathsRemove = new System.Windows.Forms.Button();
            this.ACCTAuth2DFlist = new System.Windows.Forms.ListBox();
            this.ACCTAuth2DFlistLabel = new System.Windows.Forms.Label();
            this.ACCTAuth2DFlistRemoveButton = new System.Windows.Forms.Button();
            this.ACCTAuth2DFlistAddButton = new System.Windows.Forms.Button();
            this.ACCTAuth2DFile = new System.Windows.Forms.TextBox();
            this.ACCTAuth2DFileLabel = new System.Windows.Forms.Label();
            this.ACCTObjsetFile = new System.Windows.Forms.TextBox();
            this.ACCTObjsetFileLabel = new System.Windows.Forms.Label();
            this.ACCTObjsetFlistRemoveButton = new System.Windows.Forms.Button();
            this.ACCTObjsetFlistAddButton = new System.Windows.Forms.Button();
            this.ACCTObjsetFlistLabel = new System.Windows.Forms.Label();
            this.ACCTObjsetFlist = new System.Windows.Forms.ListBox();
            this.ACCTContainerIDLabel = new System.Windows.Forms.Label();
            this.ACCTContainerID = new System.Windows.Forms.TextBox();
            this.ACCTMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ACCTNameLabel
            // 
            this.ACCTNameLabel.AutoSize = true;
            this.ACCTNameLabel.Location = new System.Drawing.Point(12, 24);
            this.ACCTNameLabel.Name = "ACCTNameLabel";
            this.ACCTNameLabel.Size = new System.Drawing.Size(0, 13);
            this.ACCTNameLabel.TabIndex = 0;
            // 
            // ACCTPaths
            // 
            this.ACCTPaths.FormattingEnabled = true;
            this.ACCTPaths.Location = new System.Drawing.Point(12, 68);
            this.ACCTPaths.Name = "ACCTPaths";
            this.ACCTPaths.Size = new System.Drawing.Size(156, 160);
            this.ACCTPaths.TabIndex = 1;
            this.ACCTPaths.SelectedIndexChanged += new System.EventHandler(this.ACCTPaths_SelectedIndexChanged);
            // 
            // ACCTPathsLabel
            // 
            this.ACCTPathsLabel.AutoSize = true;
            this.ACCTPathsLabel.Location = new System.Drawing.Point(11, 52);
            this.ACCTPathsLabel.Name = "ACCTPathsLabel";
            this.ACCTPathsLabel.Size = new System.Drawing.Size(37, 13);
            this.ACCTPathsLabel.TabIndex = 2;
            this.ACCTPathsLabel.Text = "Paths:";
            // 
            // ACCTMenuStrip
            // 
            this.ACCTMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ACCTFileMenu,
            this.editToolStripMenuItem});
            this.ACCTMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ACCTMenuStrip.Name = "ACCTMenuStrip";
            this.ACCTMenuStrip.Size = new System.Drawing.Size(929, 24);
            this.ACCTMenuStrip.TabIndex = 3;
            this.ACCTMenuStrip.Text = "menuStrip1";
            // 
            // ACCTFileMenu
            // 
            this.ACCTFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ACCTExportMenuOption,
            this.toolStripSeparator1,
            this.ACCTCloseMenuOption});
            this.ACCTFileMenu.Name = "ACCTFileMenu";
            this.ACCTFileMenu.Size = new System.Drawing.Size(37, 20);
            this.ACCTFileMenu.Text = "File";
            // 
            // ACCTExportMenuOption
            // 
            this.ACCTExportMenuOption.Name = "ACCTExportMenuOption";
            this.ACCTExportMenuOption.Size = new System.Drawing.Size(107, 22);
            this.ACCTExportMenuOption.Text = "Export";
            this.ACCTExportMenuOption.Click += new System.EventHandler(this.ACCTExportMenuOption_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // ACCTCloseMenuOption
            // 
            this.ACCTCloseMenuOption.Name = "ACCTCloseMenuOption";
            this.ACCTCloseMenuOption.Size = new System.Drawing.Size(107, 22);
            this.ACCTCloseMenuOption.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringArrayEditorToolStripMenuItem,
            this.robDatabaseEditorToolStripMenuItem,
            this.parameterDatabaseEditorUnderConstructionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // stringArrayEditorToolStripMenuItem
            // 
            this.stringArrayEditorToolStripMenuItem.Name = "stringArrayEditorToolStripMenuItem";
            this.stringArrayEditorToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.stringArrayEditorToolStripMenuItem.Text = "String Array Editor";
            this.stringArrayEditorToolStripMenuItem.Click += new System.EventHandler(this.stringArrayEditorToolStripMenuItem_Click);
            // 
            // robDatabaseEditorToolStripMenuItem
            // 
            this.robDatabaseEditorToolStripMenuItem.Name = "robDatabaseEditorToolStripMenuItem";
            this.robDatabaseEditorToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.robDatabaseEditorToolStripMenuItem.Text = "Rob Database Editor";
            this.robDatabaseEditorToolStripMenuItem.Click += new System.EventHandler(this.robDatabaseEditorToolStripMenuItem_Click);
            // 
            // parameterDatabaseEditorUnderConstructionToolStripMenuItem
            // 
            this.parameterDatabaseEditorUnderConstructionToolStripMenuItem.Name = "parameterDatabaseEditorUnderConstructionToolStripMenuItem";
            this.parameterDatabaseEditorUnderConstructionToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.parameterDatabaseEditorUnderConstructionToolStripMenuItem.Text = "Parameter Database Editor (Under Construction)";
            // 
            // ACCTPathLabel
            // 
            this.ACCTPathLabel.AutoSize = true;
            this.ACCTPathLabel.Location = new System.Drawing.Point(174, 68);
            this.ACCTPathLabel.Name = "ACCTPathLabel";
            this.ACCTPathLabel.Size = new System.Drawing.Size(32, 13);
            this.ACCTPathLabel.TabIndex = 4;
            this.ACCTPathLabel.Text = "Path:";
            // 
            // ACCTPath
            // 
            this.ACCTPath.Location = new System.Drawing.Point(173, 84);
            this.ACCTPath.Name = "ACCTPath";
            this.ACCTPath.Size = new System.Drawing.Size(137, 20);
            this.ACCTPath.TabIndex = 5;
            this.ACCTPath.TextChanged += new System.EventHandler(this.ACCTPath_TextChanged);
            // 
            // ACCTFile
            // 
            this.ACCTFile.Location = new System.Drawing.Point(173, 123);
            this.ACCTFile.Name = "ACCTFile";
            this.ACCTFile.Size = new System.Drawing.Size(137, 20);
            this.ACCTFile.TabIndex = 7;
            this.ACCTFile.TextChanged += new System.EventHandler(this.ACCTFile_TextChanged);
            // 
            // ACCTFileLabel
            // 
            this.ACCTFileLabel.AutoSize = true;
            this.ACCTFileLabel.Location = new System.Drawing.Point(174, 107);
            this.ACCTFileLabel.Name = "ACCTFileLabel";
            this.ACCTFileLabel.Size = new System.Drawing.Size(26, 13);
            this.ACCTFileLabel.TabIndex = 6;
            this.ACCTFileLabel.Text = "File:";
            // 
            // ACCTExportDialog
            // 
            this.ACCTExportDialog.Title = "Save as...";
            // 
            // ACCTPathsAddButton
            // 
            this.ACCTPathsAddButton.Location = new System.Drawing.Point(12, 234);
            this.ACCTPathsAddButton.Name = "ACCTPathsAddButton";
            this.ACCTPathsAddButton.Size = new System.Drawing.Size(75, 23);
            this.ACCTPathsAddButton.TabIndex = 8;
            this.ACCTPathsAddButton.Text = "Add";
            this.ACCTPathsAddButton.UseVisualStyleBackColor = true;
            this.ACCTPathsAddButton.Click += new System.EventHandler(this.ACCTPathsAddButton_Click);
            // 
            // ACCTPathsRemove
            // 
            this.ACCTPathsRemove.Location = new System.Drawing.Point(93, 234);
            this.ACCTPathsRemove.Name = "ACCTPathsRemove";
            this.ACCTPathsRemove.Size = new System.Drawing.Size(75, 23);
            this.ACCTPathsRemove.TabIndex = 9;
            this.ACCTPathsRemove.Text = "Remove";
            this.ACCTPathsRemove.UseVisualStyleBackColor = true;
            this.ACCTPathsRemove.Click += new System.EventHandler(this.ACCTPathsRemove_Click);
            // 
            // ACCTAuth2DFlist
            // 
            this.ACCTAuth2DFlist.FormattingEnabled = true;
            this.ACCTAuth2DFlist.Location = new System.Drawing.Point(316, 68);
            this.ACCTAuth2DFlist.Name = "ACCTAuth2DFlist";
            this.ACCTAuth2DFlist.Size = new System.Drawing.Size(155, 160);
            this.ACCTAuth2DFlist.TabIndex = 10;
            this.ACCTAuth2DFlist.SelectedIndexChanged += new System.EventHandler(this.ACCTAuth2DFlist_SelectedIndexChanged);
            // 
            // ACCTAuth2DFlistLabel
            // 
            this.ACCTAuth2DFlistLabel.AutoSize = true;
            this.ACCTAuth2DFlistLabel.Location = new System.Drawing.Point(313, 52);
            this.ACCTAuth2DFlistLabel.Name = "ACCTAuth2DFlistLabel";
            this.ACCTAuth2DFlistLabel.Size = new System.Drawing.Size(84, 13);
            this.ACCTAuth2DFlistLabel.TabIndex = 11;
            this.ACCTAuth2DFlistLabel.Text = "Auth2D File List:";
            // 
            // ACCTAuth2DFlistRemoveButton
            // 
            this.ACCTAuth2DFlistRemoveButton.Location = new System.Drawing.Point(396, 234);
            this.ACCTAuth2DFlistRemoveButton.Name = "ACCTAuth2DFlistRemoveButton";
            this.ACCTAuth2DFlistRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.ACCTAuth2DFlistRemoveButton.TabIndex = 13;
            this.ACCTAuth2DFlistRemoveButton.Text = "Remove";
            this.ACCTAuth2DFlistRemoveButton.UseVisualStyleBackColor = true;
            this.ACCTAuth2DFlistRemoveButton.Click += new System.EventHandler(this.ACCTAuth2DFlistRemoveButton_Click);
            // 
            // ACCTAuth2DFlistAddButton
            // 
            this.ACCTAuth2DFlistAddButton.Location = new System.Drawing.Point(316, 234);
            this.ACCTAuth2DFlistAddButton.Name = "ACCTAuth2DFlistAddButton";
            this.ACCTAuth2DFlistAddButton.Size = new System.Drawing.Size(75, 23);
            this.ACCTAuth2DFlistAddButton.TabIndex = 12;
            this.ACCTAuth2DFlistAddButton.Text = "Add";
            this.ACCTAuth2DFlistAddButton.UseVisualStyleBackColor = true;
            this.ACCTAuth2DFlistAddButton.Click += new System.EventHandler(this.ACCTAuth2DFlistAddButton_Click);
            // 
            // ACCTAuth2DFile
            // 
            this.ACCTAuth2DFile.Location = new System.Drawing.Point(476, 84);
            this.ACCTAuth2DFile.Name = "ACCTAuth2DFile";
            this.ACCTAuth2DFile.Size = new System.Drawing.Size(137, 20);
            this.ACCTAuth2DFile.TabIndex = 15;
            this.ACCTAuth2DFile.TextChanged += new System.EventHandler(this.ACCTAuth2DFile_TextChanged);
            // 
            // ACCTAuth2DFileLabel
            // 
            this.ACCTAuth2DFileLabel.AutoSize = true;
            this.ACCTAuth2DFileLabel.Location = new System.Drawing.Point(477, 68);
            this.ACCTAuth2DFileLabel.Name = "ACCTAuth2DFileLabel";
            this.ACCTAuth2DFileLabel.Size = new System.Drawing.Size(26, 13);
            this.ACCTAuth2DFileLabel.TabIndex = 14;
            this.ACCTAuth2DFileLabel.Text = "File:";
            // 
            // ACCTObjsetFile
            // 
            this.ACCTObjsetFile.Location = new System.Drawing.Point(779, 84);
            this.ACCTObjsetFile.Name = "ACCTObjsetFile";
            this.ACCTObjsetFile.Size = new System.Drawing.Size(137, 20);
            this.ACCTObjsetFile.TabIndex = 21;
            this.ACCTObjsetFile.TextChanged += new System.EventHandler(this.ACCTObjsetFile_TextChanged);
            // 
            // ACCTObjsetFileLabel
            // 
            this.ACCTObjsetFileLabel.AutoSize = true;
            this.ACCTObjsetFileLabel.Location = new System.Drawing.Point(780, 68);
            this.ACCTObjsetFileLabel.Name = "ACCTObjsetFileLabel";
            this.ACCTObjsetFileLabel.Size = new System.Drawing.Size(26, 13);
            this.ACCTObjsetFileLabel.TabIndex = 20;
            this.ACCTObjsetFileLabel.Text = "File:";
            // 
            // ACCTObjsetFlistRemoveButton
            // 
            this.ACCTObjsetFlistRemoveButton.Location = new System.Drawing.Point(699, 234);
            this.ACCTObjsetFlistRemoveButton.Name = "ACCTObjsetFlistRemoveButton";
            this.ACCTObjsetFlistRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.ACCTObjsetFlistRemoveButton.TabIndex = 19;
            this.ACCTObjsetFlistRemoveButton.Text = "Remove";
            this.ACCTObjsetFlistRemoveButton.UseVisualStyleBackColor = true;
            this.ACCTObjsetFlistRemoveButton.Click += new System.EventHandler(this.ACCTObjsetFlistRemoveButton_Click);
            // 
            // ACCTObjsetFlistAddButton
            // 
            this.ACCTObjsetFlistAddButton.Location = new System.Drawing.Point(619, 234);
            this.ACCTObjsetFlistAddButton.Name = "ACCTObjsetFlistAddButton";
            this.ACCTObjsetFlistAddButton.Size = new System.Drawing.Size(75, 23);
            this.ACCTObjsetFlistAddButton.TabIndex = 18;
            this.ACCTObjsetFlistAddButton.Text = "Add";
            this.ACCTObjsetFlistAddButton.UseVisualStyleBackColor = true;
            this.ACCTObjsetFlistAddButton.Click += new System.EventHandler(this.ACCTObjsetFlistAddButton_Click);
            // 
            // ACCTObjsetFlistLabel
            // 
            this.ACCTObjsetFlistLabel.AutoSize = true;
            this.ACCTObjsetFlistLabel.Location = new System.Drawing.Point(616, 52);
            this.ACCTObjsetFlistLabel.Name = "ACCTObjsetFlistLabel";
            this.ACCTObjsetFlistLabel.Size = new System.Drawing.Size(78, 13);
            this.ACCTObjsetFlistLabel.TabIndex = 17;
            this.ACCTObjsetFlistLabel.Text = "Objset File List:";
            // 
            // ACCTObjsetFlist
            // 
            this.ACCTObjsetFlist.FormattingEnabled = true;
            this.ACCTObjsetFlist.Location = new System.Drawing.Point(619, 68);
            this.ACCTObjsetFlist.Name = "ACCTObjsetFlist";
            this.ACCTObjsetFlist.Size = new System.Drawing.Size(155, 160);
            this.ACCTObjsetFlist.TabIndex = 16;
            this.ACCTObjsetFlist.SelectedIndexChanged += new System.EventHandler(this.ACCTObjsetFlist_SelectedIndexChanged);
            // 
            // ACCTContainerIDLabel
            // 
            this.ACCTContainerIDLabel.AutoSize = true;
            this.ACCTContainerIDLabel.Location = new System.Drawing.Point(313, 24);
            this.ACCTContainerIDLabel.Name = "ACCTContainerIDLabel";
            this.ACCTContainerIDLabel.Size = new System.Drawing.Size(69, 13);
            this.ACCTContainerIDLabel.TabIndex = 22;
            this.ACCTContainerIDLabel.Text = "Container ID:";
            // 
            // ACCTContainerID
            // 
            this.ACCTContainerID.Location = new System.Drawing.Point(388, 24);
            this.ACCTContainerID.Name = "ACCTContainerID";
            this.ACCTContainerID.Size = new System.Drawing.Size(100, 20);
            this.ACCTContainerID.TabIndex = 23;
            this.ACCTContainerID.TextChanged += new System.EventHandler(this.ACCTContainerID_TextChanged);
            // 
            // ACCTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 260);
            this.Controls.Add(this.ACCTContainerID);
            this.Controls.Add(this.ACCTContainerIDLabel);
            this.Controls.Add(this.ACCTObjsetFile);
            this.Controls.Add(this.ACCTObjsetFileLabel);
            this.Controls.Add(this.ACCTObjsetFlistRemoveButton);
            this.Controls.Add(this.ACCTObjsetFlistAddButton);
            this.Controls.Add(this.ACCTObjsetFlistLabel);
            this.Controls.Add(this.ACCTObjsetFlist);
            this.Controls.Add(this.ACCTAuth2DFile);
            this.Controls.Add(this.ACCTAuth2DFileLabel);
            this.Controls.Add(this.ACCTAuth2DFlistRemoveButton);
            this.Controls.Add(this.ACCTAuth2DFlistAddButton);
            this.Controls.Add(this.ACCTAuth2DFlistLabel);
            this.Controls.Add(this.ACCTAuth2DFlist);
            this.Controls.Add(this.ACCTPathsRemove);
            this.Controls.Add(this.ACCTPathsAddButton);
            this.Controls.Add(this.ACCTFile);
            this.Controls.Add(this.ACCTFileLabel);
            this.Controls.Add(this.ACCTPath);
            this.Controls.Add(this.ACCTPathLabel);
            this.Controls.Add(this.ACCTPathsLabel);
            this.Controls.Add(this.ACCTPaths);
            this.Controls.Add(this.ACCTNameLabel);
            this.Controls.Add(this.ACCTMenuStrip);
            this.MainMenuStrip = this.ACCTMenuStrip;
            this.Name = "ACCTForm";
            this.Text = "ACCTForm";
            this.ACCTMenuStrip.ResumeLayout(false);
            this.ACCTMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ACCTNameLabel;
        private System.Windows.Forms.ListBox ACCTPaths;
        private System.Windows.Forms.Label ACCTPathsLabel;
        private System.Windows.Forms.MenuStrip ACCTMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ACCTFileMenu;
        private System.Windows.Forms.ToolStripMenuItem ACCTExportMenuOption;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ACCTCloseMenuOption;
        private System.Windows.Forms.Label ACCTPathLabel;
        private System.Windows.Forms.TextBox ACCTPath;
        private System.Windows.Forms.TextBox ACCTFile;
        private System.Windows.Forms.Label ACCTFileLabel;
        private System.Windows.Forms.SaveFileDialog ACCTExportDialog;
        private System.Windows.Forms.Button ACCTPathsAddButton;
        private System.Windows.Forms.Button ACCTPathsRemove;
        private System.Windows.Forms.ListBox ACCTAuth2DFlist;
        private System.Windows.Forms.Label ACCTAuth2DFlistLabel;
        private System.Windows.Forms.Button ACCTAuth2DFlistRemoveButton;
        private System.Windows.Forms.Button ACCTAuth2DFlistAddButton;
        private System.Windows.Forms.TextBox ACCTAuth2DFile;
        private System.Windows.Forms.Label ACCTAuth2DFileLabel;
        private System.Windows.Forms.TextBox ACCTObjsetFile;
        private System.Windows.Forms.Label ACCTObjsetFileLabel;
        private System.Windows.Forms.Button ACCTObjsetFlistRemoveButton;
        private System.Windows.Forms.Button ACCTObjsetFlistAddButton;
        private System.Windows.Forms.Label ACCTObjsetFlistLabel;
        private System.Windows.Forms.ListBox ACCTObjsetFlist;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringArrayEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robDatabaseEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parameterDatabaseEditorUnderConstructionToolStripMenuItem;
        private System.Windows.Forms.Label ACCTContainerIDLabel;
        private System.Windows.Forms.TextBox ACCTContainerID;
    }
}