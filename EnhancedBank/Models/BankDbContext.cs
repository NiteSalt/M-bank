using Microsoft.EntityFrameworkCore;

namespace EnhancedBank.Model;

public sealed class BankDbContext : DbContext
{
	public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
	{
		Database.EnsureCreated();
	}
	
	public DbSet<Employee> Employees { get; set; }
}