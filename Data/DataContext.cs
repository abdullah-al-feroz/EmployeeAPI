using EmployeeAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeSkill> EmployeesSkills { get; set;}
        public DbSet<EmployeeSalary> EmployeesSalary { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne<Department>(s => s.department)
                .WithOne(g => g.Employee)
                .HasForeignKey<Department>(s => s.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasOne<EmployeeSalary>(s => s.EmployeeSalary)
                .WithOne(g => g.Employee)
                .HasForeignKey<EmployeeSalary>(s => s.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany<EmployeeSkill>(s => s.EmployeeSkill)
                .WithOne(g => g.Employee)
                .HasForeignKey(s => s.EmployeeId);

        }
    }
}
