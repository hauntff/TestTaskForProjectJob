using System;
using System.Collections.Generic;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class PiBulkItem
    {
        public int ItemId { get; set; }
        public int StoreId { get; set; }
        public string Sku { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public decimal? RegularPrice { get; set; }
        public int? UnitsPerPackage { get; set; }
        public decimal? PackagePrice { get; set; }
        public decimal? SalePrice { get; set; }
        public DateTime? SaleBegins { get; set; }
        public DateTime? SaleExpires { get; set; }
        public int? SaleMax { get; set; }
        public DateTime? CaseStartingDate { get; set; }
        public DateTime? CaseEndingDate { get; set; }
        public int? CaseQty { get; set; }
        public int? CaseMaxAllowed { get; set; }
        public decimal? CasePrice { get; set; }
        public decimal? CaseSale { get; set; }
        public int? SpecialPricePer { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTime? SpecialStarts { get; set; }
        public DateTime? SpecialEnds { get; set; }
        public int? SpecialsLimitPerOrder { get; set; }
        public string Measure { get; set; }
        public string Flags { get; set; }
        public bool? IsTaxable { get; set; }
        public string Skus { get; set; }
        public DateTime? LastSold { get; set; }
        public string OnHand { get; set; }
        public string CasePakBulk { get; set; }
        public string SpecialPakBulk { get; set; }
        public decimal? ByWeight { get; set; }
        public decimal? Size { get; set; }
        public string Unit { get; set; }
        public decimal? StoreWeight { get; set; }
        public string Life { get; set; }
        public string StorePublish { get; set; }
        public string LocOnly { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? InsertItem { get; set; }
        public string Shelf { get; set; }
        public string Name { get; set; }
        public string Passover { get; set; }
        public string Brand { get; set; }
        public string FormatedName { get; set; }
        public string Posdepartment { get; set; }
        public decimal? RetailPrice { get; set; }
        public int? ImportTaskId { get; set; }
        public int? TaxCategory { get; set; }
        public string PackageDepositSku { get; set; }
        public decimal? PackageDepositUnitPrice { get; set; }
    }
}
