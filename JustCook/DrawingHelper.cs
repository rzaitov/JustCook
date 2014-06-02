namespace JustCook
{
	public static class DrawingHelper
	{
		public static Logic.Drawing.SizeF ConvertFrom(System.Drawing.SizeF size)
		{
			return new Logic.Drawing.SizeF (size.Width, size.Height);
		}

		public static System.Drawing.SizeF ConvertFrom(Logic.Drawing.SizeF size)
		{
			return new System.Drawing.SizeF (size.Width, size.Height);
		}
	}
}

