using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Services
{
	internal class MemberAccountMoneyService 
	{
		private IMemberAccountMoneyRepository _accountMoneyRepository;
        public MemberAccountMoneyService(IMemberAccountMoneyRepository repo)
        {
            _accountMoneyRepository = repo;
        }
        public int Creat(MemberAccountMoneyDto dto)
		{
			return _accountMoneyRepository.Creat(dto);
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public MemberAccountMoneyDto GetByMemberId(int memberId)
		{
			return _accountMoneyRepository.GetByMemberId(memberId);
		}

		public List<MemberAccountMoneyDto> SearchId(int id)
		{
			throw new NotImplementedException();
		}

		public List<MemberAccountMoneyDto> GetAllList()
		{
			return _accountMoneyRepository.GetAllAccountMoney();
		}

		public void Update(MemberAccountMoneyDto dto)
		{
			_accountMoneyRepository.Update(dto);
		}
	}
}
