using System;

using VK;
using MonoTouch.UIKit;

namespace JustCook
{
	public class VkDelegate : VKSdkDelegate
	{
		public VkDelegate()
		{
		}

		public virtual void SdkDidAcceptUserToken (VKAccessToken token)
		{
		}

		public virtual void SdkDidReceiveNewToken (VKAccessToken newToken)
		{
		}

		public virtual void SdkNeedCaptchaEnter (VKError captchaError)
		{
		}

		public virtual void SdkShouldPresentViewController (UIViewController controller)
		{
		}

		public virtual void SdkTokenHasExpired (VKAccessToken expiredToken)
		{
		}

		public virtual void SdkUserDeniedAccess (VKError authorizationError)
		{
		}
	}
}
