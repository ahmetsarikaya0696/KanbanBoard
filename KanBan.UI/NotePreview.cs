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
    public partial class NotePreview : UserControl
    {
        private Proje proje;
        private Not not;
        public bool Secilimi { get; set; }
        public NotePreview(Not not, Proje proje)
        {
            Secilimi = false;
            this.not = not;
            this.proje = proje;
            InitializeComponent();
            lblBaslik.Text = not.Baslik;
            lblIcerik.Text = not.Icerik;
            tsslSonDegistirilmeTarihi.Text = not.SonGuncellenmeTarihi.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           NoteForm noteForm = new NoteForm(not);
            noteForm.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // silmek istediğinize emin misiniz vs. ekle daha sonra
            ProjeYoneticisi.ProjedenNotSil(proje, not);
            this.Parent.Controls.Remove(this);
        }

        private void NotePreview_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownMetot(sender, e);
        }

        private void MouseDownMetot(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var notePreview = sender as NotePreview;
                notePreview.BackColor = Color.Blue;
                notePreview.Secilimi = true;
               
                DoDragDrop(notePreview.Name, DragDropEffects.Move);
                notePreview.BackColor = Color.White;
                notePreview.Secilimi = false;


            }
        }

    }
}
