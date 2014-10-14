using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Logic;
using Logic.Vk;

namespace JustCook
{
	[Register("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		private VkService _vkService;

		private TestViewController _controller;

		public override UIWindow Window { get; set; }

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			/*
			_vkService = new VkService ();

			var param = new WallRequestParam {
				OwnerId = -32509740,
				Filter = FilterType.All,
			};

			_vkService.GetWall(param).ContinueWith(rT => {
				IList<Post> result = rT.Result;

				int i = 25;
			});
			*/

			/*
			_controller = new TestViewController ();
			window.RootViewController = _controller;

			window.MakeKeyAndVisible();
			*/

			return true;
		}
	}
}

