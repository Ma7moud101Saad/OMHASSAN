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
    public partial class searchproduct : Form
    {
        storeEntities2 context = new storeEntities2();
        public searchproduct()
        {
            InitializeComponent();
        }

        private void comboSupplyer_SelectedIndexChanged(object sender, EventArgs e)
        {



            ListViewItem item = new ListViewItem();
          //  int ids = int.Parse(comboSupplyer.Text);
            //var con = context.Categories.FirstOrDefault(C => C.ID ==ids );

            //item.SubItems.Add(con.ID.ToString());
            //item.SubItems.Add(con.Name.ToString());

            //listView1.Items.Add(item);
           

        }

        private void searchproduct_Load(object sender, EventArgs e)
        {
          List<Category>listCat=  context.Categories.ToList();
            
            comboSupplyer.DisplayMember = "Name";
            comboSupplyer.ValueMember = "ID";
            comboSupplyer.DataSource = listCat;

            // comboSupplyer.ValueMember = "ID";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = (int)comboSupplyer.SelectedValue;
            //MessageBox.Show(x.ToString());

            var items = context.Products.Where(e1 => e1.CategoryObj_ID == x ).ToList();
            
            foreach (var i in items)
            {
                
                ListViewItem lsi = new ListViewItem(i.ID.ToString());
                lsi.SubItems.Add(i.Name.ToString());
                lsi.SubItems.Add(i.AmountInStock.ToString());
                lsi.SubItems.Add(i.MeasuringUnits.ToString());
                lsi.SubItems.Add(i.WholesalePrice.ToString());
                lsi.SubItems.Add(i.RetailPrice.ToString());

                listView1.Items.Add(lsi);
            }
           // MessageBox.Show(comboSupplyer.Text);
            
        }
    }
}
