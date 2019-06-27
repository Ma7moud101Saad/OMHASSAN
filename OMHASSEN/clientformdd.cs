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
    public partial class clientformdd : Form
    {
        public clientformdd()
        {
            InitializeComponent();
        }

        storeEntities2 context = new storeEntities2();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string Name = textBox3.Text;
            List<Client> client = context.Clients.Where(c => c.Name.Contains(Name)).ToList();
            dataGridView1.DataSource = client;

            this.dataGridView1.Columns["NationalID"].HeaderText = " الرقم القومى";
            this.dataGridView1.Columns["Name"].HeaderText = " الأسم";
            this.dataGridView1.Columns["Phone"].HeaderText = " التلفون";
            this.dataGridView1.Columns[3].Visible = false;
        }

        private void clientformdd_Load(object sender, EventArgs e)
        {

            List<Client> client = context.Clients.ToList();
            dataGridView1.DataSource = client;

            this.dataGridView1.Columns["NationalID"].HeaderText = " الرقم القومى";
            this.dataGridView1.Columns["Name"].HeaderText = " الأسم";
            this.dataGridView1.Columns["Phone"].HeaderText = " التلفون";
            this.dataGridView1.Columns[3].Visible = false;
        }
    }
}
