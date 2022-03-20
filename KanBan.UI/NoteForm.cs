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
        public event EventHandler DegisikliklerKaydedildi;

        private Proje proje;
        private Not not;

        public NoteForm(Proje proje, Not not)
        {
            this.proje = proje;
            this.not = not;
            InitializeComponent();
            txtIcerik.MaxLength = 140;
            tsslKalanKarakterSayisi.Text = $"0   / {txtIcerik.MaxLength}";
        }
        //copyconstructor ile kodları azalt
        public NoteForm(Not not)
        {
            this.not = not;
            InitializeComponent();
            txtBaslik.Text = not.Baslik;
            txtIcerik.Text = not.Icerik;
            //kategori vs
            txtIcerik.MaxLength = 140;
            tsslKalanKarakterSayisi.Text = $"0   / {txtIcerik.MaxLength}";
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            tsslKalanKarakterSayisi.Text = $"{(txtIcerik.MaxLength - txtIcerik.Text.Length)} / {txtIcerik.MaxLength}";
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBaslik.Text.Trim() == "")
            {
                MessageBox.Show("Başlık boş olamaz");
                return;
            }

            not.Baslik = txtBaslik.Text.Trim();
            not.Icerik = txtIcerik.Text.Trim();
            //not.Kategori =
            not.SonGuncellenmeTarihi = DateTime.Now;
            ProjeYoneticisi.ProjeyeNotEkle(proje, not);
            if (DegisikliklerKaydedildi != null) DegisikliklerKaydedildi(this, e);

        }
    }
}
