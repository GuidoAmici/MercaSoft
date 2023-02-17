namespace Entities
{
    public class Invoice
    {
        public int ID { get; internal set; }
        public DateTime Date { get; internal set; }
        public string? InvoiceNumber { get; internal set; }
        public Company Company { get; set; }
        public List<InvoiceItem> Items { get; internal set; }
        public float SubtotalWithoutTaxes { get; internal set; }
        public float Taxes { get; internal set; }
        public float Total { get; internal set; }

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
            return "Factura Nº" + ID + " - " + Company.ToString();
        }
    }
}
