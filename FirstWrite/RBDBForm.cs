using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FirstLib.FirstRead;
using FirstLib.IO;
using FirstLib.FirstRead.Common;

namespace FirstWrite
{
    public partial class RBDBForm : Form
    {
        public ACCT AddonContentContainer;
        public RBDBForm(ACCT passAddonContentContainer)
        {
            InitializeComponent();
            AddonContentContainer = passAddonContentContainer;  // this again
            for (int i = 0; i < AddonContentContainer.RobDatabases.Count(); i++)
            {
                ACCTRobDatabases.Items.Add($"Rob Database {i}");
            }
        }

        /*private void ACCTRobDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ACCTRobDatabases.SelectedIndex != -1)
            {
                RBDBCharacterItemTables.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    if (ACPKPackageType.Text != "")
                          AddonContent.AddonContentPackage.PackageType = (ACPKType)Enum.Parse(typeof(ACPKType), ACPKPackageType.Text);
                    
                    RBDBCharacterItemTables.Items.Add(Enum.GetName(typeof(CharacterType), i));
                }
                foreach (var item in AddonContentContainer.RobDatabases[ACCTRobDatabases.SelectedIndex].CustomizeItems)
                {
                    RBDBCustomizeItems.Items.Add(item.ItemNumber.ToString());
                }
            }
        }*/

        /*private void RBDBCharacterItemTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RBDBCharacterItemTables.SelectedIndex != -1)
            {
                CharacterItems.Items.Clear();
                CharacterItemKeepInFile.Checked = AddonContentContainer.RobDatabases[ACCTRobDatabases.SelectedIndex].PresentCharacters[RBDBCharacterItemTables.SelectedIndex];
                foreach (var item in AddonContentContainer.RobDatabases[ACCTRobDatabases.SelectedIndex].CharacterItemTables[RBDBCharacterItemTables.SelectedIndex].Items)
                {
                    foreach (var stra in AddonContentContainer.StringArrays)
                    {
                        STRAReturn check = stra.GetStringById(uint.Parse($"190{RBDBCharacterItemTables.SelectedIndex:D2}{item.ItemNumber:D4}"));
                        if (check.Successful)
                        {
                            CharacterItems.Items.Add(check.String);
                            break;
                        }
                    }
                }
            }
        }*/

        /*private void CharacterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CharacterItems.SelectedIndex != -1)
            {
                CharacterItemName.Text = (string)CharacterItems.Items[CharacterItems.SelectedIndex];
            }
        }*/

        /*private void CharacterItemName_TextChanged(object sender, EventArgs e)
        {
            foreach (var stra in AddonContentContainer.StringArrays)
            {
                // let's be honest. if this is happening, the string probably exists
                // since it should be created on adding an item entry if i do things right
                if (stra.SetStringById(uint.Parse($"190{RBDBCharacterItemTables.SelectedIndex:D2}{AddonContentContainer.RobDatabases[ACCTRobDatabases.SelectedIndex].CharacterItemTables[RBDBCharacterItemTables.SelectedIndex].Items[CharacterItems.SelectedIndex].ItemNumber:D4}"), CharacterItemName.Text))
                    break;
            }
            CharacterItems.Items[CharacterItems.SelectedIndex] = CharacterItemName.Text;
        }*/

        private void ExportActiveRobDatabase_Click(object sender, EventArgs e)
        {
            // This is where we a test
            if (RBDBExportDialog.ShowDialog() == DialogResult.OK)
            {
                using (var file = File.Open(RBDBExportDialog.FileName, FileMode.Create))
                {
                    using (var writer = new XWriter(file))
                    {
                        AddonContentContainer.RobDatabases[ACCTRobDatabases.SelectedIndex].Write(writer);
                        writer.WriteEOFC();
                    }
                }
            }
        }

        private void CharacterItemEditor_Click(object sender, EventArgs e)
        {
            CharacterItemEditorForm characterItemEditor = new CharacterItemEditorForm(AddonContentContainer.RobDatabases[ACCTRobDatabases.SelectedIndex]);
            characterItemEditor.Show();
        }
    }
}
