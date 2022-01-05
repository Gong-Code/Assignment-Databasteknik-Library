using System.ComponentModel;

namespace Library_inlämningsuppgift.Models
{
    public class Author
    {
        public int Id { get; set; }

        [DisplayName("Author")]
        public string AuthorName { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
