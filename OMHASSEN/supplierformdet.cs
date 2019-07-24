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
    public partial class supplierformdet : Form
    {
        public supplierformdet()
        {
            InitializeComponent();
        }
        projectEntities context = new projectEntities();


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            string name = textBox3.Text;
            List<Supplyer> supplyer = context.Supplyers.Where(s => s.Name.Contains(name)).ToList();
            dataGridView1.DataSource = supplyer;

            this.dataGridView1.Columns["ID"].HeaderText = " رقم التسلسل";
            this.dataGridView1.Columns["Name"].HeaderText = " الأسم";
            this.dataGridView1.Columns["Phone"].HeaderText = " التلفون";
            this.dataGridView1.Columns["Address"].HeaderText = " العنوان";
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
        }

        private void supplierformdet_Load(object sender, EventArgs e)
        {
            List<Supplyer> supplyer = context.Supplyers.ToList();
            dataGridView1.DataSource = supplyer;

            this.dataGridView1.Columns["ID"].HeaderText = " رقم التسلسل";
            this.dataGridView1.Columns["Name"].HeaderText = " الأسم";
            this.dataGridView1.Columns["Phone"].HeaderText = " التلفون";
            this.dataGridView1.Columns["Address"].HeaderText = " العنوان";
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;

        }
    }
}
