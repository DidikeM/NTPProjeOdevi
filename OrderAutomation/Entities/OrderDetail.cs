using OrderAutomation.Entities.Dal;

namespace OrderAutomation.Entities
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal SubTax { get; set; }
        public decimal SubPrice { get; set; }
        public decimal SubWeight { get; set; }

        public OrderDetail()
        {

        }
        public void calcAll(int itemId, int quantity)
        {
            ItemID = itemId;
            Quantity = quantity;
            calcSubPrice();
            calcSubTax();
            CalcWeight();
        }

        void calcSubPrice()
        {
            ItemDal itemDal = new ItemDal();
            SubPrice = itemDal.GetByID(ItemID).Price * Quantity;
        }

        void calcSubPrice(Item item)
        {
            SubPrice =  item.Price * Quantity;
        }

        void calcSubTax()
        {
            ItemDal itemDal = new ItemDal();
            TaxDal taxDal = new TaxDal();
            SubTax = taxDal.GetByID(itemDal.GetByID(ItemID).TaxID).TaxPercent * SubPrice / 100;
        }

        void calcSubTax(Item item)
        {
            TaxDal taxDal = new TaxDal();
            SubTax =  taxDal.GetByID(item.TaxID).TaxPercent * SubPrice / 100;
        }

        void CalcWeight()
        {
            ItemDal itemDal = new ItemDal();
            SubWeight = itemDal.GetByID(ItemID).ShippingWeight * Quantity;
        }

        void CalcWeight(Item item)
        {
            SubWeight = item.ShippingWeight * Quantity;
        }
    }
}
