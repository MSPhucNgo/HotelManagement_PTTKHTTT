using BUS_HotelManagement;
using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HotelManagement
{
    public partial class MultiRoom_Form : Form
    {
        public List<Room_DTO> roomInfor = new List<Room_DTO>();
        public BookingForm_DTO inforBooking = new BookingForm_DTO();
        public Customer_DTO inforCTM = new Customer_DTO();
        public Infomation_Form_DTO inforForm = new Infomation_Form_DTO();
        public Supply_Form_DTO supInfo = new Supply_Form_DTO();
        public Bill_DTO inforBill = new Bill_DTO();
        public bool exitedCTM = new bool();

        public MultiRoom_Form()
        {
            InitializeComponent();
            bookingRoom_DataGrid.Columns.Add("NameRoom", "Name");
            bookingRoom_DataGrid.Columns.Add("PriceRoom", "Price");
            bookingRoom_DataGrid.Columns.Add("TypeRoom", "Type");

            setData_FilterType();
        }

        public MultiRoom_Form(ref Customer_DTO _inforCTM, ref BookingForm_DTO _inforBooking, ref Infomation_Form_DTO _inforForm, ref Supply_Form_DTO _supInfo, ref Bill_DTO _inforBill, ref bool _exitedCTM, ref List<Room_DTO> roomInfor)
        {
            InitializeComponent();
            this.inforBooking = _inforBooking;
            this.inforCTM = _inforCTM;
            this.inforForm = _inforForm;
            this.supInfo = _supInfo;
            this.inforBill = _inforBill;
            this.exitedCTM = _exitedCTM;
            this.roomInfor = roomInfor;

            bookingRoom_DataGrid.Columns.Add("NameRoom", "Name");
            bookingRoom_DataGrid.Columns.Add("PriceRoom", "Price");
            bookingRoom_DataGrid.Columns.Add("TypeRoom", "Type");
            foreach (Room_DTO room in this.roomInfor)
            {
                bookingRoom_DataGrid.Rows.Add(room.Name, room.Price, room.Type);

            }
            setData_FilterType();

        }

        void setData_FilterType()
        {
            List<string> ListRoomName = Room_BUS.getListRoom_Type("Trống", "All");
            foreach (string roomName in ListRoomName)
            {
                createButton(roomName);
            }
        }
        public void createButton(string roomName)
        {
            Button roundedButton = new Button();
            roundedButton.Text = roomName;
            roundedButton.Font = new Font(roundedButton.Font.FontFamily, 12, roundedButton.Font.Style);
            string statusRoom = Room_BUS.getRoomStatus(new Room_DTO(roomName.Split('\n')[0]));
            if (statusRoom == null) { return; }
            else if (statusRoom == "Trống")
            {
                roundedButton.BackColor = Color.FromArgb(0, 193, 138);
                roundedButton.Size = new Size(135, 103);
            }
            else if (statusRoom == "Đang sử dụng")
            {
                roundedButton.BackColor = ColorTranslator.FromHtml("#EF3B2C"); ;
                roundedButton.Size = new Size(135, 103);
            }
            else if (statusRoom == "Được đặt trước")
            {
                roundedButton.BackColor = Color.FromArgb(44, 121, 195);
                roundedButton.Size = new Size(135, 103);
            }

            foreach (DataGridViewRow row in bookingRoom_DataGrid.Rows)
            {
                if (row.Cells["NameRoom"].Value.ToString() == roomName.Split('\n')[0])
                {
                    roundedButton.BackColor = Color.Gray;
                }
            }
            roundedButton.FlatStyle = FlatStyle.Flat;
            roundedButton.FlatAppearance.BorderSize = 0;
            roundedButton.Cursor = Cursors.Hand;
            roundedButton.Click += Show_Click;
            ListRoom_FlowLayout.Controls.Add(roundedButton);
        }

        List<Button> buttonList = new List<Button>();
        private void Show_Click(object sender, EventArgs e)
        {
            string roomname = (sender as Button).Text.Split('\n')[0];
            string price = Room_BUS.getRoomPrice(new Room_DTO(roomname));
            string type = (sender as Button).Text.Split('\n')[1];
            //Thêm vào DataGrid
            if ((sender as Button).BackColor == Color.FromArgb(0, 193, 138))
            {
                Button disableButton = sender as Button;
                bookingRoom_DataGrid.Rows.Add(roomname, price, type);
                buttonList.Add(sender as Button);
                //(sender as Button).Enabled = false;
                (sender as Button).BackColor = Color.Gray;
                // roomInfor.Add(new Room_DTO(null, roomname, price, type));
            }
            else if ((sender as Button).BackColor == Color.Gray)
            {
                DialogResult result = MessageBox.Show("Xác nhận xóa phòng ra khỏi danh sách đặt ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in bookingRoom_DataGrid.Rows)
                    {
                        if (row.Cells["NameRoom"].Value.ToString() == roomname && !row.IsNewRow)
                        {
                            bookingRoom_DataGrid.Rows.Remove(row);
                            (sender as Button).BackColor = Color.FromArgb(0, 193, 138);
                            //foreach(Room_DTO roominfo in roomInfor)
                            //{
                            //    if(roominfo.Name == roomname) roomInfor.Remove(roominfo);
                            //}
                        }
                    }
                }
                else
                {
                    return;
                }
            }

            //Ẩn khỏi layoutPanel
            //ListRoom_FlowLayout.Controls.Remove(sender as Button);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.roomInfor.Clear();
            foreach (DataGridViewRow row in bookingRoom_DataGrid.Rows)
            {
                string temp = row.Cells["NameRoom"].Value.ToString();
                string price = row.Cells["PriceRoom"].Value.ToString();
                string typeRoom = row.Cells["TypeRoom"].Value.ToString();

                string idRoom = Room_BUS.getRoomId(new Room_DTO(null, temp, 0));
                roomInfor.Add(new Room_DTO(idRoom, temp, price, typeRoom));
            }
            inforBooking.Price = Room_BUS.totalRoomFee(ref roomInfor);
            inforBill.Room_Fee = inforBooking.Price.ToString();
            inforBill.Deposit_price = (float.Parse(inforBill.Room_Fee) * 30 / 100).ToString();

            //foreach (Room_DTO roominfo in roomInfor)
            //{
            //    MessageBox.Show(roominfo.Name.ToString());
            //}

            this.Hide();
            Booking_Form bkf = new Booking_Form(ref inforCTM, ref inforBooking, ref roomInfor, ref inforForm, ref supInfo, ref inforBill, ref exitedCTM);
            bkf.ShowDialog();
            this.Close();
        }
    }
}
