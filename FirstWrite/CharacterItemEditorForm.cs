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
    public partial class CharacterItemEditorForm : Form
    {
        public RBDB RobDatabase;
        public CharacterItemEditorForm(RBDB robDatabase)
        {
            InitializeComponent();
            RobDatabase = robDatabase;
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            ItemEditorForm itemEditor = new ItemEditorForm(RobDatabase.CharacterItemTables[CharacterItemTables.SelectedIndex], (CharacterType)CharacterItemTables.SelectedIndex);
            itemEditor.Show();
        }

        private void CharacterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CharacterItemTables.SelectedIndex != -1)
            {
                KeepInFile.Checked = RobDatabase.CharacterItemTables[CharacterItemTables.SelectedIndex].KeepInFile;
            }
        }
    }
}
