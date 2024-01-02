using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Dtos
{
	public class TradeDataDto
	{
		public int Id { get; set; }

		public int MemberId { get; set; }

		public int CompanyId { get; set; }

		public int StateId { get; set; }

		public DateTime Datetime { get; set; }

		public double? Price { get; set; }

		public double Amount { get; set; }

		public decimal AccountMoneyStart { get; set; }

		public decimal AccountMoneyEnd { get; set; }
	}
}
