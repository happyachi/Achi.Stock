using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.EFModels;
using Achi.Stock.Winform.test.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;
using Member = Achi.Stock.Winform.test.Models.EFModels.Member;

namespace Achi.Stock.Winform.test.Models.Repositories
{
	public class MemberEFRepository : IMemberRepository
	{
		public bool CheckAccountNotExist(string account)
		{
			var db = new AppDBContext();
			try
			{
				Member member = db.Members.Where(m => m.Account == account).First();
				return false;
			}
			catch (Exception)
			{
				return true;
			}
			
		}


		public int Creat(MemberDto dto)
		{
			var db = new AppDBContext();

			var member = new Member
			{
				Name = dto.Name,
				Account = dto.Account,
				Password = dto.Password,
				Birthday = dto.Birthday,
				Email = dto.Email,
				FavoriteThing = dto.FavoriteThing,
				RegisterTime = dto.RegisterTime,
				Permission = dto.Permission,
				IsAdmin = dto.IsAdmin
			};

			db.Members.Add(member);
			db.SaveChanges();

			return member.Id;
		}

		public void Delete(int id)
		{
			var db = new AppDBContext();

			Member member = db.Members.Find(id);

			db.Members.Remove(member);
			db.SaveChanges();
		}

		public MemberDto Get(int id)
		{
			var db = new AppDBContext();
			Member member = db.Members.Find(id);

			var dto = new MemberDto
			{
				Id = id,
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

			return dto;
		}

		public List<MemberDto> GetAllList()
		{
			var db = new AppDBContext();
			List<MemberDto> members = db.Members
									.Select(member => new MemberDto
									{
										Id = member.Id,
										Name = member.Name,
										Account = member.Account,
										Password = member.Password,
										Birthday = member.Birthday,
										Email = member.Email,
										FavoriteThing = member.FavoriteThing,
										RegisterTime = member.RegisterTime,
										Permission = member.Permission,
										IsAdmin = member.IsAdmin
									})
									.ToList();
			return members;
		}

		public MemberDto GetByAccountAndPassword(string account, string password)
		{
			var db = new AppDBContext();
			Member member = db.Members
						.Where(x => x.Account == account && x.Password == password)
						.Single();

			MemberDto dto = new MemberDto
			{
				Id = member.Id,
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

			return dto;
		}

		public MemberDto GetForgetPassword(string account, string email, string favorite)
		{
			var db = new AppDBContext();
			Member member = db.Members
						.Where(x => x.Account == account && x.Email == email && x.FavoriteThing == favorite)
						.Single();

			MemberDto dto = new MemberDto
			{
				Id = member.Id,
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

			return dto;
		}

		public List<MemberDto> SearchName(string name)
		{
			var db = new AppDBContext();

			List<Member> members = db.Members
									.Where(m => m.Name.Contains(name))
									.ToList();

			List<MemberDto> dtos = new List<MemberDto>();

			foreach (Member member in members)
			{
				dtos.Add(new MemberDto
				{
					Id = member.Id,
					Name = member.Name,
					Account = member.Account,
					Password = member.Password,
					Birthday = member.Birthday,
					Email = member.Email,
					FavoriteThing = member.FavoriteThing,
					RegisterTime = member.RegisterTime,
					Permission = member.Permission,
					IsAdmin = member.IsAdmin
				});
			}

			return dtos;
		}

		public void Update(MemberDto dto)
		{
			var db = new AppDBContext();

			var member = db.Members.Find(dto.Id);

			member.Name = dto.Name;
			member.Account = dto.Account;
			member.Password = dto.Password;
			member.Birthday = dto.Birthday;
			member.Email = dto.Email;
			member.FavoriteThing = dto.FavoriteThing;
			member.RegisterTime = dto.RegisterTime;
			member.Permission = dto.Permission;
			member.IsAdmin = dto.IsAdmin;

			db.SaveChanges();
		}
	}
}
