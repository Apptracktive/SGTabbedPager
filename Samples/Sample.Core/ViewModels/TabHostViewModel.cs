using System;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using MvvmCross.Platform;

namespace Sample.Core.ViewModels
{
	public class TabHostViewModel : BaseViewModel
	{
		public void Init()
		{
			var viewModelLoader = Mvx.Resolve<IMvxViewModelLoader> ();
			TabsVM = new List<IMvxViewModel> {
				viewModelLoader.LoadViewModel(new MvxViewModelRequest<FirstTabViewModel>(null, null, null), null),
				viewModelLoader.LoadViewModel(new MvxViewModelRequest<SecondTabViewModel>(null, null, null), null),
				viewModelLoader.LoadViewModel(new MvxViewModelRequest<ThirdTabViewModel>(null, null, null), null)
			};
		}

		private List<IMvxViewModel> _tabsVM;
		public List<IMvxViewModel> TabsVM {
			get { return _tabsVM; }
			set { SetProperty (ref _tabsVM, value); }
		}
	}
}

