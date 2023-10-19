using Amazon.Auth.AccessControlPolicy;
using BUS_HotelManagement;

using DTO_HotelManagement;
using GUI_HotelManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HotelManagement.Check_out
{
    public partial class Feedback : Form
    {
        string idBill = "";
        public Feedback(string BillID)
        {
            InitializeComponent();
            idBill = BillID;
            rate_Label.Text = "0";
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thêm đánh giá!", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string content = feedback_Text.Text;
                string newId = (int.Parse(Feedback_BUS.getMaxID()) + 1).ToString();
                string created_date = DateTime.Today.ToString();
                Feedback_DTO addFeedback = new Feedback_DTO(newId, content, created_date, rate_Label.Text, idBill);
                bool flag = Feedback_BUS.addFeedback(addFeedback);
                if (flag)
                {
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại, thông tin không chính xác!");
                    DialogResult messageNext = MessageBox.Show("Bạn có muốn tiếp tục đánh giá?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (messageNext == DialogResult.Yes)
                    {
                        return;
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại, thông tin không chính xác!");
                DialogResult messageNext = MessageBox.Show("Bạn có muốn tiếp tục đánh giá?", "Xác nhận", MessageBoxButtons.YesNo);
                if (messageNext == DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void Star1st_Click(object sender, EventArgs e)
        {
            Star1st.Image = Resources.Star_Bright;

            Star2nd.Image = Resources.Star_Dark;
            Star3rd.Image = Resources.Star_Dark;
            Star4th.Image = Resources.Star_Dark;
            Star5th.Image = Resources.Star_Dark;

            rate_Label.Text = "1";
        }

        private void Star2nd_Click(object sender, EventArgs e)
        {
            Star1st.Image = Resources.Star_Bright;
            Star2nd.Image = Resources.Star_Bright;

            Star3rd.Image = Resources.Star_Dark;
            Star4th.Image = Resources.Star_Dark;
            Star5th.Image = Resources.Star_Dark;

            rate_Label.Text = "2";
        }

        private void Star3rd_Click(object sender, EventArgs e)
        {
            Star1st.Image = Resources.Star_Bright;
            Star2nd.Image = Resources.Star_Bright;
            Star3rd.Image = Resources.Star_Bright;

            Star4th.Image = Resources.Star_Dark;
            Star5th.Image = Resources.Star_Dark;

            rate_Label.Text = "3";
        }

        private void Star4th_Click(object sender, EventArgs e)
        {
            Star1st.Image = Resources.Star_Bright;
            Star2nd.Image = Resources.Star_Bright;
            Star3rd.Image = Resources.Star_Bright;
            Star4th.Image = Resources.Star_Bright;

            Star5th.Image = Resources.Star_Dark;

            rate_Label.Text = "4";
        }

        private void Star5th_Click(object sender, EventArgs e)
        {
            Star1st.Image = Resources.Star_Bright;
            Star2nd.Image = Resources.Star_Bright;
            Star3rd.Image = Resources.Star_Bright;
            Star4th.Image = Resources.Star_Bright;
            Star5th.Image = Resources.Star_Bright;

            rate_Label.Text = "5";
        }
    }
}
