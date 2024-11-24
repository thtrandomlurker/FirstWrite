
namespace FirstWrite
{
    partial class ItemEditorForm
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
            this.Items = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ItemNumber = new System.Windows.Forms.TextBox();
            this.ItemNumberLabel = new System.Windows.Forms.Label();
            this.U09 = new System.Windows.Forms.TextBox();
            this.Attribute = new System.Windows.Forms.TextBox();
            this.AttributeLabel = new System.Windows.Forms.Label();
            this.DestID = new System.Windows.Forms.TextBox();
            this.DestIDLabel = new System.Windows.Forms.Label();
            this.SubIDLabel = new System.Windows.Forms.Label();
            this.SubID = new System.Windows.Forms.ComboBox();
            this.U04Label = new System.Windows.Forms.Label();
            this.U04 = new System.Windows.Forms.TextBox();
            this.U06 = new System.Windows.Forms.TextBox();
            this.U07 = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.U0F = new System.Windows.Forms.TextBox();
            this.U10 = new System.Windows.Forms.TextBox();
            this.U10Label = new System.Windows.Forms.Label();
            this.U14 = new System.Windows.Forms.TextBox();
            this.U14Label = new System.Windows.Forms.Label();
            this.Objects = new System.Windows.Forms.ListBox();
            this.ObjectsListLabel = new System.Windows.Forms.Label();
            this.TextureChanges = new System.Windows.Forms.ListBox();
            this.ObjectSets = new System.Windows.Forms.ListBox();
            this.TextureChangeLabel = new System.Windows.Forms.Label();
            this.ObjectSetsLabel = new System.Windows.Forms.Label();
            this.ObjectIDLabel = new System.Windows.Forms.Label();
            this.ObjectID = new System.Windows.Forms.TextBox();
            this.ObjectRPKLabel = new System.Windows.Forms.Label();
            this.RPK = new System.Windows.Forms.TextBox();
            this.TexChangeSrc = new System.Windows.Forms.TextBox();
            this.SourceTexLabel = new System.Windows.Forms.Label();
            this.TexChangeDst = new System.Windows.Forms.TextBox();
            this.ReplaceTexLabel = new System.Windows.Forms.Label();
            this.ObjectSetID = new System.Windows.Forms.TextBox();
            this.ObjectSetIDLabel = new System.Windows.Forms.Label();
            this.AddObjectButton = new System.Windows.Forms.Button();
            this.RemoveObjectButton = new System.Windows.Forms.Button();
            this.RemoveTextureChangeButton = new System.Windows.Forms.Button();
            this.AddTextureChangeButton = new System.Windows.Forms.Button();
            this.RemoveObjectSetsButton = new System.Windows.Forms.Button();
            this.AddObjectSetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Items
            // 
            this.Items.FormattingEnabled = true;
            this.Items.Location = new System.Drawing.Point(12, 13);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(87, 277);
            this.Items.TabIndex = 0;
            this.Items.SelectedIndexChanged += new System.EventHandler(this.Items_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 296);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 325);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(87, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ItemNumber
            // 
            this.ItemNumber.Location = new System.Drawing.Point(106, 29);
            this.ItemNumber.MaxLength = 3;
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.Size = new System.Drawing.Size(31, 20);
            this.ItemNumber.TabIndex = 3;
            // 
            // ItemNumberLabel
            // 
            this.ItemNumberLabel.AutoSize = true;
            this.ItemNumberLabel.Location = new System.Drawing.Point(103, 13);
            this.ItemNumberLabel.Name = "ItemNumberLabel";
            this.ItemNumberLabel.Size = new System.Drawing.Size(105, 13);
            this.ItemNumberLabel.TabIndex = 4;
            this.ItemNumberLabel.Text = "Num:    U06:     U07:";
            // 
            // U09
            // 
            this.U09.Location = new System.Drawing.Point(143, 68);
            this.U09.MaxLength = 3;
            this.U09.Name = "U09";
            this.U09.Size = new System.Drawing.Size(31, 20);
            this.U09.TabIndex = 6;
            // 
            // Attribute
            // 
            this.Attribute.Location = new System.Drawing.Point(161, 110);
            this.Attribute.MaxLength = 5;
            this.Attribute.Name = "Attribute";
            this.Attribute.Size = new System.Drawing.Size(49, 20);
            this.Attribute.TabIndex = 8;
            // 
            // AttributeLabel
            // 
            this.AttributeLabel.AutoSize = true;
            this.AttributeLabel.Location = new System.Drawing.Point(161, 94);
            this.AttributeLabel.Name = "AttributeLabel";
            this.AttributeLabel.Size = new System.Drawing.Size(49, 13);
            this.AttributeLabel.TabIndex = 7;
            this.AttributeLabel.Text = "Attribute:";
            // 
            // DestID
            // 
            this.DestID.Location = new System.Drawing.Point(106, 149);
            this.DestID.MaxLength = 3;
            this.DestID.Name = "DestID";
            this.DestID.Size = new System.Drawing.Size(105, 20);
            this.DestID.TabIndex = 10;
            // 
            // DestIDLabel
            // 
            this.DestIDLabel.AutoSize = true;
            this.DestIDLabel.Location = new System.Drawing.Point(106, 133);
            this.DestIDLabel.Name = "DestIDLabel";
            this.DestIDLabel.Size = new System.Drawing.Size(46, 13);
            this.DestIDLabel.TabIndex = 9;
            this.DestIDLabel.Text = "Dest ID:";
            // 
            // SubIDLabel
            // 
            this.SubIDLabel.AutoSize = true;
            this.SubIDLabel.Location = new System.Drawing.Point(105, 253);
            this.SubIDLabel.Name = "SubIDLabel";
            this.SubIDLabel.Size = new System.Drawing.Size(43, 13);
            this.SubIDLabel.TabIndex = 11;
            this.SubIDLabel.Text = "Sub ID:";
            // 
            // SubID
            // 
            this.SubID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubID.FormattingEnabled = true;
            this.SubID.Items.AddRange(new object[] {
            "ATAM_ZUJO",
            "ATAM_ATAMA",
            "ITEM02",
            "ITEM03",
            "FACE_FACE",
            "ITEM05",
            "ITEM06",
            "ITEM07",
            "JOHA_NECK",
            "ITEM09",
            "JOHA_OUTER",
            "ITEM11",
            "ITEM12",
            "ITEM13",
            "UDE_HAND",
            "ITEM15",
            "JOHA_BACK",
            "ITEM17",
            "ITEM18",
            "ITEM19",
            "ITEM20",
            "ITEM21",
            "ITEM22",
            "ITEM23",
            "ATAM_HEAD"});
            this.SubID.Location = new System.Drawing.Point(106, 269);
            this.SubID.Name = "SubID";
            this.SubID.Size = new System.Drawing.Size(105, 21);
            this.SubID.TabIndex = 12;
            // 
            // U04Label
            // 
            this.U04Label.AutoSize = true;
            this.U04Label.Location = new System.Drawing.Point(103, 94);
            this.U04Label.Name = "U04Label";
            this.U04Label.Size = new System.Drawing.Size(30, 13);
            this.U04Label.TabIndex = 14;
            this.U04Label.Text = "U04:";
            // 
            // U04
            // 
            this.U04.Location = new System.Drawing.Point(106, 110);
            this.U04.MaxLength = 5;
            this.U04.Name = "U04";
            this.U04.Size = new System.Drawing.Size(49, 20);
            this.U04.TabIndex = 13;
            // 
            // U06
            // 
            this.U06.Location = new System.Drawing.Point(143, 29);
            this.U06.MaxLength = 3;
            this.U06.Name = "U06";
            this.U06.Size = new System.Drawing.Size(31, 20);
            this.U06.TabIndex = 15;
            // 
            // U07
            // 
            this.U07.Location = new System.Drawing.Point(180, 29);
            this.U07.MaxLength = 3;
            this.U07.Name = "U07";
            this.U07.Size = new System.Drawing.Size(31, 20);
            this.U07.TabIndex = 16;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(106, 68);
            this.Type.MaxLength = 3;
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 20);
            this.Type.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Type:    U09:    U0F:";
            // 
            // U0F
            // 
            this.U0F.Location = new System.Drawing.Point(180, 66);
            this.U0F.MaxLength = 3;
            this.U0F.Name = "U0F";
            this.U0F.Size = new System.Drawing.Size(31, 20);
            this.U0F.TabIndex = 19;
            // 
            // U10
            // 
            this.U10.Location = new System.Drawing.Point(106, 188);
            this.U10.MaxLength = 3;
            this.U10.Name = "U10";
            this.U10.Size = new System.Drawing.Size(105, 20);
            this.U10.TabIndex = 21;
            // 
            // U10Label
            // 
            this.U10Label.AutoSize = true;
            this.U10Label.Location = new System.Drawing.Point(106, 172);
            this.U10Label.Name = "U10Label";
            this.U10Label.Size = new System.Drawing.Size(30, 13);
            this.U10Label.TabIndex = 20;
            this.U10Label.Text = "U10:";
            // 
            // U14
            // 
            this.U14.Location = new System.Drawing.Point(106, 227);
            this.U14.MaxLength = 3;
            this.U14.Name = "U14";
            this.U14.Size = new System.Drawing.Size(105, 20);
            this.U14.TabIndex = 23;
            // 
            // U14Label
            // 
            this.U14Label.AutoSize = true;
            this.U14Label.Location = new System.Drawing.Point(106, 211);
            this.U14Label.Name = "U14Label";
            this.U14Label.Size = new System.Drawing.Size(30, 13);
            this.U14Label.TabIndex = 22;
            this.U14Label.Text = "U14:";
            // 
            // Objects
            // 
            this.Objects.FormattingEnabled = true;
            this.Objects.Location = new System.Drawing.Point(218, 29);
            this.Objects.Name = "Objects";
            this.Objects.Size = new System.Drawing.Size(105, 30);
            this.Objects.TabIndex = 24;
            this.Objects.SelectedIndexChanged += new System.EventHandler(this.Objects_SelectedIndexChanged);
            // 
            // ObjectsListLabel
            // 
            this.ObjectsListLabel.AutoSize = true;
            this.ObjectsListLabel.Location = new System.Drawing.Point(215, 13);
            this.ObjectsListLabel.Name = "ObjectsListLabel";
            this.ObjectsListLabel.Size = new System.Drawing.Size(46, 13);
            this.ObjectsListLabel.TabIndex = 25;
            this.ObjectsListLabel.Text = "Objects:";
            // 
            // TextureChanges
            // 
            this.TextureChanges.FormattingEnabled = true;
            this.TextureChanges.Location = new System.Drawing.Point(218, 132);
            this.TextureChanges.Name = "TextureChanges";
            this.TextureChanges.Size = new System.Drawing.Size(105, 30);
            this.TextureChanges.TabIndex = 26;
            this.TextureChanges.SelectedIndexChanged += new System.EventHandler(this.TextureChanges_SelectedIndexChanged);
            // 
            // ObjectSets
            // 
            this.ObjectSets.FormattingEnabled = true;
            this.ObjectSets.Location = new System.Drawing.Point(218, 234);
            this.ObjectSets.Name = "ObjectSets";
            this.ObjectSets.Size = new System.Drawing.Size(105, 30);
            this.ObjectSets.TabIndex = 27;
            this.ObjectSets.SelectedIndexChanged += new System.EventHandler(this.ObjectSets_SelectedIndexChanged);
            // 
            // TextureChangeLabel
            // 
            this.TextureChangeLabel.AutoSize = true;
            this.TextureChangeLabel.Location = new System.Drawing.Point(216, 117);
            this.TextureChangeLabel.Name = "TextureChangeLabel";
            this.TextureChangeLabel.Size = new System.Drawing.Size(91, 13);
            this.TextureChangeLabel.TabIndex = 28;
            this.TextureChangeLabel.Text = "Texture Changes:";
            // 
            // ObjectSetsLabel
            // 
            this.ObjectSetsLabel.AutoSize = true;
            this.ObjectSetsLabel.Location = new System.Drawing.Point(218, 218);
            this.ObjectSetsLabel.Name = "ObjectSetsLabel";
            this.ObjectSetsLabel.Size = new System.Drawing.Size(65, 13);
            this.ObjectSetsLabel.TabIndex = 29;
            this.ObjectSetsLabel.Text = "Object Sets:";
            // 
            // ObjectIDLabel
            // 
            this.ObjectIDLabel.AutoSize = true;
            this.ObjectIDLabel.Location = new System.Drawing.Point(329, 13);
            this.ObjectIDLabel.Name = "ObjectIDLabel";
            this.ObjectIDLabel.Size = new System.Drawing.Size(55, 13);
            this.ObjectIDLabel.TabIndex = 30;
            this.ObjectIDLabel.Text = "Object ID:";
            // 
            // ObjectID
            // 
            this.ObjectID.Location = new System.Drawing.Point(330, 30);
            this.ObjectID.MaxLength = 10;
            this.ObjectID.Name = "ObjectID";
            this.ObjectID.Size = new System.Drawing.Size(100, 20);
            this.ObjectID.TabIndex = 31;
            // 
            // ObjectRPKLabel
            // 
            this.ObjectRPKLabel.AutoSize = true;
            this.ObjectRPKLabel.Location = new System.Drawing.Point(329, 52);
            this.ObjectRPKLabel.Name = "ObjectRPKLabel";
            this.ObjectRPKLabel.Size = new System.Drawing.Size(32, 13);
            this.ObjectRPKLabel.TabIndex = 32;
            this.ObjectRPKLabel.Text = "RPK:";
            // 
            // RPK
            // 
            this.RPK.Location = new System.Drawing.Point(332, 68);
            this.RPK.MaxLength = 3;
            this.RPK.Name = "RPK";
            this.RPK.Size = new System.Drawing.Size(31, 20);
            this.RPK.TabIndex = 33;
            // 
            // TexChangeSrc
            // 
            this.TexChangeSrc.Location = new System.Drawing.Point(326, 134);
            this.TexChangeSrc.MaxLength = 10;
            this.TexChangeSrc.Name = "TexChangeSrc";
            this.TexChangeSrc.Size = new System.Drawing.Size(100, 20);
            this.TexChangeSrc.TabIndex = 35;
            // 
            // SourceTexLabel
            // 
            this.SourceTexLabel.AutoSize = true;
            this.SourceTexLabel.Location = new System.Drawing.Point(325, 117);
            this.SourceTexLabel.Name = "SourceTexLabel";
            this.SourceTexLabel.Size = new System.Drawing.Size(58, 13);
            this.SourceTexLabel.TabIndex = 34;
            this.SourceTexLabel.Text = "Source ID:";
            // 
            // TexChangeDst
            // 
            this.TexChangeDst.Location = new System.Drawing.Point(326, 174);
            this.TexChangeDst.MaxLength = 10;
            this.TexChangeDst.Name = "TexChangeDst";
            this.TexChangeDst.Size = new System.Drawing.Size(100, 20);
            this.TexChangeDst.TabIndex = 37;
            // 
            // ReplaceTexLabel
            // 
            this.ReplaceTexLabel.AutoSize = true;
            this.ReplaceTexLabel.Location = new System.Drawing.Point(325, 157);
            this.ReplaceTexLabel.Name = "ReplaceTexLabel";
            this.ReplaceTexLabel.Size = new System.Drawing.Size(87, 13);
            this.ReplaceTexLabel.TabIndex = 36;
            this.ReplaceTexLabel.Text = "Replacement ID:";
            // 
            // ObjectSetID
            // 
            this.ObjectSetID.Location = new System.Drawing.Point(328, 235);
            this.ObjectSetID.MaxLength = 10;
            this.ObjectSetID.Name = "ObjectSetID";
            this.ObjectSetID.Size = new System.Drawing.Size(100, 20);
            this.ObjectSetID.TabIndex = 39;
            // 
            // ObjectSetIDLabel
            // 
            this.ObjectSetIDLabel.AutoSize = true;
            this.ObjectSetIDLabel.Location = new System.Drawing.Point(327, 218);
            this.ObjectSetIDLabel.Name = "ObjectSetIDLabel";
            this.ObjectSetIDLabel.Size = new System.Drawing.Size(74, 13);
            this.ObjectSetIDLabel.TabIndex = 38;
            this.ObjectSetIDLabel.Text = "Object Set ID:";
            // 
            // AddObjectButton
            // 
            this.AddObjectButton.Location = new System.Drawing.Point(217, 65);
            this.AddObjectButton.Name = "AddObjectButton";
            this.AddObjectButton.Size = new System.Drawing.Size(106, 23);
            this.AddObjectButton.TabIndex = 40;
            this.AddObjectButton.Text = "Add";
            this.AddObjectButton.UseVisualStyleBackColor = true;
            this.AddObjectButton.Click += new System.EventHandler(this.AddObjectButton_Click);
            // 
            // RemoveObjectButton
            // 
            this.RemoveObjectButton.Location = new System.Drawing.Point(218, 89);
            this.RemoveObjectButton.Name = "RemoveObjectButton";
            this.RemoveObjectButton.Size = new System.Drawing.Size(105, 23);
            this.RemoveObjectButton.TabIndex = 41;
            this.RemoveObjectButton.Text = "Remove";
            this.RemoveObjectButton.UseVisualStyleBackColor = true;
            this.RemoveObjectButton.Click += new System.EventHandler(this.RemoveObjectButton_Click);
            // 
            // RemoveTextureChangeButton
            // 
            this.RemoveTextureChangeButton.Location = new System.Drawing.Point(218, 192);
            this.RemoveTextureChangeButton.Name = "RemoveTextureChangeButton";
            this.RemoveTextureChangeButton.Size = new System.Drawing.Size(105, 23);
            this.RemoveTextureChangeButton.TabIndex = 43;
            this.RemoveTextureChangeButton.Text = "Remove";
            this.RemoveTextureChangeButton.UseVisualStyleBackColor = true;
            this.RemoveTextureChangeButton.Click += new System.EventHandler(this.RemoveTextureChangeButton_Click);
            // 
            // AddTextureChangeButton
            // 
            this.AddTextureChangeButton.Location = new System.Drawing.Point(217, 168);
            this.AddTextureChangeButton.Name = "AddTextureChangeButton";
            this.AddTextureChangeButton.Size = new System.Drawing.Size(106, 23);
            this.AddTextureChangeButton.TabIndex = 42;
            this.AddTextureChangeButton.Text = "Add";
            this.AddTextureChangeButton.UseVisualStyleBackColor = true;
            this.AddTextureChangeButton.Click += new System.EventHandler(this.AddTextureChangeButton_Click);
            // 
            // RemoveObjectSetsButton
            // 
            this.RemoveObjectSetsButton.Location = new System.Drawing.Point(219, 290);
            this.RemoveObjectSetsButton.Name = "RemoveObjectSetsButton";
            this.RemoveObjectSetsButton.Size = new System.Drawing.Size(105, 23);
            this.RemoveObjectSetsButton.TabIndex = 45;
            this.RemoveObjectSetsButton.Text = "Remove";
            this.RemoveObjectSetsButton.UseVisualStyleBackColor = true;
            this.RemoveObjectSetsButton.Click += new System.EventHandler(this.RemoveObjectSetsButton_Click);
            // 
            // AddObjectSetButton
            // 
            this.AddObjectSetButton.Location = new System.Drawing.Point(218, 266);
            this.AddObjectSetButton.Name = "AddObjectSetButton";
            this.AddObjectSetButton.Size = new System.Drawing.Size(106, 23);
            this.AddObjectSetButton.TabIndex = 44;
            this.AddObjectSetButton.Text = "Add";
            this.AddObjectSetButton.UseVisualStyleBackColor = true;
            this.AddObjectSetButton.Click += new System.EventHandler(this.AddObjectSetButton_Click);
            // 
            // ItemEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 351);
            this.Controls.Add(this.RemoveObjectSetsButton);
            this.Controls.Add(this.AddObjectSetButton);
            this.Controls.Add(this.RemoveTextureChangeButton);
            this.Controls.Add(this.AddTextureChangeButton);
            this.Controls.Add(this.RemoveObjectButton);
            this.Controls.Add(this.AddObjectButton);
            this.Controls.Add(this.ObjectSetID);
            this.Controls.Add(this.ObjectSetIDLabel);
            this.Controls.Add(this.TexChangeDst);
            this.Controls.Add(this.ReplaceTexLabel);
            this.Controls.Add(this.TexChangeSrc);
            this.Controls.Add(this.SourceTexLabel);
            this.Controls.Add(this.RPK);
            this.Controls.Add(this.ObjectRPKLabel);
            this.Controls.Add(this.ObjectID);
            this.Controls.Add(this.ObjectIDLabel);
            this.Controls.Add(this.ObjectSetsLabel);
            this.Controls.Add(this.TextureChangeLabel);
            this.Controls.Add(this.ObjectSets);
            this.Controls.Add(this.TextureChanges);
            this.Controls.Add(this.ObjectsListLabel);
            this.Controls.Add(this.Objects);
            this.Controls.Add(this.U14);
            this.Controls.Add(this.U14Label);
            this.Controls.Add(this.U10);
            this.Controls.Add(this.U10Label);
            this.Controls.Add(this.U0F);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.U07);
            this.Controls.Add(this.U06);
            this.Controls.Add(this.U04Label);
            this.Controls.Add(this.U04);
            this.Controls.Add(this.SubID);
            this.Controls.Add(this.SubIDLabel);
            this.Controls.Add(this.DestID);
            this.Controls.Add(this.DestIDLabel);
            this.Controls.Add(this.Attribute);
            this.Controls.Add(this.AttributeLabel);
            this.Controls.Add(this.U09);
            this.Controls.Add(this.ItemNumberLabel);
            this.Controls.Add(this.ItemNumber);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Items);
            this.Name = "ItemEditorForm";
            this.Text = "Item Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Items;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox ItemNumber;
        private System.Windows.Forms.Label ItemNumberLabel;
        private System.Windows.Forms.TextBox U09;
        private System.Windows.Forms.TextBox Attribute;
        private System.Windows.Forms.Label AttributeLabel;
        private System.Windows.Forms.TextBox DestID;
        private System.Windows.Forms.Label DestIDLabel;
        private System.Windows.Forms.Label SubIDLabel;
        private System.Windows.Forms.ComboBox SubID;
        private System.Windows.Forms.Label U04Label;
        private System.Windows.Forms.TextBox U04;
        private System.Windows.Forms.TextBox U06;
        private System.Windows.Forms.TextBox U07;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox U0F;
        private System.Windows.Forms.TextBox U10;
        private System.Windows.Forms.Label U10Label;
        private System.Windows.Forms.TextBox U14;
        private System.Windows.Forms.Label U14Label;
        private System.Windows.Forms.ListBox Objects;
        private System.Windows.Forms.Label ObjectsListLabel;
        private System.Windows.Forms.ListBox TextureChanges;
        private System.Windows.Forms.ListBox ObjectSets;
        private System.Windows.Forms.Label TextureChangeLabel;
        private System.Windows.Forms.Label ObjectSetsLabel;
        private System.Windows.Forms.Label ObjectIDLabel;
        private System.Windows.Forms.TextBox ObjectID;
        private System.Windows.Forms.Label ObjectRPKLabel;
        private System.Windows.Forms.TextBox RPK;
        private System.Windows.Forms.TextBox TexChangeSrc;
        private System.Windows.Forms.Label SourceTexLabel;
        private System.Windows.Forms.TextBox TexChangeDst;
        private System.Windows.Forms.Label ReplaceTexLabel;
        private System.Windows.Forms.TextBox ObjectSetID;
        private System.Windows.Forms.Label ObjectSetIDLabel;
        private System.Windows.Forms.Button AddObjectButton;
        private System.Windows.Forms.Button RemoveObjectButton;
        private System.Windows.Forms.Button RemoveTextureChangeButton;
        private System.Windows.Forms.Button AddTextureChangeButton;
        private System.Windows.Forms.Button RemoveObjectSetsButton;
        private System.Windows.Forms.Button AddObjectSetButton;
    }
}