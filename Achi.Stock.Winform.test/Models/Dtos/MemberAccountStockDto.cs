using Achi.Stock.Winform.test.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Dtos
{
	public partial class MemberAccountStockDto
	{
		public int Id { get; set; }

		public int MemberId { get; set; }

		public int StockId { get; set; }

		public double Amount { get; set; }

		public double BuyPrice { get; set; }

	}
}
