using System.Windows;

namespace EnhancedBank.View;

public partial class EmployeeWindow : Window
{
	public EmployeeWindow()
	{
		InitializeComponent();
	}
	
	private void OnLeaveButtonClick(object sender, RoutedEventArgs e)
	{
		Close();
	}
}