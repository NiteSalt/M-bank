using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace EnhancedBank.Model;

public class MainWindowModel
{
	private BankDbContext _bankDbContext;
	
	public MainWindowModel()
	{
		_bankDbContext = App.Current.ServiceProvider.GetRequiredService<BankDbContext>();
	}
}