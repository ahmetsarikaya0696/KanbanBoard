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
    public partial class NoteUserControl : UserControl
    {
        private Note note;
        private Project project;

        public NoteUserControl(Project project, Note note)
        {
            InitializeComponent();
            this.note = note;
           
            cboCategories.DataSource = KanbanData.Categories;
            cboCategories.ValueMember = "Id";
            cboCategories.DisplayMember = "Name";

            txtBaslik.Text = this.note.Title;
            txtIcerik.Text = this.note.Content;
            tsslSonDegistirilmeTarihi.Text = this.note.LastUpdateDate.ToString();
            cboCategories.SelectedValue = this.note.Category.Id;

            this.project = project;
            ProjectAdmin.AddNoteToProject(project, note);
            CharLeft.Text = "0 / 140";

        }

        public bool Selected { get; private set; }

        private void MouseDownMetot(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var noteForm = sender as NoteUserControl;
                noteForm.BackColor = Color.Blue;
                noteForm.Selected = true;

                // her şey dodragdroptan önce ve sonra belli oluyor
                DoDragDrop(noteForm.Name, DragDropEffects.Move);

                noteForm.BackColor = Color.White;
                noteForm.Selected = false;

                note.Statu = (StatuEnum)Parent.Tag;
            }
            else if (e.Button == MouseButtons.Right)
            {
                NoteUserControl noteform = (NoteUserControl)sender;
                contextMenuStrip1.Show(noteform, new Point(e.X, e.Y));
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
                note.Content = txtIcerik.Text;
                note.Category = (Category)cboCategories.SelectedItem;
                note.LastUpdateDate = DateTime.Now;
                tsslSonDegistirilmeTarihi.Text = DateTime.Now.ToString();
                MessageBox.Show("Changes have been succesfully saved!");
                note.isNoteSavedOnce = true;
                ProjectAdmin.AddNoteToProject(project, note);
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

        private void toDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyMethod("flpToDo");
        }
        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyMethod("flpDoing");
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyMethod("flpDone");
        }

        private void CopyMethod(string flpName)
        {

            if (cboCategories.SelectedValue != null && note.isNoteSavedOnce)
            {
                Note copyNote = new Note() { Content = note.Content, Category = note.Category, Statu = StatuEnum.todo, Title = note.Title };
                NoteUserControl copyNoteForm = new NoteUserControl(project, copyNote);
                var todo = Parent.Parent.Controls.OfType<FlowLayoutPanel>().FirstOrDefault(x => x.Name == flpName);
                //clbKategoriler.CheckedItems.OfType<Kategori>().ToList()
                copyNoteForm.txtBaslik.Text = note.Title;
                copyNoteForm.txtIcerik.Text = note.Content;
                copyNoteForm.cboCategories.SelectedValue = note.Category.Id;
                todo.Controls.Add(copyNoteForm);
                copyNote.Statu = (StatuEnum)copyNoteForm.Parent.Tag;
                ProjectAdmin.AddNoteToProject(project, copyNote);
                copyNote.isNoteSavedOnce = true;
            }
            else
            {
                MessageBox.Show("Try to choose a category and save the note first!");
            }

        }


    }
}
