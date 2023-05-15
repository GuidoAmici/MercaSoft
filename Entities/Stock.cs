namespace Entities
{
    public class Stock
    {
        public int Available { get; set; }
        public int InProductionQueue { get; set; }
        public int Oversold { get; set; }
        public int ReservedAsSupply { get; set; }
        public int MissingSupplies { get; set; }

        public Stock()
        {
            Available = 0;
            InProductionQueue = 0;
            MissingSupplies = 0;
            ReservedAsSupply = 0;
            Oversold = 0;
        }

        public override string ToString()
        {
            return Available.ToString();
        }

    }
}
