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
       
        public AnaForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void tsmiAddNewProject_Click(object sender, EventArgs e)
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
            foreach (var item in Veriler.AktifFormList)
                item.Show();
           
            LayoutMdi(MdiLayout.TileVertical);

        }
    }
}
