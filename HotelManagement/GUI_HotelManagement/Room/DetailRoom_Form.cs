using BUS_HotelManagement;
using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HotelManagement
{
    public partial class DetailRoom_Form : Form
    {
        Room_DTO logRoom = new Room_DTO();
        public string idCus;
        public DetailRoom_Form(Room_DTO RoomName)
        {
            InitializeComponent();
            logRoom = RoomName;
            setData(RoomName);
        }

        public void setData(Room_DTO RoomName)
        {
            string information = Room_BUS.getRoomInformation(RoomName);
            roomID_Text.Text = information.Split('\n')[0];
            roomName_Text.Text = RoomName.Name;
            roomType_Text.Text = information.Split('\n')[1];
            Price_Text.Text = information.Split('\n')[2];
            Status_Text.Text = information.Split('\n')[3];

            string cusInformation = Room_BUS.getCustomerRoomInformation(RoomName);
            if (Status_Text.Text == "Trống")
            {
                idCus = null;
                customerName_Text.Text = null;
                gender_Text.Text = null;
                Birthday_Text.Text = null;
                Email_Text.Text = null;
                Phone_Text.Text = null;
                Identify_Text.Text = null;

                //Edit_Confirm_Button.Hide();

                //Button bookingRoom = new Button();
                //bookingRoom.Enabled = true;
                //bookingRoom.Text = "Booking";
                //bookingRoom.Size = Edit_Confirm_Button.Size;
                //bookingRoom.Location = Edit_Confirm_Button.Location;
                //bookingRoom.Click += showBookingForm;
                //bookingRoom.Visible = true;
                //Controls.Add(bookingRoom);

                Edit_Confirm_Button.Click += showBookingForm;
                Edit_Confirm_Button.Text = "Booking";
            }
            else
            {
                idCus = cusInformation.Split("\n")[0];
                customerName_Text.Text = cusInformation.Split('\n')[1];
                gender_Text.Text = cusInformation.Split('\n')[2];
                Birthday_Text.Text = DateTime.Parse(cusInformation.Split('\n')[3]).ToString("dd/MM/yyyy");
                Email_Text.Text = cusInformation.Split('\n')[4];
                Phone_Text.Text = cusInformation.Split('\n')[5];
                Identify_Text.Text = cusInformation.Split('\n')[6];
            }

            serviceList_DataGrid.DataSource = Room_BUS.getRoomService(RoomName);
            ItemList_DataGrid.DataSource = Room_BUS.getRoomItems(RoomName);
        }
        private void showBookingForm(object sender, EventArgs e)
        {
            Room_DTO roomInfo = new Room_DTO(roomID_Text.Text, roomName_Text.Text, Status_Text.Text, int.Parse(Price_Text.Text), roomType_Text.Text);
            Booking_Form newBooking = new Booking_Form(roomInfo);
            this.Hide();
            newBooking.ShowDialog();
            this.Close();
        }

        public bool isEditing = true;
        private void Edit_Confirm_Button_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                Edit_Confirm_Button.Text = "Confirm";

                Price_Text.Enabled = true;

                customerName_Text.Enabled = true;
                gender_Text.Enabled = true;
                Birthday_Text.Enabled = true;
                Email_Text.Enabled = true;
                Phone_Text.Enabled = true;
                Identify_Text.Enabled = true;

            }
            else
            {
                DialogResult result = MessageBox.Show("Xác nhận cập nhật thông tin!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int price;
                    if (Price_Text.Text == "" || int.Parse(Price_Text.Text) < 0)
                    {
                        MessageBox.Show("Giá phòng không phù hợp!");
                        return;
                    }
                    else
                    {
                        price = int.Parse(Price_Text.Text);
                    }

                    String name = customerName_Text.Text;
                    string gender = gender_Text.Text;

                    string birthday = Birthday_Text.Text;
                    DateTime date;

                    if (!DateTime.TryParseExact(birthday, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        MessageBox.Show("Ngày sinh không đúng định dạng");
                        return;
                    }

                    string email = Email_Text.Text;
                    string phone = Phone_Text.Text;
                    string identify = Identify_Text.Text;

                    if (name == "" || email == "" || !email.Contains("@") || phone == "" || identify == "")
                    {
                        MessageBox.Show("Cập nhật thất bại, thông tin không chính xác");
                        return;
                    }
                    else
                    {
                        Customer_DTO CusInfo = new Customer_DTO(idCus, name, gender, birthday, email, phone, identify);
                        Room_DTO priceRoom = new Room_DTO(roomName_Text.Text, price);

                        bool flagPrice = Room_BUS.updatePriceRoom(priceRoom);
                        bool flagCustomer = Customer_BUS.updateCustomer(CusInfo);
                        if (flagPrice && flagCustomer)
                        {
                            Edit_Confirm_Button.Text = "Edit";

                            Price_Text.Enabled = false;

                            customerName_Text.Enabled = false;
                            gender_Text.Enabled = false;
                            Birthday_Text.Enabled = false;
                            Email_Text.Enabled = false;
                            Phone_Text.Enabled = false;
                            Identify_Text.Enabled = false;
                        }
                        else if (!flagPrice && flagCustomer)
                        {
                            MessageBox.Show("Cập nhật giá thất bại, thông tin không chính xác! \n" +
                                            "Cập nhật thông tin khách hàng thành công");
                            return;
                        }
                        else if (flagPrice && !flagCustomer)
                        {
                            MessageBox.Show("Cập nhật thông tin khách hàng thất bại, thông tin không chính xác! \n" +
                                            "Cập nhật thông tin giá cả thành công");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại, một số thông tin chưa chính xác");
                            return;
                        }
                    }

                }
                else
                {
                    return;
                }
            }
            isEditing = !isEditing;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
