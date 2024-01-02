using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.EFModels;
using Achi.Stock.Winform.test.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Repositories
{
	public class MemberAccountStockEFRepository : IMemberAccountStockRepository
	{
		public int Creat(MemberAccountStockDto dto)
		{
			var db = new AppDBContext();

			var memberAccount = new MemberAccountStock
			{
				MemberId = dto.MemberId,
				StockId = dto.StockId,
				Amount = dto.Amount,
				BuyPrice = dto.BuyPrice
			};

			db.MemberAccountStocks.Add(memberAccount);
			db.SaveChanges();

			return memberAccount.Id;
		}

		public void Delete(int id)
		{
			var db = new AppDBContext();
			MemberAccountStock memberAccount = db.MemberAccountStocks.Find(id);
			db.MemberAccountStocks.Remove(memberAccount);
			db.SaveChanges();
		}

		public MemberAccountStockDto Get(int id)
		{
			var db = new AppDBContext();

			MemberAccountStock memberAccount = db.MemberAccountStocks.Find(id);

			var dto = new MemberAccountStockDto
			{
				Id = memberAccount.Id,
				MemberId = memberAccount.MemberId,
				StockId = memberAccount.StockId,
				Amount = memberAccount.Amount,
				BuyPrice = memberAccount.BuyPrice
			};
			return dto;
		}

		public List<MemberAccountStockDto> GetAllAccountStock()
		{
			var db = new AppDBContext();
			List<MemberAccountStockDto> all = db.MemberAccountStocks
													.Select(i => new MemberAccountStockDto
													{
														Id = i.Id,
														MemberId = i.MemberId,
														StockId = i.StockId,
														Amount = i.Amount,
														BuyPrice = i.BuyPrice
													}).ToList();
			return all;
		}

		public List<MemberAccountStockDto> SearchByMemberId(int memberId)
		{
			var db = new AppDBContext();

			List<MemberAccountStockDto> dtos = db.MemberAccountStocks
												.AsNoTracking()
												.Where(m=>m.MemberId == memberId)
												.Select(x=> new MemberAccountStockDto
												{
													Id = x.Id,
													MemberId = x.MemberId,
													StockId = x.StockId,
													Amount = x.Amount,
													BuyPrice = x.BuyPrice
												})
												.ToList();
			return dtos;
		}


		public void Update(MemberAccountStockDto dto)
		{
			var db = new AppDBContext();

			MemberAccountStock memberAccount = db.MemberAccountStocks.Find(dto.Id);

			memberAccount.MemberId = dto.MemberId;
			memberAccount.StockId = dto.StockId;
			memberAccount.Amount = dto.Amount;
			memberAccount.BuyPrice = dto.BuyPrice;

			db.SaveChanges();
		}
	}
}
