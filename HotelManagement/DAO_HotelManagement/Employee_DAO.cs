using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_HotelManagement
{
    public class Employee_DAO
    {
        private static Employee_DAO instance;
        public static Employee_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Employee_DAO();
                return Employee_DAO.instance;
            }
            private set { Employee_DAO.instance = value; }
        }
        private Employee_DAO() { }
        public string amountEmpInfo()
        {
            string query = "SELECT \n" +
                           "SUM(CASE WHEN ROLE = N'Nhân viên quản lý vật tư' THEN 1 ELSE 0 END) AS QLVT, \n" +
                           "SUM(CASE WHEN ROLE = N'Nhân viên dịch vụ' THEN 1 ELSE 0 END) AS DV, \n" +
                           "SUM(CASE WHEN ROLE = N'Lễ tân' THEN 1 ELSE 0 END) AS LT, \n" +
                           "SUM(CASE WHEN ROLE = N'Nhân viên Bellman' THEN 1 ELSE 0 END) AS Bellman \n" +
                           "FROM EMPLOYEE";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string empinfo;
            string QLVT = dt.Rows[0]["QLVT"].ToString();
            string DV = dt.Rows[0]["DV"].ToString();
            string LT = dt.Rows[0]["LT"].ToString();
            string Bellman = dt.Rows[0]["Bellman"].ToString();

            empinfo = LT + "\n" + Bellman + "\n" + DV + "\n" + QLVT + "\n";
            return empinfo;
        }
    }
}
