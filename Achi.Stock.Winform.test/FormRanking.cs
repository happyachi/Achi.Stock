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
	public partial class FormRanking : Form
	{
		private MemberAccountStockService _memberAccountStockService = new MemberAccountStockService(new MemberAccountStockEFRepository());

		private StockDailyPriceService _dailyPriceService = new StockDailyPriceService(new StockDailyPriceEFRepository());
		private MemberService _memberService = new MemberService(new MemberEFRepository());

		private MemberAccountMoneyService _memberAccountMoneyService = new MemberAccountMoneyService(new MemberAccountMoneyEFRepository());
		private MemberDto _member;
		public FormRanking(MemberDto member)
		{
			InitializeComponent();
			_member = member;

			this.Load += FormRanking_Load;
		}

		private void FormRanking_Load(object sender, EventArgs e)
		{
			Display();
		}

		public void Display()
		{


			//var moneyAccounts = _memberAccountMoneyService.GetAllList();
			//var stockAccounts = _memberAccountStockService.GetAllList();

			//Dictionary<int , double> stockPrice = new Dictionary<int , double>();

			//foreach (var item in stockAccounts)
			//{
			//	int stockId = item.StockId;
			//	var lastTrade = _dailyPriceService.GetLastTradeByCompanyId(item.StockId);
			//	stockPrice.Add(stockId, (double)lastTrade.Closing);
			//}

			List<Ranking> rankings = new List<Ranking>();
			var members = _memberService.GetAllList();

			foreach (var member in members)
			{
				var data = _memberAccountStockService.SearchByMemberId(member.Id);
				decimal totalStockValue = 0;
				foreach (var item in data)
				{
					int stockId = item.StockId;
					var lastTrade = _dailyPriceService.GetLastTradeByCompanyId(item.StockId);
					totalStockValue += (decimal)(lastTrade.Closing * item.Amount * 1000);
				}

				var moneyAccount = _memberAccountMoneyService.GetByMemberId(member.Id);

				decimal totalValue = (totalStockValue + moneyAccount.LatestAccount);

				decimal performance = ((((totalStockValue + moneyAccount.LatestAccount) / moneyAccount.OriginalAccount)-1) * 100);


				Ranking ranking = new Ranking
				{
					MemberName = member.Name,
					MemberId = member.Id,
					Performance = performance,
					TotalValue = totalValue
				};
				rankings.Add(ranking);
			}

			rankings = rankings.OrderByDescending(x => x.Performance).ToList();
			dataGridView1.DataSource = rankings;

			Ranking thisMemberRanking = rankings.Where(r => r.MemberId == _member.Id).Single();

			this.labelTotalValue.Text = thisMemberRanking.TotalValue.ToString("#,#");

			this.labelPerformance.Text = thisMemberRanking.Performance.ToString("f2");

			int rank = rankings.IndexOf(thisMemberRanking) + 1;

			this.labelRank.Text = rank.ToString();


		}
	}

	class Ranking
	{
		public string MemberName { get; set; }
		public int MemberId { get; set; }
		public decimal Performance { get; set; }
		public decimal TotalValue { get; set; }

	}
}
