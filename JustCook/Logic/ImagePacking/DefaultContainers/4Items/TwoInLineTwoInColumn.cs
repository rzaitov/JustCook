using System;

namespace Logic
{
	//       *
	//   * * 
	//       *
	public class TwoInLineTwoInColumn : RowContainer
	{
		private readonly ColumnContainer _column;

		public TwoInLineTwoInColumn(IScalableBox box1, IScalableBox box2, IScalableBox box3, IScalableBox box4)
		{
			Add(box1);
			Add(box2);

			_column = new ColumnContainer { box3, box4 };
			Add(_column);
		}
	}
}

