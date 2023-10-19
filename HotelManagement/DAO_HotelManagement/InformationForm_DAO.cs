using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_HotelManagement;


namespace DAO_HotelManagement
{
    public class InformationForm_DAO
    {
        private static InformationForm_DAO instance;
        public static InformationForm_DAO  Instance
        {
            get
            {
                if (instance == null) instance = new InformationForm_DAO();
                return InformationForm_DAO.instance;
            }
            private set { InformationForm_DAO.instance = value; }
        }

        public bool insertInformationForm(Infomation_Form_DTO inforForm, Supply_Form_DTO sup)
        {
            string query = "DECLARE @ARRIVAL_DATE_CONVERTED DATE;\r\n SET @ARRIVAL_DATE_CONVERTED = CONVERT(DATE, '" + inforForm.ArrivalDate + "', 103);\n" +
                "EXEC USP_AddINFORMATIONFORM @TYPE = N'" + inforForm.Type + "', @ARRIVAL_DATE = @ARRIVAL_DATE_CONVERTED, @NUMBER_ROOMS = N'" + inforForm.NumberRooms +
                "', @NUMBER_STAYS = N'" + inforForm.NumberStays + "', @SPECIAL_REQUIREMENTS = N'" + inforForm.SpecialRequirements + "', @CUSTOMER = '" + inforForm.Customer + "'" +
                ", @GROUP_NAME = N'" + sup.GroupName + "', @REGISTERED_NAME = N'" + sup.RegisteredName + "', @GROUP_SIZE = " + sup.GroupSize + ";";

            int index = DataProvider.Instance.ExecuteNonQuery(query);
            if (index <= 0) { return false; }
            return true;
        }
    }
}
