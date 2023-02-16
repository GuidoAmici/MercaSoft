using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvoiceItem
    {
        public int ID { get; internal set; }
        public Item Item { get; internal set; }
        public int Quantity { get; internal set; }
        public float SubtotalWithoutTaxes { get; internal set; }
        public List<Tax> TaxesList { get; internal set; }
        public float Taxes { get; internal set; }
        public float SubtotalWithTaxes { get; internal set; }

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

            SubtotalWithTaxes = SubtotalWithoutTaxes+Taxes;
        }
    }
}
