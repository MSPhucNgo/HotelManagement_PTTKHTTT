﻿using BUS_HotelManagement;
using DAO_HotelManagement;
using DTO_HotelManagement;

using HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Services4Customer : Form
    {
        Partner_Tour_DTO partnerTour = new Partner_Tour_DTO();

        Customer_Tour_DTO cusTour = new Customer_Tour_DTO();

        DataTable dtTour = new DataTable();
        DataTable dtDestination = new DataTable();
        DataTable dtDeparture = new DataTable();

        DataGridViewButtonColumn doWork = new DataGridViewButtonColumn();
        DataGridViewButtonColumn doWork1 = new DataGridViewButtonColumn();
        DataGridViewButtonColumn doWork2 = new DataGridViewButtonColumn();
        public Services4Customer()
        {
            InitializeComponent();
            try
            {
                // set up dtgv
                dtgvRoomList.RowHeadersWidth = 50;
                dtgvTour.RowHeadersWidth = 50;
                // load data
                txbError.Text = "30";
                doWork1.HeaderText = "Delete";
                doWork1.Name = "Delete";
                doWork1.Text = "x";
                doWork2.HeaderText = "Delete";
                doWork2.Name = "Delete";
                doWork2.Text = "x";
                // dtgvServiceForm.Columns.Insert(dtgvServiceForm.Columns.Count, doWork);
                dtgvServiceForm.Columns.Insert(dtgvServiceForm.Columns.Count, doWork1);
                dtgvCustomerTour.Columns.Insert(dtgvCustomerTour.Columns.Count, doWork2);
                loadTour("", "", "null", "null");
                loadDepartureList();
                loadDestinationList();



                timepickLeaving.Format = DateTimePickerFormat.Custom;
                timepickLeaving.CustomFormat = " ";
                timepickEnd.Format = DateTimePickerFormat.Custom;
                timepickEnd.CustomFormat = " ";



                // timepickEnd.Text = "null";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        // book
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //string cusId = dtgvRoomList.Rows[e.RowIndex].Cells["ID_CUSTOMER"].Value.ToString();
            //string cusName = dtgvRoomList.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
            //string phone = dtgvRoomList.Rows[e.RowIndex].Cells["PHONE"].Value.ToString();

            // 
            try
            {
                string startDate = dtgvTour.Rows[e.RowIndex].Cells["START_TIME"].Value.ToString();
                string endDate = dtgvTour.Rows[e.RowIndex].Cells["END_TIME"].Value.ToString();
                int price = int.Parse(dtgvTour.Rows[e.RowIndex].Cells["PRICE"].Value.ToString());
                string idTourOrigin = dtgvTour.Rows[e.RowIndex].Cells["ID_TOUR"].Value.ToString();
                string tourName = dtgvTour.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
                string departure = dtgvTour.Rows[e.RowIndex].Cells["DEPARTURE_POINT"].Value.ToString();
                string destination = dtgvTour.Rows[e.RowIndex].Cells["DESTINATION"].Value.ToString();
                int totalDay = int.Parse(dtgvTour.Rows[e.RowIndex].Cells["TOTAL_DAY"].Value.ToString());
                string travel = dtgvTour.Rows[e.RowIndex].Cells["TRAVEL_AGENCY"].Value.ToString();
                Customer_DTO cus = new Customer_DTO("", "", "", "", "", "", "");
                Partner_Tour_DTO parttour = new Partner_Tour_DTO("", tourName, travel, departure, destination, "0", "0", price.ToString(), totalDay, "", "");
                Schedule_DTO sche = new Schedule_DTO("", startDate, endDate);
                cusTour = new Customer_Tour_DTO("", startDate, 1, price, "", "Đang nhập thông tin", idTourOrigin, "");
                Tour_Booking tour_Booking = new Tour_Booking(cus, parttour, cusTour, sche);
                tour_Booking.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        // load data
        private void loadTour(string depart, string des, string leavingDate, string endDate)
        {
            try
            {
                int error = int.Parse(txbError.Text);
                Partner_Tour_DTO partTour = new Partner_Tour_DTO("", "", "", depart, des, "", "", "", 0, "", "");
                Schedule_DTO sche;

                if (timepickLeaving.CustomFormat == " " && timepickEnd.CustomFormat == " ")
                {
                    sche = new Schedule_DTO("", "null", "null");
                }
                else if (timepickLeaving.CustomFormat != " ")
                {
                    sche = new Schedule_DTO("", leavingDate, "null");
                }
                else if (timepickEnd.CustomFormat != " ")
                {
                    sche = new Schedule_DTO("", "null", endDate);
                }
                else
                {
                    sche = new Schedule_DTO("", leavingDate, endDate);
                }

                dtTour = Services_for_customer_BUS.usp_searchTour_svs(partTour, sche, error);
                dtgvTour.DataSource = dtTour;

                setHeaderIndex(dtgvTour);

                // fix ui
                /*            id_tour,description, owner, superivsor, id_tour1

                mininum_Number
                maximum_number
                price
                total_day*/

                dtgvTour.Columns["ID_TOUR"].Visible = false;
                // dtgvTour.Columns["DESCRIPTION"].Visible= false;
                dtgvTour.Columns["OWNER"].Visible = false;
                //dtgvTour.Columns["SUPERVISOR"].Visible=false;
                // dtgvTour.Columns["ID_TOUR1"].Visible = false;

                dtgvTour.Columns["MINIMUM_NUMBER"].Width = 50;
                dtgvTour.Columns["MAXIMUM_NUMBER"].Width = 50;
                dtgvTour.Columns["PRICE"].Width = 50;
                dtgvTour.Columns["TOTAL_DAY"].Width = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void loadDepartureList()
        {
            try
            {
                dtDeparture = Services_for_customer_BUS.usp_getAllDepartureList_svs();
                cbxDeparture.DataSource = dtDeparture;
                cbxDeparture.DisplayMember = "DEPARTURE_POINT";
                cbxDeparture.ValueMember = "DEPARTURE_POINT";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void loadDestinationList()
        {
            try
            {
                dtDestination = Services_for_customer_BUS.usp_getAllDestinationList_svs();
                cbxDestination.DataSource = dtDestination;
                cbxDestination.DisplayMember = "DESTINATION";
                cbxDestination.ValueMember = "DESTINATION";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void loadServiceForm()
        {
            try
            {
                dtgvServiceForm.Columns.Remove("Delete");
                DataTable dt = Services_for_customer_BUS.usp_getServiceFormsByPhone_svs(tbSearchPhone.Text);

                dtgvServiceForm.DataSource = dt;


                //dtgvServiceForm.Columns.Insert(dtgvServiceForm.Columns.Count, doWork);
                dtgvServiceForm.Columns.Insert(dtgvServiceForm.Columns.Count, doWork1);
                for (int i = 0; i < dtgvServiceForm.Rows.Count - 1; i++)
                {
                    string sta = dtgvServiceForm.Rows[i].Cells["STATUS"].Value.ToString();
                    if (sta == "Đã thanh toán")
                    {
                        dtgvServiceForm.Rows[i].DefaultCellStyle.BackColor = Color.Tan;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void loadCustomerTour()
        {
            try
            {
                dtgvCustomerTour.Columns.Remove("Delete");
                DataTable dt = Services_for_customer_BUS.usp_getCustomerTourByPhone_svs(tbSearchPhoneTour.Text);

                dtgvCustomerTour.DataSource = dt;

                //dtgvServiceForm.Columns.Insert(dtgvServiceForm.Columns.Count, doWork);
                dtgvCustomerTour.Columns.Insert(dtgvCustomerTour.Columns.Count, doWork2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string str = dtgvRoomList.Rows[e.RowIndex].Cells["ID_ROOM"].Value.ToString();
                string cusId = dtgvRoomList.Rows[e.RowIndex].Cells["ID_CUSTOMER"].Value.ToString();
                string cusName = dtgvRoomList.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
                string phone = dtgvRoomList.Rows[e.RowIndex].Cells["PHONE"].Value.ToString();
                string bfId = dtgvRoomList.Rows[e.RowIndex].Cells["ID_BOOKING"].Value.ToString();

                Room_DTO room = new Room_DTO(str, "", 0);
                Customer_DTO cus = new Customer_DTO(cusId, cusName, "", "", "", phone, "");
                BookingForm_DTO bookingForm = new BookingForm_DTO(bfId);
                Service_Of_Room serviceOfRoomScreen = new Service_Of_Room(bookingForm, room, cus);
                //this.Hide();
                serviceOfRoomScreen.ShowDialog();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_tour_search_Click(object sender, EventArgs e)
        {
            try
            {
                string dep = "";
                string des = "";
                string lea = "null", end = "null";
                if (cbxDep.Checked)
                {
                    dep = cbxDeparture.Text;
                }
                if (cbxDes.Checked)
                {
                    des = cbxDestination.Text;
                }
                if (cbxLea.Checked)
                {
                    lea = timepickLeaving.Value.Date.ToString("yyyy/MM/dd").Replace("/", "-");
                }
                if (cbxEnd.Checked)
                {
                    end = timepickEnd.Value.Date.ToString("yyyy/MM/dd").Replace("/", "-");
                }
                loadTour(dep, des, lea, end);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private void setHeaderIndex(DataGridView dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
        private void btn_room_search_Click(object sender, EventArgs e)
        {
            try
            {
                string roomId = txbRoomID.Text;
                //string roomId = "1002";
                Room_DTO room = new Room_DTO(roomId, "", 0);

                dtgvRoomList.DataSource = Services_for_customer_BUS.usp_SearchRoomByID_svs(room);
                //dtgvRoomList.Columns[0].Visible = false;
                for (int i = 0; i < dtgvRoomList.Rows.Count; i++)
                {
                    dtgvRoomList.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timepickLeaving_ValueChanged(object sender, EventArgs e)
        {

            if (timepickLeaving.Text != "")
            {
                timepickLeaving.CustomFormat = "yyyy-MM-dd";
                cbxLea.Checked = true;
            }
            else
            {
                timepickLeaving.CustomFormat = " ";
            }

        }

        private void timepickEnd_ValueChanged(object sender, EventArgs e)
        {
            if (timepickEnd.Text != "")
            {
                timepickEnd.CustomFormat = "yyyy-MM-dd";
                cbxEnd.Checked = true;
            }
            else
            {
                timepickEnd.CustomFormat = " ";
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSearchServiceForm_Click(object sender, EventArgs e)
        {
            try
            {
                loadServiceForm();
                doWork1.HeaderText = "Delete";
                doWork1.Name = "Delete";
                doWork1.Text = "x";
                doWork1.Width = 60;
                doWork1.DefaultCellStyle.BackColor = Color.Green;
                doWork1.UseColumnTextForButtonValue = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void dtgvServiceForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                string formid = dtgvServiceForm.Rows[e.RowIndex].Cells["ID_SERVICE_FORM"].Value.ToString();
                string statusSF = dtgvServiceForm.Rows[e.RowIndex].Cells["STATUS"].Value.ToString();
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                          e.RowIndex >= 0 && e.ColumnIndex > 4)
                {
                    if (statusSF == "Đã thanh toán")
                    {
                        MessageBox.Show("This service bill was payed, can not be removed.");
                        return;
                    }

                    if ((MessageBox.Show("Are you sure to delete schedule?", "The Title",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                    {
                        string query = "delete from SERVICE_BILL where ID_SERVICE_FORM= '" + formid + "'";
                        int res = DataProvider.Instance.ExecuteNonQuery(query);
                        if (res != 0)
                        {
                            query = "delete from SERVICE_FORM where ID_SERVICE_FORM= '" + formid + "'";
                            res = DataProvider.Instance.ExecuteNonQuery(query);
                        }
                        else
                        {
                            MessageBox.Show("Delete fail, please try again!");
                            return;
                        }

                        if (res != 0)
                        {
                            MessageBox.Show("Delete successfully!");
                            loadServiceForm();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Delete fail, please try again!");
                            return;
                        }
                    }
                    else { return; }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void btnSearchCustomerTour_Click(object sender, EventArgs e)
        {
            try
            {
                loadCustomerTour();
                doWork2.HeaderText = "Delete";
                doWork2.Name = "Delete";
                doWork2.Text = "x";
                doWork2.Width = 60;
                doWork2.DefaultCellStyle.BackColor = Color.Green;
                doWork2.UseColumnTextForButtonValue = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dtgvCustomerTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                string formid = dtgvCustomerTour.Rows[e.RowIndex].Cells["ID_CUSTOMER_TOUR"].Value.ToString();
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                          e.RowIndex >= 0 && e.ColumnIndex > 4)
                {

                    if ((MessageBox.Show("Are you sure to delete customer's tour?", "The Title",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                    {
                        string query = "delete from CUSTOMER_TOUR where ID_CUSTOMER_TOUR= '" + formid + "'";
                        int res = DataProvider.Instance.ExecuteNonQuery(query);

                        if (res != 0)
                        {
                            MessageBox.Show("Delete successfully!");
                            loadCustomerTour();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Delete fail, please try again!");
                            return;
                        }
                    }
                    else { return; }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Services4Customer_Load(object sender, EventArgs e)
        {

        }

        private void cbxDep_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDep.Checked = true;
        }

        private void cbxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDes.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxLea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbError_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
