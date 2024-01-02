using Achi.Stock.Winform.test.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Interfaces
{
	public interface ITradeDateIntrustRepository
	{
		int Creat(TradeDateIntrustDto dto);
		List<TradeDateIntrustDto> SearchName(string name);
		List<TradeDateIntrustDto> SearchMember(int id);
		void Update(TradeDateIntrustDto dto);
		void Delete(int id);

		TradeDateIntrustDto Get(int id);
	}
}
