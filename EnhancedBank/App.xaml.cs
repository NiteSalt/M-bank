using System;
using System.Configuration;
using System.Data;
using System.Windows;
using EnhancedBank.Model;
using Microsoft.Extensions.DependencyInjection;

namespace EnhancedBank;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
	public new static App Current => (App)Application.Current;
	
	public IServiceProvider ServiceProvider { get; }
	
	public BankDbContext Db { get; }

	public App()
	{
		ServiceCollection sc = new();

		sc.AddSqlite<BankDbContext>("Data Source=bank.db");

		ServiceProvider = sc.BuildServiceProvider();


		Db = ServiceProvider.GetRequiredService<BankDbContext>();
	}
}