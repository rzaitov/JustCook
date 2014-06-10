using System;

namespace Logic
{
	//   *
	//   *
	//  * *
	public class OneOneTwo : ColumnContainer
	{
		private readonly RowContainer _row;

		public OneOneTwo(IScalableBox box1, IScalableBox box2, IScalableBox box3, IScalableBox box4)
		{
			Add(box1);
			Add(box2);

			_row = new RowContainer { box3, box4 };
			Add(_row);
		}
	}
}

