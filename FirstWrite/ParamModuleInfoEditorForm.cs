using FirstLib.FirstRead;
using FirstLib.FirstRead.Common;
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
    public partial class ParamModuleInfoEditorForm : Form
    {
        private ModuleTable ModuleTable;
        public ParamModuleInfoEditorForm(ModuleTable moduleTable)
        {
            InitializeComponent();
            ModuleTable = moduleTable;

            foreach (var module in moduleTable.Modules)
            {
                ModuleInfos.Items.Add($"{module.Character.ToString()}ITM{module.CosID+1:D3}");
            }
        }

        private void ModuleInfos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1)
            {
                ModuleID.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].ModuleID.ToString();
                CostumeID.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].CosID.ToString();
                U04.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].U04.ToString();
                U06.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].U06.ToString();
                Effect.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].Effect.ToString();
                Cloud.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].Cloud.ToString();
                Chara.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].Character.ToString();
                Rarity.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].Rarity.ToString();
                U0D.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].U0D.ToString();
                U0E.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].U0E.ToString();
                U0F.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].U0F.ToString();
                U10.Text = ModuleTable.Modules[ModuleInfos.SelectedIndex].U10.ToString();
            }
        }

        private void ModuleID_TextChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1)
            {
                if (short.TryParse(ModuleID.Text, out short value))
                {
                    ModuleTable.Modules[ModuleInfos.SelectedIndex].ModuleID = value;
                }
            }
        }

        private void CostumeID_TextChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1)
            {
                if (short.TryParse(CostumeID.Text, out short value))
                {
                    ModuleTable.Modules[ModuleInfos.SelectedIndex].CosID = value;
                    ModuleInfos.Items[ModuleInfos.SelectedIndex] = $"{ModuleTable.Modules[ModuleInfos.SelectedIndex].Character.ToString()}ITM{value + 1:D3}";
                }
            }
        }

        private void U04_TextChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1)
            {
                if (short.TryParse(U04.Text, out short value))
                {
                    ModuleTable.Modules[ModuleInfos.SelectedIndex].U04 = value;
                }
            }
        }

        private void U06_TextChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1)
            {
                if (short.TryParse(U06.Text, out short value))
                {
                    ModuleTable.Modules[ModuleInfos.SelectedIndex].U06 = value;
                }
            }
        }

        private void Effect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1 && Effect.SelectedIndex != -1)
            {
                ModuleTable.Modules[ModuleInfos.SelectedIndex].Effect = (EffectType)Enum.Parse(typeof(EffectType), Effect.Text);
            }
        }

        private void Cloud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1 && Cloud.SelectedIndex != -1)
            {
                ModuleTable.Modules[ModuleInfos.SelectedIndex].Cloud = (CloudType)Enum.Parse(typeof(CloudType), Cloud.Text);
            }
        }

        private void Chara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1 && Chara.SelectedIndex != -1)
            {
                ModuleTable.Modules[ModuleInfos.SelectedIndex].Character = (CharacterType)Enum.Parse(typeof(CharacterType), Chara.Text);
            }
        }

        private void Rarity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1 && Rarity.SelectedIndex != -1)
            {
                ModuleTable.Modules[ModuleInfos.SelectedIndex].Rarity = (ModuleRarity)Enum.Parse(typeof(ModuleRarity), Rarity.Text);
            }
        }

        private void U0D_TextChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1)
            {
                if (byte.TryParse(U0D.Text, out byte value))
                {
                    ModuleTable.Modules[ModuleInfos.SelectedIndex].U0D = value;
                }
            }
        }

        private void U0E_TextChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1)
            {
                if (byte.TryParse(U0E.Text, out byte value))
                {
                    ModuleTable.Modules[ModuleInfos.SelectedIndex].U0E = value;
                }
            }
        }

        private void U0F_TextChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1)
            {
                if (byte.TryParse(U0F.Text, out byte value))
                {
                    ModuleTable.Modules[ModuleInfos.SelectedIndex].U0F = value;
                }
            }
        }

        private void U10_TextChanged(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1)
            {
                if (long.TryParse(U10.Text, out long value))
                {
                    ModuleTable.Modules[ModuleInfos.SelectedIndex].U10 = value;
                }
            }
        }

        private void AddModuleInfoButton_Click(object sender, EventArgs e)
        {
            ModuleTable.Modules.Add(new ModuleInfo());
            ModuleInfos.Items.Add($"ModuleInfo");
        }

        private void RemoveModuleInfoButton_Click(object sender, EventArgs e)
        {
            if (ModuleInfos.SelectedIndex != -1)
            {
                ModuleInfos.Items.RemoveAt(ModuleInfos.SelectedIndex);
                ModuleTable.Modules.RemoveAt(ModuleInfos.SelectedIndex);
            }
        }
    }
}
