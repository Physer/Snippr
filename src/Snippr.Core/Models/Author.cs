namespace Snippr.Core.Models
{
    public class Author : MongoModel
    {
        public string Name => User?.Username ?? "Anonymous";

        public User User { get; set; }
    }
}
