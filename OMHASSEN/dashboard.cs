using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using EasyTabs;

namespace OMHASSEN
{
    public partial class dashboard : Form
    {
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }
        public dashboard()
        {
            InitializeComponent();
        }

        //representitive
        private void Representive_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new Representive { Text = "المندوبين" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }
        
        //owarddetails
        private void mowarddetails_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new mowarddetails { Text = "الموردين" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }
        //categories
        private void Categories_Click(object sender, EventArgs e)
        {
            
        }

        //Product
        private void products_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new products { Text = "المنتجات" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }


        //private void btn_dashboard_eznSarf_Click(object sender, EventArgs e)
        //{
        //    ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
        //    {
        //        Content = new product { Text = "المنتجات" }
        //    });
        //    ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
        //    {
        //        Content = new product { Text = "المنتجات" }
        //    });
        //    ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        //}

        private void ReturnedFromClient_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new ReturnedFromClient { Text = "مرتجعات العميل " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }

        private void searchwithname_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new searchwithname { Text = "البحث بالاسم  " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }


        //adduser
        private void adduser_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new adduser { Text = "اضافه مسئول" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        //customerreport
        private void btnDashboard_ReturnedToSupplier_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new customerreport { Text = "تقارير العملاء" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
            

        }

        //searchproduct
        private void ReturnedFromCustomer_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new searchproduct { Text = "بحث المنتج " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

            

        }

        //catogries
        private void btn_dashboard_customer_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new catogries { Text = "الاصناف" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }

        private void btn_dashboard_supplier_Click(object sender, EventArgs e)
        {


        }

        private void RepresentiveReport_Click_1(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new _ٌRepresentiveReport { Text = "تقارير المندوبين" }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void sader_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new sader { Text = "الصادر " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void customerreport_click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new customerreport { Text = "تقارير العملاء  " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void clientform_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new clientform  { Text = "بيانات العميل   " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }

        private void representiveform_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new representiveform { Text = "بيانات المندوب   " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }

        private void supplierform_Click(object sender, EventArgs e)
        {


            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new supplierform { Text = "بيانات المورد   " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }

        private void formofclient_Click(object sender, EventArgs e)
        {

            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new formofclient { Text = "فواتير العميل   " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;


        }

        private void supplierbill_Click(object sender, EventArgs e)
        {

            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new supplierbill { Text = "فواتير المورد   " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;



        }

        private void RepresentitveReport_Click_1(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new RepresentitveReport { Text = "تقارير الموردين   " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;



        }

        private void storeForm_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new storeForm { Text = "جرد المخزن   " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;


        }

        private void supplierformdet_Click(object sender, EventArgs e)
        {

            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new supplierformdet { Text = "تقارير الموردين   " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;


        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void clientformdd_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new clientformdd { Text = "تقارير العملاء  " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;


        }

        private void repreport_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new repreport { Text = "بحث بالفاتوره  " }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }







        //private void formofclient_Click(object sender, EventArgs e)
        //{


        //    ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
        //    {
        //        Content = new formofclient { Text = " فواتير العميل    " }
        //    });
        //    ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        //}
    }
}
