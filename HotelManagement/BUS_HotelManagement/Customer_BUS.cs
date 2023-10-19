using DAO_HotelManagement;
using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class Customer_BUS
    {
        public static bool updateCustomer(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.updateCustomer(Cusinfo);
        }
        public static DataTable getUsedService(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.getUsedService(Cusinfo);
        }
        public static DataTable getCustomer()
        {
            return Customer_DAO.Instance.getCustomer();
        }
        public static string getCusID_Booking(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.getCusID_Booking(Cusinfo);
        }
        public static string getCusInfo(Customer_DTO Cusinfo)
        {
            return Customer_DAO.Instance.getCusInfo(Cusinfo);
        }
        public static string insertCustomer(Customer_DTO CusInfo, Bill_DTO inforBill, Infomation_Form_DTO info, Supply_Form_DTO sup)
        {
            return Customer_DAO.Instance.insertCustomer(CusInfo, inforBill, info, sup);
        }

        public static string getIdCheck_inCus(Customer_DTO CusInfo)
        {
            return Customer_DAO.Instance.getIdCheck_inCus(CusInfo);
        }
    }
}
