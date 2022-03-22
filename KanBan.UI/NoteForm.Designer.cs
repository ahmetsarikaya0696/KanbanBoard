namespace KanBan.UI
{
    partial class NoteForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CharLeft = new System.Windows.Forms.Label();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSonDegistirilmeTarihi = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssSonGuncellemeTarihi = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            this.ssSonGuncellemeTarihi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.CharLeft);
            this.panel1.Controls.Add(this.cboCategories);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBaslik);
            this.panel1.Controls.Add(this.txtIcerik);
            this.panel1.Controls.Add(this.ssSonGuncellemeTarihi);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 250);
            this.panel1.TabIndex = 0;
            // 
            // CharLeft
            // 
            this.CharLeft.Location = new System.Drawing.Point(213, 6);
            this.CharLeft.Name = "CharLeft";
            this.CharLeft.Size = new System.Drawing.Size(114, 45);
            this.CharLeft.TabIndex = 18;
            this.CharLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCategories
            // 
            this.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(66, 30);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(130, 21);
            this.cboCategories.TabIndex = 17;
            this.cboCategories.SelectedIndexChanged += new System.EventHandler(this.cboCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Title";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaslik.Location = new System.Drawing.Point(66, 9);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(130, 20);
            this.txtBaslik.TabIndex = 15;
            // 
            // txtIcerik
            // 
            this.txtIcerik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIcerik.Location = new System.Drawing.Point(3, 57);
            this.txtIcerik.MaxLength = 140;
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(324, 168);
            this.txtIcerik.TabIndex = 14;
            this.txtIcerik.TextChanged += new System.EventHandler(this.txtIcerik_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundImage = global::KanBan.UI.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(297, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 25);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChanges.BackgroundImage = global::KanBan.UI.Properties.Resources.floppy_disk;
            this.btnSaveChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveChanges.Location = new System.Drawing.Point(261, 3);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(30, 25);
            this.btnSaveChanges.TabIndex = 12;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
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
            this.ssSonGuncellemeTarihi.AutoSize = false;
            this.ssSonGuncellemeTarihi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ssSonGuncellemeTarihi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslSonDegistirilmeTarihi});
            this.ssSonGuncellemeTarihi.Location = new System.Drawing.Point(0, 228);
            this.ssSonGuncellemeTarihi.Name = "ssSonGuncellemeTarihi";
            this.ssSonGuncellemeTarihi.Size = new System.Drawing.Size(330, 22);
            this.ssSonGuncellemeTarihi.TabIndex = 13;
            this.ssSonGuncellemeTarihi.Text = "statusStrip1";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveChanges);
            this.MaximumSize = new System.Drawing.Size(330, 281);
            this.MinimumSize = new System.Drawing.Size(330, 281);
            this.Name = "NoteForm";
            this.Size = new System.Drawing.Size(330, 281);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NoteForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ssSonGuncellemeTarihi.ResumeLayout(false);
            this.ssSonGuncellemeTarihi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.ComboBox cboCategories;
        private System.Windows.Forms.Label CharLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip ssSonGuncellemeTarihi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslSonDegistirilmeTarihi;
    }
}
