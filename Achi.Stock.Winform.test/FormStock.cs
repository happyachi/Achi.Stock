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
	public partial class FormStock : Form
	{
		private int _sotckId;
		private MemberDto _member;

		private StockDailyPriceService _service = new StockDailyPriceService(new StockDailyPriceEFRepository());

		public FormStock(MemberDto member, int pk)
		{
			InitializeComponent();
			_sotckId = pk;
			_member = member;

			
			this.Load += FormStock_Load;
			this.buttonYear.Click += buttonYear_Click;
			this.buttonSeason.Click += buttonSeason_Click;
			this.buttonMonth.Click += buttonMonth_Click;
			this.buttonWeek.Click += buttonWeek_Click;
			this.buttonTrade.Click += ButtonTrade_Click;
		}

		private void ButtonTrade_Click(object sender, EventArgs e)
		{
			var form = new FormTrade(_member, _sotckId);
			form.Owner = this;
			form.ShowDialog();
		}

		private void FormStock_Load(object sender, EventArgs e)
		{
			DisplayLabelText();
			DateTime start = DateTime.Now.AddYears(-1);
			DateTime end = DateTime.Now;
			string line = "年線";
			Display(start, end);
		}

		private void buttonYear_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now.AddYears(-1);
			DateTime end = DateTime.Now;
			string line = "年線";
			Display(start, end);
		}

		private void buttonSeason_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now.AddMonths(-3);
			DateTime end = DateTime.Now;
			string line = "季線";
			Display(start, end);
		}

		private void buttonMonth_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now.AddMonths(-1);
			DateTime end = DateTime.Now;
			string line = "月線";
			Display(start, end);
		}

		private void buttonWeek_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now.AddDays(-7);
			DateTime end = DateTime.Now;
			string line = "週線";

			Display(start, end);
		}
		public void DisplayLabelText()
		{
			var service = new StockCompanyService(new StockCompanyEFRepository());
			StockCompanyDto dto = service.Get(_sotckId);
			labelCode.Text = dto.Code;
			labelName.Text = dto.Name;

		}

		public void Display(DateTime start, DateTime end)
		{
			var service = _service;

			List<StockDailyPriceDto> dailyPrice = service.SearchByDate(_sotckId, start, end);

			dataGridView1.DataSource = dailyPrice.OrderByDescending(d => d.Date).ToList();

			var series = new Series("走勢")
			{
				ChartType = SeriesChartType.Line
			};
			if (chart1.Series.Count > 0)
			{
				chart1.Series[0].Points.Clear();
				series = chart1.Series[0];
			}


			foreach (var item in dailyPrice)
			{

				series.Points.AddXY(item.Date, item.Closing);

			}
			// 設定 X 軸的顯示格式
			chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd";
			bool check = !chart1.Series.Contains(series);
			if (check)
			{
				chart1.Series.Add(series);
			}

			// 更新圖表
			chart1.Invalidate();
		}


	}
}
