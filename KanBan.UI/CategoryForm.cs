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
    public partial class CategoryForm : Form
    {
        ColorDialog colorDialog;
        private Category category;
        Color selectedColor;
        bool ColorIsSelected = false;
        public CategoryForm(Category category)
        {
            this.category = category;
            InitializeComponent();
            colorDialog = new ColorDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
                ColorIsSelected = true;
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() != "" && ColorIsSelected)
            {
                category.Color = selectedColor;
                category.Name = txtCategoryName.Text.Trim();
                ProjectAdmin.AddCategory(category);
                MessageBox.Show("Category added!");
            }
        }
    }
}
