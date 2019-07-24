using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMHASSEN
{
    public partial class sader : Form
    {
        public sader()
        {
            InitializeComponent();
        }
        public class supproductlocal
        {
            public double GivenAmount { get; set; }
            public DateTime Date { get; set; }
            public int ProductObj_ID { get; set; }
            public double GivenAmountPrice { get; set; }
            public int RepresentitiveBillObj_ID { get; set; }


        }
        List<supproductlocal> supproductlocalList = new List<supproductlocal>();
        projectEntities context = new projectEntities();

       
        private void sader_Load(object sender, EventArgs e)
        {
            List<Representitive> rep = context.Representitives.ToList();
            comboBox1.DataSource = rep;
            comboBox1.DisplayMember = "Name";
            //-----------------displayNumber Of bill--------------
            //--------number of bill representiv----------
            int numberOfBill2;
            RepresentitiveBill representivrB = context.RepresentitiveBills.OrderByDescending(r => r.ID).FirstOrDefault();
            if (representivrB == null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9HH57Q0\MSSQLSEVEREX;Initial Catalog=project;Integrated Security=True");

                SqlCommand command = new SqlCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DBCC CHECKIDENT ('RepresentitiveBills',RESEED,0)";
                command.ExecuteNonQuery();
                connection.Close();

                numberOfBill2 = 1;
                labelNumberBill.Text = numberOfBill2.ToString();
            }
            else
            {
                numberOfBill2 = int.Parse(representivrB.ID.ToString());
                numberOfBill2++;
                labelNumberBill.Text = numberOfBill2.ToString();
            }
            List<Product> ProductList = context.Products.ToList();
            productComboSypplyer.DataSource = ProductList;
            productComboSypplyer.DisplayMember = "Name";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfBillRepresentive;
                RepresentitiveBill RpresentiveB = context.RepresentitiveBills.OrderByDescending(R => R.ID).FirstOrDefault();
                if (RpresentiveB == null)
                {
                    numberOfBillRepresentive = 1;
                    labelNumberBill.Text = numberOfBillRepresentive.ToString();
                }
                else
                {
                    numberOfBillRepresentive = int.Parse(RpresentiveB.ID.ToString());
                    numberOfBillRepresentive++;
                    labelNumberBill.Text = numberOfBillRepresentive.ToString();
                }
                listView1.Clear();
                comboBox1.Enabled = true;

                numericUQouantity.Value = 0;
            }
            catch
            {

            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Product productAdd = context.Products.FirstOrDefault(p => p.Name == productComboSypplyer.Text);

                ListViewItem items = new ListViewItem(numericUQouantity.Text, 0);
                items.SubItems.Add(productComboSypplyer.Text);
                items.SubItems.Add(DateTime.Now.ToString());
                int GAmount = int.Parse(numericUQouantity.Text);
                double amountPrice = productAdd.WholesalePrice * GAmount;

                items.SubItems.Add(amountPrice.ToString());
                listView1.Items.AddRange(new ListViewItem[] { items });

                supproductlocal locallist = new supproductlocal();
                locallist.GivenAmount = GAmount;
                locallist.ProductObj_ID = productAdd.ID;
                locallist.Date = DateTime.Now;

                locallist.GivenAmountPrice = amountPrice;
                locallist.RepresentitiveBillObj_ID = int.Parse(labelNumberBill.Text);
                supproductlocalList.Add(locallist);

            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    if (listView1.Items[i].Selected)
                    {
                        listView1.Items[i].Remove();
                    }
                }
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Enabled = false;

                RepresentitiveBillDetail newRepresentiveBd = new RepresentitiveBillDetail();
                Representitive NameRep = (Representitive)comboBox1.SelectedItem;
                Representitive rep = context.Representitives.FirstOrDefault(r => r.Name == NameRep.Name);
                RepresentitiveBill newRepresentitveBill = new RepresentitiveBill()
                {
                    Representitive_NationalID = rep.NationalID
                };
                context.RepresentitiveBills.Add(newRepresentitveBill);
                context.SaveChanges();
                RepresentitiveBill RepresentitveBillJustAdded = context.RepresentitiveBills.OrderByDescending(r => r.ID).FirstOrDefault();

                foreach (var item in supproductlocalList)
                {
                    newRepresentiveBd.GivenAmount = item.GivenAmount;
                    newRepresentiveBd.Date = item.Date;
                    newRepresentiveBd.ProductObj_ID = item.ProductObj_ID;
                    newRepresentiveBd.GivenAmountPrice = item.GivenAmountPrice;
                    newRepresentiveBd.RepresentitiveBillObj_ID = RepresentitveBillJustAdded.ID;
                    context.RepresentitiveBillDetails.Add(newRepresentiveBd);
                    context.SaveChanges();
                    Product pro = context.Products.FirstOrDefault(p => p.ID == item.ProductObj_ID);
                    if (pro.AmountInStock > item.GivenAmount)
                    {
                        pro.AmountInStock = pro.AmountInStock - item.GivenAmount;
                        context.SaveChanges();

                    }
                    else {
                        MessageBox.Show("الكمية المطلوبة أكبر من الكمية الموجوده فى المخزن");
                    }
                  
                }
                supproductlocalList.Clear();
            }
            catch
            {

            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
