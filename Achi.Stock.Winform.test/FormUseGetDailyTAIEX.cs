using Achi.Stock.Core;
using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achi.Stock.Winform.test
{
	public partial class FormUseGetDailyTAIEX : Form
	{
		public FormUseGetDailyTAIEX()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//GetTaiexHistory("20230101");
			//GetTaiexHistory("20230201");
			//GetTaiexHistory("20230301");
			//GetTaiexHistory("20230401");
			//GetTaiexHistory("20230501");
			//GetTaiexHistory("20230601");
			//GetTaiexHistory("20230701");
			//GetTaiexHistory("20230801");
			//GetTaiexHistory("20230901");
			//GetTaiexHistory("20231001");

			DateTime start = dateTimePickerStrat.Value;
			start = new DateTime(start.Year, start.Month, 1);

			DateTime end = dateTimePickerEnd.Value;
			end = new DateTime(end.Year, end.Month, 1);

			int count = 0;
			if (start <= end)
			{
				count = (end.Year - start.Year) * 12;
				if(end.Month < start.Month)
				{
					count +=  - start.Month + end.Month;
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

			for(int i = 0; i <= count; i++)
			{
				string date = $"{start.AddMonths(i).ToString("yyyyMMdd")}";
				GetTaiexHistory(date);
			}
			MessageBox.Show("新增完成");

		}

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
				StockDailyTAIEXDto stockDailyTAIEXDto = new StockDailyTAIEXDto();

				stockDailyTAIEXDto.Date = HelperMethod.TaiwanDateToDateTime(item[0]);
				stockDailyTAIEXDto.Opening = Convert.ToDouble(item[1]);
				stockDailyTAIEXDto.Highest = Convert.ToDouble(item[2]);
				stockDailyTAIEXDto.Lowest = Convert.ToDouble(item[3]);
				stockDailyTAIEXDto.Closing = Convert.ToDouble(item[4]);

				StockDailyTAIEXEFRepository repo = new StockDailyTAIEXEFRepository();


				if((repo.GetByDate((DateTime)stockDailyTAIEXDto.Date)) == null)
				{
					repo.Creat(stockDailyTAIEXDto);
				}
				
			}
		}

		private void FormUseGetDailyTAIEX_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Owner.Show();
		}
	}
	
}
