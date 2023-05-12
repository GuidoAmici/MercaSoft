namespace Entities
{
    public class Stock
    {
        public int AvaiableQuantity { get; set; }
        public int ReservedQuantity { get; set; }
        public int InProductionQuantity { get; set; }
        public int InvoicedQuantity { get; set; }

        public Stock() { }

    }
}
