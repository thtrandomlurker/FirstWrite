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
    public partial class ParamModuleUnlockOverridesEditorForm : Form
    {
        private ModuleUnlockOverrideTable ModuleUnlockOverrideTable;
        public ParamModuleUnlockOverridesEditorForm(ModuleUnlockOverrideTable uoTable)
        {
            InitializeComponent();
            ModuleUnlockOverrideTable = uoTable;

            foreach (var entry in ModuleUnlockOverrideTable.UnlockOverrides)
            {
                ModuleUnlockOverrides.Items.Add($"Module {entry.ModuleID}");
            }
        }

        private void ModuleUnlockOverrides_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModuleUnlockOverrides.SelectedIndex != -1)
            {
                Flags.Items.Clear();
                foreach (var flag in ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].OverrideFlags)
                {
                    Flags.Items.Add($"{flag.Unlocked}");
                }

                ModuleID.Text = ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].ModuleID.ToString();
            }
        }

        private void Flags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModuleUnlockOverrides.SelectedIndex != -1 && Flags.SelectedIndex != -1)
            {
                Flag.Text = ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].OverrideFlags[Flags.SelectedIndex].Unlocked.ToString();
                Unks.Items.Clear();
                foreach (var exflag in ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].OverrideFlags[Flags.SelectedIndex].Unks)
                {
                    Unks.Items.Add(exflag.ToString());
                }
            }
        }

        private void Flag_TextChanged(object sender, EventArgs e)
        {
            if (ModuleUnlockOverrides.SelectedIndex != -1 && Flags.SelectedIndex != -1)
            {
                if (byte.TryParse(Flag.Text, out byte value))
                {
                    ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].OverrideFlags[Flags.SelectedIndex].Unlocked = value;
                    Flags.Items[Flags.SelectedIndex] = $"{value}";
                }
            }
        }

        private void AddFlagButton_Click(object sender, EventArgs e)
        {
            ModuleUnlockOverrideDataSub flag = new ModuleUnlockOverrideDataSub();
            ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].OverrideFlags.Add(flag);
            Flags.Items.Add($"{flag.Unlocked}");
        }

        private void RemoveFlagButton_Click(object sender, EventArgs e)
        {
            if (ModuleUnlockOverrides.SelectedIndex != -1 && Flags.SelectedIndex != -1)
            {
                ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].OverrideFlags.RemoveAt(Flags.SelectedIndex);
                Flags.Items.RemoveAt(Flags.SelectedIndex);
            }
        }

        private void AddUnlockOverride_Click(object sender, EventArgs e)
        {
            ModuleUnlockOverrideData unlockOverride = new ModuleUnlockOverrideData();
            ModuleUnlockOverrideTable.UnlockOverrides.Add(unlockOverride);
            ModuleUnlockOverrides.Items.Add($"Module {unlockOverride.ModuleID}");
        }

        private void RemoveUnlockOverride_Click(object sender, EventArgs e)
        {
            if (ModuleUnlockOverrides.SelectedIndex != -1)
            {
                ModuleUnlockOverrides.Items.RemoveAt(ModuleUnlockOverrides.SelectedIndex);
                ModuleUnlockOverrideTable.UnlockOverrides.RemoveAt(ModuleUnlockOverrides.SelectedIndex);
            }
        }

        private void ModuleID_TextChanged(object sender, EventArgs e)
        {
            if (ModuleUnlockOverrides.SelectedIndex != -1)
            {
                if (short.TryParse(ModuleID.Text, out short value))
                {
                    ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].ModuleID = value;
                    ModuleUnlockOverrides.Items[ModuleUnlockOverrides.SelectedIndex] = $"Module {value}";
                }
            }
        }

        private void Unks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModuleUnlockOverrides.SelectedIndex != -1 && Flags.SelectedIndex != -1)
            {
                Unks.Text = ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].OverrideFlags[Flags.SelectedIndex].Unks[Unks.SelectedIndex].ToString();
            }
        }

        private void UnkValue_TextChanged(object sender, EventArgs e)
        {
            if (ModuleUnlockOverrides.SelectedIndex != -1 && Flags.SelectedIndex != -1 && Unks.SelectedIndex != -1)
            {
                if (int.TryParse(UnkValue.Text, out int value))
                {
                    ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].OverrideFlags[Flags.SelectedIndex].Unks[Unks.SelectedIndex] = value;
                }            }
        }

        private void RemoveExFlagButton_Click(object sender, EventArgs e)
        {
            if (ModuleUnlockOverrides.SelectedIndex != -1 && Flags.SelectedIndex != -1 && Unks.SelectedIndex != -1)
            {
                ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].OverrideFlags[Flags.SelectedIndex].Unks.RemoveAt(Unks.SelectedIndex);
                Unks.Items.RemoveAt(Unks.SelectedIndex);
            }
        }

        private void AddExFlagButton_Click(object sender, EventArgs e)
        {
            if (ModuleUnlockOverrides.SelectedIndex != -1 && Flags.SelectedIndex != -1)
            {
                ModuleUnlockOverrideTable.UnlockOverrides[ModuleUnlockOverrides.SelectedIndex].OverrideFlags[Flags.SelectedIndex].Unks.Add(0);
                Unks.Items.Add(0);
            }
        }
    }
}
