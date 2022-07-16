using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class Category
    {
        public Category()
        {
            PiCategoriesCategories = new HashSet<PiCategoriesCategory>();
            ProductCategoryMappings = new HashSet<ProductCategoryMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryTemplateId { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public string SeName { get; set; }
        public int? ParentCategoryIdRemove { get; set; }
        public int PictureId { get; set; }
        public int PageSize { get; set; }
        public bool AllowCustomersToSelectPageSize { get; set; }
        public string PageSizeOptions { get; set; }
        public string PriceRanges { get; set; }
        public bool? ShowOnHomePageRemove { get; set; }
        public bool HasDiscountsApplied { get; set; }
        public bool? PublishedRemove { get; set; }
        public bool Deleted { get; set; }
        public int? DisplayOrderRemove { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public bool? ChildMultiselect { get; set; }
        public bool? IgnoreSpecials { get; set; }
        public bool? ShowCase { get; set; }
        public bool SoldByWeight { get; set; }
        public int? IconId { get; set; }
        public string PopupMenuHtml { get; set; }
        public int ProductLifeId { get; set; }
        public bool? AllowDeliMenu { get; set; }
        public bool IsScale { get; set; }
        public bool? RequiresPhotoId { get; set; }
        public int? BulkOptionId { get; set; }
        public int? ShortcutToCategoryIdRemove { get; set; }
        public int CategoryUnpublishModeId { get; set; }
        public bool Passover { get; set; }
        public string UrlRemove { get; set; }
        public bool AllowQtyFromPriceCalc { get; set; }

        public virtual CategoryUnpublishMode CategoryUnpublishMode { get; set; }
        public virtual ICollection<PiCategoriesCategory> PiCategoriesCategories { get; set; }
        public virtual ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; }
    }
}
