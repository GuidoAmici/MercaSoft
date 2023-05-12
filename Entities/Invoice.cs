namespace Entities
{
    public class Invoice
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string? InvoiceNumber { get; set; }
        public Company Company { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public float SubtotalWithoutTaxes { get; set; }
        public float Taxes { get; set; }
        public float Total { get; set; }

        public Invoice()
        {

        }

        public Invoice(int id, DateTime date, Company company, List<InvoiceItem> items)
        {
            ID = id;
            Date = date;
            Company = company;
            Items = items;
        }

        public void Recalculate()
        {
            SubtotalWithoutTaxes = 0;
            Taxes = 0;
            foreach (InvoiceItem item in Items)
            {
                SubtotalWithoutTaxes += item.SubtotalWithoutTaxes;
                Taxes += item.Taxes;
            }
            Total = SubtotalWithoutTaxes + Taxes;
        }

        public override string ToString()
        {
            return $"Factura Nº {ID} - {Company.ToString()}";
        }
    }
}
