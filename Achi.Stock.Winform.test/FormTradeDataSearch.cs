using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Repositories;
using Achi.Stock.Winform.test.Models.Services;
using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achi.Stock.Winform.test
{
	public partial class FormTradeDataSearch : Form
	{
		private MemberDto _member;
		private TradeDataService _tradeDataService = new TradeDataService(new TradeDataEFRepository());
		public FormTradeDataSearch(MemberDto member)
		{
			InitializeComponent();
			_member = member;

			this.Load += FormTradeDataSearch_Load;
			this.dateTimePickerStrat.Value = DateTime.Today.AddMonths(-1);

			this.textBoxCode.TextChanged += TextBoxCode_TextChanged;
			this.textBoxName.TextChanged += TextBoxName_TextChanged;
			this.dateTimePickerStrat.TextChanged += DateTimePickerStrat_TextChanged;
			this.dateTimePickerEnd.TextChanged += DateTimePickerEnd_TextChanged;
		}

		private void FormTradeDataSearch_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void DateTimePickerEnd_TextChanged(object sender, EventArgs e)
		{
			Display();
		}

		private void DateTimePickerStrat_TextChanged(object sender, EventArgs e)
		{
			Display();
		}

		private void TextBoxName_TextChanged(object sender, EventArgs e)
		{
			Display();
		}

		private void TextBoxCode_TextChanged(object sender, EventArgs e)
		{
			Display();
		}

		
		private void buttonAll_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonBuy_Click(object sender, EventArgs e)
		{
			List<TradeDataDto> tradeDataDtos = GetTradeDataDto().Where(x=>x.StateId==1).ToList();

			dataGridView1.DataSource = tradeDataDtos;
		}

		private void buttonSale_Click(object sender, EventArgs e)
		{
			List<TradeDataDto> tradeDataDtos = GetTradeDataDto().Where(x => x.StateId == 2).ToList();

			dataGridView1.DataSource = tradeDataDtos;
		}

		public void Display()
		{
			List<TradeDataDto> tradeDataDtos = GetTradeDataDto();

			dataGridView1.DataSource = tradeDataDtos;
		}

		private List<TradeDataDto> GetTradeDataDto()
		{
			var companyService = new StockCompanyService(new StockCompanyEFRepository());

			List<StockCompanyDto> companiesList = companyService.SearchNameAndCode(textBoxName.Text, textBoxCode.Text);

			var tradeDataService = new TradeDataService(new TradeDataEFRepository());

			List<TradeDataDto> tradeDataDtos = tradeDataService.SearchByCompaniesAndDate(_member, companiesList, dateTimePickerStrat.Value, dateTimePickerEnd.Value.Date);

			List<TradeDataDto>  tradeDataDtosResult = tradeDataDtos.Where(t => t.Datetime >= dateTimePickerStrat.Value && t.Datetime < dateTimePickerEnd.Value.Date.AddDays(1)).ToList();
			return tradeDataDtosResult;
		}
	}
}
