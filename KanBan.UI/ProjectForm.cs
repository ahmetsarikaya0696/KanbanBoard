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
    public partial class ProjectForm : Form
    {
        private Project project;
        public ProjectForm(Project project)
        {
            InitializeComponent();
            this.project = project;
            this.Text = project.Name;
            lblToDo.Width = lblDoing.Width = lblDone.Width = flpToDo.Width = flpDoing.Width = flpDone.Width = ClientSize.Width;
            flpToDo.Height = flpDoing.Height = flpDone.Height = ClientSize.Height;

            flpToDo.Tag = StatuEnum.todo;
            flpDoing.Tag = StatuEnum.doing;
            flpDone.Tag = StatuEnum.done;
        }



        private void tsmiAddNote_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            NoteUserControl noteForm = new NoteUserControl(project, note);
            flpToDo.Controls.Add(noteForm);

        }

        
        private void deleteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Delete Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ProjectAdmin.DeleteProject(project);
                this.Close();
            }

        }

        private void flpToDo_DragEnter(object sender, DragEventArgs e)
        {
            DragEnterMetot(e);
        }

        private void flpDoing_DragEnter(object sender, DragEventArgs e)
        {
            DragEnterMetot(e);
        }

        private void flpDone_DragEnter(object sender, DragEventArgs e)
        {
            DragEnterMetot(e);
        }

        private void flpToDo_DragDrop(object sender, DragEventArgs e)
        {
            DragDropMetot(sender, e);
        }

        private void flpDoing_DragDrop(object sender, DragEventArgs e)
        {
            DragDropMetot(sender, e);
        }

        private void flpDone_DragDrop(object sender, DragEventArgs e)
        {
            DragDropMetot(sender, e);
        }

        private void DragDropMetot(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string)))
                return;

            var name = e.Data.GetData(typeof(string)) as string;
            var ctr = Controls.Find(name, true).Where(x => ((NoteUserControl)x).Selected).FirstOrDefault();
            if (ctr != null)
            {
                ctr.Parent.Controls.Remove(ctr);
                var panel = sender as FlowLayoutPanel;
                ((FlowLayoutPanel)sender).Controls.Add(ctr);
            }
        }

        private static void DragEnterMetot(DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void ProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            project.isOpen = false;
            KanbanData.passiveProjects.Add(project);   
        }
    }
}
