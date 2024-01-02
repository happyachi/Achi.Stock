using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.EFModels;
using Achi.Stock.Winform.test.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Repositories
{
	public class StockDailyTAIEXEFRepository : IStockDailyTAIEXRepository
	{
		public int Creat(StockDailyTAIEXDto dto)
		{
			var db = new AppDBContext();
			StockDailyTAIEX dailyTAIEX = new StockDailyTAIEX
			{
				Date = dto.Date,
				Opening = dto.Opening,
				Highest = dto.Highest,
				Lowest = dto.Lowest,
				Closing = dto.Closing,
			};
			db.StockDailyTAIEXes.Add(dailyTAIEX);
			db.SaveChanges();

			return dailyTAIEX.Id;
		}

		public void Delete(int id)
		{
			var db = new AppDBContext();
			StockDailyTAIEX dailyTAIEX = db.StockDailyTAIEXes.Find(id);

			db.StockDailyTAIEXes.Remove(dailyTAIEX);
			db.SaveChanges();
		}

		public StockDailyTAIEXDto Get(int id)
		{
			throw new NotImplementedException();
		}

		public StockDailyTAIEXDto GetByDate(DateTime date)
		{
			var db = new AppDBContext();
			StockDailyTAIEXDto data = db.StockDailyTAIEXes
												.AsNoTracking()
												.Where(x => x.Date == date)
												.Select(x => new StockDailyTAIEXDto
												{
													Date = x.Date,
													Opening = x.Opening,
													Highest = x.Highest,
													Lowest = x.Lowest,
													Closing = x.Closing
												}).FirstOrDefault();
			return data;
		}

		public List<StockDailyTAIEXDto> SearchByDate(DateTime startDT, DateTime endDT)
		{
			var db = new AppDBContext();
			List<StockDailyTAIEXDto> data = db.StockDailyTAIEXes
												.AsNoTracking()
												.Where(x=>x.Date >= startDT && x.Date <= endDT)
												.Select(x=>new StockDailyTAIEXDto
												{
													Date = x.Date,
													Opening = x.Opening,
													Highest=x.Highest,
													Lowest=x.Lowest,
													Closing=x.Closing
												}).ToList();
			return data;

		}

		public List<StockDailyTAIEXDto> SearchName(string name)
		{
			throw new NotImplementedException();
		}

		public void Update(StockDailyTAIEXDto dto)
		{
			var db = new AppDBContext();
			StockDailyTAIEX dailyTAIEX = db.StockDailyTAIEXes.Find(dto.Id);

			dailyTAIEX.Id = dto.Id;
			dailyTAIEX.Date = dto.Date;
			dailyTAIEX.Opening = dto.Opening;
			dailyTAIEX.Highest = dto.Highest;
			dailyTAIEX.Lowest = dto.Lowest;
			dailyTAIEX.Closing = dto.Closing;

			db.SaveChanges();
		}
	}
}
