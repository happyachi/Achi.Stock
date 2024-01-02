using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Dtos
{
	public partial class MemberDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Account { get; set; }

		public string Password { get; set; }

		public DateTime Birthday { get; set; }

		public string Email { get; set; }

		public string FavoriteThing { get; set; }

		public DateTime RegisterTime { get; set; }

		public bool Permission { get; set; }

		public bool IsAdmin { get; set; }

	}
}
