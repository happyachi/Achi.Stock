using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Core
{
	internal class TaiexCopy
	{
	}


	/// <summary>
	/// 
	/// </summary>
	public class TaiexHistoryFromAPI
	{
		public string Date { get; set; }
		public string OpeningIndex { get; set; }
		public string HighestIndex { get; set; }
		public string LowestIndex { get; set; }
		public string ClosingIndex { get; set; }
	}

	public class APITaiexHistory
	{
		public void GetTaiexHistory()
		{
			HttpClient httpClient = new HttpClient();
			HttpResponseMessage httpResponseMessage = httpClient.GetAsync("https://openapi.twse.com.tw/v1/indicesReport/MI_5MINS_HIST").Result;

			string content = httpResponseMessage.Content.ReadAsStringAsync().Result;
			List<TaiexHistoryFromAPI> taiex = JsonConvert.DeserializeObject<List<TaiexHistoryFromAPI>>(content);
			foreach (var item in taiex)
			{
				Console.WriteLine(item.ClosingIndex);
			}

			Console.WriteLine($"http 回應內容: {taiex}");
		}
	}
}
