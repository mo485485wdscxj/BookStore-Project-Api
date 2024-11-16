using library_.Models;

namespace library_.Dtos
{
    public class AutherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email_Address { get; set; }
        public ICollection<int> books { get; set; }
    }
}
