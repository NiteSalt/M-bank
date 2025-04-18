using EnhancedBank.Model;
using System.Runtime.Intrinsics.Arm;
using System.Windows;

namespace EnhancedBank.View;

public partial class AuthorizationWindow : Window
{
	private readonly Func<Window> _windowFactory;

	public AuthorizationWindow(Func<Window> windowFactory)
	{
		_windowFactory = windowFactory;
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

		Employee? employee = App.Current.Db.Employees.Where(u => u.Name == login).FirstOrDefault(u => u.Password == password);

		if (employee is not null)
		{
			Window window = _windowFactory();

			Hide();
			window.ShowDialog();
			Close();
			return;
		}

		MessageBox.Show("Неправильное имя пользователя или пароль");
	}
}