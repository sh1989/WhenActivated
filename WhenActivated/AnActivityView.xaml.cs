using ReactiveUI;
using System.Windows;

namespace WhenActivated
{
	public partial class AnActivityView : IViewFor<AnActivityViewModel>
	{
		public AnActivityView()
		{
			InitializeComponent();

			this.WhenActivated(_ =>
			{
				DataContext = ViewModel;
			});
		}

		public AnActivityViewModel ViewModel
		{
			get { return (AnActivityViewModel)GetValue(ViewModelProperty); }
			set { SetValue(ViewModelProperty, value); }
		}

		public static readonly DependencyProperty ViewModelProperty =
			DependencyProperty.Register("ViewModel", typeof(AnActivityViewModel), typeof(AnActivityView), new PropertyMetadata(null));

		object IViewFor.ViewModel
		{
			get { return ViewModel; }
			set { ViewModel = (AnActivityViewModel)value; }
		}
	}
}