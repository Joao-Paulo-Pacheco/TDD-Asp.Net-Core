using System.ComponentModel.DataAnnotations;

namespace TesteUnitario.Users
{
    public class User
    {
        public User()
        {

        }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        [Key]
        public string  UserName { get; set; }
        public string  Password { get; set; }
    }
}
