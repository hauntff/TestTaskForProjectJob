using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TestTaskForProjectJob
{
    public partial class test_databaseContext : DbContext
    {
        public test_databaseContext()
        {
        }

        public test_databaseContext(DbContextOptions<test_databaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryTree> CategoryTrees { get; set; }
        public virtual DbSet<CategoryTreeLeaf> CategoryTreeLeaves { get; set; }
        public virtual DbSet<CategoryUnpublishMode> CategoryUnpublishModes { get; set; }
        public virtual DbSet<PiBrand> PiBrands { get; set; }
        public virtual DbSet<PiBrandsMapping> PiBrandsMappings { get; set; }
        public virtual DbSet<PiBulkItem> PiBulkItems { get; set; }
        public virtual DbSet<PiBulkSpecialsItem> PiBulkSpecialsItems { get; set; }
        public virtual DbSet<PiCategoriesCategory> PiCategoriesCategories { get; set; }
        public virtual DbSet<PiCategoriesMapping> PiCategoriesMappings { get; set; }
        public virtual DbSet<PiCategory> PiCategories { get; set; }
        public virtual DbSet<PiTask> PiTasks { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public virtual DbSet<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }
        public virtual DbSet<ProductPictureMapping> ProductPictureMappings { get; set; }
        public virtual DbSet<ProductProductTagMapping> ProductProductTagMappings { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }
        public virtual DbSet<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; set; }
        public virtual DbSet<ProductVariant> ProductVariants { get; set; }
        public virtual DbSet<ProductVariantAttributeCombination> ProductVariantAttributeCombinations { get; set; }
        public virtual DbSet<ProductVariantAttributeTemplate> ProductVariantAttributeTemplates { get; set; }
        public virtual DbSet<ProductVariantAttributeTemplateValue> ProductVariantAttributeTemplateValues { get; set; }
        public virtual DbSet<ProductVariantAttributeValue> ProductVariantAttributeValues { get; set; }
        public virtual DbSet<ProductVariantProductAttributeMapping> ProductVariantProductAttributeMappings { get; set; }
        public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }
        public virtual DbSet<StoreProduct> StoreProducts { get; set; }
        public virtual DbSet<StoreProductPublishMode> StoreProductPublishModes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NB24L70;Database=test_database;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.HasIndex(e => e.DisplayOrderRemove, "IX_Category_DisplayOrder")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.CategoryUnpublishModeId).HasDefaultValueSql("((3))");

                entity.Property(e => e.ChildMultiselect).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.DisplayOrderRemove).HasColumnName("DisplayOrder_remove");

                entity.Property(e => e.IconId).HasDefaultValueSql("((0))");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.ParentCategoryIdRemove).HasColumnName("ParentCategoryId_remove");

                entity.Property(e => e.PopupMenuHtml).HasMaxLength(1024);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);

                entity.Property(e => e.PublishedRemove).HasColumnName("Published_remove");

                entity.Property(e => e.RequiresPhotoId)
                    .HasColumnName("RequiresPhotoID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SeName).HasMaxLength(200);

                entity.Property(e => e.ShortcutToCategoryIdRemove).HasColumnName("ShortcutToCategoryId_remove");

                entity.Property(e => e.ShowOnHomePageRemove).HasColumnName("ShowOnHomePage_remove");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.UrlRemove)
                    .HasMaxLength(200)
                    .HasColumnName("Url_remove");

                entity.HasOne(d => d.CategoryUnpublishMode)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.CategoryUnpublishModeId)
                    .HasConstraintName("FK_Category_CategoryUnpublishMode");
            });

            modelBuilder.Entity<CategoryTree>(entity =>
            {
                entity.ToTable("CategoryTree");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<CategoryTreeLeaf>(entity =>
            {
                entity.ToTable("CategoryTreeLeaf");

                entity.HasIndex(e => new { e.CategoryId, e.CategoryTreeId, e.Published }, "IX_CategoryTreeLeaf_CategoryId_CategoryTreeId_Published")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.CategoryTreeId, e.Published }, "IX_CategoryTreeLeaf_CategoryTreeId_Published")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.CategoryId, e.CategoryTreeId }, "UIX_CategoryTreeLeaf_Category_CategoryTree")
                    .IsUnique();

                entity.HasIndex(e => new { e.ParentCategoryTreeLeafId, e.CategoryTreeId, e.CategoryId, e.Id }, "_dta_index_CategoryTreeLeaf_ps")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowOnHomePage).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<CategoryUnpublishMode>(entity =>
            {
                entity.ToTable("CategoryUnpublishMode");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PiBrand>(entity =>
            {
                entity.ToTable("PI_Brands");

                entity.Property(e => e.ImportingBrandName).HasMaxLength(150);
            });

            modelBuilder.Entity<PiBrandsMapping>(entity =>
            {
                entity.ToTable("PI_BrandsMapping");

                entity.Property(e => e.PiBrandId).HasColumnName("PI_BrandId");
            });

            modelBuilder.Entity<PiBulkItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("PI_BulkItems");

                entity.Property(e => e.Brand).HasMaxLength(100);

                entity.Property(e => e.ByWeight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CaseEndingDate).HasColumnType("datetime");

                entity.Property(e => e.CasePakBulk).HasMaxLength(50);

                entity.Property(e => e.CasePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CaseSale).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CaseStartingDate).HasColumnType("datetime");

                entity.Property(e => e.Category).HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Flags).HasMaxLength(100);

                entity.Property(e => e.LastSold).HasColumnType("datetime");

                entity.Property(e => e.Life).HasMaxLength(50);

                entity.Property(e => e.LocOnly).HasMaxLength(50);

                entity.Property(e => e.Measure).HasMaxLength(100);

                entity.Property(e => e.OnHand).HasMaxLength(50);

                entity.Property(e => e.PackageDepositSku).HasColumnName("PackageDepositSKU");

                entity.Property(e => e.PackageDepositUnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PackagePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Passover).HasMaxLength(512);

                entity.Property(e => e.Posdepartment).HasColumnName("POSDepartment");

                entity.Property(e => e.RegularPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SaleBegins).HasColumnType("datetime");

                entity.Property(e => e.SaleExpires).HasColumnType("datetime");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Shelf).HasMaxLength(500);

                entity.Property(e => e.Size).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Sku).HasMaxLength(500);

                entity.Property(e => e.Skus).HasColumnName("SKUs");

                entity.Property(e => e.SpecialEnds).HasColumnType("datetime");

                entity.Property(e => e.SpecialPakBulk).HasMaxLength(50);

                entity.Property(e => e.SpecialPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SpecialStarts).HasColumnType("datetime");

                entity.Property(e => e.StorePublish).HasMaxLength(50);

                entity.Property(e => e.StoreWeight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubCategory).HasMaxLength(250);

                entity.Property(e => e.Unit).HasMaxLength(100);
            });

            modelBuilder.Entity<PiBulkSpecialsItem>(entity =>
            {
                entity.ToTable("PI_BulkSpecialsItems");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceField).HasMaxLength(50);

                entity.Property(e => e.PriceMode).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpcCode).HasMaxLength(50);
            });

            modelBuilder.Entity<PiCategoriesCategory>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.PiCategoryId, e.CategoryTreeId });

                entity.ToTable("PI_Categories_Category");

                entity.Property(e => e.PiCategoryId).HasColumnName("PI_CategoryId");

                entity.Property(e => e.Pipath).HasColumnName("PIPath");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PiCategoriesCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PI_Categories_Category_Category");

                entity.HasOne(d => d.PiCategory)
                    .WithMany(p => p.PiCategoriesCategories)
                    .HasForeignKey(d => d.PiCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PI_Categories_Category_PI_Categories");
            });

            modelBuilder.Entity<PiCategoriesMapping>(entity =>
            {
                entity.ToTable("PI_CategoriesMapping");

                entity.Property(e => e.PiCategoryId).HasColumnName("PI_CategoryId");

                entity.Property(e => e.PiParentId).HasColumnName("PI_ParentId");
            });

            modelBuilder.Entity<PiCategory>(entity =>
            {
                entity.ToTable("PI_Categories");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ImportingCategoryName).HasMaxLength(250);

                entity.Property(e => e.PiParentId).HasColumnName("PI_ParentId");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<PiTask>(entity =>
            {
                entity.ToTable("PI_Tasks");

                entity.Property(e => e.CurrentFile).HasMaxLength(512);

                entity.Property(e => e.Delimeter).HasMaxLength(5);

                entity.Property(e => e.ImportFeedsPrefix).HasMaxLength(150);

                entity.Property(e => e.LastImportOn).HasColumnType("datetime");

                entity.Property(e => e.LastImportedFile).HasMaxLength(512);

                entity.Property(e => e.LastRunOn).HasColumnType("datetime");

                entity.Property(e => e.NextUpdateOn).HasColumnType("datetime");

                entity.Property(e => e.SkuDecodeDelimeter).HasMaxLength(100);

                entity.Property(e => e.SkuDecodeFeedsPrefix).HasMaxLength(100);

                entity.Property(e => e.SpecialsDelimeter).HasMaxLength(100);

                entity.Property(e => e.SpecialsFeedsPrefix).HasMaxLength(100);
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.ToTable("Picture");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1/1/2014')");

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SeoFilename).HasMaxLength(300);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => e.Deleted, "IX_Product_Deleted_CreatedOnUtc")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Deleted, "IX_Product_Deleted_with_Popularity")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.PopularityRating, "IX_Product_PopularityRating")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ShowOnHomePage, "IX_Product_ShowOnHomepage")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.PopularityRating, e.Id, e.Deleted }, "_dta_index_Product_28_1650104919__K21D_K1_K18_2_3_4_5_6_7_8_9_10_11_12_13_14_15_16_19_20_27_28_30_32_33")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.CategoriesNamePathRemove)
                    .HasMaxLength(200)
                    .HasColumnName("CategoriesNamePath_remove");

                entity.Property(e => e.CategoriesPathRemove)
                    .HasMaxLength(250)
                    .HasColumnName("CategoriesPath_remove");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.FullNamePathRemove)
                    .HasMaxLength(300)
                    .HasColumnName("FullNamePath_remove")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsEbt).HasColumnName("IsEBT");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PopularityRating).HasDefaultValueSql("((0))");

                entity.Property(e => e.Posdepartment).HasColumnName("POSDepartment");

                entity.Property(e => e.QueryCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeName).HasMaxLength(200);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Skus).HasColumnName("SKUs");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductAttribute>(entity =>
            {
                entity.ToTable("ProductAttribute");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ProductCategoryMapping>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.ProductId })
                    .HasName("PK__Product___D249F667E905E335");

                entity.ToTable("Product_Category_Mapping");

                entity.HasIndex(e => e.CategoryId, "IX_PCM_Category")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ProductId, "IX_PCM_Product")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.CategoryId, e.ProductId }, "IX_PCM_Product_and_Category")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("ProductCategory_Category");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductCategory_Product");
            });

            modelBuilder.Entity<ProductManufacturerMapping>(entity =>
            {
                entity.ToTable("Product_Manufacturer_Mapping");

                entity.HasIndex(e => new { e.ManufacturerId, e.ProductId }, "IX_PMM_Product_and_Manufacturer")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ProductId, "IX_Product_Manufacturer_Mapping_ProductId")
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductManufacturerMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductManufacturer_Product");
            });

            modelBuilder.Entity<ProductPictureMapping>(entity =>
            {
                entity.ToTable("Product_Picture_Mapping");

                entity.HasIndex(e => e.ProductId, "IX_Product_Picture_Mapping_ProductId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.DisplayOrder, "ProductPicture_DisplayOrder")
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("ProductPicture_Picture");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductPicture_Product");
            });

            modelBuilder.Entity<ProductProductTagMapping>(entity =>
            {
                entity.HasKey(e => new { e.ProductTagId, e.ProductId })
                    .HasName("PK__Product___5802448C5919C7FE");

                entity.ToTable("Product_ProductTag_Mapping");

                entity.Property(e => e.ProductTagId).HasColumnName("ProductTag_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductTagMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductTag_Products_Target");
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.ToTable("ProductReview");

                entity.HasIndex(e => e.ProductId, "IX_ProductReview_ProductId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductReview_Product1");
            });

            modelBuilder.Entity<ProductReviewHelpfulness>(entity =>
            {
                entity.ToTable("ProductReviewHelpfulness");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.ProductReviewHelpfulnesses)
                    .HasForeignKey(d => d.ProductReviewId)
                    .HasConstraintName("ProductReviewHelpfulness_ProductReview1");
            });

            modelBuilder.Entity<ProductSpecificationAttributeMapping>(entity =>
            {
                entity.ToTable("Product_SpecificationAttribute_Mapping");

                entity.HasIndex(e => e.AllowFiltering, "IX_PSAM_AllowFiltering")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.SpecificationAttributeOptionId, e.AllowFiltering }, "IX_PSAM_SpecificationAttributeOptionId_AllowFiltering")
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSpecificationAttributeMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductSpecificationAttribute_Product");
            });

            modelBuilder.Entity<ProductVariant>(entity =>
            {
                entity.ToTable("ProductVariant");

                entity.HasIndex(e => e.DisplayOrder, "IX_ProductVariant_DisplayOrder")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ProductId, "IX_ProductVariant_ProductId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ProductId, "IX_ProductVariant_ProductId_2")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Deleted, "_dta_index_ProductVariant_28_206623779__K68_2")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.AdditionalShippingCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AllowedQuantities).HasMaxLength(1000);

                entity.Property(e => e.AvailableEndDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.AvailableStartDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.CaseEndingDate).HasColumnType("datetime");

                entity.Property(e => e.CasePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CaseStartingDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Flags).HasMaxLength(10);

                entity.Property(e => e.Gtin).HasMaxLength(400);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastSold).HasColumnType("datetime");

                entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                entity.Property(e => e.MaximumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MeasureWeight).HasDefaultValueSql("((1))");

                entity.Property(e => e.MinimumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name).HasMaxLength(400);

                entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RequiredProductVariantIds).HasMaxLength(1000);

                entity.Property(e => e.Size).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Sku).HasMaxLength(400);

                entity.Property(e => e.SpecialPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SpecialPriceEndDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.SpecialPriceStartDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVariants)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductVariant_Product");
            });

            modelBuilder.Entity<ProductVariantAttributeCombination>(entity =>
            {
                entity.ToTable("ProductVariantAttributeCombination");

                entity.HasOne(d => d.ProductVariant)
                    .WithMany(p => p.ProductVariantAttributeCombinations)
                    .HasForeignKey(d => d.ProductVariantId)
                    .HasConstraintName("ProductVariantAttributeCombination_ProductVariant");
            });

            modelBuilder.Entity<ProductVariantAttributeTemplate>(entity =>
            {
                entity.ToTable("ProductVariantAttributeTemplate");

                entity.Property(e => e.TemplateName).HasMaxLength(150);
            });

            modelBuilder.Entity<ProductVariantAttributeTemplateValue>(entity =>
            {
                entity.ToTable("ProductVariantAttributeTemplateValue");

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ProductVariantAttributeValue>(entity =>
            {
                entity.ToTable("ProductVariantAttributeValue");

                entity.HasIndex(e => e.ProductVariantAttributeId, "IX_ProductVariantAttributeValue_ProductVariantAttributeId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ProductVariantAttribute)
                    .WithMany(p => p.ProductVariantAttributeValues)
                    .HasForeignKey(d => d.ProductVariantAttributeId)
                    .HasConstraintName("ProductVariantAttributeValue_ProductVariantAttribute");
            });

            modelBuilder.Entity<ProductVariantProductAttributeMapping>(entity =>
            {
                entity.ToTable("ProductVariant_ProductAttribute_Mapping");

                entity.HasIndex(e => e.ProductVariantId, "IX_ProductVariant_ProductAttribute_Mapping_ProductVariantId")
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.ProductVariantProductAttributeMappings)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .HasConstraintName("ProductVariantAttribute_ProductAttribute");

                entity.HasOne(d => d.ProductVariant)
                    .WithMany(p => p.ProductVariantProductAttributeMappings)
                    .HasForeignKey(d => d.ProductVariantId)
                    .HasConstraintName("ProductVariantAttribute_ProductVariant");
            });

            modelBuilder.Entity<RelatedProduct>(entity =>
            {
                entity.ToTable("RelatedProduct");

                entity.HasIndex(e => e.ProductId1, "IX_RelatedProduct_ProductId1")
                    .HasFillFactor((byte)80);
            });

            modelBuilder.Entity<StoreProduct>(entity =>
            {
                entity.HasKey(e => new { e.StoreId, e.ProductId })
                    .HasName("PK_StoresProducts");

                entity.ToTable("StoreProduct");

                entity.HasIndex(e => new { e.StoreId, e.StockStatusId, e.StockStatusUpdatedOnUtc }, "IX_SP_storeId_stocks")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.StoreId, e.ProductId, e.ProductVariantId, e.Published, e.Deleted }, "IX_StoreProduct1")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Sku, "IX_StoreProduct2")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Id, "IX_StoreProduct3")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Published, e.Deleted }, "IX_StoreProduct6")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Deleted, "IX_StoreProduct_Deleted_LastSold")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.ProductId, e.DepartmentId, e.StoreId, e.Published, e.Deleted }, "IX_StoreProduct_Department")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.ProductVariantId, e.ProductId, e.StoreId }, "IX_StoreProduct_Fields")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Id, "IX_StoreProduct_Id")
                    .IsUnique()
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ProductId, "IX_StoreProduct_ProductId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.StoreId, e.DepartmentId }, "IX_StoreProduct_StoreId_DepartmentId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.StoreId, e.Published, e.UpdatedOnUtc }, "IX_StoreProduct_StoreId_Published_UpdatedOnUtc")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.ProductVariantId, "SP_IX_ProductVariantId")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.StoreId, e.Published, e.Deleted }, "SP_StoreId_IDX")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.StoreId, e.Published, e.Deleted, e.DepartmentId }, "SP_StoreId_IDX_DepartmentId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.CaseEndingDate).HasColumnType("datetime");

                entity.Property(e => e.CasePakBulk).HasMaxLength(20);

                entity.Property(e => e.CasePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CaseSpecialEndingDate).HasColumnType("datetime");

                entity.Property(e => e.CaseSpecialPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CaseSpecialStartingDate).HasColumnType("datetime");

                entity.Property(e => e.CaseStartingDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(200);

                entity.Property(e => e.Flags).HasMaxLength(10);

                entity.Property(e => e.FullNamePath).HasMaxLength(300);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastSold).HasColumnType("datetime");

                entity.Property(e => e.Life).HasMaxLength(255);

                entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderMaximumQuantity).HasDefaultValueSql("((99))");

                entity.Property(e => e.PackageDepositUnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PublishModeUtc).HasColumnType("datetime");

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Shelf).HasMaxLength(500);

                entity.Property(e => e.Size).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.SpecialPackageEndingDate).HasColumnType("datetime");

                entity.Property(e => e.SpecialPackagePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SpecialPackageStartingDate).HasColumnType("datetime");

                entity.Property(e => e.SpecialPakBulk).HasMaxLength(20);

                entity.Property(e => e.SpecialPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SpecialPriceEndDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.SpecialPriceStartDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.StockStatusUpdatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.StorePublish).HasMaxLength(255);

                entity.Property(e => e.StoreWeight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxCategoryId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ProductVariant)
                    .WithMany(p => p.StoreProducts)
                    .HasForeignKey(d => d.ProductVariantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoresProducts_Product");

                entity.HasOne(d => d.PublishModeNavigation)
                    .WithMany(p => p.StoreProducts)
                    .HasForeignKey(d => d.PublishMode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StoreProd__Publi__04E4BC85");
            });

            modelBuilder.Entity<StoreProductPublishMode>(entity =>
            {
                entity.ToTable("StoreProductPublishMode");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
