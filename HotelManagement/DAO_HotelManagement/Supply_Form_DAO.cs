﻿using DTO_HotelManagement;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Supply_Form_DAO
    {
        private static Supply_Form_DAO instance;
        public static Supply_Form_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Supply_Form_DAO();
                return Supply_Form_DAO.instance;
            }
            private set { Supply_Form_DAO.instance = value; }
        }
        private Supply_Form_DAO() { }
        public string getRegisterName(Supply_Form_DTO CusName)
        {
            string query = "SELECT * FROM SUPPLY_FORM WHERE REGISTERED_NAME = N'" + CusName.RegisteredName + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            string result;
            foreach(DataRow row in dt.Rows)
            {
                result = row["GROUP_NAME"].ToString() + '\n' + row["GROUP_SIZE"].ToString();
                return result;
            }
            return null;
        }
        
        public bool insertSupplyForm(Supply_Form_DTO supInfo)
        {
            string query = "EXEC USP_AddSUPLLYFORM @ID_INFORMATION_FORM = '" + supInfo.IdInformation + "', @GROUP_NAME = N'" + supInfo.GroupName + "', @REGISTERED_NAME = N'" + supInfo.RegisteredName + "', @GROUP_SIZE = N'" + supInfo.GroupSize + "'";
            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index <= 0) { return false; }
            return true;
        }
    }
}
