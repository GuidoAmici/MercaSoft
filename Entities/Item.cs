namespace Entities
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsProducible { get; set; }
        public bool IsForSale { get; set; }
        public float Price { get; set; }
        public Stock Stock { get; set; }
        public ItemCategory? ItemCategory { get; set; }
        public string? Description { get; set; }
        public string? CodeName { get; set; }
        public int? BarCode { get; set; }
        public int? SuppliedQuantity { get; set; }
        public List<Item>? Supplies { get; set; }

        public Item(int id, string name, bool isproducible, bool isforsale, float price, Stock stock,
            ItemCategory category, string description, string codename, int barcode)
        {
            ID = id;
            Name = name;
            IsProducible = isproducible;
            IsForSale = isforsale;
            Price = price;
            Stock = stock;
            ItemCategory = category;
            Description = description;
            CodeName = codename;
            BarCode = barcode;
        }

        public Item(Item item)
        {
            ID = item.ID;
            Name = item.Name;
            IsProducible = item.IsProducible;
            IsForSale = item.IsForSale;
            Price = item.Price;
            Stock = item.Stock;
            ItemCategory = item.ItemCategory;
            Description = item.Description;
            CodeName = item.CodeName;
            BarCode = item.BarCode;
            SuppliedQuantity = item.SuppliedQuantity;
            Supplies = item.Supplies;
        }

        public Item()
        {
            ID = -1;
            Name = "Empty item";
            Stock = new();
            ItemCategory = new();
            Supplies = new List<Item>();
        }

        public override string ToString()
        {
            if (CodeName != null && CodeName != string.Empty)
                return $"{Name} ({CodeName})";
            else return Name;
        }
    }
}
