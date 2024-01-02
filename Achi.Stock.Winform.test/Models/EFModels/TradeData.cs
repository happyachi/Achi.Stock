namespace Achi.Stock.Winform.test.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TradeData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TradeData()
        {
            TradeDateIntrusts = new HashSet<TradeDateIntrust>();
        }

        public int Id { get; set; }

        public int MemberId { get; set; }

        public int CompanyId { get; set; }

        public int StateId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Datetime { get; set; }

        public double Price { get; set; }

        public double Amount { get; set; }

        public decimal AccountMoneyStart { get; set; }

        public decimal AccountMoneyEnd { get; set; }

        public virtual Member Member { get; set; }

        public virtual StockCompany StockCompany { get; set; }

        public virtual TradeState TradeState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TradeDateIntrust> TradeDateIntrusts { get; set; }
    }
}
