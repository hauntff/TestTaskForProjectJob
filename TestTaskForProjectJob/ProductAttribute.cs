using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class ProductAttribute
    {
        public ProductAttribute()
        {
            ProductVariantProductAttributeMappings = new HashSet<ProductVariantProductAttributeMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProductVariantProductAttributeMapping> ProductVariantProductAttributeMappings { get; set; }
    }
}
