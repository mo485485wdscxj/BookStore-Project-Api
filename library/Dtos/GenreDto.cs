using library_.Models;

namespace library_.Dtos
{
    public class GenreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<int> Books { get; set; }
    }
}
