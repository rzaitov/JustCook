using System;

namespace Logic
{
	public interface ISizeFactory
	{
		ISizeF Create(float width, float height);
	}
}

