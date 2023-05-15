namespace Entities
{
    public class ItemCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ItemCategory(int id, string name, bool active)
        {
            ID = id;
            Name = name;
            IsActive = active;
        }

        public ItemCategory()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}