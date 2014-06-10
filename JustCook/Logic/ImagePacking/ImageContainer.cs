using System;
using System.Collections.Generic;

namespace Logic
{
	public abstract class ImageContainer : IScalableBox
	{
		private readonly List<IScalableBox> _elements;

		protected bool IsInitialized { get; set; }

		public List<IScalableBox> Elements
		{
			get { return _elements;}
		}

		public abstract float Width { get; set; }
		public abstract float Height { get; set; }

		public abstract float X { get; set; }
		public abstract float Y { get; set; }


		public ImageContainer()
		{
			_elements = new List<IScalableBox> ();
		}

		public virtual void Add(IScalableBox box)
		{
			_elements.Add(box);
		}

		protected abstract void TryInitDefault ();
	}
}

