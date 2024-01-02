using Achi.Stock.Winform.test.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Interfaces
{
	public interface IStockDailyTAIEXRepository
	{
		int Creat(StockDailyTAIEXDto dto);
		List<StockDailyTAIEXDto> SearchName(string name);
		List<StockDailyTAIEXDto> SearchByDate(DateTime startDT, DateTime endDT);
		StockDailyTAIEXDto GetByDate(DateTime date);
		void Update(StockDailyTAIEXDto dto);
		void Delete(int id);

		StockDailyTAIEXDto Get(int id);
	}
}
