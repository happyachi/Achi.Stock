using Achi.Stock.Winform.test.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Interfaces
{
	public interface IMemberRepository
	{
		int Creat(MemberDto dto);
		List<MemberDto> SearchName(string name);
		List<MemberDto> GetAllList();
		void Update(MemberDto dto);
		void Delete(int id);

		MemberDto Get(int id);

		MemberDto GetByAccountAndPassword(string account, string password);
		MemberDto GetForgetPassword(string account, string email, string favorite);

		bool CheckAccountNotExist(string account);
	}
}
