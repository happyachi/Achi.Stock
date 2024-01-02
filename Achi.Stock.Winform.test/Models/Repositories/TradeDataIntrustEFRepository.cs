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

namespace Achi.Stock.Winform.test.Models.Repositories
{
	internal class TradeDataIntrustEFRepository : ITradeDateIntrustRepository
	{
		public int Creat(TradeDateIntrustDto dto)
		{
			var db = new AppDBContext();

			TradeDateIntrust trade = new TradeDateIntrust
			{
				MemberId = dto.MemberId,
				CompanyId = dto.CompanyId,
				TradeStateId = dto.TradeStateId,
				TradeStateIntrustId = dto.TradeStateIntrustId,
				Price = dto.Price,
				Amount = dto.Amount,
				IntrustDatetime = dto.IntrustDatetime,
				IntrustLimitDatetime = dto.IntrustLimitDatetime
			};
			db.TradeDateIntrusts.Add(trade);
			db.SaveChanges();

			return trade.Id;
		}

		public void Delete(int id)
		{
			var db = new AppDBContext();

			TradeDateIntrust trade = db.TradeDateIntrusts.Find(id);
			db.TradeDateIntrusts.Remove(trade);
			db.SaveChanges();
		}

		public TradeDateIntrustDto Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<TradeDateIntrustDto> SearchMember(int id)
		{
			var db = new AppDBContext();

			List<TradeDateIntrust> trades = db.TradeDateIntrusts
												.Where(t=>t.MemberId == id)
												.ToList();
			List<TradeDateIntrustDto> dtos = new List<TradeDateIntrustDto>();

			foreach(var trade in trades)
			{
				dtos.Add(new TradeDateIntrustDto
				{
					Id = trade.Id,
					MemberId = trade.MemberId,
					CompanyId = trade.CompanyId,
					TradeStateId = trade.TradeStateId,
					TradeStateIntrustId = trade.TradeStateIntrustId,
					Price = trade.Price,
					Amount = trade.Amount,
					IntrustDatetime = trade.IntrustDatetime,
					IntrustLimitDatetime = trade.IntrustLimitDatetime,
					FinishDatetime = trade.FinishDatetime,
					TradeDataId = trade.TradeDataId,
				});
			}

			return dtos;
		}

		public List<TradeDateIntrustDto> SearchName(string name)
		{
			throw new NotImplementedException();
		}

		public void Update(TradeDateIntrustDto dto)
		{
			var db = new AppDBContext();

			TradeDateIntrust trade = db.TradeDateIntrusts.Find(dto.Id);

			trade.Id = dto.Id;
			trade.MemberId = dto.MemberId;
			trade.CompanyId = dto.CompanyId;
			trade.TradeStateId = dto.TradeStateId;
			trade.TradeStateIntrustId = dto.TradeStateIntrustId;
			trade.Price = dto.Price;
			trade.Amount = dto.Amount;
			trade.IntrustDatetime = dto.IntrustDatetime;
			trade.IntrustLimitDatetime = dto.IntrustLimitDatetime;
			trade.FinishDatetime = dto.FinishDatetime;
			trade.TradeDataId = dto.TradeDataId;

			db.SaveChanges();
		}
	}
}
