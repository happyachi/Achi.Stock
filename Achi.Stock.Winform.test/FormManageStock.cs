using Achi.Stock.Winform.test.Models.Dtos;
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

namespace Achi.Stock.Winform.test
{
	public partial class FormManageStock : Form
	{
		private StockDailyPriceService _stockDailyPriceService = new StockDailyPriceService(new StockDailyPriceEFRepository());
		private StockDailyTAIEXService _stockDailyTAIEXService = new StockDailyTAIEXService(new StockDailyTAIEXEFRepository());
		private string _market;

		public FormManageStock(string market)
		{
			InitializeComponent();
			_market = market;

			dateTimePickerStrat.Value = DateTime.Today.AddMonths(-1);
			dateTimePickerEnd.Value = DateTime.Today;

			this.Load += FormManageStock_Load;
			this.dateTimePickerStrat.TextChanged += DateTimePickerStrat_TextChanged;
			this.dateTimePickerEnd.TextChanged += DateTimePickerEnd_TextChanged;
		}

		private void DateTimePickerEnd_TextChanged(object sender, EventArgs e)
		{
			Display();
		}

		private void DateTimePickerStrat_TextChanged(object sender, EventArgs e)
		{
			Display();
		}

		private void FormManageStock_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void Display()
		{
			DateTime start = dateTimePickerStrat.Value;
			DateTime end = dateTimePickerEnd.Value;
			if (_market == "stock")
			{
				List<StockDailyPriceDto> dailyPriceDto = _stockDailyPriceService.SearchByDate(-1, start, end);

				dataGridView1.DataSource = dailyPriceDto;
			}
			if(_market == "TAIEXE")
			{
				List<StockDailyTAIEXDto> dailyTAIEXDtos = _stockDailyTAIEXService.SearchByDate(start, end);
				dataGridView1.DataSource= dailyTAIEXDtos;
			}
			
		}

		private void buttonManageMember_Click(object sender, EventArgs e)
		{
			if (_market == "stock")
			{
				var form = new FormUseApiGetStockPrice();
				form.Owner = this;
				form.Show();
			}
			if (_market == "TAIEXE")
			{
				var form = new FormUseGetDailyTAIEX();
				form.Owner = this;
				form.Show();//
			}
		}
	}
}
