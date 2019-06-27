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
    public partial class clientform : Form
    {
        public clientform()
        {
            InitializeComponent();
        }
        storeEntities2 storeContext = new storeEntities2();


        public class supproductlocal
        {
            public int NationalId { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }


        }

        List<supproductlocal> supproductlocalList = new List<supproductlocal>();



        private void listViewC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NationalIdClientTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameClientTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void phoneClientTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove_Client_Click(object sender, EventArgs e)
        {
            for (int i = listViewC.Items.Count - 1; i >= 0; i--)
            {
                if (listViewC.Items[i].Selected)
                {

                    listViewC.Items[i].Remove();
                }
            }
        }

        private void btn_add_Client_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem items = new ListViewItem(NameClientTxt.Text, 0);
                items.SubItems.Add(NationalIdClientTxt.Text);
                items.SubItems.Add(phoneClientTxt.Text);



                listViewC.Items.AddRange(new ListViewItem[] { items });

                supproductlocal locallist = new supproductlocal();
                //add property to locallist
                locallist.Name = (NameClientTxt.Text);
                locallist.NationalId = int.Parse(NationalIdClientTxt.Text);
                locallist.Phone = (phoneClientTxt.Text);

                supproductlocalList.Add(locallist);

            }
            catch
            {

            }
                  
            }

        private void btn_save_Client_Click(object sender, EventArgs e)
        {
            try
            {
                Client newClient = new Client();

                foreach (var item in supproductlocalList)
                {
                    newClient.NationalID = item.NationalId;
                    newClient.Name = item.Name;
                    newClient.Phone = item.Phone;

                    storeContext.Clients.Add(newClient);
                    storeContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("هناك عميل موجود بالفعل ");
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientform_Load(object sender, EventArgs e)
        {

        }
    }
}
