using Achi.Stock.Core;
using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.EFModels;
using Achi.Stock.Winform.test.Models.Repositories;
using DocumentFormat.OpenXml.EMMA;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Achi.Stock.Winform.test
{
	public partial class FormUseApiGetStockPrice : Form
	{
		public FormUseApiGetStockPrice()
		{
			InitializeComponent();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime start = dateTimePickerStrat.Value;
			start = new DateTime(start.Year, start.Month, 1);

			DateTime end = dateTimePickerEnd.Value;
			end = new DateTime(end.Year, end.Month, 1);

			int count = 0;
			if (start <= end)
			{
				count = (end.Year - start.Year) * 12;
				if (end.Month < start.Month)
				{
					count += -start.Month + end.Month;
				}
				else
				{
					count += end.Month - start.Month;
				}
			}
			else
			{
				MessageBox.Show("起始日期不可以大於結束日期");
				return;
			}



			string date = string.Empty;

			var db = new AppDBContext();
			var list = db.StockCompanys.OrderBy(x=>x.Id).ToList();


			for(int i = 0; i<list.Count(); i++)
				{

				for (int j = 0; j <= count; j++)
				{
					date = $"{start.AddMonths(j).ToString("yyyyMMdd")}";

				}
				try
				{
					GetDailyPrice(date, list[i].Code);
				}
				catch (Exception)
				{
					//
				}

				Thread.Sleep(300);

			}
			MessageBox.Show("新增完成");


		}
		public void GetDailyPrice(string date, string stockCode)
		{
			int id = GetStockId(stockCode);

			// 建立 HttpClient 物件
			HttpClient client = new HttpClient();

			// 建立 GET 請求
			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://www.twse.com.tw/exchangeReport/STOCK_DAY?response=json&date={date}&stockNo={stockCode}");

			// 發送請求
			HttpResponseMessage response = client.SendAsync(request).Result;

			// 解析 JSON 回應
			string responseBody = response.Content.ReadAsStringAsync().Result;

			StockHistoryFromAPI stockData = JsonConvert.DeserializeObject<StockHistoryFromAPI>(responseBody);
			if(stockData.data != null)
			{
				// 顯示資料
				foreach (string[] item in stockData.data)
				{
					StockDailyPriceDto stockDailyPrice = new StockDailyPriceDto();

					stockDailyPrice.CompanyId = id;
					stockDailyPrice.Date = HelperMethod.TaiwanDateToDateTime(item[0]);
					stockDailyPrice.Highest = Convert.ToDouble(item[4]);
					stockDailyPrice.Lowest = Convert.ToDouble(item[5]);
					stockDailyPrice.Opening = Convert.ToDouble(item[3]);
					stockDailyPrice.Closing = Convert.ToDouble(item[6]);
					stockDailyPrice.Amount = Convert.ToDouble(item[2]);
					stockDailyPrice.Volume = Convert.ToDouble(item[8]);

					StockDailyPriceEFRepository repo = new StockDailyPriceEFRepository();

					List<StockDailyPriceDto> dtolist = repo.SearchByDate(id, stockDailyPrice.Date, stockDailyPrice.Date);

					if (dtolist.Count == 0)
					{
						repo.Creat(stockDailyPrice);
					}
				}
			}

		}

		public int GetStockId(string code)
		{
			StockCompanyEFRepository repo= new StockCompanyEFRepository();

			List<StockCompanyDto> dtos = repo.SearchCodeGetId(code);

			return dtos[0].Id;

		}

		private void FormUseApiGetStockPrice_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Owner.Show();
		}
	}
}
