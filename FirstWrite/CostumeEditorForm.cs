using FirstLib.FirstRead.Common;
using FirstLib.FirstRead;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWrite
{
    public partial class CostumeEditorForm : Form
    {
        private CharacterType ActiveCharacter;
        private CharacterItemTable CharacterItemTable;
        public CostumeEditorForm(CharacterItemTable characterItemTable, CharacterType activeCharacter)
        {
            InitializeComponent();
            ActiveCharacter = activeCharacter;
            CharacterItemTable = characterItemTable;
            // so apparently i broke that list somehow
            // it's empty but not... so
            Costumes.Items.Clear();

            foreach (var cos in CharacterItemTable.Costumes)
            {
                Costumes.Items.Add($"{ActiveCharacter.ToString().ToUpper().Substring(0, 3)}ITM{cos.CostumeID+1:D3}");
            }
        }

        private void Costumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Costumes.SelectedIndex != -1)
            {
                CostumeItems.Items.Clear();
                for (int i = 0; i < 25; i++)
                {
                    CostumeItems.Items.Add(Enum.GetName(typeof(SubID), (SubID)i));
                }
                CostumeID.Text = CharacterItemTable.Costumes[Costumes.SelectedIndex].CostumeID.ToString();
            }
        }

        private void CostumeItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Costumes.SelectedIndex != -1 || CostumeItems.SelectedIndex != -1)
            {
                ItemNumberTextBox.Text = CharacterItemTable.Costumes[Costumes.SelectedIndex].Parts[CostumeItems.SelectedIndex].ItemNumber.ToString();
            }
        }

        private void ItemNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Costumes.SelectedIndex != -1 && CostumeItems.SelectedIndex != -1)
            {
                if (short.TryParse(ItemNumberTextBox.Text, out short value))
                {
                    CharacterItemTable.Costumes[Costumes.SelectedIndex].Parts[CostumeItems.SelectedIndex].ItemNumber = value;
                }
            }
        }

        private void RemoveCostumeButton_Click(object sender, EventArgs e)
        {
            if (Costumes.SelectedIndex != -1)
            {
                CharacterItemTable.Costumes.RemoveAt(Costumes.SelectedIndex);
                Costumes.Items.RemoveAt(Costumes.SelectedIndex);
            }
        }

        private void AddCostumeButton_Click(object sender, EventArgs e)
        {
            short cosid;
            if (CharacterItemTable.Costumes.Count != 0)
            {
                cosid = (short)(CharacterItemTable.Costumes.Last().CostumeID + ((short)1));
            }
            else
            {
                cosid = 0;
            }
            Costume newCos = new Costume() { CostumeID = cosid };

            // since we don't initialize the parts list in the constructor...
            for (int i = 0; i < 25; i++)
            {
                newCos.Parts.Add(new CostumePart());
            }

            CharacterItemTable.Costumes.Add(newCos);
            Costumes.Items.Add($"{ActiveCharacter.ToString().ToUpper()}ITM{cosid+1:D3}");
        }

        private void CostumeID_TextChanged(object sender, EventArgs e)
        {
            if (Costumes.SelectedIndex != -1)
            {
                if (short.TryParse(CostumeID.Text, out short value))
                {
                    CharacterItemTable.Costumes[Costumes.SelectedIndex].CostumeID = value;
                    Costumes.Items[Costumes.SelectedIndex] = $"{ActiveCharacter.ToString()}ITM{value+1:D3}";
                }
            }
        }
    }
}
