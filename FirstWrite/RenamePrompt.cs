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
    public partial class RenamePrompt : Form
    {
        public bool Confirm;
        public string NewVal;
        public RenamePrompt(string baseText = "")
        {
            InitializeComponent();
            RenameInputPrompt.Text = baseText;
        }

        private void RenameConfirmButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            NewVal = RenameInputPrompt.Text;
            this.Close();
        }

        private void RenameCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
