using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Interfaces;
using Achi.Stock.Winform.test.Models.Repositories;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achi.Stock.Winform.test.Models.Services
{
	public class TradeDataService 
	{
		private MemberAccountStockService _memberAccountStockService = new MemberAccountStockService(new MemberAccountStockEFRepository());

		private MemberAccountMoneyService _memberAccountMoneyService = new MemberAccountMoneyService(new MemberAccountMoneyEFRepository());

		private ITradeDataRepository _tradeDataRepository;
		public TradeDataService(ITradeDataRepository repo) 
		{ 
			_tradeDataRepository = repo;
		}
		public void TradeStock(TradeDataDto inputDto)
		{
			if (inputDto.StateId == 1)
			{
				BuyStock(inputDto);
			}
			else if (inputDto.StateId == 2)
			{
				SaleStock(inputDto);
			}
			else
			{
				throw new Exception("交易類別有誤");
			}

		}

		private void BuyStock(TradeDataDto inputDto)
		{
			int totalPrice = 0;
			// todo 這是"買"要補商業邏輯。
			// 買進手續費：股票買進成本 x 0.1425%
			totalPrice = (int)(inputDto.Price * 1000 * inputDto.Amount * (1 + 0.001425));
			if ((decimal)totalPrice > inputDto.AccountMoneyStart)
			{
				throw new Exception("購買金額大於持有現金！");
			}
			inputDto.AccountMoneyEnd = inputDto.AccountMoneyStart - totalPrice;

			
			List<MemberAccountStockDto> stockDtos = new List<MemberAccountStockDto>();
			try
			{
				stockDtos = _memberAccountStockService.SearchByMemberId(inputDto.MemberId);
				try
				{
					MemberAccountStockDto stockDto = stockDtos.Where(s => s.StockId == inputDto.CompanyId).SingleOrDefault();
					if(stockDto is null)
					{
						// 如果未有此公司持股，則增加
						// 新增交易紀錄 
						Create(inputDto);

						// 新增股票持有項目
						MemberAccountStockDto accountStockDto = new MemberAccountStockDto 
						{ 
						MemberId = inputDto.MemberId,
						StockId = inputDto.CompanyId,
						Amount = inputDto.Amount,
						BuyPrice =(double)inputDto.Price
						};
						_memberAccountStockService.Creat(accountStockDto);

						// 修改帳戶餘額
						MemberAccountMoneyDto accountMoney = _memberAccountMoneyService.GetByMemberId(inputDto.MemberId);
						accountMoney.LatestAccount = inputDto.AccountMoneyEnd;
						_memberAccountMoneyService.Update(accountMoney);
					}
					else
					{
						// 如果有找到 新增交易紀錄
						Create(inputDto);

						// 修改account stock數量及成本
						// 如果已持有，則只加數量，並計算平均成本
						_memberAccountStockService.Update(stockDto, inputDto);

						// 修改帳戶餘額
						MemberAccountMoneyDto accountMoney = _memberAccountMoneyService.GetByMemberId(inputDto.MemberId);
						accountMoney.LatestAccount = inputDto.AccountMoneyEnd;
						_memberAccountMoneyService.Update(accountMoney);
					}
				}
				catch (Exception ex)
				{
					throw new Exception($"{ex.Message}");
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"{ex.Message}");
			}
		}

		private void SaleStock(TradeDataDto inputDto)
		{
			// todo 這是"賣"要補商業邏輯。
			try
			{
				List<MemberAccountStockDto>  stockDtos = _memberAccountStockService.SearchByMemberId(inputDto.MemberId);
				MemberAccountStockDto stockDto = stockDtos.Where(s => s.StockId == inputDto.CompanyId).SingleOrDefault();
				if (stockDto is null)
				{
					// 要去確認是否有持股
					// 找不到丟出例外
					throw new Exception("未持有股票！");
				}
				else
				{
					// 要去確認數量是否足夠
					if (inputDto.Amount > stockDto.Amount) {
						throw new Exception("賣超過持股數量！");
					}
					
					// 如果有找到 新增交易紀錄
					 Create(inputDto);

					// 修改帳戶餘額
					//賣出：手續費(股票賣出成本 x 0.1425 %) + 稅額(股票賣出成本 x 0.3 %)
					int totalPrice = (int)(inputDto.Price * 1000 * inputDto.Amount * (1 - 0.001425 - 0.003));
					inputDto.AccountMoneyEnd = inputDto.AccountMoneyStart + totalPrice;

					MemberAccountMoneyDto accountMoney = _memberAccountMoneyService.GetByMemberId(inputDto.MemberId);
					accountMoney.LatestAccount = inputDto.AccountMoneyEnd;
					_memberAccountMoneyService.Update(accountMoney);

					// 修改account stock數量及成本
					// 如果已持有，則只加數量，並計算平均成本
					inputDto.Amount = -inputDto.Amount;
					_memberAccountStockService.Update(stockDto, inputDto);

					
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private void Create(TradeDataDto inputDto)
		{
			_tradeDataRepository.Creat(inputDto);
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public TradeDataDto Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<TradeDataDto> SearchMember(int id)
		{
			return _tradeDataRepository.SearchMember(id);
		}

		public List<TradeDataDto> SearchName(string name)
		{
			throw new NotImplementedException();
		}

		public List<TradeDataDto> SearchByCompaniesAndDate(MemberDto member, List<StockCompanyDto> companiesList, DateTime startDate, DateTime endTime)
		{
			//_memberAccountStockService.
			List<int> companiesIdList = new List<int>();
			companiesList.ForEach(c => companiesIdList.Add(c.Id));

			List<TradeDataDto> tradeDataDtosResult = new List<TradeDataDto>();

			List<TradeDataDto> tradeDataDtos = SearchMember(member.Id);

			foreach (var item in companiesIdList)
			{
				List<TradeDataDto> dtos = new List<TradeDataDto>();
				dtos = (tradeDataDtos.Where(x => x.CompanyId == item).ToList());

				if (dtos.Count > 0)
				{
					foreach (var d in dtos)
					{
						tradeDataDtosResult.Add(d);
					}
				}
			}
			
			return tradeDataDtosResult;

		}

		public void Update(TradeDataDto dto)
		{
			throw new NotImplementedException();
		}
	}
}
