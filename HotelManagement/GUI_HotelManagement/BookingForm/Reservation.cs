using DTO_HotelManagement;
using BUS_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement;
using DAO_HotelManagement;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace GUI_HotelManagement
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            loadlistOfReservation();
            cb_BookingID.DataSource = BookingForm_BUS.cb_BookingID();
        }


        private void bt_Edit_Reservation_Click(object sender, EventArgs e)
        {
            Edit_Resevation er = new Edit_Resevation();
            er.Show();
            this.Hide();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_inForm c = new Check_inForm(cb_BookingID.Text);
            //this.Hide();
            this.Visible = false;
            c.ShowDialog();
            //this.ShowDialog();
            this.Visible = true;

        }

        public string selectedID;
        public void loadlistOfReservation()
        {
            BookingForm_DTO booking = new BookingForm_DTO(null);
            dgv_Reservation.DataSource = BookingForm_BUS.loadlistOfReservation();
        }
        public void loadlistOfReservation(string idBooking)
        {
            BookingForm_DTO booking = new BookingForm_DTO(idBooking);
            dgv_Reservation.DataSource = BookingForm_BUS.loadlistOfReservation_Room(booking);
        }
        private void bt_Search_Reservation_Click(object sender, EventArgs e)
        {
            string BookingId = cb_BookingID.Text.ToString();
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
            loadlistOfReservation(BookingId);
        }

        private void bt_Check_Out_Click(object sender, EventArgs e)
        {
            Checkout_Form c = new Checkout_Form(cb_BookingID.Text);
            //this.Hide();
            this.Visible = false;
            c.ShowDialog();
            //this.ShowDialog();
            this.Visible = true;
        }
    }
}
