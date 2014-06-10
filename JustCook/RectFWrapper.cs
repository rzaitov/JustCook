using System;
using System.Drawing;

using Logic;

namespace JustCook
{
	public class RectFWrapper: IScalableBox
	{
		private RectangleF _rect;

		public float X
		{
			get { return _rect.X; }
			set { _rect.X = value; }
		}

		public float Y
		{
			get { return _rect.Y; }
			set { _rect.Y = value; }
		}

		public float Width
		{
			get { return _rect.Width; }
			set {
				float ratio = value / _rect.Width;

				_rect.Width = value;
				_rect.Height *= ratio;
			}
		}

		public float Height
		{
			get { return _rect.Height; }
			set {
				float ratio = value / _rect.Height;

				_rect.Height = value;
				_rect.Width *= ratio;
			}
		}

		public RectFWrapper(RectangleF rect)
		{
			_rect = rect;
		}

		public static RectangleF Convert(IScalableBox box)
		{
			return new RectangleF (box.X, box.Y, box.Width, box.Height);
		}
	}
}