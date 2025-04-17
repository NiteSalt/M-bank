using System.Windows;

namespace EnhancedBank.View;

public partial class UserDataWindow : Window
{
	public UserDataWindow()
	{
		InitializeComponent();
	}

	private void OnLeaveButtonClick(object sender, RoutedEventArgs e)
	{
		Close();
	}
}