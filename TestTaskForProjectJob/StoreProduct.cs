using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class StoreProduct
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int ProductVariantId { get; set; }
        public bool? IsTaxExempt { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTime? SpecialPriceStartDateTimeUtc { get; set; }
        public DateTime? SpecialPriceEndDateTimeUtc { get; set; }
        public int? RegularPricePer { get; set; }
        public int? SpecialPricePer { get; set; }
        public decimal? Size { get; set; }
        public decimal? Weight { get; set; }
        public string Unit { get; set; }
        public string Flags { get; set; }
        public int MeasureWeight { get; set; }
        public int? PriceQty { get; set; }
        public DateTime? LastSold { get; set; }
        public int? LimitPerOrder { get; set; }
        public DateTime? CaseStartingDate { get; set; }
        public DateTime? CaseEndingDate { get; set; }
        public int? CaseQty { get; set; }
        public int? CaseMaxAllowed { get; set; }
        public decimal? CasePrice { get; set; }
        public bool? ShowCase { get; set; }
        public string CasePakBulk { get; set; }
        public string SpecialPakBulk { get; set; }
        public int? PopularityRating { get; set; }
        public string CategoriesPath { get; set; }
        public string CategoriesNamePath { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public int? StockQuantity { get; set; }
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public decimal? CaseSpecialPrice { get; set; }
        public DateTime? CaseSpecialStartingDate { get; set; }
        public DateTime? CaseSpecialEndingDate { get; set; }
        public int? CaseSpecialQty { get; set; }
        public int? CaseSpecialMaxAllowed { get; set; }
        public decimal? SpecialPackagePrice { get; set; }
        public DateTime? SpecialPackageStartingDate { get; set; }
        public DateTime? SpecialPackageEndingDate { get; set; }
        public int? SpecialPackageQty { get; set; }
        public int? SpecialPackageMaxAllowed { get; set; }
        public decimal? StoreWeight { get; set; }
        public string Life { get; set; }
        public string StorePublish { get; set; }
        public bool? LocOnly { get; set; }
        public string Shelf { get; set; }
        public int? StockStatusId { get; set; }
        public int? StockStatusReportedByCustomerId { get; set; }
        public DateTime? StockStatusUpdatedOnUtc { get; set; }
        public int? StockStatusReportedOnOrderId { get; set; }
        public bool SoldByCount { get; set; }
        public int? VendorId { get; set; }
        public int? LayoutLocationId { get; set; }
        public int? OrderMaximumQuantity { get; set; }
        public int? OldGenericProductId { get; set; }
        public DateTime? MakeStoreSpecificOnUtc { get; set; }
        public decimal? RetailPrice { get; set; }
        public int TaxCategoryId { get; set; }
        public short PublishMode { get; set; }
        public int? PublishModeBy { get; set; }
        public DateTime? PublishModeUtc { get; set; }
        public string FullNamePath { get; set; }
        public string Department { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? PackageDepositUnitPrice { get; set; }

        public virtual ProductVariant ProductVariant { get; set; }
        public virtual StoreProductPublishMode PublishModeNavigation { get; set; }
    }
}
