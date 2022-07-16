using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class PiTask
    {
        public int Id { get; set; }
        public int? TaskType { get; set; }
        public int? Interval { get; set; }
        public bool? Notify { get; set; }
        public bool? PublishProducts { get; set; }
        public bool? PublishCategories { get; set; }
        public bool? PublishBrands { get; set; }
        public DateTime? NextUpdateOn { get; set; }
        public int? ProductTemplateId { get; set; }
        public DateTime? LastImportOn { get; set; }
        public string LastImportedFile { get; set; }
        public int? CurrentStatus { get; set; }
        public string CurrentFile { get; set; }
        public int? CurrentProductsTotal { get; set; }
        public int? CurrentProductsProcessed { get; set; }
        public int? CommandInQueue { get; set; }
        public int? ServiceResponse { get; set; }
        public int? StoreId { get; set; }
        public string ImportFeedsPrefix { get; set; }
        public string Delimeter { get; set; }
        public string SpecialsDelimeter { get; set; }
        public string SkuDecodeDelimeter { get; set; }
        public string SpecialsFeedsPrefix { get; set; }
        public string SkuDecodeFeedsPrefix { get; set; }
        public DateTime? LastRunOn { get; set; }
    }
}
