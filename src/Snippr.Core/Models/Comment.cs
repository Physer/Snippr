namespace Snippr.Core.Models
{
    public class Comment : MongoModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public Author Author { get; set; }
    }
}
