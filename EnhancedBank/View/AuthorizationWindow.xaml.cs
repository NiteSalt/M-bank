using System.Runtime.Intrinsics.Arm;
using System.Windows;
using EnhancedBank.Models;
using Microsoft.EntityFrameworkCore;

namespace EnhancedBank.View;

public partial class AuthorizationWindow : Window
{
	private readonly Func<Window> _windowFactory;
	private readonly bool _requireAdministrator;

	public AuthorizationWindow(Func<Window> windowFactory, bool requireAdministrator = false)
	{
		_windowFactory = windowFactory;
		_requireAdministrator = requireAdministrator;
		InitializeComponent();
	}

	private void OnLeaveButtonClick(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void OnLoginButtonClick(object sender, RoutedEventArgs e)
	{
		string login = usernameBox.Text;
		string password = passwordBox.Text;

		Employee? employee = App.Current.Db.Employees
			.Where(u => u.Name == login)
			.FirstOrDefault(u => u.Password == password);
		
		if (employee is not null)
		{
			if (!employee.HasAdministrativeRights && _requireAdministrator)
			{
				MessageBox.Show("У пользователя нету прав администратора");
				return;
			}
			
			Window window = _windowFactory();

			Hide();
			window.ShowDialog();
			Close();
			return;
		}

		MessageBox.Show("Неправильное имя пользователя или пароль");
	}
}