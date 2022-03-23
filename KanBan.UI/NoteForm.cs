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
    public partial class NoteForm : UserControl
    {
        private Note note;
        private Project project;

        public NoteForm(Project project, Note note)
        {
            this.note = note;
            note.Statu = StatuEnum.todo;
            this.project = project;
            ProjectAdmin.AddNoteToProject(project, note);
            InitializeComponent();
            CharLeft.Text = "0 / 140";
            cboCategories.DataSource = Datass.Categories;
        }

        public bool Selected { get; private set; }

        private void MouseDownMetot(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {


                var noteForm = sender as NoteForm;
                noteForm.BackColor = Color.Blue;
                noteForm.Selected = true;

                // her şey dodragdroptan önce ve sonra belli oluyor
                DoDragDrop(noteForm.Name, DragDropEffects.Move);

                noteForm.BackColor = Color.White;
                noteForm.Selected = false;

                note.Statu = (StatuEnum)Parent.Tag;
            }
        }

        private void NoteForm_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownMetot(sender, e);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtBaslik.Text.Trim() != "" && cboCategories.SelectedIndex != -1)
            {
                note.Title = txtBaslik.Text.Trim();
                note.Icerik = txtIcerik.Text;
                note.Category = (Category)cboCategories.SelectedItem;
                MessageBox.Show("Changes have been succesfully saved!");
            }
            else
            {
                MessageBox.Show("Changes haven't been saved!");
            }
        }

        private void txtIcerik_TextChanged(object sender, EventArgs e)
        {
            CharLeft.Text = $"{txtIcerik.TextLength} / 140";
        }

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.BackColor = ((Category)cboCategories.SelectedItem).Color;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Delete Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ProjectAdmin.DeleteNoteFromProject(project, note);
                Parent.Controls.Remove(this);
            }
        }
    }
}
