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
		private readonly string ApiVersion = "5.21";
		private readonly string WallGetBaseUrl = "https://api.vk.com/method/wall.get";

		public VkService()
		{
			_client = new HttpClient ();
		}

		public Task<IList<Post>> GetWall(WallRequestParam param)
		{
			TrySetApiVersion(param);

			UriBuilder builder = new UriBuilder (WallGetBaseUrl);
			builder.Query = param.BuildQuery();

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

		private void TrySetApiVersion(VkRequestParam param)
		{
			if(string.IsNullOrWhiteSpace(param.Version))
				param.Version = ApiVersion;
		}
	}
}

