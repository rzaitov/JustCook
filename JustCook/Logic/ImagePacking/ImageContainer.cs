using System;
using System.Collections.Generic;

using Logic.Drawing;

namespace Logic
{
	public abstract class ImageContainer : ISizeF
	{
		private readonly List<ISizeF> _elements;

		public List<ISizeF> Elements
		{
			get { return _elements;}
		}

		public abstract float Width { get; set; }
		public abstract float Height { get; set; }

		protected bool IsInitialized { get; set; }

		public ImageContainer()
		{
			_elements = new List<ISizeF> ();
		}

		public void Add(ISizeF size)
		{
			_elements.Add(size);
		}

		protected void ThrowIfNotInitialized()
		{
			if (!IsInitialized)
				throw new InvalidOperationException ();
		}
	}
}

