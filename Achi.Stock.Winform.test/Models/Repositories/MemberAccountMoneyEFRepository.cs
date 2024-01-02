using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.EFModels;
using Achi.Stock.Winform.test.Models.Interfaces;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Repositories
{
	public class MemberAccountMoneyEFRepository : IMemberAccountMoneyRepository
	{
		public int Creat(MemberAccountMoneyDto dto)
		{
			var db = new AppDBContext();

			var memberAccount = new MemberAccountMoney
			{
				MemberId = dto.MemberId,
				OriginalAccount = dto.OriginalAccount,
				LatestAccount = dto.LatestAccount,
			};

			db.MemberAccountMoneys.Add(memberAccount);
			db.SaveChanges();

			return memberAccount.Id;
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<MemberAccountMoneyDto> GetAllAccountMoney()
		{
			var db = new AppDBContext();
			List<MemberAccountMoneyDto>  all = db.MemberAccountMoneys
													.Select(i => new MemberAccountMoneyDto
													{
														Id = i.Id,
														MemberId = i.MemberId,
														OriginalAccount = i.OriginalAccount,
														LatestAccount = i.LatestAccount
													}).ToList();
			return all;
		}

		public MemberAccountMoneyDto GetByMemberId(int memberId)
		{
			var db = new AppDBContext();

			MemberAccountMoney memberAccount = db.MemberAccountMoneys
													.Where(c=> c.MemberId == memberId)
													.Single();

			var dto = new MemberAccountMoneyDto
			{
				Id = memberAccount.Id,
				MemberId = memberAccount.MemberId,
				OriginalAccount = memberAccount.OriginalAccount,
				LatestAccount = memberAccount.LatestAccount,

			};
			return dto;
		}

		public List<MemberAccountMoneyDto> SearchId(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(MemberAccountMoneyDto dto)
		{
			var db = new AppDBContext();

			MemberAccountMoney memberAccount = db.MemberAccountMoneys.Find(dto.Id);

			memberAccount.MemberId = dto.MemberId;
			memberAccount.OriginalAccount = dto.OriginalAccount;
			memberAccount.LatestAccount = dto.LatestAccount;

			db.SaveChanges();
		}
	}
}
