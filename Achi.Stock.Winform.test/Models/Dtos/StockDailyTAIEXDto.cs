using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Dtos
{
	public class StockDailyTAIEXDto
	{
		public int Id { get; set; }

		public DateTime? Date { get; set; }

		public double? Opening { get; set; }

		public double? Highest { get; set; }

		public double? Lowest { get; set; }

		public double? Closing { get; set; }
	}
}
