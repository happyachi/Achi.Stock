using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Interfaces;
using Achi.Stock.Winform.test.Models.Repositories;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Services
{
	public class MemberService 
	{
		private MemberAccountMoneyService _accountMoneySerivce = new MemberAccountMoneyService(new MemberAccountMoneyEFRepository());
		private IMemberRepository _memberRepository;
        public MemberService(IMemberRepository repo)
        {
			_memberRepository = repo;
		}
        public int Creat(MemberDto dto)
		{
			return _memberRepository.Creat(dto);
		}

		public void Delete(int id)
		{
			_memberRepository.Delete(id);
		}

		public void Initialize(int memberId)
		{
			MemberDto member = Get(memberId);
			MemberDto tempMember = new MemberDto
			{
				Name = member.Name,
				Account = member.Account,
				Password = member.Password,
				Birthday = member.Birthday,
				Email = member.Email,
				FavoriteThing = member.FavoriteThing,
				RegisterTime = member.RegisterTime,
				Permission = member.Permission,
				IsAdmin = member.IsAdmin
			};
			Delete(member.Id);
			int newId = Creat(tempMember);

			// 要同時建立金錢帳戶
			
			MemberAccountMoneyDto accountDto = new MemberAccountMoneyDto
			{
				MemberId = newId,
				OriginalAccount = 1000000,
				LatestAccount = 1000000,
			};
			int countId = _accountMoneySerivce.Creat(accountDto);
		}

		public MemberDto Get(int id)
		{
			return _memberRepository.Get(id);
		}

		public List<MemberDto> SearchName(string name)
		{
			throw new NotImplementedException();
		}

		public List<MemberDto> GetAllList()
		{
			return _memberRepository.GetAllList();
		}

		public void Update(MemberDto dto)
		{
			_memberRepository.Update(dto);
		}

		public MemberDto GetByAccountAndPassword(string account, string password)
		{
			return _memberRepository.GetByAccountAndPassword(account, password);
		}

		public bool CheckAccountNotExist(string account)
		{
			return _memberRepository.CheckAccountNotExist(account);
		}

		public MemberDto GetForgetPassword(string account, string email, string favorite)
		{
			return _memberRepository.GetForgetPassword(account, email, favorite);
		}

	}
}
