namespace RegAPI_Lab2.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Enum Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
