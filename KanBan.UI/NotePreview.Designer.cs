namespace KanBan.UI
{
    partial class NotePreview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSonDegistirilmeTarihi = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssSonGuncellemeTarihi = new System.Windows.Forms.StatusStrip();
            this.ssSonGuncellemeTarihi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBaslik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(380, 32);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "label1";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcerik
            // 
            this.lblIcerik.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblIcerik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIcerik.Location = new System.Drawing.Point(20, 32);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(338, 227);
            this.lblIcerik.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackgroundImage = global::KanBan.UI.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(311, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 25);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundImage = global::KanBan.UI.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(347, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(141, 17);
            this.toolStripStatusLabel1.Text = "Son Değiştirilme Tarihi:";
            // 
            // tsslSonDegistirilmeTarihi
            // 
            this.tsslSonDegistirilmeTarihi.ForeColor = System.Drawing.Color.White;
            this.tsslSonDegistirilmeTarihi.Name = "tsslSonDegistirilmeTarihi";
            this.tsslSonDegistirilmeTarihi.Size = new System.Drawing.Size(0, 17);
            // 
            // ssSonGuncellemeTarihi
            // 
            this.ssSonGuncellemeTarihi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ssSonGuncellemeTarihi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslSonDegistirilmeTarihi});
            this.ssSonGuncellemeTarihi.Location = new System.Drawing.Point(0, 262);
            this.ssSonGuncellemeTarihi.Name = "ssSonGuncellemeTarihi";
            this.ssSonGuncellemeTarihi.Size = new System.Drawing.Size(380, 22);
            this.ssSonGuncellemeTarihi.TabIndex = 3;
            this.ssSonGuncellemeTarihi.Text = "statusStrip1";
            // 
            // NotePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ssSonGuncellemeTarihi);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblIcerik);
            this.Controls.Add(this.lblBaslik);
            this.Name = "NotePreview";
            this.Size = new System.Drawing.Size(380, 284);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NotePreview_MouseDown);
            this.ssSonGuncellemeTarihi.ResumeLayout(false);
            this.ssSonGuncellemeTarihi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslSonDegistirilmeTarihi;
        private System.Windows.Forms.StatusStrip ssSonGuncellemeTarihi;
    }
}
