using DAO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BUS_HotelManagement
{
     public class Waiting_BUS
    {
        public static DataTable getWaiting()
        {
            return Waiting_DAO.Instance.getWaiting();
        }
    }
}
