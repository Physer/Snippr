namespace Snippr.Core.Models
{
    public class User : MongoModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
