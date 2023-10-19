using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO_HotelManagement
{
    public class Waiting_DAO : DataProvider
    {
        private static Waiting_DAO instance;
        public static Waiting_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Waiting_DAO();
                return Waiting_DAO.instance;
            }
            private set { Waiting_DAO.instance = value; }
        }
        public DataTable getWaiting()
        {
            DataProvider dp = new DataProvider();
            string query = "exec usp_getWaitingList";
            return dp.ExecuteQuery(query);
        }
    }
}
