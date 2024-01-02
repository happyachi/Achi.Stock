using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Services
{
	internal class MemberAccountStockService 
	{
		private IMemberAccountStockRepository _memberAccountStockRepository;

        public MemberAccountStockService(IMemberAccountStockRepository repo)
        {
            _memberAccountStockRepository = repo;
        }
        public int Creat(MemberAccountStockDto dto)
		{
			return _memberAccountStockRepository.Creat(dto);
		}

		public void Delete(int id)
		{
			_memberAccountStockRepository.Delete(id);
		}

		public MemberAccountStockDto Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<MemberAccountStockDto> SearchByMemberId(int memberId)
		{
			return _memberAccountStockRepository.SearchByMemberId(memberId);
		}


		public List<MemberAccountStockDto> GetAllList()
		{
			return _memberAccountStockRepository.GetAllAccountStock();
		}

		public void Update(MemberAccountStockDto dto, TradeDataDto tradeData)
		{
			MemberAccountStockDto originDto = _memberAccountStockRepository.Get(dto.Id);
			
			if (tradeData.Amount > 0) // 買
			{
				originDto.BuyPrice = (((double)tradeData.Price * tradeData.Amount)+(originDto.BuyPrice * originDto.Amount))/(tradeData.Amount+ originDto.Amount);
			}
			if( originDto.Amount == -tradeData.Amount) // 賣光時
			{
				_memberAccountStockRepository.Delete(dto.Id);
				return;
			}
			originDto.Amount += tradeData.Amount;
			_memberAccountStockRepository.Update(originDto);
		}
	}
}
