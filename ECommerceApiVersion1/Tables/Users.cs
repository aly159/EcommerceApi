namespace ECommerceApiVersion1.Tables
{
    public class Users
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public int Age { get; set; }
        public bool Gender  { get; set; }
        public string? Password { get; set; }
        public string? Mail { get; set; }
        public int Role { get; set; }

    }
}
