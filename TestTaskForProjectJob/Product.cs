using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class Product
    {
        public Product()
        {
            ProductCategoryMappings = new HashSet<ProductCategoryMapping>();
            ProductManufacturerMappings = new HashSet<ProductManufacturerMapping>();
            ProductPictureMappings = new HashSet<ProductPictureMapping>();
            ProductProductTagMappings = new HashSet<ProductProductTagMapping>();
            ProductReviews = new HashSet<ProductReview>();
            ProductSpecificationAttributeMappings = new HashSet<ProductSpecificationAttributeMapping>();
            ProductVariants = new HashSet<ProductVariant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string AdminComment { get; set; }
        public int ProductTemplateId { get; set; }
        public bool ShowOnHomePage { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public string SeName { get; set; }
        public bool AllowCustomerReviews { get; set; }
        public int ApprovedRatingSum { get; set; }
        public int NotApprovedRatingSum { get; set; }
        public int ApprovedTotalReviews { get; set; }
        public int NotApprovedTotalReviews { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public int? PopularityRating { get; set; }
        public int? QueryCount { get; set; }
        public string CategoriesPathRemove { get; set; }
        public string CategoriesNamePathRemove { get; set; }
        public int? ParentProductId { get; set; }
        public string Skus { get; set; }
        public string Sku { get; set; }
        public int? Passover { get; set; }
        public string FullNamePathRemove { get; set; }
        public bool? IsEbt { get; set; }
        public string Posdepartment { get; set; }

        public virtual ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public virtual ICollection<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }
        public virtual ICollection<ProductPictureMapping> ProductPictureMappings { get; set; }
        public virtual ICollection<ProductProductTagMapping> ProductProductTagMappings { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; set; }
        public virtual ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
