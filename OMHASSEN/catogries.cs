using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMHASSEN
{
    public partial class catogries : Form
    {
        storeEntities2 context = new storeEntities2();
        public catogries()
        {
            InitializeComponent();
        }
        public class supproductlocal
        {
            public String CatName { get; set; }


        }
        List<supproductlocal> supproductlocalList = new List<supproductlocal>();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
               
                if(CategoryText.Text!="")
                {
                var check = context.Categories.Where(d => d.Name == CategoryText.Text).FirstOrDefault();
                    if (check==null)
                    {
                        ListViewItem items = new ListViewItem(CategoryText.Text, 0);
                        //items.SubItems.Add(TextBox1.text);
                           CategoryListView.Items.AddRange(new ListViewItem[] { items });
                        supproductlocal locallist = new supproductlocal();
                        locallist.CatName = CategoryText.Text;
                        supproductlocalList.Add(locallist);
                        CategoryText.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("  الصنف موجود ");

                    }

                }

                else
                {
                    
                        MessageBox.Show("ادخل الصنف");
                    
                }
               
            }
            catch
            {

            }
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = CategoryListView.Items.Count - 1; i >= 0; i--)
                {
                    if (CategoryListView.Items[i].Selected)
                    {
                        CategoryListView.Items[i].Remove();
                    }
                }
            }
            catch
            {

            }

            
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {

            Category newCat = new Category();
            foreach (var item in supproductlocalList)
            {
                newCat.Name = item.CatName;
                context.Categories.Add(newCat);
                context.SaveChanges();
                    
            }
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategoryText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
