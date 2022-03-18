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
        public NoteForm()
        {
            InitializeComponent();
            txtNote.MaxLength = 280;
            tsslKalanKarakterSayisi.Text = $"0   / {txtNote.MaxLength}";
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            tsslKalanKarakterSayisi.Text =  $"{(txtNote.MaxLength - txtNote.Text.Length)} / {txtNote.MaxLength}";
        }

        private void saveAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // notu veri tabanına kaydet
            // notun txt ve kategorilerini notepreview item a kaydet

        }
    }
}
