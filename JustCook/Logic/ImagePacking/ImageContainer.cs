using System;
using System.Collections.Generic;

using Logic.Drawing;

namespace Logic
{
	public abstract class ImageContainer
	{
		private readonly List<SizeF> _elements;
		protected List<SizeF> Elements
		{
			get { return _elements;}
		}

		public abstract float Width { get; set; }
		public abstract float Height { get; set; }

		protected bool IsInitialized { get; set; }

		public ImageContainer()
		{
			_elements = new List<SizeF> ();
		}

		public void Add(SizeF size)
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

