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
    public partial class RepresentitveReport : Form
    {
        public RepresentitveReport()
        {
            InitializeComponent();
        }
        storeEntities2 context = new storeEntities2();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            string name = textBox3.Text;
            List<Representitive> RepresentitiveLsit = context.Representitives.Where(r => r.Name.Contains(name)).ToList();
            dataGridView1.DataSource = RepresentitiveLsit;

            this.dataGridView1.Columns["NationalID"].HeaderText = " الرقم القومى";
            this.dataGridView1.Columns["Name"].HeaderText = " الأسم";
            this.dataGridView1.Columns["Phone"].HeaderText = " التلفون";
            this.dataGridView1.Columns["Address"].HeaderText = " العنوان";
            this.dataGridView1.Columns["Salary"].HeaderText = " المرتب";
            this.dataGridView1.Columns["TargetSale"].HeaderText = " هدف الربح";
            this.dataGridView1.Columns["Commition"].HeaderText = " العمولة";
            this.dataGridView1.Columns[7].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;






        }

        private void RepresentitveReport_Load(object sender, EventArgs e)
        {
            List<Representitive> RepresentitveList = context.Representitives.ToList();
            dataGridView1.DataSource = RepresentitveList;

            this.dataGridView1.Columns["NationalID"].HeaderText = " الرقم القومى";
            this.dataGridView1.Columns["Name"].HeaderText = " الأسم";
            this.dataGridView1.Columns["Phone"].HeaderText = " التلفون";
            this.dataGridView1.Columns["Address"].HeaderText = " العنوان";
            this.dataGridView1.Columns["Salary"].HeaderText = " المرتب";
            this.dataGridView1.Columns["TargetSale"].HeaderText = " هدف الربح";
            this.dataGridView1.Columns["Commition"].HeaderText = " العمولة";
            this.dataGridView1.Columns[7].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
