using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstLib.FirstRead;
using System.IO;
using FirstLib.IO;

namespace FirstWrite
{
    public partial class STRAForm : Form
    {
        public ACCT AddonContentContainer;  // so we can edit the STRAs belonging to an ACCT a bit easier
        // not the best way to handle it, but it's the easiest for now
        public STRAForm(ACCT passAddonContentContainer)
        {
            InitializeComponent();
            AddonContentContainer = passAddonContentContainer;
            // To add the STRAs present to the ACCTStringArrays listbox with their indices
            for (int i = 0; i < AddonContentContainer.StringArrays.Count(); i++)
            {
                ACCTStringArrays.Items.Add($"STRA {i}");
            }
        }

        private void ACCTStringArrays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ACCTStringArrays.SelectedIndex != -1)
            {
                STRAStrings.Items.Clear();
                foreach (var str in AddonContentContainer.StringArrays[ACCTStringArrays.SelectedIndex].Strings)
                    STRAStrings.Items.Add(str.String);
            }
        }

        private void STRAStrings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (STRAStrings.SelectedIndex != -1 && STRAStrings.SelectedIndex < AddonContentContainer.StringArrays[ACCTStringArrays.SelectedIndex].Strings.Count())
            {
                STRAStringBox.Text = AddonContentContainer.StringArrays[ACCTStringArrays.SelectedIndex].Strings[STRAStrings.SelectedIndex].String;
                STRAStringId.Text = AddonContentContainer.StringArrays[ACCTStringArrays.SelectedIndex].Strings[STRAStrings.SelectedIndex].ID.ToString();
            }
        }

        private void STRAStringBox_TextChanged(object sender, EventArgs e)
        {
            AddonContentContainer.StringArrays[ACCTStringArrays.SelectedIndex].Strings[STRAStrings.SelectedIndex].String = STRAStringBox.Text;
            STRAStrings.Items[STRAStrings.SelectedIndex] = STRAStringBox.Text;
        }

        private void STRAStringId_TextChanged(object sender, EventArgs e)
        {
            uint.TryParse(STRAStringId.Text, out AddonContentContainer.StringArrays[ACCTStringArrays.SelectedIndex].Strings[STRAStrings.SelectedIndex].ID);
        }

        private void exportActiveSTRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This is where we a test
            if (STRAExportDialog.ShowDialog() == DialogResult.OK)
            {
                using (var file = File.Open(STRAExportDialog.FileName, FileMode.Create))
                {
                    using (var writer = new XWriter(file))
                    {
                        AddonContentContainer.StringArrays[ACCTStringArrays.SelectedIndex].Write(writer);
                    }
                }
            }
        }

        private void AddSTRA_Click(object sender, EventArgs e)
        {
            AddonContentContainer.StringArrays.Add(new STRA());
            ACCTStringArrays.Items.Add($"STRA {AddonContentContainer.StringArrays.Count() - 1}");
        }

        private void RemoveSTRA_Click(object sender, EventArgs e)
        {
            AddonContentContainer.StringArrays.RemoveAt(ACCTStringArrays.SelectedIndex);
            ACCTStringArrays.Items.RemoveAt(ACCTStringArrays.SelectedIndex);
        }

        private void AddString_Click(object sender, EventArgs e)
        {
            AddonContentContainer.StringArrays[ACCTStringArrays.SelectedIndex].Strings.Add(new STRAString() {String = "NewString"});
            STRAStrings.Items.Add("NewString");
        }

        private void RemoveString_Click(object sender, EventArgs e)
        {
            AddonContentContainer.StringArrays[ACCTStringArrays.SelectedIndex].Strings.RemoveAt(STRAStrings.SelectedIndex);
            STRAStrings.Items.RemoveAt(STRAStrings.SelectedIndex);
        }
    }
}
