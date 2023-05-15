namespace Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        internal string Password { get; set; }
        public string Email { get; set; }

        public User()
        {
            ID = -1;
            Username = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
        }

        public User(int id, string username, string password, string email)
        {
            ID = id;
            Username = username;
            Password = password;
            Email = email;
        }

        public override string ToString()
        {
            if (ID == 0) return "Empty user";
            else return Username;
        }
    }
}
