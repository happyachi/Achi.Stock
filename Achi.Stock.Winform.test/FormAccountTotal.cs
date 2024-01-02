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
	public partial class FormAccountTotal : Form
	{
		private MemberAccountStockService _memberAccountStockService = new MemberAccountStockService(new MemberAccountStockEFRepository());

		private StockDailyPriceService _dailyPriceService = new StockDailyPriceService(new StockDailyPriceEFRepository());

		private MemberAccountMoneyService _memberAccountMoneyService = new MemberAccountMoneyService(new MemberAccountMoneyEFRepository());

		private MemberDto _member;

		public FormAccountTotal(MemberDto member)
		{
			InitializeComponent();
			_member = member;

			

			this.Load += FormAccountTotal_Load;
			this.dataGridView1.CellClick += DataGridView1_CellClick;
		}

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			List<MemberAccountStockDto> companies = dataGridView1.DataSource as List<MemberAccountStockDto>;
			int companyId = companies[e.RowIndex].StockId;

			var form = new FormTrade(_member, companyId);
			form.Owner = this;
			form.ShowDialog();

		}

		private void FormAccountTotal_Load(object sender, EventArgs e)
		{
			Display();
		}

		public void Display()
		{
			var dailyPriceService = _dailyPriceService;
			
			var moneyAccount = _memberAccountMoneyService.GetByMemberId(_member.Id);
			this.labelMoneyValue.Text = moneyAccount.LatestAccount.ToString("#,#");


			var data = _memberAccountStockService.SearchByMemberId(_member.Id);
			decimal totalStockValue = 0;
			foreach (var item in data)
			{
				int stockId = item.StockId;
				var lastTrade = dailyPriceService.GetLastTradeByCompanyId(item.StockId);
				totalStockValue += (decimal)(lastTrade.Closing * item.Amount *1000);
			}
			this.labelStockValue.Text = totalStockValue.ToString("#,#");

			this.labelTotalValue.Text = (totalStockValue+ moneyAccount.LatestAccount).ToString("#,#");

			this.labelPerformance.Text = ((((totalStockValue + moneyAccount.LatestAccount) / moneyAccount.OriginalAccount)-1)*100).ToString("f2");

			dataGridView1.DataSource = data;
		}
	}
}
