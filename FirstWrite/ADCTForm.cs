using FirstLib.FirstRead;
using FirstLib.IO;
using System;
using System.IO;
using System.Windows.Forms;

namespace FirstWrite
{
    public partial class ADCTForm : Form
    {
        public ADCT AddonContent;
        public ADCTForm()
        {
            InitializeComponent();
            AddonContent = new ADCT();
        }

        private void ADCTMenuStripOpen_Click(object sender, EventArgs e)
        {
            // This is where we do the reading
            if (ADCTOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var file = File.Open(ADCTOpenFileDialog.FileName, FileMode.Open))
                {
                    using (var reader = new XReader(file))
                    {
                        AddonContent.AddonContentContainers.Clear();
                        AddonContent.Read(reader);
                        ACPKDescription.Text = AddonContent.AddonContentPackage.Description;
                        ACPKPackageId.Text = AddonContent.AddonContentPackage.PackageID.ToString();
                        ACPKPackageType.Text = AddonContent.AddonContentPackage.PackageType.ToString();
                        ACPKIsRequired.Checked = AddonContent.AddonContentPackage.IsRequired > 0;
                        ACPKU11.Text = AddonContent.AddonContentPackage.U11.ToString();
                        ADCTContainers.Items.Clear(); // ensure no leftovers are carried into the new file
                        foreach (var item in AddonContent.AddonContentContainers)
                        {
                            ADCTContainers.Items.Add(item.ContainerName);
                        }
                    }
                }
            }
        }

        private void ADCTMenuStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ACPKPackageType_TextChanged(object sender, EventArgs e)
        {
            if (ACPKPackageType.Text != "")
                AddonContent.AddonContentPackage.PackageType = (ACPKType)Enum.Parse(typeof(ACPKType), ACPKPackageType.Text);
        }

        private void ACPKIsRequired_Changed(object sender, EventArgs e)
        {
            AddonContent.AddonContentPackage.IsRequired = (byte)(ACPKIsRequired.Checked ? 1 : 0);
        }

        private void ACPKPackageId_TextChanged(object sender, EventArgs e)
        {
            short.TryParse(ACPKPackageId.Text, out AddonContent.AddonContentPackage.PackageID);
        }

        private void ACPKDescription_TextChanged(object sender, EventArgs e)
        {
            AddonContent.AddonContentPackage.Description = ACPKDescription.Text;
        }

        private void ACPKExportButton_Click(object sender, EventArgs e)
        {
            // This is where we a test
            if (ADCTSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var file = File.Open(ADCTSaveFileDialog.FileName, FileMode.Create))
                {
                    using (var writer = new XWriter(file))
                    {
                        AddonContent.AddonContentPackage.Write(writer);
                        writer.WriteEOFC();
                    }
                }
            }
        }

        private void ACPKU11_TextChanged(object sender, EventArgs e)
        {
            byte.TryParse(ACPKPackageId.Text, out AddonContent.AddonContentPackage.U11);
        }

        private void ADCTMenuStripSave_Click(object sender, EventArgs e)
        {
            // This is where we a test
            if (ADCTSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var file = File.Open(ADCTSaveFileDialog.FileName, FileMode.Create))
                {
                    using (var writer = new XWriter(file))
                    {
                        AddonContent.Write(writer);
                    }
                }
            }
        }

        private void ACCTEditButton_Click(object sender, EventArgs e)
        {
            if (ADCTContainers.SelectedIndex != -1)
            {
                ACCTForm addonContentContainerEditor = new ACCTForm(AddonContent.AddonContentContainers[ADCTContainers.SelectedIndex]);
                addonContentContainerEditor.Show();
            }
        }

        private void ACCTRenameButton_Click(object sender, EventArgs e)
        {
            using (var renameForm = new RenamePrompt(ADCTContainers.SelectedItem.ToString()))
            {
                if (renameForm.ShowDialog() == DialogResult.OK)
                {
                    if (ADCTContainers.SelectedIndex != -1)
                    {
                        ADCTContainers.Items[ADCTContainers.SelectedIndex] = renameForm.NewVal;
                        AddonContent.AddonContentContainers[ADCTContainers.SelectedIndex].ContainerName = renameForm.NewVal;
                    }
                }
            }
        }

        private void ADCTAddACCTButton_Click(object sender, EventArgs e)
        {
            AddonContent.AddonContentContainers.Add(new ACCT() { ContainerName = "cnt_new", U08 = 1 });
            ADCTContainers.Items.Add("cnt_new");
        }

        private void ADCTRemoveACCTButton_Click(object sender, EventArgs e)
        {
            AddonContent.AddonContentContainers.RemoveAt(ADCTContainers.SelectedIndex);
            ADCTContainers.Items.RemoveAt(ADCTContainers.SelectedIndex);
        }
    }
}
