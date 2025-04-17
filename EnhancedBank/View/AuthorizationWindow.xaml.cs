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
		string pass = passwordBox.Text;
		string login = usernameBox.Text;

		if (login == "user" && pass == "pass2")
		{
			Window window = _windowFactory();

			Hide();
			window.ShowDialog();
			Close();
		}
	}
}