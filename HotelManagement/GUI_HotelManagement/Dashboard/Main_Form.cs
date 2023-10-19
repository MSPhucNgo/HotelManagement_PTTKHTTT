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

namespace GUI_HotelManagement.Dashboard
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            setMainForm();
        }
        public void setMainForm()
        {
            //Room
            string roominfo = Room_BUS.amountRoomInfo();
            string room2P = roominfo.Split("\n")[0];
            string room4P = roominfo.Split("\n")[1];
            string room6P = roominfo.Split("\n")[2];
            string room8P = roominfo.Split("\n")[3];
            Amount_room_Label.Text = (int.Parse(room2P) + int.Parse(room4P) + int.Parse(room6P) + int.Parse(room8P)).ToString();
            Line_Room_Label.Text = "Phòng 2 người : " + room2P + "\n" +
                                    "Phòng 4 người : " + room4P + "\n" +
                                    "Phòng 6 người : " + room6P + "\n" +
                                    "Phòng 8 người : " + room8P + "\n";

            //Emp
            string empinfo = Employee_BUS.amountEmpInfo();
            string LT = empinfo.Split("\n")[0];
            string Bellman = empinfo.Split("\n")[1];
            string DV = empinfo.Split("\n")[2];
            string QLVT = empinfo.Split("\n")[3];
            Amount_Emp_Label.Text = (int.Parse(LT) + int.Parse(Bellman) + int.Parse(DV) + int.Parse(QLVT)).ToString();
            Line_Emp_Label.Text = "Lễ tân : " + LT + "\n" +
                                    "Nhân viên quản lí vật tư : " + QLVT + "\n" +
                                    "Nhân viên dịch vụ: " + DV + "\n" +
                                    "Nhân viên Bellman : " + Bellman + "\n";
            //Service
            string serviceinfo = HotelService_BUS.amountServiceInfo();
            string DVHC = serviceinfo.Split("\n")[0];
            string DVKD = serviceinfo.Split("\n")[1];

            Amount_Service_Label.Text = (int.Parse(DVKD) + int.Parse(DVHC)).ToString();
            Line_Service_Label.Text = "Dịch vụ hậu cần : " + DVHC + "\n" +
                                        "Dịch vụ kinh doanh : " + DVKD + "\n";
        }
    }
}
