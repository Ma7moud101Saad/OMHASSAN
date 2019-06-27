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
    public partial class storeForm : Form
    {
        public storeForm()
        {
            InitializeComponent();
        }

        storeEntities2 context = new storeEntities2();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            List<Product> productList = context.Products.Where(p => p.Name.Contains(name)).ToList();
            dataGridView1.DataSource = productList;

            this.dataGridView1.Columns["ID"].HeaderText = " رقم التسلسل";
            this.dataGridView1.Columns["Name"].HeaderText = " الأسم";
            this.dataGridView1.Columns["AmountInStock"].HeaderText = " الكمية المخزنة";
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[7].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[12].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void storeForm_Load(object sender, EventArgs e)
        {
            List<Product> productList = context.Products.ToList();
            dataGridView1.DataSource = productList;

            this.dataGridView1.Columns["ID"].HeaderText = " رقم التسلسل";
            this.dataGridView1.Columns["Name"].HeaderText = " الأسم";
            this.dataGridView1.Columns["AmountInStock"].HeaderText = " الكمية المخزنة";
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[7].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[12].Visible = false;

        }
    }
}
