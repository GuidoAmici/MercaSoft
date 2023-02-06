using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Invoice
    {
        public int ID { get; internal set; }
        public DateTime Date { get; internal set; }
        public Company Company { get; internal set; }
        public List<InvoiceItem> Items { get; internal set; }
        public float SubtotalWithoutTaxes { get; internal set; }
        public float Taxes { get; internal set; }
        public float Total { get; internal set; }

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
