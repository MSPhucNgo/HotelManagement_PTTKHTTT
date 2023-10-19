using GUI_HotelManagement.Dashboard;
using HotelManagement;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HotelManagement
{
    public partial class Dashboard_GUI : Form
    {
        public Dashboard_GUI()
        {
            InitializeComponent();
            showMainForm();
        }

        public void showMainForm()
        {
            label_Tittle.Text = "DASHBOARD";
            loadForm(new Main_Form());
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadForm(object Form)
        {
            if (this.panel_Container.Controls.Count > 0)
                this.panel_Container.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_Container.Controls.Add(f);
            this.panel_Container.Tag = f;
            f.Show();
        }

        private void btn_BookingRoom_Click(object sender, EventArgs e)
        {
            Booking_Form BKF = new Booking_Form();
            BKF.ShowDialog();
        }

        private void btn_Service_Click_1(object sender, EventArgs e)
        {
            label_Tittle.Text = "SERVICE";
            loadForm(new ServiceForm());
        }

        private void btn_Item_Click_1(object sender, EventArgs e)
        {
            label_Tittle.Text = "ITEM";
            loadForm(new List_Of_Items());
        }

        private void btn_Rule_Click_1(object sender, EventArgs e)
        {
            label_Tittle.Text = "RULE";
            loadForm(new RulesForm());
        }

        private void btn_DiscountPromotion_Click_1(object sender, EventArgs e)
        {
            label_Tittle.Text = "DISCOUNT";
            loadForm(new Discount_PromotionForm());
        }

        private void btn_Logout_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            login_GUI loginForm = new login_GUI();
            loginForm.Show();
        }

        private void btn_Checkin_Click_1(object sender, EventArgs e)
        {
            Check_inForm checkIn = new Check_inForm();
            checkIn.ShowDialog();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            Checkout_Form checkOut = new Checkout_Form();
            checkOut.ShowDialog();
        }

        private void btn_Dashboard_Click_1(object sender, EventArgs e)
        {
            showMainForm();
        }

        private void btn_Customer_Click_1(object sender, EventArgs e)
        {
            label_Tittle.Text = "CUSTOMER";
            loadForm(new CustomerList());
        }

        private void btn_Reservation_Click_1(object sender, EventArgs e)
        {
            label_Tittle.Text = "RESERVATION";
            loadForm(new Reservation());
        }

        private void btn_OrderService_Click_1(object sender, EventArgs e)
        {
            Services4Customer services = new Services4Customer();
            services.ShowDialog();
        }

        private void btn_Room_Click(object sender, EventArgs e)
        {
            label_Tittle.Text = "ROOM";
            loadForm(new Room_Form());
        }
    }
}


/*
 * Tạo CSDL
 * Tạo user, phân quyền, 
 * viết hàm, thủ tục bằng PL SQL
 * Cho RBTV, vẽ bảng tầm ảnh hưởng -> viết trigger bằng PL SQL
 * 
 */
