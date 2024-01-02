using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Interfaces;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Services
{
	public class StockDailyPriceService 
	{
		private IStockDailyPriceRepository _repository;

        public StockDailyPriceService(IStockDailyPriceRepository repo)
        {
            _repository = repo;
        }
		public int Creat(StockDailyPriceDto dto)
		{
			throw new NotImplementedException();
		}
		
		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public StockDailyPriceDto Get(int id)
		{
			return _repository.Get(id);
		}

		public StockDailyPriceDto GetLastTradeByCompanyId(int companyId)
		{
			return _repository.GetLastTradeByCompanyId(companyId);
		}

		public List<StockDailyPriceDto> SearchByDate(int companyId, DateTime startDT, DateTime endDT)
		{
			return _repository.SearchByDate(companyId, startDT, endDT);
		}

		public List<StockDailyPriceDto> SearchCode(string code)
		{
			throw new NotImplementedException();
		}

		public List<StockDailyPriceDto> SearchName(string name)
		{
			throw new NotImplementedException();
		}

		public void Update(StockDailyPriceDto dto)
		{
			throw new NotImplementedException();
		}
	}
}
