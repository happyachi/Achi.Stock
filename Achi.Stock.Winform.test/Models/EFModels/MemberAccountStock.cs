namespace Achi.Stock.Winform.test.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MemberAccountStock
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int StockId { get; set; }

        public double Amount { get; set; }

        public double BuyPrice { get; set; }

        public virtual Member Member { get; set; }

        public virtual StockCompany StockCompany { get; set; }
    }
}
