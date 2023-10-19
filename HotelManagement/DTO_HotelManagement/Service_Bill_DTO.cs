using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HotelManagement
{
    public class Service_Bill_DTO
    {
        private string idServiceBill;
        private float totalPrice;
        private string usedDate;
        private float discount;
        private string idServiceForm;
        private string idBill;
        private string customer;
        private string status;
        private int subtotal_price;
        public Service_Bill_DTO() { }

        public string IdServiceBill { get => idServiceBill; set => idServiceBill = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string UsedDate { get => usedDate; set => usedDate = value; }
        public float Discount { get => discount; set => discount = value; }
        public string IdServiceForm { get => idServiceForm; set => idServiceForm = value; }
        public string IdBill { get => idBill; set => idBill = value; }
        public string Customer { get => customer; set => customer = value; }
        public string Status { get => status; set => status = value; }
        public int Subtotal_price { get => subtotal_price; set => subtotal_price = value; }

        public Service_Bill_DTO(string idServiceBill, float totalPrice, string usedDate, float discount, string idServiceForm, string idBill, string customer)
        {
            this.IdServiceBill = idServiceBill;
            this.TotalPrice = totalPrice;
            this.UsedDate = usedDate;
            this.Discount = discount;
            this.IdServiceForm = idServiceForm;
            this.IdBill = idBill;
            this.Customer = customer;

        }
        public Service_Bill_DTO(string idServiceBill, float totalPrice, string usedDate, float discount, string idServiceForm, string idBill, string customer, string status, int subtotal_price)
        {
            this.IdServiceBill = idServiceBill;
            this.TotalPrice = totalPrice;
            this.UsedDate = usedDate;
            this.Discount = discount;
            this.IdServiceForm = idServiceForm;
            this.IdBill = idBill;
            this.Customer = customer;
            this.Status = status;
            this.subtotal_price = subtotal_price;
            this.Subtotal_price = subtotal_price;
        }
    }
}