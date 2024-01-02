namespace Achi.Stock.Winform.test.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MemberLoginData
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Datetime { get; set; }

        [StringLength(16)]
        public string IP { get; set; }

        public virtual Member Member { get; set; }
    }
}
