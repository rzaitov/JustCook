using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
	public static class QueryBuilder
	{
		public static string CreateQueryStringFrom(Dictionary<string, string> nameValues)
		{
			if (nameValues == null || nameValues.Count == 0)
				return string.Empty;

			StringBuilder sb = new StringBuilder ();

			foreach (var kvp in nameValues) {
				sb.AppendFormat("{0}={1}&", kvp.Key, kvp.Value);
			}

			if (sb.Length > 0)
				sb.Length--;

			return sb.ToString();
		}
	}
}

