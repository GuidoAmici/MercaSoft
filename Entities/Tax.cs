using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tax
    {
        public string? Name { get; internal set; } = "No tax name";
        public string? Description { get; internal set; } = "No description";
        public float Percentage { get; internal set; }

        public override string ToString()
        {
            return Name + " (" + Percentage.ToString() + ")";
        }
    }
}
