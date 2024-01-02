using Achi.Stock.Winform.test.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Interfaces
{
	public interface IStockCompanyRepository
	{
		int Creat(StockCompanyDto dto);
		List<StockCompanyDto> SearchName(string name);
		List<StockCompanyDto> SearchCode(string code);
		List<StockCompanyDto> SearchNameAndCode(string name, string code);
		void Update(StockCompanyDto dto);
		void Delete(int id);

		StockCompanyDto Get(int id);
	}
}
