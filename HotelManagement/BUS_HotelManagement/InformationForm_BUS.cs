using DTO_HotelManagement;
using DAO_HotelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class InformationForm_BUS
    {
        public static bool insertInformationForm(Infomation_Form_DTO inforForm, Supply_Form_DTO sup)
        {
            return InformationForm_DAO.Instance.insertInformationForm(inforForm, sup);
        }    
    }
}
