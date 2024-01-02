using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Repositories;
using Achi.Stock.Winform.test.Models.Services;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achi.Stock.Winform.test
{
	internal static class Program
	{
		/// <summary>
		/// 應用程式的主要進入點。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// 臨時 dto
			MemberDto dto = new MemberDto
			{
				Id = 4,
				Name = "a",
				Account = "123456",
				Password = "123456",
				Birthday = new DateTime(2023, 12, 6),
				Email = "a",
				FavoriteThing = "a",
				RegisterTime = new DateTime(2023, 12, 6, 23, 10, 8),
				Permission = true,
				IsAdmin = false
			};

			
			//Application.Run(new FormBase(dto));
			//Application.Run(new FormUseApiGetStockPrice());

			Application.Run(new FormLogin());

		}

	}
}
