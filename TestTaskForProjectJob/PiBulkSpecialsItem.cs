using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class PiBulkSpecialsItem
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string UpcCode { get; set; }
        public string PriceField { get; set; }
        public string PriceMode { get; set; }
        public decimal? Price { get; set; }
        public int? PerPack { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
