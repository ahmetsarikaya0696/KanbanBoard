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
    public partial class ProjectFormHeader : Form
    {
        public event EventHandler ProjeEklendi;
        public ProjectFormHeader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtprojectName.Text))
            {
                ProjectAdmin.AddProject(txtprojectName.Text);
                txtprojectName.Clear();
                
                if (ProjeEklendi != null) ProjeEklendi(this, e);
            }
        }
    }
}
