using System;
using Logic.Drawing;

namespace Logic
{
	/// <summary>
	/// Основная задача RowContainer – выравнивание элементов по высоте
	/// </summary>
	public class RowContainer : ImageContainer
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
				// После того как все элементы одной высоты их можно просто отмасштабировать
				if (!IsInitialized)
					Height = 100f;

				float ratio = value / _width;
				_width = value;
				_height *= ratio;

				for (int i = 0; i < Elements.Count; i++)
				{
					SizeF size = Elements[i];
					var scaledSize = new SizeF(ratio * size.Width, _height);
					Elements[i] = scaledSize;
				}
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
				_height = value;
				_width = 0;

				// scale here
				for (int i = 0; i < Elements.Count; i++)
				{
					SizeF size = Elements[i];
					float ratio = _height / size.Height;
					var scaledSize = new SizeF(ratio * size.Width, _height);

					Elements[i] = scaledSize;
					_width += scaledSize.Width;
				}

				IsInitialized = true;
			}
		}

		public RowContainer()
		{
		}
	}
}

