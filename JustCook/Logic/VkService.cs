using System;
using System.Collections.Generic;
using System.Collections;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Logic.Vk;

namespace Logic
{
	public class VkService
	{
		private readonly HttpClient _client;

		public VkService()
		{
			_client = new HttpClient ();
		}

		public Task<IList<Post>> GetWall(int ownerId, string filter, int count)
		{
			var parameters = new Dictionary<string, string>{
				{ "v", "5.21" },
				{ "owner_id", ownerId.ToString() },
				{ "filter", filter },
				{ "count", count.ToString() }
			};
			string queryStr = QueryBuilder.CreateQueryStringFrom(parameters);
			UriBuilder builder = new UriBuilder ("https://api.vk.com/method/wall.get");
			builder.Query = queryStr;

			Task<HttpResponseMessage> requestTask = _client.GetAsync(builder.Uri);

			return requestTask.ContinueWith(rTask => {

				HttpResponseMessage responce = rTask.Result;
				responce.EnsureSuccessStatusCode();

				return responce.Content.ReadAsStringAsync().ContinueWith(t => {
					var postRootObject = JsonConvert.DeserializeObject<VkRootObject<Post>>(t.Result);
					var result = postRootObject.response.items;
					return (IList<Post>)result;
				});

			}).Unwrap();
		}
	}
}

