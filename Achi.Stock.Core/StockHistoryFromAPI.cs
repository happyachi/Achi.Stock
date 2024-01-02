using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Core
{
	/// <summary>
	/// 個股一開始取得的資料格式及型態
	/// </summary>
	public class StockHistoryFromAPI
	{
        public string stat { get; set; }
		public string date { get; set; }
		public string title { get; set; }
		
		public List<string> fields { get; set; }

		public List<string[]> data { get; set; }

		public List<string> notes { get; set; }
		public string total { get; set; }
	}

	/// <summary>
	/// 個股可以存到資料庫的資料格式及型態
	/// </summary>
	public class StockHistoryRightType
	{
		//"fields": ["日期", "成交股數", "成交金額", "開盤價","最高價","最低價", "收盤價", "漲跌價差","成交筆數"];
		public string CompanyCode { get; set; } //公司代號
		public DateTime Date { get; set; } // 日期
		public double Shares { get; set; } // 成交股數
		public double Amount { get; set; } // 成交金額
		public double Open { get; set; } // 開盤價
		public double High { get; set; } // 最高價
		public double Low { get; set; } // 最低價
		public double Close { get; set; } // 收盤價
		public double Change { get; set; } // 漲跌價差
		public double Count { get; set; } // 成交筆數


	}

	/// <summary>
	/// 透過API取的個股的資料
	/// </summary>
	public class APIHistoryStockData
	{
		public List<StockHistoryRightType> ListStock = new List<StockHistoryRightType>();
		public void GetHistoryByMonthAndStockCode(string stockCode, string date)
		{
			// 建立 HttpClient 物件
			HttpClient client = new HttpClient();

			// 建立 GET 請求
			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://www.twse.com.tw/exchangeReport/STOCK_DAY?response=json&date={date}&stockNo={stockCode}");

			// 發送請求
			HttpResponseMessage response = client.SendAsync(request).Result;

			// 解析 JSON 回應
			string responseBody = response.Content.ReadAsStringAsync().Result;
			
			StockHistoryFromAPI stockData = JsonConvert.DeserializeObject<StockHistoryFromAPI>(responseBody);


			// 顯示資料
			foreach (string[] item in stockData.data)
			{
				StockHistoryRightType result = ChangeStockHistoryToRightType(stockCode, item);
				ListStock.Add(result);
			}
		}

		public StockHistoryRightType ChangeStockHistoryToRightType(string companyCode, string[] item)
		{
			StockHistoryRightType stock = new StockHistoryRightType();

			stock.CompanyCode = companyCode;
			stock.Date = HelperMethod.TaiwanDateToDateTime(item[0]);
			stock.Shares = Convert.ToDouble(item[1]);
			stock.Amount = Convert.ToDouble(item[2]);
			stock.Open = Convert.ToDouble(item[3]);
			stock.High = Convert.ToDouble(item[4]);
			stock.Low = Convert.ToDouble(item[5]);
			stock.Close = Convert.ToDouble(item[6]);
			stock.Change = Convert.ToDouble(item[7]);
			stock.Count = Convert.ToDouble(item[8]);

			return stock;
		}


		public void show()
		{
			foreach (var i in ListStock)
			{
				Console.Write(i.CompanyCode + "\t" + 
					i.Date + "\t" + 
					i.Shares + "\t" + 
					i.Amount + "\t" +
					i.Open + "\t" +
					i.High + "\t" +
					i.Low + "\t" +
					i.Close + "\t" +
					i.Change + "\t" +
					i.Count + "\n");
			}
			Console.WriteLine();
		}
	}

}
