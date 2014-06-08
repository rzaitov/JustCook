using System;

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
					Elements[i].Width *= ratio;
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
					IScalableSizeF size = Elements[i];
					float ratio = _height / size.Height;

					size.Width *= ratio;
					size.Height = _height;

					_width += size.Width;
				}

				IsInitialized = true;
			}
		}

		protected override void TryInitDefault ()
		{
			if (IsInitialized)
				return;

			Height = 100f;
		}
	}
}

