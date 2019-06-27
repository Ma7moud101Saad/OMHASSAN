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
    public partial class customerreport : Form
    {
        storeEntities2 context = new storeEntities2();
        public customerreport()
        {
            InitializeComponent();
        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                storeEntities2 context = new storeEntities2();
                List<Client> clientList = context.Clients.Where(c => c.Name.Contains(textBox7.Text)).ToList();
                dataGridView1.DataSource = clientList;

            }
            catch (Exception)
            {
                MessageBox.Show("خطأ فى أدخال البيانات");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerreport_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
