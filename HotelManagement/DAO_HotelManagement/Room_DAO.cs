using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using System.Data.SqlClient;

namespace DAO_HotelManagement
{
    public class Room_DAO
    {
        public DataTable getRoom()
        {
            DataProvider dp = new DataProvider();
            string query = "exec usp_getRoomList";
            return dp.ExecuteQuery(query);
        }

        private static Room_DAO instance;
        public static Room_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Room_DAO();
                return Room_DAO.instance;
            }
            private set { Room_DAO.instance = value; }
        }
        private Room_DAO() { }
        public List<string> getListRoom()
        {
            string query = "SELECT * FROM ROOM\n" +
                           "ORDER BY NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> roomList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string roomNumber = row["NAME"].ToString() + "\n";
                roomList.Add(roomNumber);
            }
            return roomList;
        }

        public List<string> getListFRoom(string floor)
        {
            string query = "SELECT * FROM ROOM\n" +
                           "WHERE NAME LIKE N'Phòng " + floor + "%'" +
                           "ORDER BY NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> roomList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string roomNumber = row["NAME"].ToString();
                roomList.Add(roomNumber);
            }
            return roomList;
        }

        public DataTable getRoomService(Room_DTO RoomName)
        {
            string query = "SELECT HS.* FROM ROOM R\n " +
                           "JOIN ROOM_SERVICE RS ON R.ID_ROOM = RS.ID_ROOM\n" +
                           "JOIN HOTEL_SERVICE HS ON HS.ID_SERVICE = RS.ID_SERVICE\n" +
                           "WHERE R.NAME = N'" + RoomName.Name + "'\n" +
                           "AND HS.STATUS = N'Khả dụng' \n" +
                           "ORDER BY NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable getRoomService_Bus(Room_DTO RoomName)
        {
            string query = "SELECT HS.* FROM ROOM R\n " +
                           "JOIN ROOM_SERVICE RS ON R.ID_ROOM = RS.ID_ROOM\n" +
                           "JOIN HOTEL_SERVICE HS ON HS.ID_SERVICE = RS.ID_SERVICE\n" +
                           "WHERE R.NAME = N'" + RoomName.Name + "'\n" +
                           "AND HS.STATUS = N'Khả dụng' \n" +
                           "AND HS.TYPE = N'Dịch vụ kinh doanh' \n" +
                           "ORDER BY NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable getRoomService_Sub(Room_DTO RoomName)
        {
            string query = "SELECT HS.* FROM ROOM R\n " +
                           "JOIN ROOM_SERVICE RS ON R.ID_ROOM = RS.ID_ROOM\n" +
                           "JOIN HOTEL_SERVICE HS ON HS.ID_SERVICE = RS.ID_SERVICE\n" +
                           "WHERE R.NAME = N'" + RoomName.Name + "'\n" +
                           "AND HS.STATUS = N'Khả dụng' \n" +
                           "AND HS.TYPE = N'Dịch vụ hậu cần' \n" +
                           "ORDER BY NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public List<string> getListItems(Room_DTO RoomInfo)
        {
            string query = "select I.NAME from ROOM R \n" +
                           "join ITEM_ROOM IR on R.ID_ROOM = IR.ID_ROOM \n" +
                           "join ITEM I on I.ID_ITEM = IR.ID_ITEM \n" +
                           "WHERE R.NAME = N'" + RoomInfo.Name + "'\n" +
                           "ORDER BY I.NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<string> listItems= new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string name = row["NAME"].ToString();
                listItems.Add(name);
            }
            return listItems;
        }
        public DataTable getRoomItems(Room_DTO RoomName)
        {
            string query = "select I.NAME, I.ITEM_FUNCTION, I.TYPE, IR.AMOUNT from ROOM R \n" +
                           "join ITEM_ROOM IR on R.ID_ROOM = IR.ID_ROOM \n" +
                           "join ITEM I on I.ID_ITEM = IR.ID_ITEM \n" +
                           "WHERE R.NAME = N'" + RoomName.Name + "'\n" +
                           "ORDER BY I.NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public string getRoomStatus(Room_DTO RoomName)
        {
            string query = "SELECT STATUS FROM ROOM \n " +
                           "WHERE NAME = N'" + RoomName.Name + "'\n";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string statusRoom;
            foreach (DataRow dr in dt.Rows)
            {
                statusRoom = dr["STATUS"].ToString();
                return statusRoom;
            }
            return null;
        }
        public string getRoomPrice(Room_DTO RoomName)
        {
            string query = "SELECT PRICE FROM ROOM \n " +
                           "WHERE NAME = N'" + RoomName.Name + "'\n";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string priceRoom;
            foreach (DataRow dr in dt.Rows)
            {
                priceRoom = dr["PRICE"].ToString();
                return priceRoom;
            }
            return null;
        }
        public List<string> getListRoom(string filterStatus, string filterType)
        {
            string query = "";
            if(filterStatus == "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "ORDER BY NAME ASC";

            }
            else if(filterStatus != "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n" +
                        "ORDER BY NAME ASC";
            }
            else if(filterStatus == "All" && filterType != "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE TYPE = N'" + filterType + "'\n" +
                        "ORDER BY NAME ASC";
            }
            else
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n" +
                        "AND TYPE = N'" + filterType + "'\n" +
                        "ORDER BY NAME ASC";
            }
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> roomList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string roomNumber = row["NAME"].ToString() + "\n";
                roomList.Add(roomNumber);
            }
            return roomList;
        }

        public List<string> getListRoomFilter_Status(string filterStatus, string filterType)
        {
            string query = "";
            if (filterStatus == "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "ORDER BY STATUS DESC";

            }
            else if (filterStatus != "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n";
            }
            else if (filterStatus == "All" && filterType != "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE TYPE = N'" + filterType + "'\n" +
                        "ORDER BY STATUS DESC";
            }
            else
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n" +
                        "AND TYPE = N'" + filterType + "'\n";
            }

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> roomList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string roomNumber = row["NAME"].ToString() + "\n" + row["STATUS"].ToString();
                roomList.Add(roomNumber);
            }
            return roomList;
        }
        public List<string> getListRoomFilter_Type(string filterStatus, string filterType)
        {
            string query = "";
            if (filterStatus == "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "ORDER BY TYPE ASC";

            }
            else if (filterStatus != "All" && filterType == "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n" +
                        "ORDER BY TYPE ASC";
            }
            else if (filterStatus == "All" && filterType != "All")
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE TYPE = N'" + filterType + "'\n";
            }
            else
            {
                query = "SELECT * FROM ROOM\n" +
                        "WHERE STATUS = N'" + filterStatus + "'\n" +
                        "AND TYPE = N'" + filterType + "'\n";
            }

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> roomList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string roomNumber = row["NAME"].ToString() + "\n" + row["TYPE"].ToString();
                roomList.Add(roomNumber);
            }
            return roomList;
        }
        public string getRoomInformation(Room_DTO RoomName)
        {
            string query = "SELECT *\n" +
                           "FROM ROOM \n" +
                           "WHERE NAME = '" + RoomName.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string idRoom;
            foreach (DataRow dr in dt.Rows)
            {
                idRoom = dr["ID_ROOM"].ToString() + "\n" + dr["TYPE"].ToString() + "\n" +
                         dr["PRICE"].ToString() + "\n" + dr["STATUS"].ToString() + "\n";
                return idRoom;
            }
            return null;
        }
        public string getCustomerRoomInformation(Room_DTO RoomName)
        {
            string query = "SELECT C.ID_CUSTOMER, C.NAME, C.GENDER, CONVERT(DATE,C.BIRTHDAY) AS BIRTHDAY, C.EMAIL, C.PHONE, C.IDENTIFY_CARD\n" +
                           "FROM ROOM R\n" +
                           "JOIN BOOKING_ROOM BR ON BR.ID_ROOM = R.ID_ROOM \n" +
                           "JOIN BOOKING_FORM BF ON BF.ID_BOOKING = BR.ID_BOOKING \n" +
                           "JOIN CUSTOMER C ON C.ID_CUSTOMER = BF.CUSTOMER \n" +
                           "WHERE R.NAME = '" + RoomName.Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string cusInfo;
            foreach (DataRow dr in dt.Rows)
            {
                cusInfo =dr["ID_CUSTOMER"].ToString() + "\n" + dr["NAME"].ToString() + "\n" + dr["GENDER"].ToString() + "\n" +
                         dr["BIRTHDAY"].ToString() + "\n" + dr["EMAIL"].ToString() + "\n" +
                         dr["PHONE"].ToString() + "\n" + dr["IDENTIFY_CARD"].ToString() + "\n";
                return cusInfo;
            }
            return null;
        }
        public bool updatePriceRoom(Room_DTO roomPrice)
        {
            string query = "UPDATE ROOM \n" +
                           "SET PRICE = " + roomPrice.Price + "\n" +
                           "WHERE NAME = N'" + roomPrice.Name + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if(index <= 0) { return false; }
            return true;
        }

        public string getRoomId(Room_DTO roomInfor)
        {
            string query = "SELECT ID_ROOM FROM ROOM \n " +
                           "WHERE NAME = N'" + roomInfor.Name + "'\n";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string idRoom;
            foreach (DataRow dr in dt.Rows)
            {
                idRoom = dr["ID_ROOM"].ToString();
                return idRoom;
            }
            return null;
        }

      /*  public List<string> getListItems(Room_DTO RoomInfo)
        {
            string query = "select I.NAME from ROOM R \n" +
                           "join ITEM_ROOM IR on R.ID_ROOM = IR.ID_ROOM \n" +
                           "join ITEM I on I.ID_ITEM = IR.ID_ITEM \n" +
                           "WHERE R.NAME = N'" + RoomInfo.Name + "'\n" +
                           "ORDER BY I.NAME ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<string> listItems = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string name = row["NAME"].ToString();
                listItems.Add(name);
            }
            return listItems;
        }*/
        public bool updateStatusRoom(Room_DTO roomName, string newStatus)
        {
            string query = "UPDATE ROOM \n" +
                           "SET STATUS = N'" + newStatus + "'\n" +
                           "WHERE NAME = N'" + roomName.Name + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index <= 0) { return false; }
            return true;
        }
      

        public string getRoomPrice2(Room_DTO Room)
        {
            string query = "SELECT PRICE FROM ROOM \n " +
                           "WHERE ID_ROOM = N'" + Room.IdRoom+ "'\n";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string price;
            foreach (DataRow dr in dt.Rows)
            {
                price = dr["PRICE"].ToString();
                return price;
            }
            return null;
        }
        public int totalRoomFee(ref List<Room_DTO> room) {
            int total = 0;
            for(int i = 0;  i <room.Count(); i++)
            {
                total = total + int.Parse(getRoomPrice2(room[i]));
            }
            return total;
        }
        public string amountRoomInfo()
        {
            string query = "SELECT \n  " +
                           "SUM(CASE WHEN TYPE = N'Phòng 2 người' THEN 1 ELSE 0 END) AS COUNT_2, \n  " +
                           "SUM(CASE WHEN TYPE = N'Phòng 4 người' THEN 1 ELSE 0 END) AS COUNT_4, \n  " +
                           "SUM(CASE WHEN TYPE = N'Phòng 6 người' THEN 1 ELSE 0 END) AS COUNT_6, \n  " +
                           "SUM(CASE WHEN TYPE = N'Phòng 8 người' THEN 1 ELSE 0 END) AS COUNT_8 \n" +
                           "FROM ROOM";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string roominfo;
            string count_2 = dt.Rows[0]["COUNT_2"].ToString();
            string count_4 = dt.Rows[0]["COUNT_4"].ToString();
            string count_6 = dt.Rows[0]["COUNT_6"].ToString();
            string count_8 = dt.Rows[0]["COUNT_8"].ToString();

            roominfo = count_2 + "\n" + count_4 + "\n" + count_6 + "\n" + count_8 + "\n";
            return roominfo;
        }
    }

}