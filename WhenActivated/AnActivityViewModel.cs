using ReactiveUI;
using System;

namespace WhenActivated
{
	public class AnActivityViewModel : SubScreenViewModel
	{
		private readonly ReactiveCommand<object> goBack;

		public AnActivityViewModel(IScreen hostScreen)
			: base(hostScreen)
		{
			goBack = ReactiveCommand.Create();

			this.WhenActivated(d =>
			{
				d(goBack.Subscribe(_ =>
				{
					hostScreen.Router.NavigateBack.Execute(null);
				}));
			});
		}

		public override string UrlPathSegment
		{
			get { return "anActivity"; }
		}

		public ReactiveCommand<object> GoBack
		{
			get { return goBack; }
		}
	}
}
