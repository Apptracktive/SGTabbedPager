using System;
using MvvmCross.Core.ViewModels;

namespace Sample.Core.ViewModels
{
	public abstract class BaseViewModel : MvxViewModel
	{
		private string _title;
		public string Title {
			get { return _title; }
			set { SetProperty (ref _title, value); }
		}
	}
}

