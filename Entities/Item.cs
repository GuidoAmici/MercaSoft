namespace Entities
{
    public class Item
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public bool IsForSale { get; internal set; }
        public float Price { get; internal set; }
        public int Stock { get; internal set; }
        public Category? Category { get; internal set; }
        public string? Description { get; internal set; }
        public string? CodeName { get; internal set; }
        public int? BarCode { get; internal set; }

        public Item(int id, string name, bool isforsale, float price,
            Category category, string description, string codename, int barcode)
        {
            ID = id;
            Name = name;
            Price = price;
            IsForSale = isforsale;
            Category = category;
            Description = description;
            CodeName = codename;
            BarCode = barcode;
        }

        public override string ToString()
        {
            return Name + " (" + CodeName + ")";
        }
    }
}
