namespace FirstWrite
{
    partial class ParamModuleInfoEditorForm
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
            this.ModuleInfos = new System.Windows.Forms.ListBox();
            this.AddModuleInfoButton = new System.Windows.Forms.Button();
            this.RemoveModuleInfoButton = new System.Windows.Forms.Button();
            this.ModuleInfosLabel = new System.Windows.Forms.Label();
            this.ModuleIDLabel = new System.Windows.Forms.Label();
            this.ModuleID = new System.Windows.Forms.TextBox();
            this.CostumeIDLabel = new System.Windows.Forms.Label();
            this.CostumeID = new System.Windows.Forms.TextBox();
            this.U04 = new System.Windows.Forms.TextBox();
            this.U04Label = new System.Windows.Forms.Label();
            this.U06 = new System.Windows.Forms.TextBox();
            this.U06Label = new System.Windows.Forms.Label();
            this.Effect = new System.Windows.Forms.ComboBox();
            this.EffectLabel = new System.Windows.Forms.Label();
            this.CloudLabel = new System.Windows.Forms.Label();
            this.Cloud = new System.Windows.Forms.ComboBox();
            this.CharaLabel = new System.Windows.Forms.Label();
            this.Chara = new System.Windows.Forms.ComboBox();
            this.RarityLabel = new System.Windows.Forms.Label();
            this.U0DLabel = new System.Windows.Forms.Label();
            this.U0D = new System.Windows.Forms.TextBox();
            this.U0ELabel = new System.Windows.Forms.Label();
            this.U0E = new System.Windows.Forms.TextBox();
            this.U0FLabel = new System.Windows.Forms.Label();
            this.U0F = new System.Windows.Forms.TextBox();
            this.U10Label = new System.Windows.Forms.Label();
            this.U10 = new System.Windows.Forms.TextBox();
            this.Rarity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ModuleInfos
            // 
            this.ModuleInfos.FormattingEnabled = true;
            this.ModuleInfos.ItemHeight = 12;
            this.ModuleInfos.Location = new System.Drawing.Point(13, 25);
            this.ModuleInfos.Name = "ModuleInfos";
            this.ModuleInfos.Size = new System.Drawing.Size(120, 328);
            this.ModuleInfos.TabIndex = 0;
            this.ModuleInfos.SelectedIndexChanged += new System.EventHandler(this.ModuleInfos_SelectedIndexChanged);
            // 
            // AddModuleInfoButton
            // 
            this.AddModuleInfoButton.Location = new System.Drawing.Point(13, 360);
            this.AddModuleInfoButton.Name = "AddModuleInfoButton";
            this.AddModuleInfoButton.Size = new System.Drawing.Size(120, 23);
            this.AddModuleInfoButton.TabIndex = 1;
            this.AddModuleInfoButton.Text = "Add";
            this.AddModuleInfoButton.UseVisualStyleBackColor = true;
            this.AddModuleInfoButton.Click += new System.EventHandler(this.AddModuleInfoButton_Click);
            // 
            // RemoveModuleInfoButton
            // 
            this.RemoveModuleInfoButton.Location = new System.Drawing.Point(12, 389);
            this.RemoveModuleInfoButton.Name = "RemoveModuleInfoButton";
            this.RemoveModuleInfoButton.Size = new System.Drawing.Size(120, 23);
            this.RemoveModuleInfoButton.TabIndex = 1;
            this.RemoveModuleInfoButton.Text = "Remove";
            this.RemoveModuleInfoButton.UseVisualStyleBackColor = true;
            this.RemoveModuleInfoButton.Click += new System.EventHandler(this.RemoveModuleInfoButton_Click);
            // 
            // ModuleInfosLabel
            // 
            this.ModuleInfosLabel.AutoSize = true;
            this.ModuleInfosLabel.Location = new System.Drawing.Point(13, 7);
            this.ModuleInfosLabel.Name = "ModuleInfosLabel";
            this.ModuleInfosLabel.Size = new System.Drawing.Size(70, 12);
            this.ModuleInfosLabel.TabIndex = 2;
            this.ModuleInfosLabel.Text = "Module Infos";
            // 
            // ModuleIDLabel
            // 
            this.ModuleIDLabel.AutoSize = true;
            this.ModuleIDLabel.Location = new System.Drawing.Point(140, 25);
            this.ModuleIDLabel.Name = "ModuleIDLabel";
            this.ModuleIDLabel.Size = new System.Drawing.Size(56, 12);
            this.ModuleIDLabel.TabIndex = 3;
            this.ModuleIDLabel.Text = "Module ID";
            // 
            // ModuleID
            // 
            this.ModuleID.Location = new System.Drawing.Point(142, 41);
            this.ModuleID.MaxLength = 4;
            this.ModuleID.Name = "ModuleID";
            this.ModuleID.Size = new System.Drawing.Size(100, 19);
            this.ModuleID.TabIndex = 4;
            this.ModuleID.TextChanged += new System.EventHandler(this.ModuleID_TextChanged);
            // 
            // CostumeIDLabel
            // 
            this.CostumeIDLabel.AutoSize = true;
            this.CostumeIDLabel.Location = new System.Drawing.Point(142, 67);
            this.CostumeIDLabel.Name = "CostumeIDLabel";
            this.CostumeIDLabel.Size = new System.Drawing.Size(65, 12);
            this.CostumeIDLabel.TabIndex = 5;
            this.CostumeIDLabel.Text = "Costume ID";
            // 
            // CostumeID
            // 
            this.CostumeID.Location = new System.Drawing.Point(142, 82);
            this.CostumeID.MaxLength = 4;
            this.CostumeID.Name = "CostumeID";
            this.CostumeID.Size = new System.Drawing.Size(100, 19);
            this.CostumeID.TabIndex = 4;
            this.CostumeID.TextChanged += new System.EventHandler(this.CostumeID_TextChanged);
            // 
            // U04
            // 
            this.U04.Location = new System.Drawing.Point(142, 119);
            this.U04.MaxLength = 4;
            this.U04.Name = "U04";
            this.U04.Size = new System.Drawing.Size(100, 19);
            this.U04.TabIndex = 4;
            this.U04.TextChanged += new System.EventHandler(this.U04_TextChanged);
            // 
            // U04Label
            // 
            this.U04Label.AutoSize = true;
            this.U04Label.Location = new System.Drawing.Point(142, 104);
            this.U04Label.Name = "U04Label";
            this.U04Label.Size = new System.Drawing.Size(25, 12);
            this.U04Label.TabIndex = 5;
            this.U04Label.Text = "U04";
            // 
            // U06
            // 
            this.U06.Location = new System.Drawing.Point(142, 156);
            this.U06.MaxLength = 4;
            this.U06.Name = "U06";
            this.U06.Size = new System.Drawing.Size(100, 19);
            this.U06.TabIndex = 4;
            this.U06.TextChanged += new System.EventHandler(this.U06_TextChanged);
            // 
            // U06Label
            // 
            this.U06Label.AutoSize = true;
            this.U06Label.Location = new System.Drawing.Point(142, 141);
            this.U06Label.Name = "U06Label";
            this.U06Label.Size = new System.Drawing.Size(25, 12);
            this.U06Label.TabIndex = 5;
            this.U06Label.Text = "U06";
            // 
            // Effect
            // 
            this.Effect.FormattingEnabled = true;
            this.Effect.Items.AddRange(new object[] {
            "Mystery",
            "ChanceTimeCatcher",
            "RateUpCatcher",
            "VoltageRateRecovery1",
            "VoltageRateRecovery2",
            "VoltageRateRecovery3",
            "NoEffect6",
            "NoEffect7",
            "ComboSaver1",
            "ComboSaver2",
            "ComboSaver3",
            "ComboSaver4",
            "ComboSaver5",
            "SafetyJudgeNone",
            "SafetyJudgeChanceTime",
            "SafetyJudgeTechZone",
            "SafetyJudge15",
            "EffectBreaker",
            "BadVoltage",
            "ReducePenalty1",
            "ReducePenalty2",
            "ReducePenalty3",
            "ReducePenalty4",
            "ReducePenalty5",
            "RateUp12s",
            "RateUp10s",
            "RateUp8s",
            "RateUp6s",
            "RateUp4s",
            "TechRateUp1",
            "TechRateUp2",
            "TechRateUp3",
            "TechRateUp4",
            "TechRateUp5",
            "ComboRateUp80",
            "ComboRateUp60",
            "ComboRateUp40",
            "ComboRateUp30",
            "ComboRateUp20",
            "Combo100RateUp1",
            "Combo100RateUp2",
            "Combo100RateUp3",
            "Combo100RateUp4",
            "Combo100RateUp5",
            "Combo50RateUp1",
            "Combo50RateUp2",
            "Combo50RateUp3",
            "Combo50RateUp4",
            "Combo50RateUp5",
            "Combo100Bonus1",
            "Combo100Bonus2",
            "Combo100Bonus3",
            "Combo100Bonus4",
            "Combo100Bonus5",
            "RateNotesUp1",
            "RateNotesUp2",
            "RateNotesUp3",
            "RateNotesUp4",
            "RateNotesUp5",
            "RateNotesPlus1",
            "RateNotesPlus2",
            "RateNotesPlus3",
            "RateNotesPlus4",
            "RateNotesPlus5",
            "NewModuleDropper1",
            "NewModuleDropper2",
            "NewModuleDropper3",
            "NewModuleDropper4",
            "RareModuleDropper1",
            "RareModuleDropper2",
            "RareModuleDropper3",
            "RareModuleDropper4",
            "AccessoryDroppper1",
            "AccessoryDroppper2",
            "AccessoryDroppper3",
            "AccessoryDroppper4",
            "GiftDroppper1",
            "GiftDroppper2",
            "GiftDroppper3",
            "GiftDroppper4",
            "Overclocker",
            "NanoTargeter",
            "StealthyTarget",
            "ChaosStorm",
            "MixUp",
            "WibblyWobbly",
            "PsycheOut",
            "NinjaStrike"});
            this.Effect.Location = new System.Drawing.Point(142, 193);
            this.Effect.Name = "Effect";
            this.Effect.Size = new System.Drawing.Size(100, 20);
            this.Effect.TabIndex = 6;
            this.Effect.SelectedIndexChanged += new System.EventHandler(this.Effect_SelectedIndexChanged);
            // 
            // EffectLabel
            // 
            this.EffectLabel.AutoSize = true;
            this.EffectLabel.Location = new System.Drawing.Point(142, 178);
            this.EffectLabel.Name = "EffectLabel";
            this.EffectLabel.Size = new System.Drawing.Size(36, 12);
            this.EffectLabel.TabIndex = 5;
            this.EffectLabel.Text = "Effect";
            // 
            // CloudLabel
            // 
            this.CloudLabel.AutoSize = true;
            this.CloudLabel.Location = new System.Drawing.Point(142, 216);
            this.CloudLabel.Name = "CloudLabel";
            this.CloudLabel.Size = new System.Drawing.Size(34, 12);
            this.CloudLabel.TabIndex = 5;
            this.CloudLabel.Text = "Cloud";
            // 
            // Cloud
            // 
            this.Cloud.FormattingEnabled = true;
            this.Cloud.Items.AddRange(new object[] {
            "Neutral",
            "Cute",
            "Cool",
            "Beauty",
            "Chaos",
            "Extra",
            "All"});
            this.Cloud.Location = new System.Drawing.Point(142, 231);
            this.Cloud.Name = "Cloud";
            this.Cloud.Size = new System.Drawing.Size(100, 20);
            this.Cloud.TabIndex = 6;
            this.Cloud.SelectedIndexChanged += new System.EventHandler(this.Cloud_SelectedIndexChanged);
            // 
            // CharaLabel
            // 
            this.CharaLabel.AutoSize = true;
            this.CharaLabel.Location = new System.Drawing.Point(142, 254);
            this.CharaLabel.Name = "CharaLabel";
            this.CharaLabel.Size = new System.Drawing.Size(35, 12);
            this.CharaLabel.TabIndex = 5;
            this.CharaLabel.Text = "Chara";
            // 
            // Chara
            // 
            this.Chara.FormattingEnabled = true;
            this.Chara.Items.AddRange(new object[] {
            "MIK",
            "RIN",
            "LEN",
            "LUK",
            "NER",
            "HAK",
            "KAI",
            "MEI",
            "SAK",
            "TET",
            "EXT"});
            this.Chara.Location = new System.Drawing.Point(142, 269);
            this.Chara.Name = "Chara";
            this.Chara.Size = new System.Drawing.Size(100, 20);
            this.Chara.TabIndex = 6;
            this.Chara.SelectedIndexChanged += new System.EventHandler(this.Chara_SelectedIndexChanged);
            // 
            // RarityLabel
            // 
            this.RarityLabel.AutoSize = true;
            this.RarityLabel.Location = new System.Drawing.Point(246, 25);
            this.RarityLabel.Name = "RarityLabel";
            this.RarityLabel.Size = new System.Drawing.Size(36, 12);
            this.RarityLabel.TabIndex = 3;
            this.RarityLabel.Text = "Rarity";
            // 
            // U0DLabel
            // 
            this.U0DLabel.AutoSize = true;
            this.U0DLabel.Location = new System.Drawing.Point(246, 67);
            this.U0DLabel.Name = "U0DLabel";
            this.U0DLabel.Size = new System.Drawing.Size(27, 12);
            this.U0DLabel.TabIndex = 3;
            this.U0DLabel.Text = "U0D";
            // 
            // U0D
            // 
            this.U0D.Location = new System.Drawing.Point(248, 83);
            this.U0D.MaxLength = 4;
            this.U0D.Name = "U0D";
            this.U0D.Size = new System.Drawing.Size(38, 19);
            this.U0D.TabIndex = 4;
            this.U0D.TextChanged += new System.EventHandler(this.U0D_TextChanged);
            // 
            // U0ELabel
            // 
            this.U0ELabel.AutoSize = true;
            this.U0ELabel.Location = new System.Drawing.Point(246, 105);
            this.U0ELabel.Name = "U0ELabel";
            this.U0ELabel.Size = new System.Drawing.Size(26, 12);
            this.U0ELabel.TabIndex = 3;
            this.U0ELabel.Text = "U0E";
            // 
            // U0E
            // 
            this.U0E.Location = new System.Drawing.Point(248, 121);
            this.U0E.MaxLength = 4;
            this.U0E.Name = "U0E";
            this.U0E.Size = new System.Drawing.Size(38, 19);
            this.U0E.TabIndex = 4;
            this.U0E.TextChanged += new System.EventHandler(this.U0E_TextChanged);
            // 
            // U0FLabel
            // 
            this.U0FLabel.AutoSize = true;
            this.U0FLabel.Location = new System.Drawing.Point(246, 143);
            this.U0FLabel.Name = "U0FLabel";
            this.U0FLabel.Size = new System.Drawing.Size(26, 12);
            this.U0FLabel.TabIndex = 3;
            this.U0FLabel.Text = "U0F";
            // 
            // U0F
            // 
            this.U0F.Location = new System.Drawing.Point(248, 159);
            this.U0F.MaxLength = 4;
            this.U0F.Name = "U0F";
            this.U0F.Size = new System.Drawing.Size(38, 19);
            this.U0F.TabIndex = 4;
            this.U0F.TextChanged += new System.EventHandler(this.U0F_TextChanged);
            // 
            // U10Label
            // 
            this.U10Label.AutoSize = true;
            this.U10Label.Location = new System.Drawing.Point(246, 181);
            this.U10Label.Name = "U10Label";
            this.U10Label.Size = new System.Drawing.Size(25, 12);
            this.U10Label.TabIndex = 3;
            this.U10Label.Text = "U10";
            // 
            // U10
            // 
            this.U10.Location = new System.Drawing.Point(248, 197);
            this.U10.MaxLength = 4;
            this.U10.Name = "U10";
            this.U10.Size = new System.Drawing.Size(127, 19);
            this.U10.TabIndex = 4;
            this.U10.TextChanged += new System.EventHandler(this.U10_TextChanged);
            // 
            // Rarity
            // 
            this.Rarity.FormattingEnabled = true;
            this.Rarity.Items.AddRange(new object[] {
            "None",
            "Common",
            "Rare"});
            this.Rarity.Location = new System.Drawing.Point(248, 41);
            this.Rarity.Name = "Rarity";
            this.Rarity.Size = new System.Drawing.Size(121, 20);
            this.Rarity.TabIndex = 7;
            this.Rarity.SelectedIndexChanged += new System.EventHandler(this.Rarity_SelectedIndexChanged);
            // 
            // ParamModuleInfoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.Rarity);
            this.Controls.Add(this.Chara);
            this.Controls.Add(this.Cloud);
            this.Controls.Add(this.Effect);
            this.Controls.Add(this.CharaLabel);
            this.Controls.Add(this.CloudLabel);
            this.Controls.Add(this.EffectLabel);
            this.Controls.Add(this.U06Label);
            this.Controls.Add(this.U06);
            this.Controls.Add(this.U04Label);
            this.Controls.Add(this.U04);
            this.Controls.Add(this.CostumeIDLabel);
            this.Controls.Add(this.CostumeID);
            this.Controls.Add(this.U10);
            this.Controls.Add(this.U0F);
            this.Controls.Add(this.U0E);
            this.Controls.Add(this.U0D);
            this.Controls.Add(this.ModuleID);
            this.Controls.Add(this.U10Label);
            this.Controls.Add(this.U0FLabel);
            this.Controls.Add(this.U0ELabel);
            this.Controls.Add(this.U0DLabel);
            this.Controls.Add(this.RarityLabel);
            this.Controls.Add(this.ModuleIDLabel);
            this.Controls.Add(this.ModuleInfosLabel);
            this.Controls.Add(this.RemoveModuleInfoButton);
            this.Controls.Add(this.AddModuleInfoButton);
            this.Controls.Add(this.ModuleInfos);
            this.Name = "ParamModuleInfoEditorForm";
            this.Text = "ParamModuleInfoEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ModuleInfos;
        private System.Windows.Forms.Button AddModuleInfoButton;
        private System.Windows.Forms.Button RemoveModuleInfoButton;
        private System.Windows.Forms.Label ModuleInfosLabel;
        private System.Windows.Forms.Label ModuleIDLabel;
        private System.Windows.Forms.TextBox ModuleID;
        private System.Windows.Forms.Label CostumeIDLabel;
        private System.Windows.Forms.TextBox CostumeID;
        private System.Windows.Forms.TextBox U04;
        private System.Windows.Forms.Label U04Label;
        private System.Windows.Forms.TextBox U06;
        private System.Windows.Forms.Label U06Label;
        private System.Windows.Forms.ComboBox Effect;
        private System.Windows.Forms.Label EffectLabel;
        private System.Windows.Forms.Label CloudLabel;
        private System.Windows.Forms.ComboBox Cloud;
        private System.Windows.Forms.Label CharaLabel;
        private System.Windows.Forms.ComboBox Chara;
        private System.Windows.Forms.Label RarityLabel;
        private System.Windows.Forms.Label U0DLabel;
        private System.Windows.Forms.TextBox U0D;
        private System.Windows.Forms.Label U0ELabel;
        private System.Windows.Forms.TextBox U0E;
        private System.Windows.Forms.Label U0FLabel;
        private System.Windows.Forms.TextBox U0F;
        private System.Windows.Forms.Label U10Label;
        private System.Windows.Forms.TextBox U10;
        private System.Windows.Forms.ComboBox Rarity;
    }
}