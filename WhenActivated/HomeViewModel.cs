using System;
using System.Reactive.Linq;
using ReactiveUI;

namespace WhenActivated
{
	public class HomeViewModel : SubScreenViewModel
	{
		private readonly ReactiveCommand<object> goForward;

		public HomeViewModel(IScreen hostScreen)
			: base(hostScreen)
		{
			goForward = ReactiveCommand.Create();
			
			this.WhenActivated(d =>
			{
				d(goForward.Subscribe(_ =>
				{
					var anActivityViewModel = new AnActivityViewModel(hostScreen);
					hostScreen.Router.Navigate.Execute(anActivityViewModel);
				}));
			});
		}

		public override string UrlPathSegment
		{
			get { return "home"; }
		}

		public ReactiveCommand<object> GoForward
		{
			get { return goForward; }
		}
	}
}
