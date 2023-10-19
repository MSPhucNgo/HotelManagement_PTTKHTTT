using BUS_HotelManagement;
using DAO_HotelManagement;
using DTO_HotelManagement;

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
    public partial class Discount_PromotionForm : Form
    {
        public Discount_PromotionForm()
        {
            InitializeComponent();
            setData();
        }

        public void setData()
        {
            Discount_DataGrid.DataSource = DiscountPromotion_BUS.LoadDataDiscount();
            ServiceID_ComboBox.DataSource = HotelService_BUS.getServiceID();
            idDiscount_ComboBox.DataSource = DiscountPromotion_BUS.getDiscountID();
        }

        private void Disable_Button_Click(object sender, EventArgs e)
        {
            string DiscountId = idDiscount_ComboBox.Text;

            DiscountPromotion_DTO idDiscount = new DiscountPromotion_DTO(DiscountId);
            bool flag = DiscountPromotion_BUS.removeDiscountID(idDiscount);

            if (flag)
            {
                MessageBox.Show("Xóa thành công!");
                foreach (DataGridViewRow row in Discount_DataGrid.Rows)
                {
                    if (row.Cells["ID_DISCOUNT"].Value.ToString() == DiscountId)
                    {
                        Discount_DataGrid.Rows.Remove(row);
                        break;
                    }
                }
                idDiscount_ComboBox.DataSource = DiscountPromotion_BUS.getDiscountID();
                return;
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
                return;
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            DiscountPromotion_DTO discountDate = new DiscountPromotion_DTO(Start_DataTime.Value.ToString(), End_DataTime.Value.ToString());
            Discount_DataGrid.DataSource = DiscountPromotion_BUS.SearchDataDiscount(discountDate, ServiceID_ComboBox.Text);
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Discount_DataGrid.DataSource = DiscountPromotion_BUS.LoadDataDiscount();
            ServiceID_ComboBox.DataSource = HotelService_BUS.getServiceID();
            Start_DataTime.Value = DateTime.Today;
            End_DataTime.Value = DateTime.Today.AddMonths(1);
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            DiscountPromotion_DTO discountID = new DiscountPromotion_DTO(idDiscount_ComboBox.Text);
            addDiscountForm addDiscount = new addDiscountForm(discountID);
            addDiscount.ShowDialog();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            addDiscountForm addDiscount = new addDiscountForm();
            addDiscount.ShowDialog();
        }
    }
}
