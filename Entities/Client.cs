namespace Entities
{
    public class Client
    {
        private string Name { get; set; }
        private string LastName { get; set; }
        private int DNI { get; set; }
        private string Birth { get; set; }


        private Client()
        {
        }

        private Client(string name, string lastName, int dni, string birth)
        {
            Name = name;
            LastName = lastName;
            DNI = dni;
            Birth = birth;
        }

    }
}