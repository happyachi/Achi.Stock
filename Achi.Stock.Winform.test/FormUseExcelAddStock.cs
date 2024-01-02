using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Achi.Stock.Core;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Achi.Stock.Winform.test
{
	public partial class FormUseExcelAddStock : Form
	{
		public FormUseExcelAddStock()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string filePath = "D:\\code\\Stock上市公司 (1).xlsx";

			// 檢查檔案是否存在
			if (File.Exists(filePath))
			{
				// 讀取Excel檔案
				using (var package = new ExcelPackage(new FileInfo(filePath)))
				{
					ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
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
						for (int col = 1; col <= colCount; col += 2)
						{
							StockCompanyDto compnay = new StockCompanyDto();
							// 取得 Code
							string code = worksheet.Cells[row, col].Value.ToString().Trim();
							// 取得 Name
							string name = worksheet.Cells[row, col + 1].Value.ToString().Trim();

							compnay.MarketId = 1;
							compnay.Name = name;
							compnay.Code = code;

							StockCompanyEFRepository stock = new StockCompanyEFRepository();
							stock.Creat(compnay);

							// 在這裡處理單元格的值，例如輸出到控制台
							Console.WriteLine(count + "\t" + code + "\t" + name);
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
