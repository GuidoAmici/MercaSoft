namespace Entities
{
    public class Company
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; } = "No company name";
        public bool IsClient { get; internal set; }
        public bool IsSupplier { get; internal set; }

        public Company(int id, string name, bool isClient, bool isSupplier)
        {
            ID = id;
            Name = name;
            IsClient = isClient;
            IsSupplier = isSupplier;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}