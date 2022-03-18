namespace KanBan.UI
{
    partial class ProjectForm
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
            this.msProjectContainer = new System.Windows.Forms.MenuStrip();
            this.tsmiAddNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flpDone = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDone = new System.Windows.Forms.Label();
            this.flpDoing = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDoing = new System.Windows.Forms.Label();
            this.flpToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblToDo = new System.Windows.Forms.Label();
            this.msProjectContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpDone.SuspendLayout();
            this.flpDoing.SuspendLayout();
            this.flpToDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // msProjectContainer
            // 
            this.msProjectContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNote});
            this.msProjectContainer.Location = new System.Drawing.Point(0, 0);
            this.msProjectContainer.Name = "msProjectContainer";
            this.msProjectContainer.Size = new System.Drawing.Size(786, 25);
            this.msProjectContainer.TabIndex = 4;
            this.msProjectContainer.Text = "menuStrip1";
            // 
            // tsmiAddNote
            // 
            this.tsmiAddNote.Image = global::KanBan.UI.Properties.Resources.add;
            this.tsmiAddNote.Name = "tsmiAddNote";
            this.tsmiAddNote.Size = new System.Drawing.Size(93, 21);
            this.tsmiAddNote.Text = "Add Note";
            this.tsmiAddNote.Click += new System.EventHandler(this.tsmiAddNote_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Controls.Add(this.flpDone, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpDoing, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpToDo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 505);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // flpDone
            // 
            this.flpDone.AllowDrop = true;
            this.flpDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDone.Controls.Add(this.lblDone);
            this.flpDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDone.Location = new System.Drawing.Point(525, 3);
            this.flpDone.Name = "flpDone";
            this.flpDone.Size = new System.Drawing.Size(258, 499);
            this.flpDone.TabIndex = 21;
            this.flpDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpDone_DragDrop);
            this.flpDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpDone_DragEnter);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.BackColor = System.Drawing.Color.PaleGreen;
            this.lblDone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.Location = new System.Drawing.Point(3, 0);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(59, 20);
            this.lblDone.TabIndex = 0;
            this.lblDone.Text = "DONE";
            this.lblDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpDoing
            // 
            this.flpDoing.AllowDrop = true;
            this.flpDoing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDoing.Controls.Add(this.lblDoing);
            this.flpDoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDoing.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDoing.Location = new System.Drawing.Point(264, 3);
            this.flpDoing.Name = "flpDoing";
            this.flpDoing.Size = new System.Drawing.Size(255, 499);
            this.flpDoing.TabIndex = 20;
            this.flpDoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpDoing_DragDrop);
            this.flpDoing.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpDoing_DragEnter);
            // 
            // lblDoing
            // 
            this.lblDoing.AutoSize = true;
            this.lblDoing.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblDoing.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoing.Location = new System.Drawing.Point(3, 0);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(67, 20);
            this.lblDoing.TabIndex = 0;
            this.lblDoing.Text = "DOING";
            this.lblDoing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpToDo
            // 
            this.flpToDo.AllowDrop = true;
            this.flpToDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpToDo.Controls.Add(this.lblToDo);
            this.flpToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpToDo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpToDo.Location = new System.Drawing.Point(3, 3);
            this.flpToDo.Name = "flpToDo";
            this.flpToDo.Size = new System.Drawing.Size(255, 499);
            this.flpToDo.TabIndex = 19;
            this.flpToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpToDo_DragDrop);
            this.flpToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpToDo_DragEnter);
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDo.Location = new System.Drawing.Point(3, 0);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(58, 20);
            this.lblToDo.TabIndex = 0;
            this.lblToDo.Text = "TODO";
            this.lblToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.msProjectContainer);
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
            this.msProjectContainer.ResumeLayout(false);
            this.msProjectContainer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flpDone.ResumeLayout(false);
            this.flpDone.PerformLayout();
            this.flpDoing.ResumeLayout(false);
            this.flpDoing.PerformLayout();
            this.flpToDo.ResumeLayout(false);
            this.flpToDo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msProjectContainer;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNote;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpDone;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.FlowLayoutPanel flpDoing;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.FlowLayoutPanel flpToDo;
        private System.Windows.Forms.Label lblToDo;
    }
}