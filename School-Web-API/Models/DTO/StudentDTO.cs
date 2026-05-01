namespace School_Web_API.Models.DTO
{
    public class StudentDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

        public StudentDTO()
        {
        }
    }
}
