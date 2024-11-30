namespace FirstWrite
{
    partial class ParamModuleUnlockOverridesEditorForm
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
            this.ModuleUnlockOverrides = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddUnlockOverride = new System.Windows.Forms.Button();
            this.RemoveUnlockOverride = new System.Windows.Forms.Button();
            this.Flags = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddFlagButton = new System.Windows.Forms.Button();
            this.RemoveFlagButton = new System.Windows.Forms.Button();
            this.FlagValueLabel = new System.Windows.Forms.Label();
            this.Flag = new System.Windows.Forms.TextBox();
            this.ModuleIDLabel = new System.Windows.Forms.Label();
            this.ModuleID = new System.Windows.Forms.TextBox();
            this.Unks = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UnkValue = new System.Windows.Forms.TextBox();
            this.AddExFlagButton = new System.Windows.Forms.Button();
            this.RemoveExFlagButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModuleUnlockOverrides
            // 
            this.ModuleUnlockOverrides.FormattingEnabled = true;
            this.ModuleUnlockOverrides.ItemHeight = 12;
            this.ModuleUnlockOverrides.Location = new System.Drawing.Point(12, 28);
            this.ModuleUnlockOverrides.Name = "ModuleUnlockOverrides";
            this.ModuleUnlockOverrides.Size = new System.Drawing.Size(134, 328);
            this.ModuleUnlockOverrides.TabIndex = 0;
            this.ModuleUnlockOverrides.SelectedIndexChanged += new System.EventHandler(this.ModuleUnlockOverrides_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Module Unlock Overrides";
            // 
            // AddUnlockOverride
            // 
            this.AddUnlockOverride.Location = new System.Drawing.Point(12, 363);
            this.AddUnlockOverride.Name = "AddUnlockOverride";
            this.AddUnlockOverride.Size = new System.Drawing.Size(134, 23);
            this.AddUnlockOverride.TabIndex = 2;
            this.AddUnlockOverride.Text = "Add";
            this.AddUnlockOverride.UseVisualStyleBackColor = true;
            this.AddUnlockOverride.Click += new System.EventHandler(this.AddUnlockOverride_Click);
            // 
            // RemoveUnlockOverride
            // 
            this.RemoveUnlockOverride.Location = new System.Drawing.Point(12, 392);
            this.RemoveUnlockOverride.Name = "RemoveUnlockOverride";
            this.RemoveUnlockOverride.Size = new System.Drawing.Size(134, 23);
            this.RemoveUnlockOverride.TabIndex = 2;
            this.RemoveUnlockOverride.Text = "Remove";
            this.RemoveUnlockOverride.UseVisualStyleBackColor = true;
            this.RemoveUnlockOverride.Click += new System.EventHandler(this.RemoveUnlockOverride_Click);
            // 
            // Flags
            // 
            this.Flags.FormattingEnabled = true;
            this.Flags.ItemHeight = 12;
            this.Flags.Location = new System.Drawing.Point(153, 28);
            this.Flags.Name = "Flags";
            this.Flags.Size = new System.Drawing.Size(134, 328);
            this.Flags.TabIndex = 3;
            this.Flags.SelectedIndexChanged += new System.EventHandler(this.Flags_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flags";
            // 
            // AddFlagButton
            // 
            this.AddFlagButton.Location = new System.Drawing.Point(153, 363);
            this.AddFlagButton.Name = "AddFlagButton";
            this.AddFlagButton.Size = new System.Drawing.Size(134, 23);
            this.AddFlagButton.TabIndex = 2;
            this.AddFlagButton.Text = "Add";
            this.AddFlagButton.UseVisualStyleBackColor = true;
            this.AddFlagButton.Click += new System.EventHandler(this.AddFlagButton_Click);
            // 
            // RemoveFlagButton
            // 
            this.RemoveFlagButton.Location = new System.Drawing.Point(153, 392);
            this.RemoveFlagButton.Name = "RemoveFlagButton";
            this.RemoveFlagButton.Size = new System.Drawing.Size(134, 23);
            this.RemoveFlagButton.TabIndex = 2;
            this.RemoveFlagButton.Text = "Remove";
            this.RemoveFlagButton.UseVisualStyleBackColor = true;
            this.RemoveFlagButton.Click += new System.EventHandler(this.RemoveFlagButton_Click);
            // 
            // FlagValueLabel
            // 
            this.FlagValueLabel.AutoSize = true;
            this.FlagValueLabel.Location = new System.Drawing.Point(295, 66);
            this.FlagValueLabel.Name = "FlagValueLabel";
            this.FlagValueLabel.Size = new System.Drawing.Size(60, 12);
            this.FlagValueLabel.TabIndex = 4;
            this.FlagValueLabel.Text = "Flag Value";
            // 
            // Flag
            // 
            this.Flag.Location = new System.Drawing.Point(297, 81);
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(100, 19);
            this.Flag.TabIndex = 5;
            this.Flag.TextChanged += new System.EventHandler(this.Flag_TextChanged);
            // 
            // ModuleIDLabel
            // 
            this.ModuleIDLabel.AutoSize = true;
            this.ModuleIDLabel.Location = new System.Drawing.Point(295, 28);
            this.ModuleIDLabel.Name = "ModuleIDLabel";
            this.ModuleIDLabel.Size = new System.Drawing.Size(56, 12);
            this.ModuleIDLabel.TabIndex = 6;
            this.ModuleIDLabel.Text = "Module ID";
            // 
            // ModuleID
            // 
            this.ModuleID.Location = new System.Drawing.Point(297, 44);
            this.ModuleID.Name = "ModuleID";
            this.ModuleID.Size = new System.Drawing.Size(100, 19);
            this.ModuleID.TabIndex = 7;
            this.ModuleID.TextChanged += new System.EventHandler(this.ModuleID_TextChanged);
            // 
            // Unks
            // 
            this.Unks.FormattingEnabled = true;
            this.Unks.ItemHeight = 12;
            this.Unks.Location = new System.Drawing.Point(297, 122);
            this.Unks.Name = "Unks";
            this.Unks.Size = new System.Drawing.Size(100, 88);
            this.Unks.TabIndex = 8;
            this.Unks.SelectedIndexChanged += new System.EventHandler(this.Unks_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unks";
            // 
            // UnkValue
            // 
            this.UnkValue.Location = new System.Drawing.Point(297, 216);
            this.UnkValue.Name = "UnkValue";
            this.UnkValue.Size = new System.Drawing.Size(100, 19);
            this.UnkValue.TabIndex = 10;
            this.UnkValue.TextChanged += new System.EventHandler(this.UnkValue_TextChanged);
            // 
            // AddExFlagButton
            // 
            this.AddExFlagButton.Location = new System.Drawing.Point(297, 242);
            this.AddExFlagButton.Name = "AddExFlagButton";
            this.AddExFlagButton.Size = new System.Drawing.Size(100, 23);
            this.AddExFlagButton.TabIndex = 11;
            this.AddExFlagButton.Text = "Add";
            this.AddExFlagButton.UseVisualStyleBackColor = true;
            this.AddExFlagButton.Click += new System.EventHandler(this.AddExFlagButton_Click);
            // 
            // RemoveExFlagButton
            // 
            this.RemoveExFlagButton.Location = new System.Drawing.Point(297, 271);
            this.RemoveExFlagButton.Name = "RemoveExFlagButton";
            this.RemoveExFlagButton.Size = new System.Drawing.Size(100, 23);
            this.RemoveExFlagButton.TabIndex = 11;
            this.RemoveExFlagButton.Text = "Remove";
            this.RemoveExFlagButton.UseVisualStyleBackColor = true;
            this.RemoveExFlagButton.Click += new System.EventHandler(this.RemoveExFlagButton_Click);
            // 
            // ParamModuleUnlockOverridesEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 424);
            this.Controls.Add(this.RemoveExFlagButton);
            this.Controls.Add(this.AddExFlagButton);
            this.Controls.Add(this.UnkValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Unks);
            this.Controls.Add(this.ModuleID);
            this.Controls.Add(this.ModuleIDLabel);
            this.Controls.Add(this.Flag);
            this.Controls.Add(this.FlagValueLabel);
            this.Controls.Add(this.Flags);
            this.Controls.Add(this.RemoveFlagButton);
            this.Controls.Add(this.RemoveUnlockOverride);
            this.Controls.Add(this.AddFlagButton);
            this.Controls.Add(this.AddUnlockOverride);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModuleUnlockOverrides);
            this.Name = "ParamModuleUnlockOverridesEditorForm";
            this.Text = "ParamModuleUnlockOverridesEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ModuleUnlockOverrides;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddUnlockOverride;
        private System.Windows.Forms.Button RemoveUnlockOverride;
        private System.Windows.Forms.ListBox Flags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddFlagButton;
        private System.Windows.Forms.Button RemoveFlagButton;
        private System.Windows.Forms.Label FlagValueLabel;
        private System.Windows.Forms.TextBox Flag;
        private System.Windows.Forms.Label ModuleIDLabel;
        private System.Windows.Forms.TextBox ModuleID;
        private System.Windows.Forms.ListBox Unks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UnkValue;
        private System.Windows.Forms.Button AddExFlagButton;
        private System.Windows.Forms.Button RemoveExFlagButton;
    }
}