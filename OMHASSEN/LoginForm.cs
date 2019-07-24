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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            
            
                projectEntities db = new projectEntities();
            var logincheck = db.Users.Where(d => d.Username == textBox1.Text && d.Password == txt_password.Text).SingleOrDefault();

           // if (textBox1.Text == "Admin" && txt_password.Text == "12345")
                if (logincheck !=null)

                {
                    AppContainer container = new AppContainer();
                // add itiail tab
                container.Tabs.Add(
                    new TitleBarTab(container)
                    {
                        Content = new dashboard
                        {
                            Text = "الصفحة الرئيسية"
                        }
                    });
                container.SelectedTabIndex = 0;
                TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
                applicationContext.Start(container);
               

                container.Show();
                


            }

            else
            {
                MessageBox.Show("يجب إدخال اسم المستخدم وكلمة المرور بطريقة صحيحية");
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
