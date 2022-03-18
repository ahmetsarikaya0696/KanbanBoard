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
    public partial class AnaForm : Form
    {
        private bool isFormOpen { get; set; }
        public AnaForm()
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
            ProjectForm projectForm = new ProjectForm();

            projectForm.MdiParent = this;

            projectForm.Disposed += ProjectForm_Disposed;
            Veriler.AktifFormList.Add(projectForm);
            AktifFormlariListele();

        }

        private void ProjectForm_Disposed(object sender, EventArgs e)
        {
            Veriler.PasifFormList.Add((ProjectForm)sender);
            Veriler.AktifFormList.Remove((ProjectForm)sender);
            AktifFormlariListele();

        }

        private void AktifFormlariListele()
        {
            if (isFormOpen)
            {
                foreach (var item in Veriler.AktifFormList)
                    item.Show();

                LayoutMdi(MdiLayout.TileVertical);
            }
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isFormOpen = false;
        }
    }
}
