using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate42
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'real_Estate47DataSet.Real_Estate_Data' table. You can move, or remove it, as needed.
            this.real_Estate_DataTableAdapter1.Fill(this.real_Estate47DataSet.Real_Estate_Data);
            // TODO: This line of code loads data into the 'real_Estate_DataDataSet1.Real_Estate_Data' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'accountsDataSet1.Accounts' table. You can move, or remove it, as needed.


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible= true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sampleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.real_Estate_DataTableAdapter.Sample(this.real_Estate_DataDataSet1.Real_Estate_Data);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
