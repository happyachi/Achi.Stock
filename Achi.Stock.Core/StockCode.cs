using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Achi.Stock.Core
{
	public class StockCompany
	{
        public string Code { get; set; }
		public string Name { get; set; }
    }
	public class StockCode
	{
		List<StockCompany> CompanysList = new List<StockCompany>();
		public static void KeyInsSockByExcel()
		{

			string filePath = "D:\\code\\Stock上市公司 (1).xlsx";

			// 檢查檔案是否存在
			if (File.Exists(filePath))
			{
				// 讀取Excel檔案
				using (var package = new ExcelPackage(new FileInfo(filePath)))
				{
					// 取得第一個工作表
					ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

					// 取得工作表的行數和列數
					int rowCount = worksheet.Dimension.Rows;
					int colCount = worksheet.Dimension.Columns;
					int count = 1;
					// 逐行讀取內容
					for (int row = 1; row <= rowCount; row++)
					{
						// 逐列讀取內容
						for (int col = 1; col <= colCount; col+=2)
						{
							StockCompany compnay = new StockCompany();
							// 取得 Code
							string code = worksheet.Cells[row, col].Value.ToString().Trim();
							// 取得 Name
							string name = worksheet.Cells[row, col+1].Value.ToString().Trim();


							compnay.Name = name;
							compnay.Code = code;




							// 在這裡處理單元格的值，例如輸出到控制台
							Console.WriteLine(count+"\t"+ code + "\t" + name);
							count++;
						}

						// 換行
						Console.WriteLine();
					}
				}
			}
			else
			{
				Console.WriteLine("檔案不存在： " + filePath);
			}
		}
	}
}
