using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }// 0 = Sipariş alındı, 1 = Ödeme yapıldı, 2 = Ürünler teslim edildi.
        public decimal TotalTax { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalWeight { get; set; }
        //public Customer Customer { get; set; }
        //public Payment Payments { get; set; }
        //public List<OrderDetail> OrderDetails { get; set; }
        public void calcAll(List<OrderDetail> orderDetails)
        {
            CalcTotalTax(orderDetails);
            CalcTotalPrice(orderDetails);
            CalcTotalWeight(orderDetails);
        }

        void CalcTotalTax(List<OrderDetail> orderDetails)
        {
            foreach (var orderDetail in orderDetails)
            {
                TotalTax += orderDetail.SubTax;
            }
        }

        void CalcTotalPrice(List<OrderDetail> orderDetails)
        {
            foreach (var orderDetail in orderDetails)
            {
                TotalPrice += orderDetail.SubPrice;
            }
        }

        void CalcTotalWeight(List<OrderDetail> orderDetails)
        {
            foreach (var orderDetail in orderDetails)
            {
                TotalWeight += orderDetail.SubWeight;
            }
        }
    }
}
