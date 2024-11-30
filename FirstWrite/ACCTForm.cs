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
    public partial class ACCTForm : Form
    {
        public ACCT AddonContentContainer;
        public ACCTForm(ACCT passAddonContentContainer)
        {
            InitializeComponent();
            AddonContentContainer = passAddonContentContainer;
            ACCTNameLabel.Text = AddonContentContainer.ContainerName;
            ACCTContainerID.Text = AddonContentContainer.ContainerID.ToString();
            foreach (var path in AddonContentContainer.Paths)
            {
                ACCTPaths.Items.Add(path.FilePath + path.FileName);
            }
            foreach (var file in AddonContentContainer.Auth2DFlist)
            {
                ACCTAuth2DFlist.Items.Add(file);
            }
            foreach (var file in AddonContentContainer.ObjsetFlist)
            {
                ACCTObjsetFlist.Items.Add(file);
            }
        }

        private void ACCTPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ACCTPaths.SelectedIndex != -1)
            {
                ACCTPath.Text = AddonContentContainer.Paths[ACCTPaths.SelectedIndex].FilePath;
                ACCTFile.Text = AddonContentContainer.Paths[ACCTPaths.SelectedIndex].FileName;
                PathMode.Text = AddonContentContainer.Paths[ACCTPaths.SelectedIndex].Flags.ToString();
            }
        }

        private void ACCTPath_TextChanged(object sender, EventArgs e)
        {
            AddonContentContainer.Paths[ACCTPaths.SelectedIndex].FilePath = ACCTPath.Text;
            ACCTPaths.Items[ACCTPaths.SelectedIndex] = ACCTPath.Text + ACCTFile.Text;
        }

        private void ACCTFile_TextChanged(object sender, EventArgs e)
        {
            AddonContentContainer.Paths[ACCTPaths.SelectedIndex].FileName = ACCTFile.Text;
            ACCTPaths.Items[ACCTPaths.SelectedIndex] = ACCTPath.Text + ACCTFile.Text;
        }

        private void ACCTExportMenuOption_Click(object sender, EventArgs e)
        {
            // This is where we a test
            if (ACCTExportDialog.ShowDialog() == DialogResult.OK)
            {
                using (var file = File.Open(ACCTExportDialog.FileName, FileMode.Create))
                {
                    using (var writer = new XWriter(file))
                    {
                        AddonContentContainer.Write(writer);
                        writer.WriteEOFC();
                    }
                }
            }
        }

        private void ACCTPathsAddButton_Click(object sender, EventArgs e)
        {
            AddonContentContainer.Paths.Add(new ACCTPath() {FilePath = "", FileName = "NewFile", Flags = ACCTPathMode.Packed});
            ACCTPaths.Items.Add("NewFile");
        }

        private void ACCTPathsRemove_Click(object sender, EventArgs e)
        {
            if (ACCTPaths.SelectedIndex != -1)
            {
                AddonContentContainer.Paths.RemoveAt(ACCTPaths.SelectedIndex);
                ACCTPaths.Items.RemoveAt(ACCTPaths.SelectedIndex);
            }
        }

        private void ACCTAuth2DFlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ACCTAuth2DFlist.SelectedIndex != -1)
            {
                ACCTAuth2DFile.Text = AddonContentContainer.Auth2DFlist[ACCTAuth2DFlist.SelectedIndex];
            }
        }

        private void ACCTAuth2DFile_TextChanged(object sender, EventArgs e)
        {
            AddonContentContainer.Auth2DFlist[ACCTAuth2DFlist.SelectedIndex] = ACCTAuth2DFile.Text;
            ACCTAuth2DFlist.Items[ACCTAuth2DFlist.SelectedIndex] = ACCTAuth2DFile.Text;
        }

        private void ACCTObjsetFlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ACCTObjsetFlist.SelectedIndex != -1)
            {
                ACCTObjsetFile.Text = AddonContentContainer.ObjsetFlist[ACCTObjsetFlist.SelectedIndex];
            }
        }

        private void ACCTObjsetFile_TextChanged(object sender, EventArgs e)
        {
            AddonContentContainer.ObjsetFlist[ACCTObjsetFlist.SelectedIndex] = ACCTObjsetFile.Text;
            ACCTObjsetFlist.Items[ACCTObjsetFlist.SelectedIndex] = ACCTObjsetFile.Text;
        }

        private void ACCTAuth2DFlistAddButton_Click(object sender, EventArgs e)
        {
            AddonContentContainer.Auth2DFlist.Add("NewFile");
            ACCTAuth2DFlist.Items.Add("NewFile");
        }

        private void ACCTAuth2DFlistRemoveButton_Click(object sender, EventArgs e)
        {
            if (ACCTAuth2DFlist.SelectedIndex != -1)
            {
                AddonContentContainer.Auth2DFlist.RemoveAt(ACCTAuth2DFlist.SelectedIndex);
                ACCTAuth2DFlist.Items.RemoveAt(ACCTAuth2DFlist.SelectedIndex);
            }
        }

        private void ACCTObjsetFlistAddButton_Click(object sender, EventArgs e)
        {
            AddonContentContainer.ObjsetFlist.Add("NewFile");
            ACCTObjsetFlist.Items.Add("NewFile");
        }

        private void ACCTObjsetFlistRemoveButton_Click(object sender, EventArgs e)
        {
            if (ACCTObjsetFlist.SelectedIndex != -1)
            {
                AddonContentContainer.ObjsetFlist.RemoveAt(ACCTObjsetFlist.SelectedIndex);
                ACCTObjsetFlist.Items.RemoveAt(ACCTObjsetFlist.SelectedIndex);
            }
        }

        private void stringArrayEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STRAForm stringArrayEditor = new STRAForm(AddonContentContainer);
            stringArrayEditor.Show();
        }

        private void robDatabaseEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RBDBForm robDatabaseEditor = new RBDBForm(AddonContentContainer);
            robDatabaseEditor.Show();
        }

        private void ACCTContainerID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ACCTContainerID.Text, out int ID))
            {
                AddonContentContainer.ContainerID = ID;
            }
        }

        private void moduleInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddonContentContainer.ParameterDatabases.Count() != 0)
            {
                ParamModuleInfoEditorForm moduleInfoForm = new ParamModuleInfoEditorForm(AddonContentContainer.ParameterDatabases[0].ModuleTable);
                moduleInfoForm.Show();
            }
        }

        private void createPRDBIfNotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddonContentContainer.ParameterDatabases.Clear();
            AddonContentContainer.ParameterDatabases.Add(new PRDB());
            AddonContentContainer.ParameterDatabases[0].U00 = 4194304;
        }

        private void moduleUnlockOverrideInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddonContentContainer.ParameterDatabases.Count() != 0)
            {
                ParamModuleUnlockOverridesEditorForm overrideForm = new ParamModuleUnlockOverridesEditorForm(AddonContentContainer.ParameterDatabases[0].ModuleUnlockOverrideTable);
                overrideForm.Show();
            }
        }

        private void PathMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ACCTPaths.SelectedIndex != -1)
            {
                AddonContentContainer.Paths[ACCTPaths.SelectedIndex].Flags = (ACCTPathMode)Enum.Parse(typeof(ACCTPathMode), PathMode.Text);
            }
        }

        private void packedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var path in AddonContentContainer.Paths)
            {
                path.Flags = ACCTPathMode.Packed;
            }
        }

        private void unpackedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var path in AddonContentContainer.Paths)
            {
                path.Flags = ACCTPathMode.Unpacked;
            }
        }
    }
}
