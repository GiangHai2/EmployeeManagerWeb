using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerWeb.Models
{
    public enum RoleType
    {
        [Display(Name = "Quản lý")]
        Manager = 0,

        [Display(Name = "Thu ngân")]
        Cashier = 1,

        [Display(Name = "Pha chế")]
        Barista = 2,

        [Display(Name = "Phục vụ")]
        Waiter = 3
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public RoleType Role { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
