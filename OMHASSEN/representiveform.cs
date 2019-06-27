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
    public partial class representiveform : Form
    {
        storeEntities2 storeContext = new storeEntities2();
        public representiveform()
        {
            InitializeComponent();
        }
      

        public class supproductlocal
        {
            public int NationalId { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public double salary { get; set; }
            public double TargetSale { get; set; }
            public double commuation { get; set; }


        }
        List<supproductlocal> supproductlocalList = new List<supproductlocal>();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_reps_Click(object sender, EventArgs e)
        {
            ListViewItem items = new ListViewItem(NationalIdRepTxt.Text, 0);
            items.SubItems.Add(NameRepTxt.Text);
            items.SubItems.Add(phoneRepTxt.Text);
            items.SubItems.Add(AddressText.Text);
            items.SubItems.Add(salaryRepTxt.Text);
            items.SubItems.Add(SaleTargetTxt.Text);
            items.SubItems.Add(ComuationRepTxt.Text);

            listView1.Items.AddRange(new ListViewItem[] { items });

            supproductlocal locallist = new supproductlocal();
            //add property to locallist
            locallist.NationalId = Convert.ToInt32(NationalIdRepTxt.Text);
            locallist.Name = NameRepTxt.Text;
            locallist.Phone = phoneRepTxt.Text;
            locallist.Address = AddressText.Text;
            locallist.salary = double.Parse(salaryRepTxt.Text);
            locallist.TargetSale = double.Parse(SaleTargetTxt.Text);
            locallist.Phone = SaleTargetTxt.Text;
            supproductlocalList.Add(locallist);
            //repres.n
            //storeContext.Representitives.Add();
            //storeContext.SaveChanges();
            NationalIdRepTxt.Text = "";
            NameRepTxt.Text = "";
            phoneRepTxt.Text = "";
            AddressText.Text = "";
            salaryRepTxt.Text = "";
            SaleTargetTxt.Text = "";
            ComuationRepTxt.Text = "";

        }

        private void btn_delete_reps_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
            }
        }

        private void btn_save_reps_Click(object sender, EventArgs e)
        {


            try
            {
                Representitive newRepres = new Representitive();
                foreach (var item in supproductlocalList)
                {
                    newRepres.Name = item.Name;
                    newRepres.NationalID = item.NationalId;
                    newRepres.Phone = item.Phone;
                    newRepres.Salary = item.salary;
                    newRepres.TargetSale = item.TargetSale;

                    storeContext.Representitives.Add(newRepres);
                    storeContext.SaveChanges();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("هناك مندوب موجود بالفعل ");
            }


        }
    }
}
