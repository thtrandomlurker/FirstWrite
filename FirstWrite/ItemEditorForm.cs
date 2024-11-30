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
using FirstLib.FirstRead.Common;

namespace FirstWrite
{
    public partial class ItemEditorForm : Form
    {
        private CharacterType ActiveCharacter;
        private CharacterItemTable CharacterItemTable;
        public ItemEditorForm(CharacterItemTable characterItemTable, CharacterType activeCharacter)
        {
            InitializeComponent();
            ActiveCharacter = activeCharacter;
            CharacterItemTable = characterItemTable;
            // init
            foreach (var item in CharacterItemTable.Items)
            {
                // construct the string
                // get the character, set number, and part name
                Items.Items.Add($"{ActiveCharacter.ToString().ToUpper().Substring(0, 3)}ITM{item.ItemNumber:D3}");
            }
        }

        private void Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                ItemNumber.Text = CharacterItemTable.Items[Items.SelectedIndex].ItemNumber.ToString();
                Attribute.Text = CharacterItemTable.Items[Items.SelectedIndex].Attribute.ToString();
                U04.Text = CharacterItemTable.Items[Items.SelectedIndex].U04.ToString();
                U06.Text = CharacterItemTable.Items[Items.SelectedIndex].U06.ToString();
                U07.Text = CharacterItemTable.Items[Items.SelectedIndex].U07.ToString();
                Type.Text = CharacterItemTable.Items[Items.SelectedIndex].Type.ToString();
                U09.Text = CharacterItemTable.Items[Items.SelectedIndex].U09.ToString();
                DestID.Text = CharacterItemTable.Items[Items.SelectedIndex].DestID.ToString();
                SubID.Text = CharacterItemTable.Items[Items.SelectedIndex].SubID.ToString();
                U0F.Text = CharacterItemTable.Items[Items.SelectedIndex].U0F.ToString();
                U10.Text = CharacterItemTable.Items[Items.SelectedIndex].U10.ToString();
                U14.Text = CharacterItemTable.Items[Items.SelectedIndex].U14.ToString();

                // cleanup from previous
                Objects.Items.Clear();
                TextureChanges.Items.Clear();
                ObjectSets.Items.Clear();

                foreach (var itmObject in CharacterItemTable.Items[Items.SelectedIndex].Objects)
                {
                    Objects.Items.Add(itmObject.ObjectID.ToString());
                }

                foreach (var texChange in CharacterItemTable.Items[Items.SelectedIndex].TextureChanges)
                {
                    TextureChanges.Items.Add(texChange.OriginalTextureID.ToString());
                }

                foreach (var objectSet in CharacterItemTable.Items[Items.SelectedIndex].ObjectSets)
                {
                    ObjectSets.Items.Add(objectSet.ToString());
                }
            }
        }

        private void Objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Objects.SelectedIndex != -1)
            {
                ObjectID.Text = CharacterItemTable.Items[Items.SelectedIndex].Objects[Objects.SelectedIndex].ObjectID.ToString();
                RPK.Text = CharacterItemTable.Items[Items.SelectedIndex].Objects[Objects.SelectedIndex].RPK.ToString();
            }
        }

        private void TextureChanges_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextureChanges.SelectedIndex != -1)
            {
                TexChangeSrc.Text = CharacterItemTable.Items[Items.SelectedIndex].TextureChanges[TextureChanges.SelectedIndex].OriginalTextureID.ToString();
                TexChangeDst.Text = CharacterItemTable.Items[Items.SelectedIndex].TextureChanges[TextureChanges.SelectedIndex].ReplacementTextureID.ToString();
            }
        }

        private void ObjectSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ObjectSets.SelectedIndex != -1)
            {
                ObjectSetID.Text = CharacterItemTable.Items[Items.SelectedIndex].ObjectSets[ObjectSets.SelectedIndex].ToString();
            }
        }

        private void RemoveObjectButton_Click(object sender, EventArgs e)
        {
            if (Objects.SelectedIndex != -1)
            {
                CharacterItemTable.Items[Items.SelectedIndex].Objects.RemoveAt(Objects.SelectedIndex);
                Objects.Items.RemoveAt(Objects.SelectedIndex);
            }
        }

        private void RemoveTextureChangeButton_Click(object sender, EventArgs e)
        {
            if (TextureChanges.SelectedIndex != -1)
            {
                CharacterItemTable.Items[Items.SelectedIndex].TextureChanges.RemoveAt(TextureChanges.SelectedIndex);
                TextureChanges.Items.RemoveAt(TextureChanges.SelectedIndex);
            }
        }

        private void RemoveObjectSetsButton_Click(object sender, EventArgs e)
        {
            if (ObjectSets.SelectedIndex != -1)
            {
                CharacterItemTable.Items[Items.SelectedIndex].ObjectSets.RemoveAt(ObjectSets.SelectedIndex);
                ObjectSets.Items.RemoveAt(ObjectSets.SelectedIndex);
            }
        }

        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            CharacterItemTable.Items[Items.SelectedIndex].Objects.Add(new ItemObject());
            Objects.Items.Add("0");
        }

        private void AddTextureChangeButton_Click(object sender, EventArgs e)
        {
            CharacterItemTable.Items[Items.SelectedIndex].TextureChanges.Add(new TextureChange());
            TextureChanges.Items.Add("0");
        }

        private void AddObjectSetButton_Click(object sender, EventArgs e)
        {
            CharacterItemTable.Items[Items.SelectedIndex].ObjectSets.Add(0);
            ObjectSets.Items.Add("0");
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                CharacterItemTable.Items.RemoveAt(Items.SelectedIndex);
                Items.Items.RemoveAt(Items.SelectedIndex);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CharacterItemTable.Items.Add(new Item());
            Items.Items.Add($"{ActiveCharacter.ToString().ToUpper().Substring(0, 3)}ITM000");
        }

        private void ItemNumber_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                if (short.TryParse(ItemNumber.Text, out short value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].ItemNumber = value;
                }
            }
        }

        private void Type_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                if (byte.TryParse(Type.Text, out byte value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].Type = value;
                }
            }
        }

        private void U06_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                if (byte.TryParse(U06.Text, out byte value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].U06 = value;
                }
            }
        }

        private void U09_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                if (byte.TryParse(U09.Text, out byte value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].U09 = value;
                }
            }
        }

        private void U07_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                if (byte.TryParse(U07.Text, out byte value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].U07 = value;
                }
            }
        }

        private void U0F_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                if (byte.TryParse(U0F.Text, out byte value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].U0F = value;
                }
            }
        }

        private void U04_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                if (short.TryParse(U04.Text, out short value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].U04 = value;
                }
            }
        }

        private void Attribute_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                if (short.TryParse(Attribute.Text, out short value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].Attribute = value;
                }
            }
        }

        private void DestID_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                if (byte.TryParse(DestID.Text, out byte value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].DestID = value;
                }
            }
        }

        private void U10_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                if (int.TryParse(U10.Text, out int value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].U10 = value;
                }
            }
        }

        private void U14_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1)
            {
                if (int.TryParse(U14.Text, out int value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].U14 = value;
                }
            }
        }

        private void ObjectID_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1 && Objects.SelectedIndex != -1)
            {
                if (uint.TryParse(ObjectID.Text, out uint value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].Objects[Objects.SelectedIndex].ObjectID = value;
                }
            }
        }

        private void RPK_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1 && Objects.SelectedIndex != -1)
            {
                if (byte.TryParse(RPK.Text, out byte value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].Objects[Objects.SelectedIndex].RPK = value;
                }
            }
        }

        private void TexChangeSrc_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1 && TextureChanges.SelectedIndex != -1)
            {
                if (uint.TryParse(TexChangeSrc.Text, out uint value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].TextureChanges[TextureChanges.SelectedIndex].OriginalTextureID = value;
                }
            }
        }

        private void TexChangeDst_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1 && TextureChanges.SelectedIndex != -1)
            {
                if (uint.TryParse(TexChangeDst.Text, out uint value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].TextureChanges[TextureChanges.SelectedIndex].ReplacementTextureID = value;
                }
            }
        }

        private void ObjectSetID_TextChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1 && ObjectSets.SelectedIndex != -1)
            {
                if (uint.TryParse(ObjectSetID.Text, out uint value))
                {
                    CharacterItemTable.Items[Items.SelectedIndex].ObjectSets[ObjectSets.SelectedIndex] = value;
                }
            }
        }

        private void SubID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex != -1 && SubID.SelectedIndex != -1)
            {
                CharacterItemTable.Items[Items.SelectedIndex].SubID = (SubID)SubID.SelectedIndex;  // this is more likely to work since it gets initialized with the values of the SubID enum.
            }
        }
    }
}
