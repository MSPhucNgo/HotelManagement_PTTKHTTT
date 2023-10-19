using DAO_HotelManagement;
using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class Employee_BUS
    {
        public static string amountEmpInfo()
        {
            return Employee_DAO.Instance.amountEmpInfo();
        }
    }
}
