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
    public partial class searchwithname : Form
    {
        storeEntities2 context = new storeEntities2();
        public searchwithname()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string NameOfRrepresentive = textBox5.Text;
                storeEntities2 context = new storeEntities2();
                List<Representitive> rbList = context.Representitives.Where(r => r.Name.Contains(NameOfRrepresentive)).ToList();
                dataGridView1.DataSource = rbList;
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء فى أدخال الداتا ");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                storeEntities2 context = new storeEntities2();
                if (textBox6.Text != "")
                {
                    double SearchSalary = double.Parse(textBox6.Text);

                    List<Representitive> rbList1 = context.Representitives.Where(r => r.Salary < SearchSalary).ToList();
                    dataGridView1.DataSource = rbList1;
                }
                else
                {
                    List<Representitive> rbList2 = context.Representitives.ToList();
                    dataGridView1.DataSource = rbList2;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء فى أدخال الداتا ");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
