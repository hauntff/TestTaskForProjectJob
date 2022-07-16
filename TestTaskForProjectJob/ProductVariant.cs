﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class ProductVariant
    {
        public ProductVariant()
        {
            ProductVariantAttributeCombinations = new HashSet<ProductVariantAttributeCombination>();
            ProductVariantProductAttributeMappings = new HashSet<ProductVariantProductAttributeMapping>();
            StoreProducts = new HashSet<StoreProduct>();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public string AdminComment { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public string Gtin { get; set; }
        public bool IsGiftCard { get; set; }
        public int GiftCardTypeId { get; set; }
        public bool RequireOtherProducts { get; set; }
        public string RequiredProductVariantIds { get; set; }
        public bool AutomaticallyAddRequiredProductVariants { get; set; }
        public bool IsDownload { get; set; }
        public int DownloadId { get; set; }
        public bool UnlimitedDownloads { get; set; }
        public int MaxNumberOfDownloads { get; set; }
        public int? DownloadExpirationDays { get; set; }
        public int DownloadActivationTypeId { get; set; }
        public bool HasSampleDownload { get; set; }
        public int SampleDownloadId { get; set; }
        public bool HasUserAgreement { get; set; }
        public string UserAgreementText { get; set; }
        public bool IsRecurring { get; set; }
        public int RecurringCycleLength { get; set; }
        public int RecurringCyclePeriodId { get; set; }
        public int RecurringTotalCycles { get; set; }
        public bool IsShipEnabled { get; set; }
        public bool IsFreeShipping { get; set; }
        public decimal AdditionalShippingCharge { get; set; }
        public bool IsTaxExempt { get; set; }
        public int TaxCategoryId { get; set; }
        public int ManageInventoryMethodId { get; set; }
        public int StockQuantity { get; set; }
        public bool DisplayStockAvailability { get; set; }
        public bool DisplayStockQuantity { get; set; }
        public int MinStockQuantity { get; set; }
        public int LowStockActivityId { get; set; }
        public int NotifyAdminForQuantityBelow { get; set; }
        public int BackorderModeId { get; set; }
        public bool AllowBackInStockSubscriptions { get; set; }
        public int OrderMinimumQuantity { get; set; }
        public int OrderMaximumQuantity { get; set; }
        public string AllowedQuantities { get; set; }
        public bool DisableBuyButton { get; set; }
        public bool DisableWishlistButton { get; set; }
        public bool AvailableForPreOrder { get; set; }
        public bool CallForPrice { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public decimal ProductCost { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTime? SpecialPriceStartDateTimeUtc { get; set; }
        public DateTime? SpecialPriceEndDateTimeUtc { get; set; }
        public bool CustomerEntersPrice { get; set; }
        public decimal MinimumCustomerEnteredPrice { get; set; }
        public decimal MaximumCustomerEnteredPrice { get; set; }
        public bool HasTierPrices { get; set; }
        public bool HasDiscountsApplied { get; set; }
        public decimal Weight { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public int PictureId { get; set; }
        public DateTime? AvailableStartDateTimeUtc { get; set; }
        public DateTime? AvailableEndDateTimeUtc { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public int? RegularPricePer { get; set; }
        public int? SpecialPricePer { get; set; }
        public decimal? Size { get; set; }
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

        public virtual Product Product { get; set; }
        public virtual ICollection<ProductVariantAttributeCombination> ProductVariantAttributeCombinations { get; set; }
        public virtual ICollection<ProductVariantProductAttributeMapping> ProductVariantProductAttributeMappings { get; set; }
        public virtual ICollection<StoreProduct> StoreProducts { get; set; }
    }
}
