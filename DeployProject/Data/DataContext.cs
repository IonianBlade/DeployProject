using DeployProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DeployProject.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> context) : base(context) { }
    
    public DbSet<Employee> Employees { get; set; }
    
}