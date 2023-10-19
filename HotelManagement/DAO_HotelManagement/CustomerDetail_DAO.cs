using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class CustomerDetail_DAO
    {
        public DataTable getCustomerDetai()
        {
            DataProvider dp = new DataProvider();
            string query = "exec usp_getCustomerDetail";
            return dp.ExecuteQuery(query);
        }
    }
}
