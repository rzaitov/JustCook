using System;
using System.Collections.Generic;

namespace Logic
{
	public abstract class ImageContainer : IScalableSizeF
	{
		private readonly List<IScalableSizeF> _elements;

		public List<IScalableSizeF> Elements
		{
			get { return _elements;}
		}

		public abstract float Width { get; set; }
		public abstract float Height { get; set; }

		protected bool IsInitialized { get; set; }

		public ImageContainer()
		{
			_elements = new List<IScalableSizeF> ();
		}

		public void Add(IScalableSizeF size)
		{
			_elements.Add(size);
		}

		protected abstract void TryInitDefault ();
	}
}

