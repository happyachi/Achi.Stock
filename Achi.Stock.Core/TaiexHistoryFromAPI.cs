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
	/// 大盤指數可以存到SQL的資料格式及型態
	/// </summary>
	public class TaiexHistoryRightType
	{
		public DateTime Date { get; set; }
		public double OpeningIndex { get; set; }
		public double HighestIndex { get; set; }
		public double LowestIndex { get; set; }
		public double ClosingIndex { get; set; }
	}

	/// <summary>
	/// 大盤指數一開始取得的資料格式及型態
	/// </summary>
	public class TaiexHistoryFromAPIByDate
	{
		public string stat { get; set; }
		public string title { get; set; }
		public string date { get; set; }
		public string[] fields { get; set; }
		public List<string[]> data { get; set; }
		public string total { get; set; }
	}

	/// <summary>
	/// API 接收的原始台股大盤指數，每月為單位
	/// </summary>
	public class APITaiexHistoryByDay
	{
		public List<TaiexHistoryRightType> ListTaiexToSQL = new List<TaiexHistoryRightType>();

		/// <summary>
		/// 透過API，依年、月份，取得該月份的大盤指數
		/// </summary>
		public void GetTaiexHistory(string date)
		{
			// 建立 HttpClient 物件
			HttpClient httpClient = new HttpClient();

			// 建立 GET 請求
			HttpResponseMessage httpResponseMessage = httpClient.GetAsync($"https://www.twse.com.tw/rwd/zh/TAIEX/MI_5MINS_HIST?date={date}&response=json").Result;

			// 從Result取得Json
			string content = httpResponseMessage.Content.ReadAsStringAsync().Result; 

			TaiexHistoryFromAPIByDate taiexJson = JsonConvert.DeserializeObject<TaiexHistoryFromAPIByDate>(content); // 把Json 格式轉成 TaiexHistoryFromAPIByDate 格式

			foreach (string[] item in taiexJson.data)
			{
				TaiexHistoryRightType result = ChangeTaiexHistoryToRightType(item);
				ListTaiexToSQL.Add(result); // 把原始資料轉換格式後，加到list裡
			}
		}

		/// <summary>
		/// 把大盤指數原始string資料，轉成DateTime, double的格式
		/// </summary>
		public TaiexHistoryRightType ChangeTaiexHistoryToRightType(string[] item)
		{
				TaiexHistoryRightType taiex = new TaiexHistoryRightType();

				taiex.Date = HelperMethod.TaiwanDateToDateTime(item[0]);
				taiex.OpeningIndex = Convert.ToDouble(item[1]);
				taiex.HighestIndex = Convert.ToDouble(item[2]);
				taiex.LowestIndex = Convert.ToDouble(item[3]);
				taiex.ClosingIndex = Convert.ToDouble(item[4]);

				return taiex;
		}

		public void show()
		{
			foreach (var i in ListTaiexToSQL)
			{
				Console.Write(i.Date + "\t" + i.OpeningIndex + "\t" + i.HighestIndex + "\t" + i.LowestIndex + "\t" + i.ClosingIndex + "\n");
			}
			Console.WriteLine();
		}
	}

}
