using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_HotelManagement;
using DAO_HotelManagement;
using BUS_HotelManagement;
namespace GUI_HotelManagement
{
    public partial class CustomerList : Form
    {
        Customer_BUS busCustomer = new Customer_BUS();
        public CustomerList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void GUI_Customer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Customer_BUS.getCustomer();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
