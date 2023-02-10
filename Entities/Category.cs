namespace Entities
{
    public class Category
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public bool IsActive { get; internal set; }

        public Category(int id, string name, bool active)
        {
            ID = id;
            Name = name;
            IsActive = active;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}