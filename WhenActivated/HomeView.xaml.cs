using ReactiveUI;
using System.Windows;

namespace WhenActivated
{
	public partial class HomeView : IViewFor<HomeViewModel>
    {
        public HomeView()
        {
            InitializeComponent();

            this.WhenActivated(_ =>
            {
                DataContext = ViewModel;
            });
        }

        public HomeViewModel ViewModel
        {
            get { return (HomeViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(HomeViewModel), typeof(HomeView), new PropertyMetadata(null));

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (HomeViewModel)value; }
        }
	}
}
