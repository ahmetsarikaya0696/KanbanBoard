using KanBan.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBan.UI
{
    public partial class NoteForm : Form
    {
        private Not not;
        public event EventHandler DegisikliklerKaydedildi;
        public NoteForm(Not not)
        {
            this.not = not;
            InitializeComponent();
            txtIcerik.MaxLength = 140;
            tsslKalanKarakterSayisi.Text = $"0   / {txtIcerik.MaxLength}";
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            tsslKalanKarakterSayisi.Text =  $"{(txtIcerik.MaxLength - txtIcerik.Text.Length)} / {txtIcerik.MaxLength}";
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBaslik.Text))
            {
                not.Baslik = txtBaslik.Text;
                not.Icerik = txtIcerik.Text;
                //not.Kategori =
                not.SonGuncellenmeTarihi = DateTime.Now;
                
                if (DegisikliklerKaydedildi != null) DegisikliklerKaydedildi(this, e);
            }
        }
    }
}
