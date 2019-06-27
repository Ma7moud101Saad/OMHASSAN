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
    public partial class repreport : Form
    {
        public repreport()
        {
            InitializeComponent();
        }
        storeEntities2 context = new storeEntities2();


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int id = int.Parse(textBox3.Text);

                List<RepresentitiveBillDetail> ListOfRepresentitveDetails = context.RepresentitiveBillDetails.Where(r => r.RepresentitiveBillObj_ID == id).ToList();
                dataGridView1.DataSource = ListOfRepresentitveDetails;

                this.dataGridView1.Columns["ID"].HeaderText = " رقم التسلسل";
                this.dataGridView1.Columns["GivenAmount"].HeaderText = " الكمية المعطاه";

                this.dataGridView1.Columns["Date"].HeaderText = " التاريخ";
                this.dataGridView1.Columns["RepresentitiveBillObj_ID"].HeaderText = " رقم الفاتورة";

                this.dataGridView1.Columns[2].Visible = false;
                this.dataGridView1.Columns[3].Visible = false;
                this.dataGridView1.Columns[4].Visible = false;
                this.dataGridView1.Columns[5].Visible = false;
                this.dataGridView1.Columns[6].Visible = false;
                this.dataGridView1.Columns[8].Visible = false;
                this.dataGridView1.Columns[9].Visible = false;
                //this.dataGridView1.Columns[10].Visible = false;
                this.dataGridView1.Columns[11].Visible = false;
                this.dataGridView1.Columns[12].Visible = false;
                this.dataGridView1.Columns[13].Visible = false;

            }

        }

        private void repreport_Load(object sender, EventArgs e)
        {
            List<RepresentitiveBillDetail> ListOfRepresentitveDetails = context.RepresentitiveBillDetails.ToList();
            dataGridView1.DataSource = ListOfRepresentitveDetails;

            this.dataGridView1.Columns["ID"].HeaderText = " رقم التسلسل";
            this.dataGridView1.Columns["GivenAmount"].HeaderText = " الكمية المعطاه";

            this.dataGridView1.Columns["Date"].HeaderText = " التاريخ";
            this.dataGridView1.Columns["RepresentitiveBillObj_ID"].HeaderText = " رقم الفاتورة";

            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            //this.dataGridView1.Columns[10].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[12].Visible = false;
            this.dataGridView1.Columns[13].Visible = false;

        }
    }
}
