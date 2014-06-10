using System;

namespace Logic
{
	//     *
	//   * *
	//     *
	public class OneInLineThreeInColumn : RowContainer
	{
		private readonly ColumnContainer _column;

		public OneInLineThreeInColumn(IScalableBox box1, IScalableBox box2, IScalableBox box3, IScalableBox box4)
		{

			Add(box1);

			_column = new ColumnContainer { box2, box3, box4 };
			Add(_column);
		}
	}
}

