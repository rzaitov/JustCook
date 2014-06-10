using System;

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
				TryInitDefault();
				return _width;
			}
			set
			{
				_width = value;
				_height = 0;

				for (int i = 0; i < Elements.Count; i++)
				{
					IScalableBox size = Elements [i];
					float ratio = _width / size.Width;

					size.Height *= ratio;
					size.Width = _width;

					_height += size.Height;
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
					Elements[i].Height *= ratio;
			}
		}

		protected override void TryInitDefault ()
		{
			if (IsInitialized)
				return;

			Width = 100f;
		}
	}
}