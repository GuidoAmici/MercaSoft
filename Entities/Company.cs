namespace Entities
{
    public class Company
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; } = "No company name";

        public Company() { }

        public override string ToString()
        {
            return Name;
        }
    }
}