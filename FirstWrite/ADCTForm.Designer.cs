
namespace FirstWrite
{
    partial class ADCTForm
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
            this.ADCTMenuStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ADCTMenuStripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ADCTMenuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ADCTOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ADCTacpkInfoLabel = new System.Windows.Forms.Label();
            this.ADCTSeparatorVert01 = new System.Windows.Forms.Label();
            this.ACPKDescription = new System.Windows.Forms.TextBox();
            this.ACPKDescriptionLabel = new System.Windows.Forms.Label();
            this.ACPKPackageIdLabel = new System.Windows.Forms.Label();
            this.ACPKPackageId = new System.Windows.Forms.TextBox();
            this.ACPKPackageType = new System.Windows.Forms.ComboBox();
            this.ACPKPackageTypeLabel = new System.Windows.Forms.Label();
            this.ACPKIsRequired = new System.Windows.Forms.CheckBox();
            this.ACPKU11Label = new System.Windows.Forms.Label();
            this.ACPKU11 = new System.Windows.Forms.TextBox();
            this.ACPKExportButton = new System.Windows.Forms.Button();
            this.ADCTSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ADCTContainersLabel = new System.Windows.Forms.Label();
            this.ADCTContainers = new System.Windows.Forms.ListBox();
            this.ACCTEditButton = new System.Windows.Forms.Button();
            this.ACCTRenameButton = new System.Windows.Forms.Button();
            this.ADCTAddACCTButton = new System.Windows.Forms.Button();
            this.ADCTRemoveACCTButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADCTMenuStripOpen,
            this.ADCTMenuStripSave,
            this.toolStripSeparator1,
            this.ADCTMenuStripExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ADCTMenuStripOpen
            // 
            this.ADCTMenuStripOpen.Name = "ADCTMenuStripOpen";
            this.ADCTMenuStripOpen.Size = new System.Drawing.Size(103, 22);
            this.ADCTMenuStripOpen.Text = "Open";
            this.ADCTMenuStripOpen.Click += new System.EventHandler(this.ADCTMenuStripOpen_Click);
            // 
            // ADCTMenuStripSave
            // 
            this.ADCTMenuStripSave.Name = "ADCTMenuStripSave";
            this.ADCTMenuStripSave.Size = new System.Drawing.Size(103, 22);
            this.ADCTMenuStripSave.Text = "Save";
            this.ADCTMenuStripSave.Click += new System.EventHandler(this.ADCTMenuStripSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // ADCTMenuStripExit
            // 
            this.ADCTMenuStripExit.Name = "ADCTMenuStripExit";
            this.ADCTMenuStripExit.Size = new System.Drawing.Size(103, 22);
            this.ADCTMenuStripExit.Text = "Exit";
            this.ADCTMenuStripExit.Click += new System.EventHandler(this.ADCTMenuStripExit_Click);
            // 
            // ADCTOpenFileDialog
            // 
            this.ADCTOpenFileDialog.FileName = "firstread.bin";
            this.ADCTOpenFileDialog.Title = "Select a firstread.bin file";
            // 
            // ADCTacpkInfoLabel
            // 
            this.ADCTacpkInfoLabel.AutoSize = true;
            this.ADCTacpkInfoLabel.Location = new System.Drawing.Point(12, 34);
            this.ADCTacpkInfoLabel.Name = "ADCTacpkInfoLabel";
            this.ADCTacpkInfoLabel.Size = new System.Drawing.Size(150, 13);
            this.ADCTacpkInfoLabel.TabIndex = 1;
            this.ADCTacpkInfoLabel.Text = "Addon Contents Package Info";
            // 
            // ADCTSeparatorVert01
            // 
            this.ADCTSeparatorVert01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ADCTSeparatorVert01.Location = new System.Drawing.Point(252, 28);
            this.ADCTSeparatorVert01.Name = "ADCTSeparatorVert01";
            this.ADCTSeparatorVert01.Size = new System.Drawing.Size(2, 412);
            this.ADCTSeparatorVert01.TabIndex = 2;
            // 
            // ACPKDescription
            // 
            this.ACPKDescription.Location = new System.Drawing.Point(16, 69);
            this.ACPKDescription.MaxLength = 19;
            this.ACPKDescription.Name = "ACPKDescription";
            this.ACPKDescription.Size = new System.Drawing.Size(213, 20);
            this.ACPKDescription.TabIndex = 3;
            this.ACPKDescription.TextChanged += new System.EventHandler(this.ACPKDescription_TextChanged);
            // 
            // ACPKDescriptionLabel
            // 
            this.ACPKDescriptionLabel.AutoSize = true;
            this.ACPKDescriptionLabel.Location = new System.Drawing.Point(13, 53);
            this.ACPKDescriptionLabel.Name = "ACPKDescriptionLabel";
            this.ACPKDescriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.ACPKDescriptionLabel.TabIndex = 4;
            this.ACPKDescriptionLabel.Text = "Description: ";
            // 
            // ACPKPackageIdLabel
            // 
            this.ACPKPackageIdLabel.AutoSize = true;
            this.ACPKPackageIdLabel.Location = new System.Drawing.Point(12, 92);
            this.ACPKPackageIdLabel.Name = "ACPKPackageIdLabel";
            this.ACPKPackageIdLabel.Size = new System.Drawing.Size(67, 13);
            this.ACPKPackageIdLabel.TabIndex = 5;
            this.ACPKPackageIdLabel.Text = "Package ID:";
            // 
            // ACPKPackageId
            // 
            this.ACPKPackageId.Location = new System.Drawing.Point(15, 109);
            this.ACPKPackageId.MaxLength = 4;
            this.ACPKPackageId.Name = "ACPKPackageId";
            this.ACPKPackageId.Size = new System.Drawing.Size(213, 20);
            this.ACPKPackageId.TabIndex = 6;
            this.ACPKPackageId.Text = "0";
            this.ACPKPackageId.TextChanged += new System.EventHandler(this.ACPKPackageId_TextChanged);
            // 
            // ACPKPackageType
            // 
            this.ACPKPackageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ACPKPackageType.FormattingEnabled = true;
            this.ACPKPackageType.Items.AddRange(new object[] {
            "Patch",
            "DLC",
            "Base"});
            this.ACPKPackageType.Location = new System.Drawing.Point(16, 151);
            this.ACPKPackageType.Name = "ACPKPackageType";
            this.ACPKPackageType.Size = new System.Drawing.Size(213, 21);
            this.ACPKPackageType.TabIndex = 7;
            this.ACPKPackageType.TextChanged += new System.EventHandler(this.ACPKPackageType_TextChanged);
            // 
            // ACPKPackageTypeLabel
            // 
            this.ACPKPackageTypeLabel.AutoSize = true;
            this.ACPKPackageTypeLabel.Location = new System.Drawing.Point(12, 132);
            this.ACPKPackageTypeLabel.Name = "ACPKPackageTypeLabel";
            this.ACPKPackageTypeLabel.Size = new System.Drawing.Size(80, 13);
            this.ACPKPackageTypeLabel.TabIndex = 8;
            this.ACPKPackageTypeLabel.Text = "Package Type:";
            // 
            // ACPKIsRequired
            // 
            this.ACPKIsRequired.AutoSize = true;
            this.ACPKIsRequired.Location = new System.Drawing.Point(72, 178);
            this.ACPKIsRequired.Name = "ACPKIsRequired";
            this.ACPKIsRequired.Size = new System.Drawing.Size(69, 17);
            this.ACPKIsRequired.TabIndex = 9;
            this.ACPKIsRequired.Text = "Required";
            this.ACPKIsRequired.UseVisualStyleBackColor = true;
            this.ACPKIsRequired.CheckedChanged += new System.EventHandler(this.ACPKIsRequired_Changed);
            // 
            // ACPKU11Label
            // 
            this.ACPKU11Label.AutoSize = true;
            this.ACPKU11Label.Location = new System.Drawing.Point(9, 185);
            this.ACPKU11Label.Name = "ACPKU11Label";
            this.ACPKU11Label.Size = new System.Drawing.Size(30, 13);
            this.ACPKU11Label.TabIndex = 10;
            this.ACPKU11Label.Text = "U11:";
            // 
            // ACPKU11
            // 
            this.ACPKU11.Location = new System.Drawing.Point(12, 202);
            this.ACPKU11.MaxLength = 3;
            this.ACPKU11.Name = "ACPKU11";
            this.ACPKU11.Size = new System.Drawing.Size(216, 20);
            this.ACPKU11.TabIndex = 11;
            this.ACPKU11.Text = "0";
            this.ACPKU11.TextChanged += new System.EventHandler(this.ACPKU11_TextChanged);
            // 
            // ACPKExportButton
            // 
            this.ACPKExportButton.Location = new System.Drawing.Point(72, 228);
            this.ACPKExportButton.Name = "ACPKExportButton";
            this.ACPKExportButton.Size = new System.Drawing.Size(75, 23);
            this.ACPKExportButton.TabIndex = 12;
            this.ACPKExportButton.Text = "Export";
            this.ACPKExportButton.UseVisualStyleBackColor = true;
            this.ACPKExportButton.Click += new System.EventHandler(this.ACPKExportButton_Click);
            // 
            // ADCTSaveFileDialog
            // 
            this.ADCTSaveFileDialog.Title = "Save as...";
            // 
            // ADCTContainersLabel
            // 
            this.ADCTContainersLabel.AutoSize = true;
            this.ADCTContainersLabel.Location = new System.Drawing.Point(257, 34);
            this.ADCTContainersLabel.Name = "ADCTContainersLabel";
            this.ADCTContainersLabel.Size = new System.Drawing.Size(134, 13);
            this.ADCTContainersLabel.TabIndex = 14;
            this.ADCTContainersLabel.Text = "Addon Content Containers:";
            // 
            // ADCTContainers
            // 
            this.ADCTContainers.FormattingEnabled = true;
            this.ADCTContainers.Location = new System.Drawing.Point(260, 53);
            this.ADCTContainers.Name = "ADCTContainers";
            this.ADCTContainers.Size = new System.Drawing.Size(318, 173);
            this.ADCTContainers.TabIndex = 13;
            // 
            // ACCTEditButton
            // 
            this.ACCTEditButton.Location = new System.Drawing.Point(341, 232);
            this.ACCTEditButton.Name = "ACCTEditButton";
            this.ACCTEditButton.Size = new System.Drawing.Size(75, 23);
            this.ACCTEditButton.TabIndex = 15;
            this.ACCTEditButton.Text = "Edit";
            this.ACCTEditButton.UseVisualStyleBackColor = true;
            this.ACCTEditButton.Click += new System.EventHandler(this.ACCTEditButton_Click);
            // 
            // ACCTRenameButton
            // 
            this.ACCTRenameButton.Location = new System.Drawing.Point(260, 232);
            this.ACCTRenameButton.Name = "ACCTRenameButton";
            this.ACCTRenameButton.Size = new System.Drawing.Size(75, 23);
            this.ACCTRenameButton.TabIndex = 16;
            this.ACCTRenameButton.Text = "Rename";
            this.ACCTRenameButton.UseVisualStyleBackColor = true;
            this.ACCTRenameButton.Click += new System.EventHandler(this.ACCTRenameButton_Click);
            // 
            // ADCTAddACCTButton
            // 
            this.ADCTAddACCTButton.Location = new System.Drawing.Point(422, 232);
            this.ADCTAddACCTButton.Name = "ADCTAddACCTButton";
            this.ADCTAddACCTButton.Size = new System.Drawing.Size(75, 23);
            this.ADCTAddACCTButton.TabIndex = 17;
            this.ADCTAddACCTButton.Text = "Add";
            this.ADCTAddACCTButton.UseVisualStyleBackColor = true;
            this.ADCTAddACCTButton.Click += new System.EventHandler(this.ADCTAddACCTButton_Click);
            // 
            // ADCTRemoveACCTButton
            // 
            this.ADCTRemoveACCTButton.Location = new System.Drawing.Point(503, 232);
            this.ADCTRemoveACCTButton.Name = "ADCTRemoveACCTButton";
            this.ADCTRemoveACCTButton.Size = new System.Drawing.Size(75, 23);
            this.ADCTRemoveACCTButton.TabIndex = 18;
            this.ADCTRemoveACCTButton.Text = "Remove";
            this.ADCTRemoveACCTButton.UseVisualStyleBackColor = true;
            this.ADCTRemoveACCTButton.Click += new System.EventHandler(this.ADCTRemoveACCTButton_Click);
            // 
            // ADCTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 260);
            this.Controls.Add(this.ADCTRemoveACCTButton);
            this.Controls.Add(this.ADCTAddACCTButton);
            this.Controls.Add(this.ACCTRenameButton);
            this.Controls.Add(this.ACCTEditButton);
            this.Controls.Add(this.ADCTContainersLabel);
            this.Controls.Add(this.ADCTContainers);
            this.Controls.Add(this.ACPKExportButton);
            this.Controls.Add(this.ACPKU11);
            this.Controls.Add(this.ACPKU11Label);
            this.Controls.Add(this.ACPKIsRequired);
            this.Controls.Add(this.ACPKPackageTypeLabel);
            this.Controls.Add(this.ACPKPackageType);
            this.Controls.Add(this.ACPKPackageId);
            this.Controls.Add(this.ACPKPackageIdLabel);
            this.Controls.Add(this.ACPKDescriptionLabel);
            this.Controls.Add(this.ACPKDescription);
            this.Controls.Add(this.ADCTSeparatorVert01);
            this.Controls.Add(this.ADCTacpkInfoLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ADCTForm";
            this.Text = "FirstWrite";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ADCTMenuStripOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ADCTMenuStripExit;
        private System.Windows.Forms.OpenFileDialog ADCTOpenFileDialog;
        private System.Windows.Forms.Label ADCTacpkInfoLabel;
        private System.Windows.Forms.Label ADCTSeparatorVert01;
        private System.Windows.Forms.TextBox ACPKDescription;
        private System.Windows.Forms.Label ACPKDescriptionLabel;
        private System.Windows.Forms.Label ACPKPackageIdLabel;
        private System.Windows.Forms.TextBox ACPKPackageId;
        private System.Windows.Forms.ComboBox ACPKPackageType;
        private System.Windows.Forms.Label ACPKPackageTypeLabel;
        private System.Windows.Forms.CheckBox ACPKIsRequired;
        private System.Windows.Forms.Label ACPKU11Label;
        private System.Windows.Forms.TextBox ACPKU11;
        private System.Windows.Forms.Button ACPKExportButton;
        private System.Windows.Forms.SaveFileDialog ADCTSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem ADCTMenuStripSave;
        private System.Windows.Forms.Label ADCTContainersLabel;
        private System.Windows.Forms.ListBox ADCTContainers;
        private System.Windows.Forms.Button ACCTEditButton;
        private System.Windows.Forms.Button ACCTRenameButton;
        private System.Windows.Forms.Button ADCTAddACCTButton;
        private System.Windows.Forms.Button ADCTRemoveACCTButton;
    }
}

