using System.Windows;
using EnhancedBank.Model;

namespace EnhancedBank.View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
		DataContext = new MainWindowModel();
	}

	private void OnClientsButtonClick(object sender, RoutedEventArgs e)
	{
		UserDataWindow userDataWindow = new();
		Visibility = Visibility.Hidden;
		userDataWindow.ShowDialog();
		Visibility = Visibility.Visible;
	}
	
	private void OnEmployeesButtonClick(object sender, RoutedEventArgs e)
	{
		AuthorizationWindow authWindow = new(() => new EmployeeWindow());
		Visibility = Visibility.Hidden;
		authWindow.ShowDialog();
		Visibility = Visibility.Visible;
	}
	
	private void OnAdministratorButtonClick(object sender, RoutedEventArgs e)
	{
		AuthorizationWindow authWindow = new(() => new AdminWindow());
		Visibility = Visibility.Hidden;
		authWindow.ShowDialog();
		Visibility = Visibility.Visible;
	}
	
	private void OnExitButtonClick(object sender, RoutedEventArgs e)
	{
		App.Current.Shutdown();
	}
}