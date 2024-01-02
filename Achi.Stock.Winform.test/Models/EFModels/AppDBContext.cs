using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Achi.Stock.Winform.test.Models.EFModels
{
	public partial class AppDBContext : DbContext
	{
		public AppDBContext()
			: base("name=AppDBContext")
		{
		}

		public virtual DbSet<MemberAccountMoney> MemberAccountMoneys { get; set; }
		public virtual DbSet<MemberAccountStock> MemberAccountStocks { get; set; }
		public virtual DbSet<MemberLoginData> MemberLoginDatas { get; set; }
		public virtual DbSet<Member> Members { get; set; }
		public virtual DbSet<StockCompany> StockCompanys { get; set; }
		public virtual DbSet<StockDailyPrice> StockDailyPrices { get; set; }
		public virtual DbSet<StockDailyTAIEX> StockDailyTAIEXes { get; set; }
		public virtual DbSet<StockMarket> StockMarkets { get; set; }
		public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
		public virtual DbSet<TradeData> TradeDatas { get; set; }
		public virtual DbSet<TradeDateIntrust> TradeDateIntrusts { get; set; }
		public virtual DbSet<TradeStateIntrust> TradeStateIntrusts { get; set; }
		public virtual DbSet<TradeState> TradeStates { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MemberAccountMoney>()
				.Property(e => e.OriginalAccount)
				.HasPrecision(18, 0);

			modelBuilder.Entity<MemberAccountMoney>()
				.Property(e => e.LatestAccount)
				.HasPrecision(18, 0);

			modelBuilder.Entity<Member>()
				.HasMany(e => e.MemberAccountMoneys)
				.WithRequired(e => e.Member)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Member>()
				.HasMany(e => e.MemberAccountStocks)
				.WithRequired(e => e.Member)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Member>()
				.HasMany(e => e.MemberLoginDatas)
				.WithRequired(e => e.Member)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Member>()
				.HasMany(e => e.TradeDatas)
				.WithRequired(e => e.Member)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Member>()
				.HasMany(e => e.TradeDateIntrusts)
				.WithRequired(e => e.Member)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<StockCompany>()
				.HasMany(e => e.MemberAccountStocks)
				.WithRequired(e => e.StockCompany)
				.HasForeignKey(e => e.StockId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<StockCompany>()
				.HasMany(e => e.StockDailyPrices)
				.WithRequired(e => e.StockCompany)
				.HasForeignKey(e => e.CompanyId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<StockCompany>()
				.HasMany(e => e.TradeDatas)
				.WithRequired(e => e.StockCompany)
				.HasForeignKey(e => e.CompanyId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<StockCompany>()
				.HasMany(e => e.TradeDateIntrusts)
				.WithRequired(e => e.StockCompany)
				.HasForeignKey(e => e.CompanyId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<StockMarket>()
				.HasMany(e => e.StockCompanys)
				.WithRequired(e => e.StockMarket)
				.HasForeignKey(e => e.MarketId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<TradeData>()
				.Property(e => e.AccountMoneyStart)
				.HasPrecision(18, 0);

			modelBuilder.Entity<TradeData>()
				.Property(e => e.AccountMoneyEnd)
				.HasPrecision(18, 0);

			modelBuilder.Entity<TradeStateIntrust>()
				.HasMany(e => e.TradeDateIntrusts)
				.WithRequired(e => e.TradeStateIntrust)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<TradeState>()
				.HasMany(e => e.TradeDatas)
				.WithRequired(e => e.TradeState)
				.HasForeignKey(e => e.StateId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<TradeState>()
				.HasMany(e => e.TradeDateIntrusts)
				.WithRequired(e => e.TradeState)
				.WillCascadeOnDelete(false);
		}
	}
}
