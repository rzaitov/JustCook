using System;
using System.Drawing;

using Logic;

namespace JustCook
{
	public class RectFWrapper: IScalableBox
	{
		private SizeF _size;

		public float Width
		{
			get { return _size.Width; }
			set {
				float ratio = value / _size.Width;

				_size.Width = value;
				_size.Height *= ratio;
			}
		}

		public float Height
		{
			get { return _size.Height; }
			set {
				float ratio = value / _size.Height;

				_size.Height = value;
				_size.Width *= ratio;
			}
		}

		public RectFWrapper(SizeF size)
		{
			_size = size;
		}

		public static SizeF Convert(IScalableBox size)
		{
			return new SizeF (size.Width, size.Height);
		}
	}
}