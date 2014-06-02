using System;
using System.Collections.Generic;
using System.Drawing;

using MonoTouch.UIKit;
using Logic;

namespace JustCook
{
	public class TestViewController : UIViewController
	{
		private UIScrollView _scroll;
		private List<UIImageView> _images;

		public TestViewController()
		{
			_images = new List<UIImageView> ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad();

			_scroll = new UIScrollView ();
			_scroll.BackgroundColor = UIColor.Cyan;

			View.AddSubview(_scroll);
			View.BackgroundColor = UIColor.White;

			LoadImages();
		}

		private void LoadImages()
		{
			_images.Clear();
			List<UIImage> imgs = new List<UIImage> ();
			RowContainer rc = new RowContainer();

			foreach (var path in ImgPaths())
			{
				UIImage img = UIImage.FromFile(path);
				imgs.Add(img);

				rc.Add(DrawingHelper.ConvertFrom(img.Size));
			}

			//rc.Height = 100f;
			rc.Width = 320f;
			PointF location = new PointF ();
			for(int i = 0; i < imgs.Count; i++)
			{
				UIImageView imgView = new UIImageView (imgs[i]);
				_images.Add(imgView);
				_scroll.AddSubview(imgView);

				var size = rc.Elements [i];
				imgView.Frame = new RectangleF (location, DrawingHelper.ConvertFrom(size));

				location.X += size.Width;
			}

			_scroll.Frame = new RectangleF(0f, 0f, 320f, 200f);
			_scroll.ContentSize = new SizeF (rc.Width, rc.Height);
		}

		public override void ViewWillLayoutSubviews ()
		{
			base.ViewWillLayoutSubviews();

		}

		private IEnumerable<string> ImgPaths()
		{
			yield return "TestImages/_7E5pLvSWQc.jpg";
			yield return "TestImages/7TzTt64uC5I.jpg";
			yield return "TestImages/8kRuiq5bjfM.jpg";
			yield return "TestImages/Co1Z6PbkZ40.jpg";
			yield return "TestImages/KXX3VUnNsq8.jpg";
			yield return "TestImages/m-mfbOYoMao.jpg";
			yield return "TestImages/V-DjgYm2dm0.jpg";
		}
	}
}

