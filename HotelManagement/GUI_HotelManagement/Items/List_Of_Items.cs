using BUS_HotelManagement;
using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_HotelManagement
{
    public partial class List_Of_Items : Form
    {
        public List_Of_Items()
        {
            InitializeComponent();
            loadlistOfItems();
            cb_RoomID.DataSource = BookingForm_BUS.cb_RoomID();
        }

        private void Search_Button_Click(object sender, EventArgs e) //Search
        {
            string BookingId = cb_RoomID.Text.ToString();
            if (BookingId == "")
            {
                MessageBox.Show("The Room_ID is not correct, please re-enter the Room_ID!");
                return;
            }
            else if (BookingId == "0")
            {
                MessageBox.Show("The Room_ID is not correct, please re-enter the Room_ID!");
                return;
            }
            else if (BookingId == null)
            {
                MessageBox.Show("The Room_ID is not correct, please re-enter the Room_ID!");
                return;
            }
            loadlistOfItems(BookingId);

        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadlistOfItems()
        {
            BookingForm_DTO booking = new BookingForm_DTO(null);
            dgv_List_Of_Items.DataSource = BookingForm_BUS.loadlistOfItems();
        }
        public void loadlistOfItems(string idBooking)
        {
            BookingForm_DTO bookingID = new BookingForm_DTO(idBooking);
            dgv_List_Of_Items_Room.DataSource = BookingForm_BUS.loadlistOfItems_Room(bookingID);
        }

        private void dgv_List_Of_Items_Room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
