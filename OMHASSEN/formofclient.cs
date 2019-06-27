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
    public partial class formofclient : Form
    {
        bool flag = true;

        public class supproductlocal
        {
            public double Amount { get; set; }
            public DateTime Date { get; set; }
            public string Type { get; set; }//قطاعى وجملة
            public double AmountPrice { get; set; }
            public int RepresentitiveBillObj_ID { get; set; }
            //public int ClientBillObj_ID { get; set; }
            public int ProductOpj_ID { get; set; }
            public string AdeyMortagaType { get; set; }

        }

        public formofclient()
        {
            InitializeComponent();
        }
        storeEntities2 context = new storeEntities2();
        Representitive x;




        private void button2_Click(object sender, EventArgs e)
        {
            //compoOfClients.Enabled = false;

            //RepresentitiveBillDetail newRepresentiveBd = new RepresentitiveBillDetail();





            //ClientBill CLientBillJustAdded = context.ClientBills.OrderByDescending(r => r.ID).FirstOrDefault();
            //ClientBillDetail clientBDetails = new ClientBillDetail();
            //double totalPrice = 0;
            //string trypeClientBill = null;
            //foreach (var item in supperList)
            //{
            //    clientBDetails.Amount = item.Amount;
            //    clientBDetails.Date = item.Date;
            //    clientBDetails.Type = item.Type;
            //    trypeClientBill = item.Type;
            //    clientBDetails.AmountPrice = item.AmountPrice;
            //    clientBDetails.Paid = 0;
            //    clientBDetails.Debt = 0;
            //    clientBDetails.ClientBillObj_ID = CLientBillJustAdded.ID;
            //    clientBDetails.ProductOpj_ID = item.ProductOpj_ID;
            //    clientBDetails.AdeyMortagaType = item.AdeyMortagaType;

            //    context.ClientBillDetails.Add(clientBDetails);

            //    totalPrice = totalPrice + clientBDetails.AmountPrice;
            //    ClientBillDetail ClientBillJustAdded = context.ClientBillDetails.OrderByDescending(cB => cB.ID).FirstOrDefault();

            //    x = (Representitive)rpresentiveCombo.SelectedItem;
            //    var prdN = productComboFromRepresentive.Text.ToString();
            //    var prd = context.Products.Where(n => n.Name == prdN).FirstOrDefault();
            //    //amount of representitveBillDetails
            //    var y = context.RepresentitiveBillDetails
            //          .Where(p => p.RepresentitiveBill.Representitive_NationalID == x.NationalID && p.ProductObj_ID == prd.ID).FirstOrDefault();
            //    clientBDetails.RepresentitiveBillDetailsObj_ID = y.ID;

            //    ClientBillDetail cUpdated = context.ClientBillDetails.OrderByDescending(c => c.ID).FirstOrDefault();

            //    //  cUpdated.RepresentitiveBillDetail.GivenAmount = cUpdated.RepresentitiveBillDetail.GivenAmount - item.Amount;
            //    //context.SaveChanges(); 


            //    RepresentitiveBillDetail rebDeta = context.RepresentitiveBillDetails.FirstOrDefault(r => r.ID == cUpdated.RepresentitiveBillDetailsObj_ID);

            //    if (rebDeta.GivenAmount > 0 && MortagaAdeyCombo.SelectedItem.ToString() == "عادى")
            //    {
            //        rebDeta.GivenAmount = rebDeta.GivenAmount + item.Amount;


            //    }
            //    else
            //    {
            //        prd.AmountInStock = prd.AmountInStock + item.Amount;

            //    }
            //    context.SaveChanges();
            //}
            //Client ClientObj = (Client)compoOfClients.SelectedItem;
            ////Representitive rep = context.Clients.FirstOrDefault(r => r.Name == NameRep.Name);
            //double paid = int.Parse(PaidNumericUpdown.Value.ToString());
            //double deptPrice = totalPrice - paid;
            //ClientBill NewClientBill = new ClientBill()
            //{
            //    ClientObj_NationalID = ClientObj.NationalID,
            //    TotalPrice = totalPrice,
            //    type = trypeClientBill,
            //    PaidPrice = paid,
            //    DeptPrice = deptPrice
            //};

            ////lapelTotalPrice.Text = totalPrice.ToString();
            ////lapelTotalPrice.Visible = true;
            //if (flag == true)
            //{
            //    context.ClientBills.Add(NewClientBill);
            //    context.SaveChanges();
            //    flag = false;
            //}
            compoOfClients.Enabled = false;

            RepresentitiveBillDetail newRepresentiveBd = new RepresentitiveBillDetail();

            Client ClientSelected = context.Clients.FirstOrDefault(c => c.Name == compoOfClients.Text);
            ClientBill clientBilld = new ClientBill()
            {
                ClientObj_NationalID = ClientSelected.NationalID,
                type = TypeBillCombo.Text,


            };

            context.ClientBills.Add(clientBilld);
            context.SaveChanges();


            ClientBill CLientBillJustAdded = context.ClientBills.OrderByDescending(r => r.ID).FirstOrDefault();
            ClientBillDetail clientBDetails = new ClientBillDetail();
            double totalPrice = 0;
            string trypeClientBill = null;
            foreach (var item in supperList)
            {
                clientBDetails.Amount = item.Amount;
                clientBDetails.Date = item.Date;
                clientBDetails.Type = item.Type;
                trypeClientBill = item.Type;
                clientBDetails.AmountPrice = item.AmountPrice;
                clientBDetails.Paid = 0;
                clientBDetails.Debt = 0;
                clientBDetails.ClientBillObj_ID = CLientBillJustAdded.ID;
                clientBDetails.ProductOpj_ID = item.ProductOpj_ID;
                clientBDetails.AdeyMortagaType = item.AdeyMortagaType;

                context.ClientBillDetails.Add(clientBDetails);

                totalPrice = totalPrice + clientBDetails.AmountPrice;
                ClientBillDetail ClientBillJustAdded = context.ClientBillDetails.OrderByDescending(cB => cB.ID).FirstOrDefault();

                x = (Representitive)rpresentiveCombo.SelectedItem;
                var prdN = productComboFromRepresentive.Text.ToString();
                var prd = context.Products.Where(n => n.Name == prdN).FirstOrDefault();
                //amount of representitveBillDetails
                var y = context.RepresentitiveBillDetails
                      .Where(p => p.RepresentitiveBill.Representitive_NationalID == x.NationalID && p.ProductObj_ID == prd.ID).FirstOrDefault();
                clientBDetails.RepresentitiveBillDetailsObj_ID = y.ID;

                ClientBillDetail cUpdated = context.ClientBillDetails.OrderByDescending(c => c.ID).FirstOrDefault();

                //  cUpdated.RepresentitiveBillDetail.GivenAmount = cUpdated.RepresentitiveBillDetail.GivenAmount - item.Amount;
                //context.SaveChanges(); 


                RepresentitiveBillDetail rebDeta = context.RepresentitiveBillDetails.FirstOrDefault(r => r.ID == cUpdated.RepresentitiveBillDetailsObj_ID);

                if (rebDeta.GivenAmount > 0 && MortagaAdeyCombo.SelectedItem.ToString() == "عادى")
                {
                    rebDeta.GivenAmount = rebDeta.GivenAmount - item.Amount;


                }
                else
                {
                    prd.AmountInStock = prd.AmountInStock + item.Amount;

                }
                context.SaveChanges();
            }
            Client ClientObj = (Client)compoOfClients.SelectedItem;
            //Representitive rep = context.Clients.FirstOrDefault(r => r.Name == NameRep.Name);
            double paid = int.Parse(PaidNumericUpdown.Value.ToString());
            double deptPrice = totalPrice - paid;
            ClientBill NewClientBill = new ClientBill()
            {
                ClientObj_NationalID = ClientObj.NationalID,
                TotalPrice = totalPrice,
                type = trypeClientBill,
                PaidPrice = paid,
                DeptPrice = deptPrice
            };

            //lapelTotalPrice.Text = totalPrice.ToString();
            //lapelTotalPrice.Visible = true;
            if (flag == true)
            {
                context.ClientBills.Add(NewClientBill);
                context.SaveChanges();
                flag = false;
            }
        }


        private void FormOfClient_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            flag = true;
            compoOfClients.Enabled = true;
            int numberOfBill;
            ClientBill clientB = context.ClientBills.OrderByDescending(c => c.ID).FirstOrDefault();
            if (clientB == null)
            {
                numberOfBill = 1;
                labelNumberBill.Text = numberOfBill.ToString();
            }
            else
            {
                numberOfBill = int.Parse(clientB.ID.ToString());
                numberOfBill++;
                labelNumberBill.Text = numberOfBill.ToString();
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {

            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
            }
        }

        private void formofclient_Load(object sender, EventArgs e)
        {
            List<Client> ListOfClient = context.Clients.ToList();
            compoOfClients.DataSource = ListOfClient;
            compoOfClients.DisplayMember = "Name";
            //------------------------------------------------------

            int numberOfBill;
            ClientBill clientB = context.ClientBills.OrderByDescending(c => c.ID).FirstOrDefault();
            if (clientB == null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CEGP0DR\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");

                SqlCommand command = new SqlCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DBCC CHECKIDENT ('clientBills',RESEED,0)";
                command.ExecuteNonQuery();
                connection.Close();

                numberOfBill = 1;
                labelNumberBill.Text = numberOfBill.ToString();
            }
            else
            {
                numberOfBill = int.Parse(clientB.ID.ToString());
                numberOfBill++;
                labelNumberBill.Text = numberOfBill.ToString();
            }
            List<Representitive> rep = context.Representitives.ToList();
            rpresentiveCombo.DataSource = rep;
            rpresentiveCombo.DisplayMember = "Name";

            //------------------------fill name of product------------
            List<Product> ProductList = context.Products.ToList();
            productComboFromRepresentive.DataSource = ProductList;
            productComboFromRepresentive.DisplayMember = "Name";
        }
        List<supproductlocal> supperList = new List<supproductlocal>();
        supproductlocal superItem;
        double totalPrice = 0;
        double priceType = 0;

        private void rpresentiveCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            x = (Representitive)rpresentiveCombo.SelectedItem;
            string repName = rpresentiveCombo.SelectedItem.ToString();
            var y = context.RepresentitiveBillDetails
                  .Where(p => p.RepresentitiveBill.Representitive_NationalID == x.NationalID);
            List<Product> ProductList = new List<Product>();
            foreach (var item in y)
            {
                Product ProdcutOfRep = context.Products.FirstOrDefault(p => p.ID == item.ProductObj_ID);
                ProductList.Add(ProdcutOfRep);
            }
            // productComboFromRepresentive.DataSource= ProductList;//بتوع المندوب
            // productComboFromRepresentive.DisplayMember = "Name";


        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Product ChechProduct = null;
            if (TypeBillCombo.Text == "جملة")
            {
                ChechProduct = ChechProduct = context.Products.FirstOrDefault(p => p.Name == productComboFromRepresentive.Text);
                priceType = ChechProduct.WholesalePrice;
            }
            if (TypeBillCombo.Text == "قطاعى")
            {
                ChechProduct = ChechProduct = context.Products.FirstOrDefault(p => p.Name == productComboFromRepresentive.Text);
                priceType = ChechProduct.RetailPrice;
            }
            if (MortagaAdeyCombo.Text == "عادى")
            {
                double price = int.Parse(numericUQouantity.Value.ToString()) * priceType;
                totalPrice += price;

                lapelTotalPrice.Text = totalPrice.ToString();
                lapelTotalPrice.Visible = true;
            }
            superItem = new supproductlocal();
            // string RepresentiveName = null;
            if (TypeBillCombo.SelectedIndex == -1)
            {
                MessageBox.Show("لابد من ادخال نوع الفاتوره اولا"); return;
            }
            // if (labelRepresentitve.Text == "")
            //{
            LabelTypeOfBill.Visible = true;
            LabelTypeOfBill.Text = TypeBillCombo.Text;
            TypeBillCombo.Visible = false;
            // }

            if (rpresentiveCombo.SelectedIndex == -1)
            { MessageBox.Show("لابد من أدخال أسم المندوب اولا"); return; }
            // if (.Text == "")
            // {
            //RepresentiveName= rpresentiveCombo.Text;
            labelRepresentitve.Visible = true;
            labelRepresentitve.Text = rpresentiveCombo.Text;
            rpresentiveCombo.Visible = false;
            // }
            x = (Representitive)rpresentiveCombo.SelectedItem;
            var prdN = productComboFromRepresentive.Text.ToString();
            var prd = context.Products.Where(n => n.Name == prdN).FirstOrDefault();
            //amount of representitveBillDetails
            var y = context.RepresentitiveBillDetails
                  .Where(p => p.RepresentitiveBill.Representitive_NationalID == x.NationalID && p.ProductObj_ID == prd.ID).FirstOrDefault();
            if (y != null)
            {
                if (MortagaAdeyCombo.Text == "عادى")
                {
                    if (int.Parse(numericUQouantity.Value.ToString()) > int.Parse(y.GivenAmount.ToString()))
                    { MessageBox.Show("الكميه غير متاحه عند المندوب"); return; }
                }
            }

            //------------------add to list View---------------------------
            Product productAdd = context.Products.FirstOrDefault(p => p.Name == productComboFromRepresentive.Text);
            int GAmount = int.Parse(numericUQouantity.Text);
            //check if قطاعى else جملة from combo
            double amountPrice = 0;
            if (TypeBillCombo.Text == "قطاعى")
            {
                amountPrice = productAdd.RetailPrice * GAmount;

            }
            else if (TypeBillCombo.Text == "جملة")
            {
                amountPrice = productAdd.WholesalePrice * GAmount;
                totalPrice = amountPrice;
            }

            ListViewItem items = new ListViewItem(numericUQouantity.Value.ToString(), 0);
            items.SubItems.Add(DateTime.Now.ToString());
            items.SubItems.Add(amountPrice.ToString());
            items.SubItems.Add(productComboFromRepresentive.Text);
            items.SubItems.Add(MortagaAdeyCombo.Text);
            listView1.Items.AddRange(new ListViewItem[] { items });

            var product = context.Products.FirstOrDefault(p => p.Name == productComboFromRepresentive.Text);

            //----------------------mapping---------------
            var representitve = context.Representitives.FirstOrDefault(r => r.Name == rpresentiveCombo.Text);
            RepresentitiveBill repAdded = context.RepresentitiveBills.FirstOrDefault(r => r.Representitive_NationalID == representitve.NationalID);
            superItem.Amount = double.Parse(numericUQouantity.Value.ToString());
            superItem.Date = DateTime.Now;
            superItem.AmountPrice = amountPrice;
            superItem.ProductOpj_ID = product.ID;
            superItem.Type = TypeBillCombo.Text;
            superItem.AdeyMortagaType = MortagaAdeyCombo.Text;
            superItem.RepresentitiveBillObj_ID = repAdded.ID;

            supperList.Add(superItem);
        }
    }
}


