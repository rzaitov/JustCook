using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

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

		public Task<IList<Post>> GetWall()
		{
			var wallRequest = "https://api.vk.com/method/wall.get?v=5.21&owner_id=-32509740&filter=owner&count=1";
			Task<HttpResponseMessage> requestTask = _client.GetAsync(wallRequest);

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

