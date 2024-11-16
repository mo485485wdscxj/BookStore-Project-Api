using System.ComponentModel.DataAnnotations;

namespace library_.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email_Address { get; set; }
        public ICollection<Book> books { get; set; }
    }
}
