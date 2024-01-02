using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Services
{
	public class StockDailyTAIEXService
	{
		private IStockDailyTAIEXRepository _repository;

        public StockDailyTAIEXService(IStockDailyTAIEXRepository repo)
        {
			_repository = repo;
		}

        public int Creat(StockDailyTAIEXDto dto)
		{
			return _repository.Creat(dto);
		}

		public void Delete(int id)
		{
			_repository.Delete(id);
		}

		public StockDailyTAIEXDto Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<StockDailyTAIEXDto> SearchName(string name)
		{
			throw new NotImplementedException();
		}

		public StockDailyTAIEXDto GetByDate(DateTime date)
		{
			return _repository .GetByDate(date);
		}
		public List<StockDailyTAIEXDto> SearchByDate(DateTime start, DateTime end)
		{
			return _repository.SearchByDate(start, end);
		}

		public void Update(StockDailyTAIEXDto dto)
		{
			_repository.Update(dto);
		}
	}
}
