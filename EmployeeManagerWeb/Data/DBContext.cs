using EmployeeManagerWeb.Models; // Đảm bảo gọi đúng namespace chứa file Employee
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagerWeb.Data
{
    // Kế thừa từ DbContext của Entity Framework
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        // Dòng này báo cho C# biết: Hãy tạo một bảng tên là Employees trong Database dựa trên class Employee
        public DbSet<Employee> Employees { get; set; }
    }
}