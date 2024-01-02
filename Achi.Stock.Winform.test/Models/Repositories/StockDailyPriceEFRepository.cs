using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.EFModels;
using Achi.Stock.Winform.test.Models.Interfaces;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Achi.Stock.Winform.test.Models.Repositories
{
	public class StockDailyPriceEFRepository : IStockDailyPriceRepository
	{
		public int Creat(StockDailyPriceDto dto)
		{
			var db = new AppDBContext();

			StockDailyPrice stock = new StockDailyPrice
			{
				CompanyId = dto.CompanyId,
				Date = dto.Date,
				Highest = dto.Highest,
				Lowest = dto.Lowest,
				Opening = dto.Opening,
				Closing = dto.Closing,
				Amount = dto.Amount,
				Volume = dto.Volume,
			};

			db.StockDailyPrices.Add(stock);
			db.SaveChanges();

			return stock.Id;
		}

		public void Delete(int id)
		{
			var db = new AppDBContext();

			StockDailyPrice stock = db.StockDailyPrices.Find(id);
			db.StockDailyPrices.Remove(stock);
			db.SaveChanges();
		}

		public StockDailyPriceDto Get(int id)
		{
			throw new NotImplementedException();

		}

		public StockDailyPriceDto GetLastTradeByCompanyId(int companyId)
		{
			var db = new AppDBContext();
			StockDailyPriceDto data = db.StockDailyPrices
												.AsNoTracking()
												.Where(x => x.CompanyId == companyId)
												.OrderByDescending(x => x.Date)
												.Select(x => new StockDailyPriceDto
												{
													Id = x.Id,
													CompanyId = x.CompanyId,
													Date = x.Date,
													Highest = x.Highest,
													Lowest = x.Lowest,
													Opening = x.Opening,
													Closing = x.Closing,
													Amount = x.Amount,
													Volume = x.Volume,
												}).First();
			return data;
		}

		public List<StockDailyPriceDto> SearchByDate(int companyId, DateTime startDT, DateTime endDT)
		{
			var db = new AppDBContext();

			if(companyId < 0)
			{
				List<StockDailyPriceDto> dataAll = db.StockDailyPrices
												.AsNoTracking()
												.Where(x => x.Date >= startDT && x.Date <= endDT)
												.Select(x => new StockDailyPriceDto
												{
													Id = x.Id,
													CompanyId = x.CompanyId,
													Date = x.Date,
													Highest = x.Highest,
													Lowest = x.Lowest,
													Opening = x.Opening,
													Closing = x.Closing,
													Amount = x.Amount,
													Volume = x.Volume,
												}).ToList();
				return dataAll;
			}
			List<StockDailyPriceDto> data = db.StockDailyPrices
												.AsNoTracking()
												.Where(x => x.CompanyId == companyId && x.Date >= startDT && x.Date <= endDT)
												.Select(x=> new StockDailyPriceDto
												{
													Id = x.Id,
													CompanyId = x.CompanyId,
													Date = x.Date,
													Highest = x.Highest,
													Lowest = x.Lowest,
													Opening = x.Opening,
													Closing = x.Closing,
													Amount = x.Amount,
													Volume = x.Volume,
												}).ToList();
			return data;
		}



		public List<StockDailyPriceDto> SearchCode(string code)
		{
			var db = new AppDBContext();

			var query = from dailyPrice in db.StockDailyPrices
						join company in db.StockCompanys on dailyPrice.CompanyId equals company.Id
						where company.Code.Contains(code)
						select dailyPrice;

			List<StockDailyPrice> stocks = query.ToList();
			List<StockDailyPriceDto> dtos = new List<StockDailyPriceDto>();

			foreach (StockDailyPrice stock in stocks)
			{
				dtos.Add(new StockDailyPriceDto
				{
					Id = stock.Id,
					CompanyId = stock.CompanyId,
					Date = stock.Date,
					Highest = stock.Highest,
					Lowest = stock.Lowest,
					Opening = stock.Opening,
					Closing = stock.Closing,
					Amount = stock.Amount,
					Volume = stock.Volume
				});
			}

			return dtos;
		}

		public List<StockDailyPriceDto> SearchName(string name)
		{
			var db = new AppDBContext();

			var query = from dailyPrice in db.StockDailyPrices
						join company in db.StockCompanys on dailyPrice.CompanyId equals company.Id
						where company.Name.Contains(name)
						select dailyPrice;

			List <StockDailyPrice> stocks = query.ToList();
			List<StockDailyPriceDto> dtos = new List<StockDailyPriceDto>();

			foreach (StockDailyPrice stock in stocks)
			{
				dtos.Add(new StockDailyPriceDto
				{
					Id = stock.Id,
					CompanyId = stock.CompanyId,
					Date = stock.Date,
					Highest = stock.Highest,
					Lowest = stock.Lowest,
					Opening = stock.Opening,
					Closing = stock.Closing,
					Amount = stock.Amount,
					Volume = stock.Volume
				});
			}

			return dtos;
		}

		public void Update(StockDailyPriceDto dto)
		{
			var db = new AppDBContext();

			StockDailyPrice dailyPrice = db.StockDailyPrices.Find(dto.Id);

			dailyPrice.Id = dto.Id;
			dailyPrice.CompanyId = dto.CompanyId;
			dailyPrice.Date = dto.Date;
			dailyPrice.Highest = dto.Highest;
			dailyPrice.Lowest = dto.Lowest;
			dailyPrice.Opening = dto.Opening;
			dailyPrice.Closing = dto.Closing;
			dailyPrice.Amount = dto.Amount;
			dailyPrice.Volume = dto.Volume;

			db.SaveChanges();
		}
	}
}
