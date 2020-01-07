using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleDesktop.Data;
using SampleDesktop.Models;

namespace SampleDesktop
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _dbContext;
        public Form1()
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryComboBox.ValueMember = "CategoryId";
            CategoryComboBox.DisplayMember = "Name"; 
            CategoryComboBox.DataSource = _dbContext.Categories.ToList();
        }

        private async void AddCategoryButton_Click(object sender, EventArgs e)
        {
            var newCategory = new Category() {Name = CategoryTextBox.Text};
            _dbContext.Categories.Add(newCategory);
            await _dbContext.SaveChangesAsync();
            MessageBox.Show($"ประเภทใหม่คือ {newCategory.Name} มีรหัสเป็น {newCategory.CategoryId}", "สำเร็จ!");
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = (Category)CategoryComboBox.SelectedItem;

        }
    }
}
