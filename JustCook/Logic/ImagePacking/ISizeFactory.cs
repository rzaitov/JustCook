using System;

namespace Logic
{
	public interface ISizeFactory
	{
		IScalableBox Create(float width, float height);
	}
}

