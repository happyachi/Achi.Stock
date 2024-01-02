using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Dtos
{
	public class TradeDateIntrustDto
	{
		public int Id { get; set; }

		public int MemberId { get; set; }

		public int CompanyId { get; set; }

		public int TradeStateId { get; set; }

		public int TradeStateIntrustId { get; set; }

		public double Price { get; set; }

		public double Amount { get; set; }

		public DateTime IntrustDatetime { get; set; }

		public DateTime IntrustLimitDatetime { get; set; }

		public DateTime? FinishDatetime { get; set; }

		public int? TradeDataId { get; set; }
	}
}
