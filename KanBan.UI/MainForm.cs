using KanBan.DATA;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            isFormOpen = true;
            this.WindowState = FormWindowState.Maximized;
            ReadKanbanDatas();
            // temp list for closed projects
            foreach (Project item in KanbanData.Projects)
            {
                if (!item.isOpen)
                    KanbanData.passiveProjects.Add(item);
            }
            lstClosedProjects.DataSource = KanbanData.passiveProjects;
        }


        private void tsmiAddNewProject_Click(object sender, EventArgs e)
        {
            ProjectFormHeader pfh = new ProjectFormHeader();
            pfh.ProjeEklendi += Pfh_ProjeEklendi;
            pfh.ShowDialog();

        }

        private void Pfh_ProjeEklendi(object sender, EventArgs e)
        {
            Project project = KanbanData.Projects.Last();

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

            foreach (Project item in KanbanData.Projects)
                item.isOpen = false;

            SaveKanbanDatas();
        }

        private void SaveKanbanDatas()
        {
            string projectsToJson = JsonConvert.SerializeObject(KanbanData.Projects);
            File.WriteAllText("projects.json", projectsToJson);

            string categoriesToJson = JsonConvert.SerializeObject(KanbanData.Categories);
            File.WriteAllText("categories.json", categoriesToJson);
        }
        private void ReadKanbanDatas()
        {
            try
            {
                string projectsFromJson = File.ReadAllText("projects.json");
                KanbanData.Projects = JsonConvert.DeserializeObject<BindingList<Project>>(projectsFromJson);

                string categoriesFromJson = File.ReadAllText("categories.json");
                KanbanData.Categories = JsonConvert.DeserializeObject<BindingList<Category>>(categoriesFromJson);
            }
            catch (Exception)
            {

            }
        }

        private void addAndEditCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void tsmiShowClosedProjects_Click(object sender, EventArgs e)
        {
            lstClosedProjects.Visible = !lstClosedProjects.Visible;
            Listele();
        }

        private void lstClosedProjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstClosedProjects.SelectedIndex != -1)
            {
                var selectedProject = lstClosedProjects.SelectedItem as Project;
                ProjectForm projectForm = new ProjectForm(selectedProject);
                KanbanData.passiveProjects.Remove(selectedProject);
                selectedProject.isOpen = true;
                projectForm.MdiParent = this;
                projectForm.Show();
                Listele();
            }
        }
    }
}
