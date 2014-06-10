using System;

namespace Logic
{
	public interface IScalableBox
	{
		float X { get; set; }
		float Y { get; set; }

		float Width { get; set; }
		float Height { get; set; }
	}
}