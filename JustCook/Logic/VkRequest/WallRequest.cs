using System;
using System.Collections.Generic;

namespace Logic.Vk
{
	public class WallRequestParam : VkRequestParam
	{
		public int OwnerId { get; set; }
		public string Filter { get; set; }
		public int? Count { get; set; }
		public int? Offset { get; set; }

		protected override void CollectParameters (Dictionary<string, string> nameValues)
		{
			base.CollectParameters(nameValues);

			TryCollect("owner_id", OwnerId, nameValues);
			TryCollect("filter", Filter, nameValues);
			TryCollect("count", Count, nameValues);
			TryCollect("offset", Offset, nameValues);
		}
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

