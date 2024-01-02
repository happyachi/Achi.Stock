using Achi.Stock.Winform.test.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Interfaces
{
	public interface IMemberAccountMoneyRepository
	{
		int Creat(MemberAccountMoneyDto dto);
		List<MemberAccountMoneyDto> SearchId(int id);
		List<MemberAccountMoneyDto> GetAllAccountMoney();
		void Update(MemberAccountMoneyDto dto);
		void Delete(int id);

		MemberAccountMoneyDto GetByMemberId(int memberId);
	}
}
