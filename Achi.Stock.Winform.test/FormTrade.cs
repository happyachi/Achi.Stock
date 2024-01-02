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
	public partial class FormTrade : Form
	{
		private int _companyId;
		private MemberDto _member;
		private StockDailyPriceDto _dailyPrice;

		private StockDailyPriceService _dailyPriceService = new StockDailyPriceService(new StockDailyPriceEFRepository());
		private StockCompanyService _companyService = new StockCompanyService(new StockCompanyEFRepository());
		private MemberAccountStockService _memberAccountStockService = new MemberAccountStockService(new MemberAccountStockEFRepository());
		private MemberAccountMoneyService _memberAccountMoneyService = new MemberAccountMoneyService(new MemberAccountMoneyEFRepository());
		public FormTrade(MemberDto member, int companyId)
		{
			InitializeComponent();
			_companyId = companyId;
			_member = member;

			this.Load += FormTrade_Load;

			//buttonRightNow.Click += ButtonRightNow_Click;
			//buttonIntrust.Click += ButtonIntrust_Click;
				
		}

		private void FormTrade_Load(object sender, EventArgs e)
		{
			Display();
			var form = new FormTradeRightNow(_member, _dailyPrice);
			form.Owner = this;
			OpenChildForm(form);
		}

		private void ButtonIntrust_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormTradeIntrust(_member, _dailyPrice));
		}

		//private void ButtonRightNow_Click(object sender, EventArgs e)
		//{
		//	var form = new FormTradeRightNow(_member, _dailyPrice);
		//	form.Owner = this;
		//	OpenChildForm(form);
		//}

		public void Display()
		{
			var dailyPriceService = _dailyPriceService;
			_dailyPrice = dailyPriceService.GetLastTradeByCompanyId(_companyId);

			var companyService = _companyService;
			StockCompanyDto company = companyService.Get(_dailyPrice.CompanyId);

			MemberAccountMoneyDto moneyDto = _memberAccountMoneyService.GetByMemberId(_member.Id);

			labelPrice.Text = _dailyPrice.Closing.ToString();
			labelCode.Text = company.Code;
			labelName.Text = company.Name;
			labelAmount.Text = "0";
			labelAccountMoney.Text = moneyDto.LatestAccount.ToString("#,#");

			var data = _memberAccountStockService.SearchByMemberId(_member.Id);
			try
			{
				var stock = data.Where(x => x.StockId == company.Id).Single();
				labelAmount.Text = ((int)stock.Amount).ToString();
			}
			catch (Exception)
			{
				//
			}
			
			dataGridView1.DataSource = data;
		}

		// 子表單切換
		private Form activeForm = null; // 確認表單是否開啟
		private void OpenChildForm(Form childForm) // 開啟子表單
		{
			if (activeForm != null) activeForm.Close();

			activeForm = childForm; // 若表單未開啟，將表單指名給變數
			childForm.TopLevel = false; // 子表單不能設定為最上層表單
			childForm.FormBorderStyle = FormBorderStyle.None; // 設定子表單無邊框
			childForm.Dock = DockStyle.Fill; // 設定子表單位置
			panelChildForm.Controls.Add(childForm); // 表單加入panel顯示
			panelChildForm.Tag = childForm; // 將標籤設為子表單名
			childForm.BringToFront(); // 將表單放置到前面
			childForm.Show();
		}

	}
}
