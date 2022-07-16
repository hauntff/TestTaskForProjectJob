using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class ProductVariantAttributeValue
    {
        public int Id { get; set; }
        public int ProductVariantAttributeId { get; set; }
        public string Name { get; set; }
        public decimal PriceAdjustment { get; set; }
        public decimal WeightAdjustment { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }
        public int? AttributesTemplateValueId { get; set; }

        public virtual ProductVariantProductAttributeMapping ProductVariantAttribute { get; set; }
    }
}
