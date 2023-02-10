using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductionOrder
    {
        public int ID { get; internal set; }
        public DateTime Date { get; internal set; }
        public Item Item { get; internal set; }
        public ProductionOrder() { }
    }
}
