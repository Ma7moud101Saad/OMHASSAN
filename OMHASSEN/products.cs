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
    public partial class products : Form
    {
        projectEntities context = new projectEntities();
        public products()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = context.Categories.ToList();
            CategoryComboBox.DisplayMember = "Name";
        }

        private void products_Load(object sender, EventArgs e)
        {

        }

        private void AmountNumberList_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoryComboBox.SelectedItem == null || ProductNameTxt.Text.Trim() == ""
                        || MeasuringUnitTxt.Text.Trim() == "" || WholePriceTxt.Text.Trim() == ""
                        || RetailPriceTxt.Text.Trim() == "")
                {
                    MessageBox.Show("من فضلك املأ كل البيانات المطلوبة");
                }
                else
                {
                    //listView1.Columns["category"].Text = CategoryComboBox.SelectedItem.ToString();
                    //listView1.Columns["ProductName"].Text = ProductNameTxt.Text;
                    //listView1.Columns["MeasuringUnit"].Text = MeasuringUnitTxt.Text;
                    //listView1.Columns["RetailPrice"].Text = RetailPrice.Text;
                    //listView1.Columns["WholeSalePrice"].Text = WholePriceTxt.Text;


                    //Add items to the list view
                   Category cat= (Category)CategoryComboBox.SelectedItem;
                    ListViewItem items = new ListViewItem(ProductNameTxt.Text, 0);
                    items.SubItems.Add(cat.Name);
                    items.SubItems.Add(AmountNumberList.Text);
                    items.SubItems.Add(MeasuringUnitTxt.Text);
                    items.SubItems.Add(WholePriceTxt.Text);
                    items.SubItems.Add(RetailPriceTxt.Text);
                    listView1.Items.Add(items);

                    //clear the text boxes
                    CategoryComboBox.SelectedItem = null;
                    AmountNumberList.Text = "0";
                    ProductNameTxt.Text = String.Empty;
                    MeasuringUnitTxt.Text = String.Empty;
                    WholePriceTxt.Text = String.Empty;
                    RetailPriceTxt.Text = String.Empty;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("حدث خطأ أثناء الإضافة، من فضلك حاول مرة أخرى");
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("من فضلك حدد ما تريد حذفه");
                }
                else
                {
                    listView1.SelectedItems[0].Remove();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ أثناء الحذف، من فضلك حاول مرة أخرى");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    //get values entered by the user
                    string ProdName = listView1.Items[i].SubItems[0].Text;

                    //check if the product already exists
                    if (context.Products.Where(c => c.Name.Contains(ProdName)).FirstOrDefault() != null)
                    {
                        if (MessageBox.Show("من الممكن ان يكون المنتج موجودا بالفعل \n هل تريد الإضافة على أي حال؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // user clicked yes
                            string catName = listView1.Items[i].SubItems[1].Text;
                            int? catID = context.Categories.FirstOrDefault(c => c.Name == catName).ID;
                           int Amount= int.Parse(listView1.Items[i].SubItems[2].Text);
                            //  int.TryParse(listView1.Items[i].SubItems[2].Text, out int Amount);
                            int wholeSalePrice = int.Parse(listView1.Items[i].SubItems[4].Text);
                            string measuringUnit = listView1.Items[i].SubItems[3].Text;
                            //int.TryParse(listView1.Items[i].SubItems[4].Text, out int wholeSalePrice);
                            int retailPrice = int.Parse(listView1.Items[i].SubItems[5].Text);
                            //int.TryParse(listView1.Items[i].SubItems[5].Text, out int retailPrice);

                            //Save changes to the database
                            Product NewProduct = new Product
                            {
                                Name = ProdName,
                                CategoryObj_ID = catID,
                                AmountInStock = Amount,
                                WholesalePrice = wholeSalePrice,
                                RetailPrice = retailPrice
                            };
                            context.Products.Add(NewProduct);
                            context.SaveChanges();

                            //add the measuring unit
                            int lastAddedProductID = context.Products.OrderByDescending(p => p.ID).FirstOrDefault().ID;
                            MeasuringUnit meauringUnit = new MeasuringUnit
                            {
                                UnitName = measuringUnit,
                                PID = lastAddedProductID
                            };
                            context.MeasuringUnits.Add(meauringUnit);
                            context.SaveChanges();

                        }

                    }
                    else
                    {

                        string catName = listView1.Items[i].SubItems[1].Text;
                        int? catID = context.Categories.FirstOrDefault(c => c.Name == catName).ID;
                        int Amount = int.Parse(listView1.Items[i].SubItems[2].Text);
                      //  int.TryParse(listView1.Items[i].SubItems[2].Text, out int Amount);
                        string measuringUnit = listView1.Items[i].SubItems[3].Text;
                        int wholeSalePrice = int.Parse(listView1.Items[i].SubItems[4].Text);
                      //  int.TryParse(listView1.Items[i].SubItems[4].Text, out int wholeSalePrice);
                       // int.TryParse(listView1.Items[i].SubItems[5].Text, out int retailPrice);
                        int retailPrice = int.Parse(listView1.Items[i].SubItems[5].Text);

                        //Save product changes to the database
                        Product NewProduct = new Product
                        {
                            Name = ProdName,
                            CategoryObj_ID = catID,
                            AmountInStock = Amount,
                            WholesalePrice = wholeSalePrice,
                            RetailPrice = retailPrice
                        };
                        context.Products.Add(NewProduct);
                        context.SaveChanges();

                        //add the measuring unit and save it to DB
                        int lastAddedProductID = context.Products.OrderByDescending(p => p.ID).FirstOrDefault().ID;
                        MeasuringUnit meauringUnit = new MeasuringUnit
                        {
                            UnitName = measuringUnit,
                            PID = lastAddedProductID
                        };
                        context.MeasuringUnits.Add(meauringUnit);
                        context.SaveChanges();

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ البيانات، من فضلك حاول مرة أخرى");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
