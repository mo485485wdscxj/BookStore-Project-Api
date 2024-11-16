using library_.Models;

namespace library_.Dtos
{
    public class BookDtos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedYear { get; set; }
        public ICollection<int> authorIds { get; set; }
        public ICollection<int> genreIds { get; set; }
    }
}
