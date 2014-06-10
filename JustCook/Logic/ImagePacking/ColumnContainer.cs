using System;
using System.Collections;

namespace Logic
{
	public class ColumnContainer : ImageContainer, IEnumerable
	{
		private float _width;
		private float _height;

		private float _x;
		public override float X
		{
			get { return _x; }
			set
			{
				_x = value;

				foreach (var box in Elements)
					box.X = _x;
			}
		}

		private float _y;
		public override float Y
		{
			get { return _y; }
			set
			{
				float dy = value - _y;
				_y = value;

				foreach (var box in Elements)
					box.Y += dy;
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
				_width = value;
				_height = 0;

				for (int i = 0; i < Elements.Count; i++)
				{
					IScalableBox box = Elements [i];
					float ratio = _width / box.Width;

					box.X = X;
					box.Y = _height;
					box.Height *= ratio;
					box.Width = _width;

					_height += box.Height;
				}

				IsInitialized = true;
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
				TryInitDefault();

				float ratio = value / _height;
				_height = value;
				_width *= ratio;

				for (int i = 0; i < Elements.Count; i++)
				{
					var box = Elements [i];
					box.Y *= ratio;
					box.Height *= ratio;
				}
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

			Width = 100f;
		}
	}
}