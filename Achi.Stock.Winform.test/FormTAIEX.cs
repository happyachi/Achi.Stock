using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Interfaces;
using Achi.Stock.Winform.test.Models.Repositories;
using Achi.Stock.Winform.test.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Achi.Stock.Winform.test
{
	public partial class FormTAIEX : Form
	{
		private IStockDailyTAIEXRepository GetRepository()
		{
			return new StockDailyTAIEXEFRepository();
		}
		public FormTAIEX()
		{
			InitializeComponent();
			this.Load += FormTAIEX_Load;
		}

		private void FormTAIEX_Load(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now.AddYears(-1);
			DateTime end = DateTime.Now;
			string line = "年線";
			Display(start, end, line);
		}


		private void buttonYear_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now.AddYears(-1);
			DateTime end = DateTime.Now;
			string line = "年線";
			Display(start, end, line);
		}

		private void buttonSeason_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now.AddMonths(-3);
			DateTime end = DateTime.Now;
			string line = "季線";
			Display(start, end, line);
		}

		private void buttonMonth_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now.AddMonths(-1);
			DateTime end = DateTime.Now;
			string line = "月線";
			Display(start, end, line);
		}

		private void buttonWeek_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now.AddDays(-7);
			DateTime end = DateTime.Now;
			string line = "週線";

			Display(start, end, line);
		}


		public void Display(DateTime start, DateTime end, string serie)
		{
			var service = new StockDailyTAIEXService(GetRepository());

			List<StockDailyTAIEXDto> dailyTAIEXDtos = service.SearchByDate(start, end);

			List<StockDailyTAIEXDisplay> data = new List<StockDailyTAIEXDisplay>();

			foreach (var item in dailyTAIEXDtos)
			{
				StockDailyTAIEXDisplay display = new StockDailyTAIEXDisplay();
				DateTime.TryParse(item.Date.ToString(), out DateTime result);
				display.Date = result;
				display.Opening = item.Opening;
				display.Highest = item.Highest;
				display.Lowest = item.Lowest;
				display.Closing = item.Closing;

				data.Add(display);
			}
			dataGridView1.DataSource = data.OrderByDescending(x => x.Date).ToList();


			var series = new Series("大盤走勢")
			{
				ChartType = SeriesChartType.Line
			};

			if (chart1.Series.Count > 0)
			{
				chart1.Series[0].Points.Clear();
				series = chart1.Series[0];
			}
			

			foreach (var item in data)
			{

				series.Points.AddXY(item.Date, item.Closing);

			}
			// 設定 X 軸的顯示格式
			chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd";

			// 設定 X 軸的範圍，這裡假設你的資料是按日期排序的
			//chart1.ChartAreas[0].AxisX.Minimum = Convert.ToInt32( data[0].Date.ToString("yyyyMMdd"));
			//chart1.ChartAreas[0].AxisX.Maximum = Convert.ToInt32(data[data.Count - 1].Date.ToString("yyyyMMdd"));

			bool check = !chart1.Series.Contains(series);
			if (check)
			{
				chart1.Series.Add(series);
			}

			// 更新圖表
			chart1.Invalidate();

		}
	}

	public class StockDailyTAIEXDisplay
	{
		public DateTime Date { get; set; }

		public double? Opening { get; set; }

		public double? Highest { get; set; }

		public double? Lowest { get; set; }

		public double? Closing { get; set; }
	}
}
