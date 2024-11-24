
namespace FirstWrite
{
    partial class RenamePrompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RenameInputPrompt = new System.Windows.Forms.TextBox();
            this.RenameCancelButton = new System.Windows.Forms.Button();
            this.RenameConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RenameInputPrompt
            // 
            this.RenameInputPrompt.Location = new System.Drawing.Point(12, 12);
            this.RenameInputPrompt.Name = "RenameInputPrompt";
            this.RenameInputPrompt.Size = new System.Drawing.Size(393, 20);
            this.RenameInputPrompt.TabIndex = 0;
            // 
            // RenameCancelButton
            // 
            this.RenameCancelButton.Location = new System.Drawing.Point(330, 38);
            this.RenameCancelButton.Name = "RenameCancelButton";
            this.RenameCancelButton.Size = new System.Drawing.Size(75, 23);
            this.RenameCancelButton.TabIndex = 3;
            this.RenameCancelButton.Text = "Cancel";
            this.RenameCancelButton.UseVisualStyleBackColor = true;
            this.RenameCancelButton.Click += new System.EventHandler(this.RenameCancelButton_Click);
            // 
            // RenameConfirmButton
            // 
            this.RenameConfirmButton.Location = new System.Drawing.Point(249, 38);
            this.RenameConfirmButton.Name = "RenameConfirmButton";
            this.RenameConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.RenameConfirmButton.TabIndex = 2;
            this.RenameConfirmButton.Text = "Rename";
            this.RenameConfirmButton.UseVisualStyleBackColor = true;
            this.RenameConfirmButton.Click += new System.EventHandler(this.RenameConfirmButton_Click);
            // 
            // RenamePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 69);
            this.Controls.Add(this.RenameCancelButton);
            this.Controls.Add(this.RenameConfirmButton);
            this.Controls.Add(this.RenameInputPrompt);
            this.Name = "RenamePrompt";
            this.Text = "RenamePrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RenameInputPrompt;
        private System.Windows.Forms.Button RenameCancelButton;
        private System.Windows.Forms.Button RenameConfirmButton;
    }
}