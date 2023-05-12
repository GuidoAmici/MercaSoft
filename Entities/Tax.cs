namespace Entities
{
    public class Tax
    {
        public string? Name { get; set; } = "No tax name";
        public string? Description { get; set; } = "No description";
        public float Percentage { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Percentage})";
        }
    }
}
