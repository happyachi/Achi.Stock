namespace Achi.Stock.Winform.test.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MemberAccountMoney
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public decimal OriginalAccount { get; set; }

        public decimal LatestAccount { get; set; }

        public virtual Member Member { get; set; }
    }
}
