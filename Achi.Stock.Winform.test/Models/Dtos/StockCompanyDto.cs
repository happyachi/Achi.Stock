using Achi.Stock.Winform.test.Models.EFModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Dtos
{
	public class StockCompanyDto
	{
		public int Id { get; set; }

		public int MarketId { get; set; }

		public string Code { get; set; }

		public string Name { get; set; }
	}
}
