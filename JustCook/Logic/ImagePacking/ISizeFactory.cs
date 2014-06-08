using System;

namespace Logic
{
	public interface ISizeFactory
	{
		IScalableSizeF Create(float width, float height);
	}
}

