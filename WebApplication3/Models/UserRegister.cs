namespace WebApplication3.Models
{
    public class UserRegister
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    public class UserCollection
    {
        public List<UserRegister> collection { get; set; }
        public UserCollection()
        {
            collection = new List<UserRegister>();
        }
    }
}
