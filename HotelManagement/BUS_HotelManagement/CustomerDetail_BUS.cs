using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_HotelManagement;
using System.Data;
namespace BUS_HotelManagement
{
    public class CustomerDetail_BUS
    {
        CustomerDetail_DAO daoCustomerDetail = new CustomerDetail_DAO();
        public DataTable GetDataTable()
        {
            return daoCustomerDetail.getCustomerDetai();
        }
    }
}
