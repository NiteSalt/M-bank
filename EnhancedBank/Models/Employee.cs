namespace EnhancedBank.Models;

public class Employee
{
	public uint Id { get; set; }
	public string Name { get; set; }
	public string LastName { get; set; }
	public string Password { get; set; }
	public bool HasAdministrativeRights { get; set; }
}