using ReactiveUI;
using Splat;
using System.Windows;

namespace WhenActivated
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new MainViewModel(new RoutingState(), Locator.CurrentMutable);
		}
	}
}
