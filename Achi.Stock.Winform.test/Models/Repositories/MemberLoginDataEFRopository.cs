using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.EFModels;
using Achi.Stock.Winform.test.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Achi.Stock.Winform.test.Models.Repositories
{
	public class MemberLoginDataEFRopository : IMemberLoginDataRopository
	{
		public int Creat(MemberLoginDataDto dto)
		{
			var db = new AppDBContext();

			var login = new MemberLoginData
			{
				MemberId = dto.MemberId,
				Datetime = dto.Datetime,
				IP = dto.IP,
			};

			db.MemberLoginDatas.Add(login);
			db.SaveChanges();

			return login.Id;
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
			var db = new AppDBContext();

			List<MemberLoginData> logins = db.MemberLoginDatas
									.Where(m => m.MemberId == memberId)
									.ToList();

			List<MemberLoginDataDto> dtos = new List<MemberLoginDataDto>();

			foreach (MemberLoginData login in logins)
			{
				dtos.Add(new MemberLoginDataDto
				{
					MemberId = login.MemberId,
					Datetime = login.Datetime,
					IP = login.IP,
				});
			}

			return dtos;
		}

		public void Update(MemberLoginDataDto dto)
		{
			throw new NotImplementedException();
		}
	}
}
