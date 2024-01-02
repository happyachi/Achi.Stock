using Achi.Stock.Winform.test.Models.EFModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test.Models.Dtos
{
	public class StockMarketDto
	{
		public int Id { get; set; }
		public string Market { get; set; }

	}
}
