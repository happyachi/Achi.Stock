using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Interfaces
{
	public interface ITradeDataRepository
	{
		int Creat(TradeDataDto dto);
		List<TradeDataDto> SearchName(string name);
		List<TradeDataDto> SearchMember(int id);
		void Update(TradeDataDto dto);
		void Delete(int id);

		TradeDataDto Get(int id);
	}
}
