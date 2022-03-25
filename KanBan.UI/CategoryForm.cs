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
    
        Color selectedColor;
        bool ColorIsSelected = false;
        public CategoryForm()
        {
            
            InitializeComponent();
            colorDialog = new ColorDialog();
            lstCategories.DataSource = KanbanData.Categories;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            // güncelle kısmını if le
            if (btnAddCategory.Text == "Add Category" && txtCategoryName.Text.Trim() != "" && ColorIsSelected)
            {
                Category category = new Category();
                category.Color = btnAddCategory.BackColor;
                category.Name = txtCategoryName.Text.Trim();
                ProjectAdmin.AddCategory(category);
                ColorIsSelected=false;
                txtCategoryName.Clear();
            }
            else if (btnAddCategory.Text == "Update Category" && txtCategoryName.Text.Trim() != "" && ColorIsSelected)
            {
                var selectedCategory = (Category)lstCategories.SelectedItem;
                selectedCategory.Color = btnAddCategory.BackColor;
                selectedCategory.Name = txtCategoryName.Text.Trim();
                ColorIsSelected = false;
                txtCategoryName.Clear();
            }
            else if (txtCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("Category name can't be empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(btnChooseColor.BackColor == SystemColors.Control) // defaultrenk
            {
                MessageBox.Show("Color can't be empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstCategories_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstCategories.SelectedIndex != -1)
            {
                btnAddCategory.Text = "Update Category";
                btnCancel.Visible = true;
                var selectedCategory = (Category)lstCategories.SelectedItem;
                txtCategoryName.Text = selectedCategory.Name;

                // niye olmuyor bura kardeşim yaaaaaaa
                btnChooseColor.BackColor = selectedCategory.Color;
                ColorIsSelected = true;
            }
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
                ColorIsSelected = true;
                btnChooseColor.BackColor = selectedColor;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnAddCategory.Text = "Add Category";
            txtCategoryName.Clear();
            btnChooseColor.BackColor = SystemColors.Control;
        }
    }
}
