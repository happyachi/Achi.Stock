namespace Achi.Stock.Winform.test.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockDailyTAIEX")]
    public partial class StockDailyTAIEX
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public double? Opening { get; set; }

        public double? Highest { get; set; }

        public double? Lowest { get; set; }

        public double? Closing { get; set; }
    }
}
