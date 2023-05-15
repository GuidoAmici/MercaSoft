namespace Entities
{
    public class ProductionOrder
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public User User { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }

        public ProductionOrder()
        {
            ID = -1;
            User = new();
            Item = new();
        }

        public ProductionOrder(int id, User user, DateTime dateTime, Item item, int quantity)
        {
            ID = id;
            DateTime = dateTime;
            User = user;
            Item = item;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"O.P. Nº {ID} - {Item.Name} * {Quantity}";
        }
    }
}
