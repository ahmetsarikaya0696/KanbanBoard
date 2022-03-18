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
        NoteForm noteForm;
        public NotePreview()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            noteForm = new NoteForm();
            noteForm.ShowDialog();
        }

        private void NotePreview_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownMetot(sender, e);
        }

        private void MouseDownMetot(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var btn = sender as Control;
                this.DoDragDrop(btn.Name, DragDropEffects.Move);
            }
        }
    }
}
