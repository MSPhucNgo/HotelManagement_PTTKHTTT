using BUS_HotelManagement;
using DTO_HotelManagement;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_HotelManagement
{
    public partial class Checkout_Form : Form
    {
        bool isUpdate = false;
        DataTable listItemDamaged = new DataTable();
        DataTable room = new DataTable();
        DataTable service = new DataTable();
        public Checkout_Form()
        {
            InitializeComponent();
            Method_ComboBox.Text = "None";
            //cusName_Text.Text = "Ngô Lê Hưng Thịnh ";
        }
        public Checkout_Form(string bookingID)
        {
            InitializeComponent();
            idBooking_Text.Text = bookingID;
            cusName_Text.Text = "";
            string userName = cusName_Text.Text.ToString();
            bool flag = BookingForm_BUS.check_BookingCheckout(new BookingForm_DTO(idBooking_Text.Text));
            //MessageBox.Show(flag.ToString());
            setDatawithCusInfo(new Customer_DTO(userName), flag);
        }
        public Checkout_Form(BookingForm_DTO bookingInfo, DataTable listDamaged)
        {
            isUpdate = true;
            InitializeComponent();
            cusName_Text.Text = BookingForm_BUS.getGuestName(bookingInfo);
            listItemDamaged = listDamaged;
            damage_DataGrid.DataSource = listDamaged;

            setDatawithCusInfo(new Customer_DTO(cusName_Text.Text), true);

        }
        public void setDatawithCusInfo(Customer_DTO cusInfo, bool flag)
        {
            if (cusInfo.Name.Trim().Length != 0 && idBooking_Text.Text.Trim().Length == 0 && flag)
            {
                idBooking_Text.Text = Customer_BUS.getCusID_Booking(cusInfo);
                if (idBooking_Text.Text != "")
                {
                    BookingForm_DTO bookingID = new BookingForm_DTO(idBooking_Text.Text);
                    cusName_Text.Text = BookingForm_BUS.getGuestName(bookingID);
                    Method_ComboBox.Text = BookingForm_BUS.getPaymenMethods(bookingID);
                    addDamage_Button.Enabled = true;
                    listRoom_DataGrid.DataSource = BookingForm_BUS.getListRoom(bookingID);
                    room = BookingForm_BUS.getListRoom(bookingID);
                    listService_DataGrid.DataSource = Customer_BUS.getUsedService(new Customer_DTO(cusName_Text.Text.ToString()));
                    service = Customer_BUS.getUsedService(new Customer_DTO(cusName_Text.Text.ToString()));
                    setPrice();
                }
                else
                {
                    MessageBox.Show("Customer not have any booking form!");
                    setNullData();
                }
            }
            else if (cusInfo.Name.Trim().Length == 0 && idBooking_Text.Text.Trim().Length != 0 && flag)
            {
                try
                {
                    BookingForm_DTO bookingID = new BookingForm_DTO(idBooking_Text.Text);
                    cusName_Text.Text = BookingForm_BUS.getGuestName(bookingID);
                    Method_ComboBox.Text = BookingForm_BUS.getPaymenMethods(bookingID);
                    addDamage_Button.Enabled = true;
                    listRoom_DataGrid.DataSource = BookingForm_BUS.getListRoom(bookingID);
                    room = BookingForm_BUS.getListRoom(bookingID);
                    listService_DataGrid.DataSource = Customer_BUS.getUsedService(new Customer_DTO(cusName_Text.Text.ToString()));
                    service = Customer_BUS.getUsedService(new Customer_DTO(cusName_Text.Text.ToString()));
                    setPrice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't find booking id!");
                }
            }
            else if (cusInfo.Name.Trim().Length != 0 && idBooking_Text.Text.Trim().Length != 0 && flag)
            {
                if (idBooking_Text.Text == Customer_BUS.getCusID_Booking(cusInfo))
                {
                    BookingForm_DTO bookingID = new BookingForm_DTO(idBooking_Text.Text);
                    cusName_Text.Text = BookingForm_BUS.getGuestName(bookingID);
                    Method_ComboBox.Text = BookingForm_BUS.getPaymenMethods(bookingID);
                    addDamage_Button.Enabled = true;
                    listRoom_DataGrid.DataSource = BookingForm_BUS.getListRoom(bookingID);
                    room = BookingForm_BUS.getListRoom(bookingID);
                    listService_DataGrid.DataSource = Customer_BUS.getUsedService(new Customer_DTO(cusName_Text.Text.ToString()));
                    service = Customer_BUS.getUsedService(new Customer_DTO(cusName_Text.Text.ToString()));
                    setPrice();
                }
                else
                {
                    MessageBox.Show("Customer not have any booking form!");
                    setNullData();
                }
            }
            else
            {
                MessageBox.Show("Can't find the booking form, please check your information again!");
                setNullData();
            }
        }
        public void setNullData()
        {
            idBooking_Text.Text = null;
            cusName_Text.Text = null;
            roomFee_Text.Text = null;
            serviceFee_Text.Text = null;
            damageFee_Text.Text = null;
            addDamage_Button.Enabled = false;
            totalFee_Text.Text = null;
            Method_ComboBox.Text = "None";
            listRoom_DataGrid.DataSource = null;
            listService_DataGrid.DataSource = null;
        }
        public void setPrice()
        {
            string billID = BookingForm_BUS.getBillID(new BookingForm_DTO(idBooking_Text.Text));

            int roomFee = 0;
            int serviceFee = 0;
            int damagedFee = 0;
            int depositFree = 0;
            int serviceFeePay = 0;
            string billInfo = Bill_BUS.getBillInfo(new Bill_DTO(billID));
            depositFree = int.Parse(billInfo.Split('\n')[0]);
            string statusBill = billInfo.Split('\n')[1];
            foreach (DataGridViewRow row in listRoom_DataGrid.Rows)
            {
                if (!row.IsNewRow && row.Cells["Price"].Value.ToString() != "")
                {
                    int price = int.Parse(row.Cells["Price"].Value.ToString());
                    roomFee += price;
                }
            }
            foreach (DataGridViewRow row in listService_DataGrid.Rows)
            {
                if (!row.IsNewRow && row.Cells["Total_Price"].Value.ToString() != "")
                {
                    int price = int.Parse(row.Cells["Total_Price"].Value.ToString());
                    serviceFee += price;
                }
            }
            foreach (DataGridViewRow row in listService_DataGrid.Rows)
            {
                if (!row.IsNewRow && row.Cells["Total_Price"].Value.ToString() != "")
                {
                    string statusService = row.Cells["Status"].Value.ToString();
                    if (statusService == "Ðã thanh toán")
                    {
                        int price = int.Parse(row.Cells["Total_Price"].Value.ToString());
                        serviceFeePay += price;
                    }
                }
            }
            foreach (DataGridViewRow row in damage_DataGrid.Rows)
            {
                if (!row.IsNewRow && row.Cells["Total_Price"].Value.ToString() != "")
                {
                    int price = int.Parse(row.Cells["Total_Price"].Value.ToString());
                    damagedFee += price;
                }
            }
            roomFee_Text.Text = roomFee.ToString();
            serviceFee_Text.Text = (serviceFee - serviceFeePay).ToString();
            damageFee_Text.Text = damagedFee.ToString();
            depositPrice_Text.Text = depositFree.ToString();
            Deposit_Fee_Status_Label.Text = "Status : " + statusBill.ToString();
            NotPay_Label.Text = "Not pay : " + (serviceFee - serviceFeePay).ToString();
            Pay_Label.Text = "Pay : " + serviceFeePay.ToString();
            if (statusBill == "Chưa thanh toán") totalFee_Text.Text = (roomFee + serviceFee + damagedFee + depositFree - serviceFeePay).ToString();
            else totalFee_Text.Text = (roomFee + serviceFee + damagedFee - serviceFeePay).ToString();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string userName = cusName_Text.Text.ToString();
            setDatawithCusInfo(new Customer_DTO(userName), true);
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                cusName_Text.Text = null;
                idBooking_Text.Text = null;
                roomFee_Text.Text = null;
                serviceFee_Text.Text = null;
                depositPrice_Text.Text = null;
                damageFee_Text.Text = null;
                totalFee_Text.Text = null;
                Method_ComboBox.Text = "Cash";
                listRoom_DataGrid.DataSource = null;
                listService_DataGrid.DataSource = null;
                addDamage_Button.Enabled = false;
            }
            else
            {
                setDatawithCusInfo(new Customer_DTO(cusName_Text.Text), true);
            }
        }
        private void addDamage_Button_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                BookingForm_DTO bookingInfo = new BookingForm_DTO(idBooking_Text.Text);
                damagedItems addDamagedForm = new damagedItems(bookingInfo);
                addDamagedForm.ShowDialog();
                this.Close();
            }
            else
            {
                BookingForm_DTO bookingInfo = new BookingForm_DTO(idBooking_Text.Text);
                damagedItems addDamagedForm = new damagedItems(bookingInfo, listItemDamaged);
                addDamagedForm.ShowDialog();
                this.Close();
            }
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thanh toán!", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string billID = BookingForm_BUS.getBillID(new BookingForm_DTO(idBooking_Text.Text));
                Bill_DTO updateBill = new Bill_DTO(billID, roomFee_Text.Text, serviceFee_Text.Text, damageFee_Text.Text, depositPrice_Text.Text, totalFee_Text.Text, Method_ComboBox.Text, "Đã thanh toán", "EMP02", idBooking_Text.Text);
                foreach (DataGridViewRow row in listRoom_DataGrid.Rows)
                {
                    if (!row.IsNewRow && row.Cells["NAME"].Value.ToString() != "")
                    {
                        Room_DTO updateStatus = new Room_DTO(row.Cells["NAME"].Value.ToString());
                        bool flag_status = Room_BUS.updateStatusRoom(updateStatus, "Trống");
                        if (!flag_status)
                        {
                            MessageBox.Show("Cập nhật thất bại, thông tin không chính xác!");
                            return;
                        }
                    }
                }
                bool flag = Bill_BUS.updateBill(updateBill);
                bool flagCheckout = BookingForm_BUS.Update_BookingFormCheckOut(new BookingForm_DTO(idBooking_Text.Text));

                if (flag && flagCheckout)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Một số thông tin cập nhật thất bại, thông tin không chính xác!");
                    return;
                }
                BookingForm_DTO billBooking = new BookingForm_DTO(idBooking_Text.Text);
                Customer_DTO cusInfo = new Customer_DTO(cusName_Text.Text);
                checkoutBill_Form Bill = new checkoutBill_Form(billID, billBooking, cusInfo, room, service, listItemDamaged);
                this.Hide();
                Bill.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }

        bool isClick_Deposit = false;
        bool isClick_Service = false;
        private void Status_Service_Fee_Button_Click(object sender, EventArgs e)
        {
            if (!isClick_Service)
            {
                Service_Fee_Details_Panel.Visible = true;
            }
            else
            {
                Service_Fee_Details_Panel.Visible = false;
            }
            isClick_Service = !isClick_Service;
        }

        private void Deposit_Fee_Status_Button_Click(object sender, EventArgs e)
        {
            if (!isClick_Deposit)
            {
                Deposit_Fee_Details_Panel.Visible = true;
            }
            else
            {
                Deposit_Fee_Details_Panel.Visible = false;
            }
            isClick_Deposit = !isClick_Deposit;
        }
    }
}
