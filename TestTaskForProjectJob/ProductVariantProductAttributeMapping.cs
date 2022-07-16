using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class ProductVariantProductAttributeMapping
    {
        public ProductVariantProductAttributeMapping()
        {
            ProductVariantAttributeValues = new HashSet<ProductVariantAttributeValue>();
        }

        public int Id { get; set; }
        public int ProductVariantId { get; set; }
        public int ProductAttributeId { get; set; }
        public string TextPrompt { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }
        public int? AttributesTemplateId { get; set; }

        public virtual ProductAttribute ProductAttribute { get; set; }
        public virtual ProductVariant ProductVariant { get; set; }
        public virtual ICollection<ProductVariantAttributeValue> ProductVariantAttributeValues { get; set; }
    }
}
