using Achi.Stock.Winform.test.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Dtos
{
	public partial class MemberAccountMoneyDto
	{
		public int Id { get; set; }

		public int MemberId { get; set; }

		public decimal OriginalAccount { get; set; }

		public decimal LatestAccount { get; set; }

	}
}
