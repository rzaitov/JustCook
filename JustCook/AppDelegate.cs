using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using VK;

namespace JustCook
{
	[Register("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		private UIWindow window;
		private VkDelegate _vkDelegate;
		VKApi _vkApi;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			_vkDelegate = new VkDelegate ();
			VKSdk.InitializeWithDelegate(_vkDelegate, "4370991");

			_vkApi = new VKApi ();
			var vkapi = new VkNet.VkApi ();
			int totalCount;

			var posts = vkapi.Wall.Get(-32509740, out totalCount, 10, 0);

			window.MakeKeyAndVisible();

			return true;
		}
	}
}

