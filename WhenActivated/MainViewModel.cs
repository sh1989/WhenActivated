using ReactiveUI;
using Splat;

namespace WhenActivated
{
	public class MainViewModel : IScreen
	{
		private readonly RoutingState router;

		public MainViewModel(RoutingState router, IMutableDependencyResolver resolver)
		{
			this.router = router;

			resolver.RegisterConstant(this, typeof(IScreen));
			resolver.Register(() => new HomeView(), typeof (IViewFor<HomeViewModel>));
			resolver.Register(() => new AnActivityView(), typeof (IViewFor<AnActivityViewModel>));

			Router.Navigate.Execute(new HomeViewModel(this));
		}

		public RoutingState Router
		{
			get { return router; }
		}
	}
}
