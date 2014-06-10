using System;
using System.Collections;

namespace Logic
{
	/// <summary>
	/// Основная задача RowContainer – выравнивание элементов по высоте
	/// </summary>
	public class RowContainer : ImageContainer, IEnumerable
	{
		private float _width;
		private float _height;

		private float _x;
		public override float X
		{
			get { return _x; }
			set
			{
				float dx = value - _x;
				_x = value;

				foreach (var box in Elements)
					box.X += dx;
			}
		}

		private float _y;
		public override float Y
		{
			get { return _y; }
			set
			{
				_y = value;

				foreach (var box in Elements)
					box.Y = _y;
			}
		}

		public override float Width
		{
			get
			{
				TryInitDefault();
				return _width;
			}
			set
			{
				TryInitDefault();

				float ratio = value / _width;
				_width = value;
				_height *= ratio;

				for (int i = 0; i < Elements.Count; i++)
				{
					var box = Elements[i];
					box.X *= ratio;
					box.Width *= ratio;
				}
			}
		}

		public override float Height
		{
			get
			{
				TryInitDefault();
				return _height;
			}
			set
			{
				_height = value;
				_width = 0;

				// scale here
				for (int i = 0; i < Elements.Count; i++)
				{
					IScalableBox box = Elements[i];
					float ratio = _height / box.Height;

					box.X = _width;
					box.Y = Y;
					box.Width *= ratio;
					box.Height = _height;

					_width += box.Width;
				}

				IsInitialized = true;
			}
		}

		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}

		protected override void TryInitDefault ()
		{
			if (IsInitialized)
				return;

			Height = 100f;
		}
	}
}

