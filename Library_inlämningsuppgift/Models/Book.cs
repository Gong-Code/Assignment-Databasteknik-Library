using System.ComponentModel;

namespace Library_inlämningsuppgift.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Author? Author { get; set; }

        public BookCategory Category { get; set; }

        public decimal Price  { get; set; }

        [DisplayName("Pages")]
        public int  AmountOfPage { get; set; }


    }
}
