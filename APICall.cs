using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ConsoleAppStockPriceGetter
{
	public static class APICall
	{
		private static HttpClient GetHttpClient(string url)
		{
			var client = new HttpClient { BaseAddress = new Uri(url) };
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			return client;
		}

		private static async Task<T> GetAsync<T>(string url, string urlParameters)
		{
			try
			{
				using (var client = GetHttpClient(url))
				{
					HttpResponseMessage response = await client.GetAsync(urlParameters);
					//Console.WriteLine(response.StatusCode);
					if (response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var json = await response.Content.ReadAsStringAsync();
						var result = JsonConvert.DeserializeObject<T>(json);
						return result;
					}
					return default(T);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return default(T);
			}
		}

		public static async Task<T> RunAsync<T>(string url, string urlParameters)
		{
			return await GetAsync<T>(url, urlParameters);
		}
	}
}

