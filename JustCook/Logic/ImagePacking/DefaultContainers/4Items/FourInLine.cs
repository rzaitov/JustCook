using System;

namespace Logic
{
	//   * * * *
	public class FourInLine : RowContainer
	{
		public FourInLine(IScalableBox box1, IScalableBox box2, IScalableBox box3, IScalableBox box4)
		{
			Add(box1);
			Add(box2);
			Add(box3);
			Add(box4);
		}
	}
}

