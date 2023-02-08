namespace Entities
{
    public class Item
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public float? SalePrice { get; internal set; }
        public Category? Category { get; internal set; }
        public bool IsForSale { get; internal set; }
        public string? Description { get; internal set; }
        public string? CodeName { get; internal set; }
        public int? BarCode { get; internal set; }

        public Item() { }

        public override string ToString()
        {
            return Name + " (" + CodeName + ")";
        }
    }
}
