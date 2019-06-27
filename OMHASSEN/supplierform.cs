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
    public partial class supplierform : Form
    {
        public supplierform()
        {
            InitializeComponent();
        }
        storeEntities2 storeContext = new storeEntities2();


        public class supproductlocal
        {

            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }


        }
        List<supproductlocal> supproductlocalList = new List<supproductlocal>();


        private void btn_add_supllier_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem items = new ListViewItem(NameSupTxt.Text, 0);
                items.SubItems.Add(phoneSupTxt.Text);
                items.SubItems.Add(AddressSupTxt.Text);


                listViewSupplier.Items.AddRange(new ListViewItem[] { items });

                supproductlocal locallist = new supproductlocal();
                //add property to locallist
                locallist.Name = (NameSupTxt.Text);
                locallist.Phone = (phoneSupTxt.Text);
                locallist.Address = (AddressSupTxt.Text);
                supproductlocalList.Add(locallist);


            }
            catch
            {

            }



        }

        private void NameSupTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddressSupTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void phoneSupTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove_supllier_Click(object sender, EventArgs e)
        {
            try
            {

            for (int i = listViewSupplier.Items.Count - 1; i >= 0; i--)
            {
                if (listViewSupplier.Items[i].Selected)
                {

                    listViewSupplier.Items[i].Remove();
                }
            }
            }
            catch
            {

            }
        }

        private void listViewSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_supllier_Click(object sender, EventArgs e)
        {
            try
            {
                Supplyer newSuppyer = new Supplyer();

                foreach (var item in supproductlocalList)
                {

                    newSuppyer.Name = item.Name;
                    newSuppyer.Phone = item.Phone;

                    newSuppyer.Address = item.Address;
                    storeContext.Supplyers.Add(newSuppyer);
                    storeContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("هناك عميل موجود بالفعل ");
            }


        }

        private void supplierform_Load(object sender, EventArgs e)
        {

        }
    }
}
