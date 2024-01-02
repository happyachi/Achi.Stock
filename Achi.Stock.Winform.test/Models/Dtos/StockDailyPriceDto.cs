using Achi.Stock.Winform.test.Models.EFModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Dtos
{
	public class StockDailyPriceDto
	{
		public int Id { get; set; }

		public int CompanyId { get; set; }

		public DateTime Date { get; set; }

		public double? Highest { get; set; }

		public double? Lowest { get; set; }

		public double? Opening { get; set; }

		public double? Closing { get; set; }

		public double? Amount { get; set; }

		public double? Volume { get; set; }
	}
}
