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
            if (txtprojectName.Text.Trim() != "")
            {
                ProjectAdmin.AddProject(txtprojectName.Text.Trim());
                txtprojectName.Clear();

                if (ProjeEklendi != null) ProjeEklendi(this, e);
            }
            else
            {
                MessageBox.Show("Project title can't be empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
