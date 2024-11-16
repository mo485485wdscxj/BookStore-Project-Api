using System.ComponentModel.DataAnnotations;

namespace library_.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedYear { get; set; }
        public ICollection<Author> authors { get; set; }
        public ICollection<Genre> genres { get; set; }



    }
}
