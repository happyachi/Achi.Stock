using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Core
{
	public class HelperMethod
	{
		/// <summary>
		/// 把原始string的民國年月日，轉換成西元DateTime格式
		/// </summary>
		/// <param name="dateString"></param>
		/// <returns></returns>
		public static DateTime TaiwanDateToDateTime(string dateString)
		{
			string[] strings = dateString.Split('/');

			int year , month , day ;
			year = Convert.ToInt32(strings[0]) + 1911;
			month = Convert.ToInt32(strings[1]);
			day = Convert.ToInt32(strings[2]);
			return new DateTime(year, month, day);
		}
	}
}
