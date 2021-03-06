﻿using System;
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
		private UIWindow window;
		private VkService _vkService;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);


			_vkService = new VkService ();

			var param = new WallRequestParam {
				OwnerId = -32509740,
				Filter = FilterType.All,
			};

			_vkService.GetWall(param).ContinueWith(rT => {
				IList<Post> result = rT.Result;

				int i = 25;
			});

			window.MakeKeyAndVisible();

			return true;
		}
	}
}

