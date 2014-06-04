﻿using System;
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
			RowContainer rc = new RowContainer();
			ColumnContainer cc = new ColumnContainer ();

			foreach (var path in ImgPaths())
			{
				UIImage img = UIImage.FromFile(path);
				imgs.Add(img);

				var size = new DrawSizeF(img.Size);
				rc.Add(size);
				cc.Add(size);
			}

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

