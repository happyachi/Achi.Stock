namespace Achi.Stock.Winform.test.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StockDailyPrice
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public double? Highest { get; set; }

        public double? Lowest { get; set; }

        public double? Opening { get; set; }

        public double? Closing { get; set; }

        public double? Amount { get; set; }

        public double? Volume { get; set; }

        public virtual StockCompany StockCompany { get; set; }
    }
}
