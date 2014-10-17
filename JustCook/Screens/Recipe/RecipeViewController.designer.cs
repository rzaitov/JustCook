// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace JustCook
{
	[Register ("RecipeViewController")]
	partial class RecipeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView Avatar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView Bookmark { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel GroupTitle { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView ImageContainer { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton LikesBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Text { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Time { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Avatar != null) {
				Avatar.Dispose ();
				Avatar = null;
			}
			if (Bookmark != null) {
				Bookmark.Dispose ();
				Bookmark = null;
			}
			if (GroupTitle != null) {
				GroupTitle.Dispose ();
				GroupTitle = null;
			}
			if (ImageContainer != null) {
				ImageContainer.Dispose ();
				ImageContainer = null;
			}
			if (LikesBtn != null) {
				LikesBtn.Dispose ();
				LikesBtn = null;
			}
			if (Text != null) {
				Text.Dispose ();
				Text = null;
			}
			if (Time != null) {
				Time.Dispose ();
				Time = null;
			}
		}
	}
}
