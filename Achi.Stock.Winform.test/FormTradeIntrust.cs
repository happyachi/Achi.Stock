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
	public partial class FormTradeIntrust : Form
	{
		private TradeDataIntrustService _tradeDataIntrustSservice = new TradeDataIntrustService(new TradeDataIntrustEFRepository());
		private MemberDto _member;
		private StockDailyPriceDto _dailyPrice;
		public FormTradeIntrust(MemberDto member, StockDailyPriceDto dailyPrice)
		{
			InitializeComponent();
		}

	}
}
