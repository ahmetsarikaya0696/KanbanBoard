namespace KanBan.UI
{
    partial class AnaForm
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
            this.msAnaForm = new System.Windows.Forms.MenuStrip();
            this.tsmiAddNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.msAnaForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAnaForm
            // 
            this.msAnaForm.AllowMerge = false;
            this.msAnaForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNewProject});
            this.msAnaForm.Location = new System.Drawing.Point(0, 0);
            this.msAnaForm.Name = "msAnaForm";
            this.msAnaForm.Size = new System.Drawing.Size(698, 25);
            this.msAnaForm.TabIndex = 1;
            // 
            // tsmiAddNewProject
            // 
            this.tsmiAddNewProject.Image = global::KanBan.UI.Properties.Resources.new_project;
            this.tsmiAddNewProject.Name = "tsmiAddNewProject";
            this.tsmiAddNewProject.Size = new System.Drawing.Size(134, 21);
            this.tsmiAddNewProject.Text = "Add New Project";
            this.tsmiAddNewProject.Click += new System.EventHandler(this.tsmiAddNewProject_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 384);
            this.Controls.Add(this.msAnaForm);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msAnaForm;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.msAnaForm.ResumeLayout(false);
            this.msAnaForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewProject;
        private System.Windows.Forms.MenuStrip msAnaForm;
    }
}