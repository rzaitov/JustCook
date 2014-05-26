using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

using Newtonsoft.Json;
using Logic.VkResponse;

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

				var strData = responce.Content.ReadAsStringAsync().Result;
				var result = JsonConvert.DeserializeObject<PostRootObject>(strData).response.items;

				return (IList<Post>)result;
			});

		}
	}
}

