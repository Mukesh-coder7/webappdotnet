namespace WebApplication1.Models
{
    public class Student
    {
        public int STUDENTID { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Enrollmentdate { get; set; }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
