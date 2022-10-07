using Microsoft.EntityFrameworkCore;

namespace RegAPI_Lab2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(new Department
            { Id = 1, Name = "Economy", Description = "We like numbers and profit" });

            modelBuilder.Entity<Department>().HasData(new Department
            { Id = 2, Name = "IT", Description = "System development and digitization" });

            modelBuilder.Entity<Department>().HasData(new Department
            { Id = 3, Name = "Marketing", Description = "Markets our company and products" });

            modelBuilder.Entity<Department>().HasData(new Department
            { Id = 4, Name = "Sales", Description = "We sold our soul to sell" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                FirstName = "Kalle",
                LastName = "Anka",
                Gender = "Man",
                Email = "kalle@anka.se",
                PhoneNumber = "0706655221",
                Adress = "fågelvägen 4",
                Salary = 30000M,
                DepartmentId = 1
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 2,
                FirstName = "Knatte",
                LastName = "Anka",
                Gender = "Man",
                Email = "knatte@anka.se",
                PhoneNumber = "0703343123",
                Adress = "fjädergatan 3",
                Salary = 30000M,
                DepartmentId = 2
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 3,
                FirstName = "Tjatte",
                LastName = "Anka",
                Gender = "Man",
                Email = "tjatte@anka.se",
                PhoneNumber = "0702122569",
                Adress = "näbbvägen 34",
                Salary = 30000M,
                DepartmentId = 3
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 4,
                FirstName = "Fnatte",
                LastName = "Anka",
                Gender = "Man",
                Email = "fnatte@anka.se",
                PhoneNumber = "07032323223",
                Adress = "luftgatan 40",
                Salary = 30000M,
                DepartmentId = 4
            });
        }
    }
}
