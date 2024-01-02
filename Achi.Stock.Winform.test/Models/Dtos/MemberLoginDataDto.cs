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
	public class MemberLoginDataDto
	{
		public int Id { get; set; }

		public int MemberId { get; set; }

		public DateTime Datetime { get; set; }

		public string IP { get; set; }

	}
}
