namespace Achi.Stock.Winform.test.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TradeStateIntrust
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TradeStateIntrust()
        {
            TradeDateIntrusts = new HashSet<TradeDateIntrust>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TradeDateIntrust> TradeDateIntrusts { get; set; }
    }
}
