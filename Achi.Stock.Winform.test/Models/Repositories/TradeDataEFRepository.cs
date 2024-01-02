using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.EFModels;
using Achi.Stock.Winform.test.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Achi.Stock.Winform.test.Models.Repositories
{
	public class TradeDataEFRepository : ITradeDataRepository
	{
		public int Creat(TradeDataDto dto)
		{
			var db = new AppDBContext();
			TradeData trade = new TradeData
			{
				MemberId = dto.MemberId,
				CompanyId = dto.CompanyId,
				StateId = dto.StateId,
				Datetime = dto.Datetime,
				Price =(double) dto.Price,
				Amount = dto.Amount,
				AccountMoneyStart = dto.AccountMoneyStart,
				AccountMoneyEnd = dto.AccountMoneyEnd
			};

			db.TradeDatas.Add(trade);
			db.SaveChanges();

			return trade.Id;
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public TradeDataDto Get(int id)
		{
			var db = new AppDBContext();

			TradeData tradeData = db.TradeDatas.Find(id);

			TradeDataDto dto = new TradeDataDto
			{
				Id = tradeData.Id,
				MemberId = tradeData.MemberId,
				CompanyId = tradeData.CompanyId,
				StateId = tradeData.StateId,
				Datetime = tradeData.Datetime,
				Price = tradeData.Price,
				Amount = tradeData.Amount,
				AccountMoneyStart = tradeData.AccountMoneyStart,
				AccountMoneyEnd = tradeData.AccountMoneyEnd
			};

			return dto;

		}

		public List<TradeDataDto> SearchMember(int id)
		{
			var db = new AppDBContext();

			List<TradeData> trades= db.TradeDatas
										.Where(x => x.MemberId == id)
										.OrderBy(x => x.Datetime)
										.ToList();

			List<TradeDataDto> dtos = new List<TradeDataDto>();

			foreach (var trade in trades)
			{
				dtos.Add(new TradeDataDto
				{
					MemberId = trade.MemberId,
					CompanyId = trade.CompanyId,
					StateId = trade.StateId,
					Datetime = trade.Datetime,
					Price = trade.Price,
					Amount = trade.Amount,
					AccountMoneyStart = trade.AccountMoneyStart,
					AccountMoneyEnd = trade.AccountMoneyEnd
				});
			}

			return dtos;
		}

		public List<TradeDataDto> SearchName(string name)
		{
			throw new NotImplementedException();
		}

		public void Update(TradeDataDto dto)
		{
			throw new NotImplementedException();

		}
	}
}
