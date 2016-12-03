namespace Snippr.Domain.Models
{
    public class Comment
    {
        public Author Author { get; set; }
        public int Upvotes { get; set; }
        public string Content { get; set; }
    }
}
