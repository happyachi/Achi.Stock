using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Services
{
	internal class TradeDataIntrustService 
	{
		private ITradeDateIntrustRepository _tradeDateIntrustRepository;
        public TradeDataIntrustService(ITradeDateIntrustRepository repo)
        {
            _tradeDateIntrustRepository = repo;
        }
        public int Creat(TradeDateIntrustDto dto)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public TradeDateIntrustDto Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<TradeDateIntrustDto> SearchMember(int id)
		{
			throw new NotImplementedException();
		}

		public List<TradeDateIntrustDto> SearchName(string name)
		{
			throw new NotImplementedException();
		}

		public void Update(TradeDateIntrustDto dto)
		{
			throw new NotImplementedException();
		}
	}
}
