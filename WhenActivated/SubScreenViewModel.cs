using ReactiveUI;

namespace WhenActivated
{
	public abstract class SubScreenViewModel : ReactiveObject, IRoutableViewModel, ISupportsActivation
	{
		private readonly IScreen hostScreen;
		private readonly ViewModelActivator activator;

		protected SubScreenViewModel(IScreen hostScreen)
		{
			this.hostScreen = hostScreen;
			activator = new ViewModelActivator();
		}

		public IScreen HostScreen
		{
			get { return hostScreen; }
		}

		public ViewModelActivator Activator
		{
			get { return activator; }
		}

		public abstract string UrlPathSegment { get; }
	}
}
