using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Logic
{
	public class VkJsonResponse<T>
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("items")]
		public List<T> Items { get; set; }
	}

	public class VkResponseRootObject<T>
	{
		[JsonProperty("response")]
		public VkJsonResponse<T> Response { get; set;}
	}
}

