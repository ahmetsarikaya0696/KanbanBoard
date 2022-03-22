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
    public partial class MainForm : Form
    {
        private bool isFormOpen { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            isFormOpen = true;
        }

        private void tsmiAddNewProject_Click(object sender, EventArgs e)
        {
            ProjectFormHeader pfh = new ProjectFormHeader();
            pfh.ProjeEklendi += Pfh_ProjeEklendi;
            pfh.ShowDialog();

        }

        private void Pfh_ProjeEklendi(object sender, EventArgs e)
        {
            Project project = Datass.Projects.Last();

            ProjectForm projectForm = new ProjectForm(project);

            projectForm.MdiParent = this;
            projectForm.Show();
            Listele();

            projectForm.Disposed += ProjectForm_Disposed;
        }

        private void ProjectForm_Disposed(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            if (isFormOpen)
                LayoutMdi(MdiLayout.TileVertical);
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isFormOpen = false;
        }

        private void addAndEditCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            CategoryForm categoryForm = new CategoryForm(category);
            categoryForm.ShowDialog();
        }
    }
}
