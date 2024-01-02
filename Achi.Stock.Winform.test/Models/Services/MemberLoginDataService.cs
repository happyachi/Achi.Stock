using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Services
{

	internal class MemberLoginDataService
	{
        private IMemberLoginDataRopository _repository;
        public MemberLoginDataService(IMemberLoginDataRopository repo)
        {
            _repository = repo;
        }

		public int Creat(MemberLoginDataDto dto)
		{
			return _repository.Creat(dto);
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public MemberLoginDataDto Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<MemberLoginDataDto> SearchMemberId(int memberId)
		{
			return _repository.SearchMemberId(memberId);
		}

		public void Update(MemberLoginDataDto dto)
		{
			throw new NotImplementedException();
		}
	}
}
