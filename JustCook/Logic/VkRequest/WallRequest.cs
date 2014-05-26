using System;

namespace Logic.Vk
{
	public class WallRequestParam : VkRequestParam
	{
		public string OwnerId { get; set; }
		public string Filter { get; set; }
		public string Count { get; set; }
	}

	public class FilterType
	{
		public const string Suggested = "suggests";
		public const string Postponed = "postponed";
		public const string Owner = "owner";
		public const string Others = "others";
		public const string All = "all";
	}
}

