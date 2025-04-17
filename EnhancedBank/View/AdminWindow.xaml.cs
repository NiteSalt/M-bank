using System.Windows;

namespace EnhancedBank.View;

public partial class AdminWindow : Window
{
	public AdminWindow()
	{
		InitializeComponent();
	}

	private void OnLeaveButtonClick(object sender, RoutedEventArgs e)
	{
		Close();
	}
}