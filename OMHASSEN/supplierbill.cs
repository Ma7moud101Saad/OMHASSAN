using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMHASSEN
{
    public partial class supplierbill : Form
    {
        public supplierbill()
        {
            InitializeComponent();
        }
        public class supproductlocal
        {
            public double Amount { get; set; }
            public DateTime Date { get; set; }
            public double AmountPrice { get; set; }
            public int productOpj_ID { get; set; }
            public int SupplyerBillobj_ID { get; set; }
            public string AdeyMortagaType { get; set; }

        }

        storeEntities2 context = new storeEntities2();


        private void button4_Click(object sender, EventArgs e)
        {


            int numberOfSupplyerBill;
            SupplyerBill SupplyerB = context.SupplyerBills.OrderByDescending(c => c.ID).FirstOrDefault();
            if (SupplyerB == null)
            {
                numberOfSupplyerBill = 1;
                BillNumberSypplyer.Text = numberOfSupplyerBill.ToString();
            }
            else
            {
                numberOfSupplyerBill = int.Parse(SupplyerB.ID.ToString());
                numberOfSupplyerBill++;
                BillNumberSypplyer.Text = numberOfSupplyerBill.ToString();
            }


        }
        double totalPrice = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            superItem = new supproductlocal();
            Product prod = context.Products.FirstOrDefault(p => p.Name == productComboSypplyer.Text);
            double price = int.Parse(numericUQouantity.Value.ToString()) * prod.WholesalePrice;
            totalPrice += price;
            LabelAmountPrice.Text = totalPrice.ToString();
            LabelAmountPrice.Visible = true;
            //------------------add to list View---------------------------
            Product productAdd = context.Products.FirstOrDefault(p => p.Name == productComboSypplyer.Text);

            int GAmount = int.Parse(numericUQouantity.Text);
            double priceOfOneProduct = productAdd.WholesalePrice;
            double amountPrice = priceOfOneProduct * int.Parse(numericUQouantity.Value.ToString());



            ListViewItem items = new ListViewItem(numericUQouantity.Value.ToString(), 0);
            items.SubItems.Add(DateTime.Now.ToString());
            items.SubItems.Add(amountPrice.ToString());
            items.SubItems.Add(TypeOfBillCombo.Text);
            listView1.Items.AddRange(new ListViewItem[] { items });
            //------------------mapping to class----------------------
            Product Prod = context.Products.FirstOrDefault(p => p.Name == productComboSypplyer.Text);

            //----------------------mapping---------------

            superItem.Amount = double.Parse(numericUQouantity.Value.ToString());
            superItem.Date = DateTime.Now;
            superItem.AmountPrice = amountPrice;
            superItem.AdeyMortagaType = TypeOfBillCombo.Text;
            superItem.productOpj_ID = Prod.ID;

            supperList.Add(superItem);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
            }

        }
        List<supproductlocal> supperList = new List<supproductlocal>();
        supproductlocal superItem;
        private void button2_Click(object sender, EventArgs e)
        {
            Supplyer sup = context.Supplyers.FirstOrDefault(s => s.Name == SupplyerCombo.Text);
            SupplyerBill suppleyBill = new SupplyerBill()
            {
                supplyer_ID = sup.ID,
                PaidPrice = 0,
                DeptPrice = 0
            };
            context.SupplyerBills.Add(suppleyBill);
            context.SaveChanges();
            SupplyerBill supBill = context.SupplyerBills.OrderByDescending(s => s.ID).FirstOrDefault();
            SupplyerBillDetail supplyerBDetails;
            foreach (var item in supperList)
            {
                supplyerBDetails = new SupplyerBillDetail();
                supplyerBDetails.Amount = item.Amount;
                supplyerBDetails.Date = item.Date;
                supplyerBDetails.Paid = 0;
                supplyerBDetails.Debt = 0;
                supplyerBDetails.AmountPrice = item.AmountPrice;
                supplyerBDetails.productOpj_ID = item.productOpj_ID;
                supplyerBDetails.AdeyMortagaType = item.AdeyMortagaType;
                supplyerBDetails.SupplyerBillobj_ID = supBill.supplyer_ID;
                context.SupplyerBillDetails.Add(supplyerBDetails);

                Product UpdateProduct = context.Products.FirstOrDefault(p => p.ID == supplyerBDetails.productOpj_ID);
                if (supplyerBDetails.AdeyMortagaType == "عادى")
                {
                    UpdateProduct.AmountInStock = UpdateProduct.AmountInStock + supplyerBDetails.Amount;
                }
                if (supplyerBDetails.AdeyMortagaType == "مرتجع")
                {
                    UpdateProduct.AmountInStock = UpdateProduct.AmountInStock - supplyerBDetails.Amount;
                }
                context.SaveChanges();

            }
        }

        private void supplierbill_Load(object sender, EventArgs e)
        {
            //--------------------fill Supplyer Name----------------------------
            List<Supplyer> supplyerList = context.Supplyers.ToList();
            SupplyerCombo.DataSource = supplyerList;
            SupplyerCombo.DisplayMember = "Name";

            //------------------------fill name of product------------
            List<Product> ProductList = context.Products.ToList();
            productComboSypplyer.DataSource = ProductList;
            productComboSypplyer.DisplayMember = "Name";

            int numberOfBill3;
            SupplyerBill supplyerB = context.SupplyerBills.OrderByDescending(s => s.ID).FirstOrDefault();
            if (supplyerB == null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CEGP0DR\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");

                SqlCommand command = new SqlCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DBCC CHECKIDENT ('supplyerBills',RESEED,0)";
                command.ExecuteNonQuery();
                connection.Close();

                numberOfBill3 = 1;
                BillNumberSypplyer.Text = numberOfBill3.ToString();
            }
            else
            {
                numberOfBill3 = int.Parse(supplyerB.ID.ToString());
                numberOfBill3++;
                BillNumberSypplyer.Text = numberOfBill3.ToString();
            }

        }
    }
}
