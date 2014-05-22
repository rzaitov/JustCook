using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Logic;

namespace JustCook
{
	[Register("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		private UIWindow window;
//		private VkDelegate _vkDelegate;
		private VkService _vkService;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);


			_vkService = new VkService ();
			_vkService.GetWall().ContinueWith(rT => {
				IList<Post> result = rT.Result;

				int i = 25;
			});

			window.MakeKeyAndVisible();

			return true;
		}
	}
}

