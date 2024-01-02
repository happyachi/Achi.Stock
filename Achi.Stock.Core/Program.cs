using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Achi.Stock.Core
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//APIHistoryStockData f = new APIHistoryStockData();
			//f.GetHistoryByMonthAndStockCode("2330", "20220505");
			//f.show();

			//APIDailyStockData a = new APIDailyStockData();
			//a.GetDailyStockData();

			//APITaiexHistoryByDay t = new APITaiexHistoryByDay();
			//t.GetTaiexHistory("20230801");
			//t.show();
			//for(int i = 0; i<12; i++)
			//{
			//	DateTime dateTime = new DateTime(2023, 1, 01);
			//	Console.WriteLine(dateTime.AddMonths(i).ToString("yyyyMMdd"));
			// }

			var host = Dns.GetHostEntry(Dns.GetHostName());
			
			foreach (var ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					Console.WriteLine("IP Address = " + ip.ToString());
				}
			}


			//if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
			//{
			//	Console.WriteLine("No Network Available");
			//}

			//IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

			//var ippaddress =
			//	host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
			//Console.WriteLine(ippaddress);
		}
			
	}
}
