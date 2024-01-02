using Achi.Stock.Winform.test.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Interfaces
{
	public interface IStockDailyPriceRepository
	{
		int Creat(StockDailyPriceDto dto);
		List<StockDailyPriceDto> SearchName(string name);
		List<StockDailyPriceDto> SearchCode(string code);
		List<StockDailyPriceDto> SearchByDate(int companyId, DateTime startDT, DateTime endDT);
		StockDailyPriceDto GetLastTradeByCompanyId(int companyId);
		void Update(StockDailyPriceDto dto);
		void Delete(int id);

		StockDailyPriceDto Get(int id);
	}
}
