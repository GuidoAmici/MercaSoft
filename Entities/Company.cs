namespace Entities
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; } = "No company name";
        public bool IsClient { get; set; }
        public bool IsSupplier { get; set; }

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