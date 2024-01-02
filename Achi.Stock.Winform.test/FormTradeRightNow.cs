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
	public partial class FormTradeRightNow : Form
	{
		private TradeDataService _tradeDataService = new TradeDataService(new TradeDataEFRepository());
		private MemberAccountMoneyService _memberAccountMoneyService = new MemberAccountMoneyService(new MemberAccountMoneyEFRepository());

		
		private MemberDto _member;
		private StockDailyPriceDto _dailyPrice;
		public FormTradeRightNow(MemberDto member, StockDailyPriceDto dailyPrice)
		{
			InitializeComponent();
			_member = member;
			_dailyPrice = dailyPrice;

			this.Load += FormTradeRightNow_Load;
			this.textBoxAmount.Leave += TextBoxAmount_Leave;
			this.buttonSend.Click += ButtonSend_Click;
		}

		private void ButtonSend_Click(object sender, EventArgs e)
		{
			if(TextAmountCheck() && RadioBuyOrSaleCheck())
			{
				try
				{
					int stated = -1;
					if (radioButtonBuy.Checked) stated = 1; //買
					if (radioButtonSale.Checked) stated = 2; // 賣

					MemberAccountMoneyDto accountDto =  _memberAccountMoneyService.GetByMemberId(_member.Id);

					TradeDataDto dto = new TradeDataDto
					{
						MemberId = _member.Id,
						CompanyId = _dailyPrice.CompanyId,
						StateId = stated,
						Datetime = DateTime.Now,
						Price = _dailyPrice.Closing,
						Amount = double.TryParse( textBoxAmount.Text, out double amount)? amount: 0,
						AccountMoneyStart = accountDto.LatestAccount,
					};
					// 執行交易
					_tradeDataService.TradeStock(dto);

					MessageBox.Show("交易成功");

					//radioButtonBuy.Checked = false;
					//radioButtonSale.Checked = false;
					//textBoxAmount.Text = string.Empty;
					this.Owner.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("交易失敗 "+ex.Message);
				}
			}
		}

		private void TextBoxAmount_Leave(object sender, EventArgs e)
		{
			TextAmountCheck();
		}

		private void FormTradeRightNow_Load(object sender, EventArgs e)
		{
			labelAmountCheck.Text = string.Empty;
			labelBuyOrSellCheck.Text = string.Empty;
		}

		private bool TextAmountCheck()
		{
			string amount;
			try
			{
				amount = textBoxAmount.Text.FormTextInputCheck();
			}
			catch (Exception ex)
			{
				labelAmountCheck.Text = ex.Message;
				return false;
			}

			bool parse = int.TryParse(amount, out int amountInt);
			if (!parse || amountInt <= 0)
			{
				labelAmountCheck.Text = "請輸入正整數";
				return false;
			}
			else
			{
				labelAmountCheck.Text = string.Empty;
				return true;
			}
		}

		private bool RadioBuyOrSaleCheck()
		{
			if (radioButtonBuy.Checked || radioButtonSale.Checked )
			{
				labelAmountCheck.Text = string.Empty;
				return true;
			}
			else
			{
				labelAmountCheck.Text = "選選擇買或賣";
				return false;
			}

		}
	}
}
