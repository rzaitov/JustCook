using System;

namespace Logic
{
	//    * *
	//    * *
	public class TwoItemsPerLineTwoLines : ColumnContainer
	{
		private readonly RowContainer _rowTop, _rowBottom;

		public TwoItemsPerLineTwoLines(IScalableBox box1, IScalableBox box2, IScalableBox box3, IScalableBox box4)
		{
			_rowTop = new RowContainer{ box1, box2 };
			_rowBottom = new RowContainer{ box3, box4 };

			Add(_rowTop);
			Add(_rowBottom);
		}
	}
}

