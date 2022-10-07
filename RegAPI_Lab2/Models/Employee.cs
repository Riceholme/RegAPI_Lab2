using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace RegAPI_Lab2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter First Name!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter Last Name!")]
        public string LastName { get; set; }
        public string FullName => FirstName +" "+ LastName;
        [Required(ErrorMessage = "Please enter Gender!")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter Email!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter Phone Number!")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter Adress!")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Please enter Gender!")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }
        [AllowNull]
        public Department? Department { get; set; }
        [Required(ErrorMessage = "Please enter DepartmentId!")]
        public int DepartmentId { get; set; }
    }
}
