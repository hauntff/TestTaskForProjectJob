using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class ProductVariantAttributeCombination
    {
        public int Id { get; set; }
        public int ProductVariantId { get; set; }
        public string AttributesXml { get; set; }
        public int StockQuantity { get; set; }
        public bool AllowOutOfStockOrders { get; set; }

        public virtual ProductVariant ProductVariant { get; set; }
    }
}
