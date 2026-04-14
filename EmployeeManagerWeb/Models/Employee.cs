namespace EmployeeManagerWeb.Models
{
    public enum RoleType
    {
        QuanLy,
        PhaChe,
        PhucVu,
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
