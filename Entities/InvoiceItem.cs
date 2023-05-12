namespace Entities
{
    public class InvoiceItem
    {
        public int ID { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public float SubtotalWithoutTaxes { get; set; }
        public List<Tax> TaxesList { get; set; }
        public float Taxes { get; set; }
        public float SubtotalWithTaxes { get; set; }

        public InvoiceItem(int id, Item item, int quantity, List<Tax> taxesList)
        {
            ID = id;
            Item = item;
            Quantity = quantity;
            TaxesList = taxesList;

            Recalculate();
        }

        public void Recalculate()
        {
            SubtotalWithoutTaxes = (float)Item.Price * Quantity;

            Taxes = 0;
            foreach (Tax tax in TaxesList)
            {
                Taxes += SubtotalWithoutTaxes * tax.Percentage;
            }

            SubtotalWithTaxes = SubtotalWithoutTaxes + Taxes;
        }
    }
}
