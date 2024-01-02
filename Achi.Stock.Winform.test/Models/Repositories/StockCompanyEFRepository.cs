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
	public class StockCompanyEFRepository : IStockCompanyRepository
	{
		public int Creat(StockCompanyDto dto)
		{
			var db = new AppDBContext();

			var company = new StockCompany();

			company.MarketId = dto.MarketId;
			company.Code = dto.Code;
			company.Name = dto.Name;
			

			db.StockCompanys.Add(company);
			db.SaveChanges();

			return company.Id;
		}

		public void Delete(int id)
		{
			var db = new AppDBContext();

			StockCompany company = db.StockCompanys.Find(id);

			db.StockCompanys.Remove(company);
			db.SaveChanges();
		}

		public StockCompanyDto Get(int id)
		{
			var db = new AppDBContext();

			StockCompany company = db.StockCompanys.Find(id);
			StockCompanyDto dto = new StockCompanyDto
			{
				Id = company.Id,
				MarketId = company.MarketId,
				Code = company.Code,
				Name = company.Name
			};

			return dto;
		}

		public List<StockCompanyDto> SearchCode(string code)
		{
			var db = new AppDBContext();

			List<StockCompany> companies = db.StockCompanys
						.Where(u => u.Code.Contains(code))
						.ToList();

			List<StockCompanyDto> dtos = new List<StockCompanyDto>();

			foreach (StockCompany company in companies)
			{
				dtos.Add(new StockCompanyDto
				{

					MarketId = company.MarketId,
					Code = company.Code,
					Name = company.Name
				});
			}

			return dtos;
		}

		public List<StockCompanyDto> SearchCodeGetId(string code)
		{
			var db = new AppDBContext();

			List<StockCompany> companies = db.StockCompanys
						.Where(u => u.Code.Contains(code))
						.ToList();

			List<StockCompanyDto> dtos = new List<StockCompanyDto>();

			foreach (StockCompany company in companies)
			{
				dtos.Add(new StockCompanyDto
				{
					Id = company.Id,
					MarketId = company.MarketId,
					Code = company.Code,
					Name = company.Name
				});
			}

			return dtos;
		}



		public List<StockCompanyDto> SearchName(string name)
		{
			var db = new AppDBContext();

			List<StockCompany> companies = db.StockCompanys
						.Where(u => u.Name.Contains(name))
						.ToList();

			List<StockCompanyDto> dtos = new List<StockCompanyDto>();

			foreach (StockCompany company in companies)
			{
				dtos.Add(new StockCompanyDto
				{
					MarketId = company.MarketId,
					Code = company.Code,
					Name = company.Name
				});
			}

			return dtos;
		}

		public List<StockCompanyDto> SearchNameAndCode(string name, string code)
		{
			var db = new AppDBContext();

			List<StockCompany> companies = db.StockCompanys
						.Where(u => u.Code.Contains(code) && u.Name.Contains(name))
						.ToList();

			List<StockCompanyDto> dtos = new List<StockCompanyDto>();

			foreach (StockCompany company in companies)
			{
				dtos.Add(new StockCompanyDto
				{
					Id = company.Id,
					MarketId = company.MarketId,
					Code = company.Code,
					Name = company.Name
				});
			}

			return dtos;
		}

		public void Update(StockCompanyDto dto)
		{
			var db = new AppDBContext();

			var company = db.StockCompanys.Find(dto.Id);

			company.MarketId = dto.MarketId;
			company.Code = dto.Code;
			company.Name = dto.Name;

			db.SaveChanges();
		}
	}
}
