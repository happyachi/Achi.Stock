using Achi.Stock.Winform.test.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Interfaces
{
	public interface IMemberLoginDataRopository
	{
		int Creat(MemberLoginDataDto dto);
		List<MemberLoginDataDto> SearchMemberId(int memberId);
		void Update(MemberLoginDataDto dto);
		void Delete(int id);

		MemberLoginDataDto Get(int id);
	}
}
