namespace Entities
{
    public class Item
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public float Price { get; internal set; }

        public Item() { }

        public override string ToString()
        {
            return Name;
        }
    }
}
