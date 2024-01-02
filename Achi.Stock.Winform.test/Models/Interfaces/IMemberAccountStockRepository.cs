using Achi.Stock.Winform.test.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Interfaces
{
	public interface IMemberAccountStockRepository
	{
		int Creat(MemberAccountStockDto dto);
		List<MemberAccountStockDto> SearchByMemberId(int memberId);
		List<MemberAccountStockDto> GetAllAccountStock();
		void Update(MemberAccountStockDto dto);
		void Delete(int id);

		MemberAccountStockDto Get(int id);



	}
}
