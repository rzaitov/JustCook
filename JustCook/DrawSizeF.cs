using System;
using System.Drawing;

using Logic;

namespace JustCook
{
	public class DrawSizeF: ISizeF
	{
		private SizeF _size;

		public float Width
		{
			get { return _size.Width; }
			set { _size.Width = value; }
		}

		public float Height
		{
			get { return _size.Height; }
			set { _size.Height = value; }
		}

		public DrawSizeF(SizeF size)
		{
			_size = size;
		}

		public static SizeF Convert(ISizeF size)
		{
			return new SizeF (size.Width, size.Height);
		}
	}
}