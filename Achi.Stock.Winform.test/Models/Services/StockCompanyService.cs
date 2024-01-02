using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Interfaces;
using DocumentFormat.OpenXml.EMMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Services
{
	public class StockCompanyService 
	{
		private IStockCompanyRepository _repository;

        public StockCompanyService(IStockCompanyRepository repo)
        {
            _repository = repo;
        }

        public int Creat(StockCompanyDto dto)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public StockCompanyDto Get(int id)
		{
			return _repository.Get(id);
		}

		public List<StockCompanyDto> SearchCode(string code)
		{
			return _repository.SearchCode(code);
		}

		public List<StockCompanyDto> SearchName(string name)
		{
			return _repository.SearchCode(name);
		}
		public List<StockCompanyDto> SearchNameAndCode(string name, string code)
		{
			return _repository.SearchNameAndCode(name, code);
		}

		public void Update(StockCompanyDto dto)
		{
			throw new NotImplementedException();
		}
	}
}
