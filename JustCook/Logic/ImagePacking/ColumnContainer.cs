using System;
using Logic.Drawing;

namespace Logic
{
	public class ColumnContainer : ImageContainer
	{
		private float _width;
		private float _height;

		public override float Width
		{
			get
			{
				ThrowIfNotInitialized();
				return _width;
			}
			set
			{
				_width = value;
				_height = 0;

				for (int i = 0; i < Elements.Count; i++)
				{
					SizeF size = Elements [i];
					float ratio = _width / size.Width;
					var scaledSize = new SizeF(_width, size.Height * ratio);

					Elements [i] = scaledSize;
					_height += scaledSize.Height;
				}

				IsInitialized = true;
			}
		}

		public override float Height
		{
			get
			{
				ThrowIfNotInitialized();
				return _height;
			}
			set
			{
				if (!IsInitialized)
					Width = 100;

				float ratio = value / _height;
				_height = value;
				_width *= ratio;

				for (int i = 0; i < Elements.Count; i++)
				{
					SizeF size = Elements [i];
					var scaledSize = new SizeF(_width, size.Height * ratio);
					Elements [i] = scaledSize;
				}
			}
		}

		public ColumnContainer()
		{
		}
	}
}