using System;
using System.Collections.Generic;
using System.Drawing;

using MonoTouch.UIKit;
using Logic;

namespace JustCook
{
	public class TestViewController : UIViewController
	{
		private UIScrollView _hScroll;
		private UIScrollView _vScroll;
		private List<UIImageView> _images;

		public TestViewController()
		{
			_images = new List<UIImageView> ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad();

			_hScroll = new UIScrollView ();
			_vScroll = new UIScrollView ();

			_hScroll.BackgroundColor = UIColor.Cyan;
			_vScroll.BackgroundColor = UIColor.Cyan;

//			View.AddSubview(_hScroll);
			View.AddSubview(_vScroll);
			View.BackgroundColor = UIColor.White;

			LoadImages();
		}

		private void LoadImages()
		{
			_images.Clear();
			List<UIImage> imgs = new List<UIImage> ();

			foreach (var path in ImgPaths())
			{
				UIImage img = UIImage.FromFile(path);
				imgs.Add(img);
			}

			/*
			//rc.Height = 100f;
			rc.Width = 320f;
			cc.Height = 450f;
			PointF rcLocation = PointF.Empty;
			PointF ccLocation = PointF.Empty;
			for(int i = 0; i < imgs.Count; i++)
			{
				UIImageView imgv1 = new UIImageView (imgs[i]);
				UIImageView imgv2 = new UIImageView (imgs[i]);

				_hScroll.AddSubview(imgv1);
				_vScroll.AddSubview(imgv2);

				var size1 = rc.Elements [i];
				var size2 = cc.Elements [i];

				imgv1.Frame = new RectangleF (rcLocation, DrawSizeF.Convert(size1));
				imgv2.Frame = new RectangleF (ccLocation, DrawSizeF.Convert(size2));

				rcLocation.X += size1.Width;
				ccLocation.Y += size2.Height;
			}

			_hScroll.Frame = new RectangleF(0f, 0f, 320f, 200f);
			_vScroll.Frame = new RectangleF (0f, 0f, 200f, 450f);

			_hScroll.ContentSize = new SizeF (rc.Width, rc.Height);
			_vScroll.ContentSize = new SizeF (cc.Width, cc.Height);
			*/

			var box1 = new RectFWrapper(new RectangleF(PointF.Empty, imgs[0].Size));
			var box2 = new RectFWrapper(new RectangleF(PointF.Empty, imgs[1].Size));
			var box3 = new RectFWrapper(new RectangleF(PointF.Empty, imgs[2].Size));
			var box4 = new RectFWrapper(new RectangleF(PointF.Empty, imgs[3].Size));

			ImageContainer ic = new TwoItemsPerLineTwoLines(box1, box2, box3, box4);

//			ic.Height = 250;
			ic.Width = 300f;

			UIImageView imgv1 = new UIImageView (imgs[0]);
			imgv1.Frame = RectFWrapper.Convert(box1);

			UIImageView imgv2 = new UIImageView (imgs[1]);
			imgv2.Frame = RectFWrapper.Convert(box2);

			UIImageView imgv3 = new UIImageView (imgs[2]);
			imgv3.Frame = RectFWrapper.Convert(box3);

			UIImageView imgv4 = new UIImageView (imgs[3]);
			imgv4.Frame = RectFWrapper.Convert(box4);


			View.AddSubview(imgv1);
			View.AddSubview(imgv2);
			View.AddSubview(imgv3);
			View.AddSubview(imgv4);
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

