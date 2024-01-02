using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Winform.test
{
	public static class Helper
	{
		public static string FormTextInputCheck(this string input)
		{
			if (string.IsNullOrWhiteSpace(input)) throw new Exception("欄位不得為空值");
			return input;
		}

		public static string FormTextAccountAndPasswordCheck(this string input)
		{
			input = input.FormTextInputCheck();

			if (input.Length < 6) throw new Exception("請輸入不得少於6個字元");
			return input;

		}
	}
}
