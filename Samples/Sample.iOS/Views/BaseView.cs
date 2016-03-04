using System;
using MvvmCross.iOS.Views;
using MvvmCross.Core.ViewModels;

namespace Sample.iOS.Views
{
	public abstract class BaseView<TViewModel> : MvxViewController<TViewModel> where TViewModel : class, IMvxViewModel
	{
	}
}

