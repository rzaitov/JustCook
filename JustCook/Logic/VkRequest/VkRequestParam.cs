using System;
using System.Collections.Generic;

namespace Logic.Vk
{
	public class VkRequestParam
	{
		public string Version { get; set; }
		public string CapchaSid { get; set; }
		public string CapchaKey { get; set; }

		public string BuildQuery()
		{
			var nameValues = new Dictionary<string, string> ();
			CollectParameters(nameValues);

			return QueryBuilder.CreateQueryStringFrom(nameValues);
		}

		protected virtual void CollectParameters(Dictionary<string, string> nameValues)
		{
			TryCollect("v", Version, nameValues);
			TryCollect("captcha_sid", CapchaSid, nameValues);
			TryCollect("captcha_key", CapchaKey, nameValues);
		}

		protected void TryCollect(string key, string value, Dictionary<string, string> nameValues)
		{
			if (!string.IsNullOrWhiteSpace(value))
				nameValues [key] = value;
		}

		protected void TryCollect(string key, object value, Dictionary<string, string> nameValues)
		{
			if (value != null)
				nameValues [key] = value.ToString();
		}
	}
}

