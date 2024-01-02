namespace Achi.Stock.Winform.test.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TradeDateIntrust
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int CompanyId { get; set; }

        public int TradeStateId { get; set; }

        public int TradeStateIntrustId { get; set; }

        public double Price { get; set; }

        public double Amount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime IntrustDatetime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime IntrustLimitDatetime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FinishDatetime { get; set; }

        public int? TradeDataId { get; set; }

        public virtual Member Member { get; set; }

        public virtual StockCompany StockCompany { get; set; }

        public virtual TradeData TradeData { get; set; }

        public virtual TradeStateIntrust TradeStateIntrust { get; set; }

        public virtual TradeState TradeState { get; set; }
    }
}
