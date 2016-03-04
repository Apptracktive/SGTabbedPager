using System;

using UIKit;
using Sample.Core.ViewModels;

namespace Sample.iOS.Views
{
	public partial class ThirdTabView : BaseView<ThirdTabViewModel>
	{
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


