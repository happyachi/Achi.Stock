using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Core
{
	internal class DailyStockData
	{
		private DateTime _date;
		public string Date { get; set; }

		public string SecuritiesCompanyCode { get; set; }
		public string CompanyName { get; set; }
		public string Close { get; set; }
		public string Change { get; set; }
		public string Open { get; set; }
		public string High { get; set; }
		public string Low { get; set; }
		public string TradingShares { get; set; }
		public string TransactionAmount { get; set; }
		public string TransactionNumber { get; set; }
		public string LatestBidPrice { get; set; }
		public string LatesAskPrice { get; set; }
		public string Capitals { get; set; }
		public string NextLimitUp { get; set; }
		public string NextLimitDown { get; set; }
	}
	
	public class APIDailyStockData
	{
		public void GetDailyStockData()
		{
			HttpClient httpClient = new HttpClient();
			HttpResponseMessage httpResponseMessage = httpClient.GetAsync("https://www.tpex.org.tw/openapi/v1/tpex_mainboard_quotes").Result;

	

			string content = httpResponseMessage.Content.ReadAsStringAsync().Result;
			List<DailyStockData> stock = JsonConvert.DeserializeObject<List<DailyStockData>>(content);
			foreach (var item in stock)
			{
				Console.WriteLine(item.CompanyName);
			}


			Console.WriteLine($"http 回應內容: {stock}");
		}
	}
}
