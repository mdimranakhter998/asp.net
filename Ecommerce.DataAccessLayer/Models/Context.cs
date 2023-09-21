using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DataAccessLayer.Models;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAddressType> TblAddressTypes { get; set; }

    public virtual DbSet<TblBankAccount> TblBankAccounts { get; set; }

    public virtual DbSet<TblBrand> TblBrands { get; set; }

    public virtual DbSet<TblCart> TblCarts { get; set; }

    public virtual DbSet<TblCategory> TblCategories { get; set; }

    public virtual DbSet<TblColorType> TblColorTypes { get; set; }

    public virtual DbSet<TblCompare> TblCompares { get; set; }

    public virtual DbSet<TblCountry> TblCountries { get; set; }

    public virtual DbSet<TblCountryCity> TblCountryCities { get; set; }

    public virtual DbSet<TblCustomerReview> TblCustomerReviews { get; set; }

    public virtual DbSet<TblCustomerReviewImage> TblCustomerReviewImages { get; set; }

    public virtual DbSet<TblDiscount> TblDiscounts { get; set; }

    public virtual DbSet<TblGender> TblGenders { get; set; }

    public virtual DbSet<TblOrderDetail> TblOrderDetails { get; set; }

    public virtual DbSet<TblOrderHeader> TblOrderHeaders { get; set; }

    public virtual DbSet<TblOrderPayment> TblOrderPayments { get; set; }

    public virtual DbSet<TblOrderStatus> TblOrderStatuses { get; set; }

    public virtual DbSet<TblPaymentStatus> TblPaymentStatuses { get; set; }

    public virtual DbSet<TblPaymentType> TblPaymentTypes { get; set; }

    public virtual DbSet<TblProductDetail> TblProductDetails { get; set; }

    public virtual DbSet<TblProductFeature> TblProductFeatures { get; set; }

    public virtual DbSet<TblProductHeader> TblProductHeaders { get; set; }

    public virtual DbSet<TblProductTag> TblProductTags { get; set; }

    public virtual DbSet<TblSeason> TblSeasons { get; set; }

    public virtual DbSet<TblSeasonDiscount> TblSeasonDiscounts { get; set; }

    public virtual DbSet<TblShippingFee> TblShippingFees { get; set; }

    public virtual DbSet<TblSizeLevel> TblSizeLevels { get; set; }

    public virtual DbSet<TblSizeType> TblSizeTypes { get; set; }

    public virtual DbSet<TblSizeTypeByLevel> TblSizeTypeByLevels { get; set; }

    public virtual DbSet<TblStatus> TblStatuses { get; set; }

    public virtual DbSet<TblSubCategory> TblSubCategories { get; set; }

    public virtual DbSet<TblTag> TblTags { get; set; }

    public virtual DbSet<TblUnit> TblUnits { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblUserAddress> TblUserAddresses { get; set; }

    public virtual DbSet<TblUserStatus> TblUserStatuses { get; set; }

    public virtual DbSet<TblUserType> TblUserTypes { get; set; }

    public virtual DbSet<TblWishList> TblWishLists { get; set; }

   

      
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAddressType>(entity =>
        {
            entity.HasKey(e => e.AddressTypeId);

            entity.ToTable("tbl_AddressType");

            entity.Property(e => e.AddressTypeId).ValueGeneratedNever();
            entity.Property(e => e.AddressType).IsUnicode(false);
        });

        modelBuilder.Entity<TblBankAccount>(entity =>
        {
            entity.HasKey(e => e.BankAccountId);

            entity.ToTable("tbl_BankAccount");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccountTitle)
                .HasMaxLength(450)
                .IsUnicode(false);
            entity.Property(e => e.BankName).HasMaxLength(450);
            entity.Property(e => e.Ibanno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IBANNo");

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.TblBankAccounts)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_BankAccount_tbl_User");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.TblBankAccounts)
                .HasForeignKey(d => d.PaymentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_BankAccount_tbl_PaymentType");

            entity.HasOne(d => d.Status).WithMany(p => p.TblBankAccounts)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_BankAccount_tbl_Status");
        });

        modelBuilder.Entity<TblBrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("tbl_Brand");

            entity.Property(e => e.BrandTitle).HasMaxLength(250);
        });

        modelBuilder.Entity<TblCart>(entity =>
        {
            entity.HasKey(e => e.CartId);

            entity.ToTable("tbl_Cart");

            entity.Property(e => e.UniqueNo).HasMaxLength(50);

            entity.HasOne(d => d.Discount).WithMany(p => p.TblCarts)
                .HasForeignKey(d => d.DiscountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_Cart_tbl_Discount");

            entity.HasOne(d => d.ProductDetail).WithMany(p => p.TblCarts)
                .HasForeignKey(d => d.ProductDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_Cart_tbl_ProductDetail");
        });

        modelBuilder.Entity<TblCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("tbl_Category");

            entity.Property(e => e.CategoryTitle).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StatusId).HasColumnName("statusId");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.TblCategories)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_Category_User");

            entity.HasOne(d => d.Status).WithMany(p => p.TblCategories)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_tbl_Category_Status");
        });

        modelBuilder.Entity<TblColorType>(entity =>
        {
            entity.HasKey(e => e.ColorTypeId);

            entity.ToTable("tbl_ColorType");

            entity.Property(e => e.ColorCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ColorTitle).HasMaxLength(150);

            entity.HasOne(d => d.Status).WithMany(p => p.TblColorTypes)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_tbl_ColorType_Status");
        });

        modelBuilder.Entity<TblCompare>(entity =>
        {
            entity.HasKey(e => e.CompareId);

            entity.ToTable("tbl_Compare");

            entity.HasOne(d => d.CompareUser).WithMany(p => p.TblCompares)
                .HasForeignKey(d => d.CompareUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_Compare_User");

            entity.HasOne(d => d.ProductDetail).WithMany(p => p.TblCompares)
                .HasForeignKey(d => d.ProductDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_Compare_ProductDetail");
        });

        modelBuilder.Entity<TblCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__tbl_Coun__10D1609FCB376EC1");

            entity.ToTable("tbl_Country");

            entity.Property(e => e.CountryName).HasMaxLength(350);
        });

        modelBuilder.Entity<TblCountryCity>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__tbl_Coun__F2D21B768E39E029");

            entity.ToTable("tbl_Country_City");

            entity.Property(e => e.CityName).HasMaxLength(350);

            entity.HasOne(d => d.Country).WithMany(p => p.TblCountryCities)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK__tbl_Count__Count__06CD04F7");
        });

        modelBuilder.Entity<TblCustomerReview>(entity =>
        {
            entity.HasKey(e => e.CustomerReviewId);

            entity.ToTable("tbl_CustomerReview");

            entity.Property(e => e.CustomerReview).HasMaxLength(500);

            entity.HasOne(d => d.CustomerReviewUser).WithMany(p => p.TblCustomerReviews)
                .HasForeignKey(d => d.CustomerReviewUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_CustomerReview_tbl_User");

            entity.HasOne(d => d.OrderHeader).WithMany(p => p.TblCustomerReviews)
                .HasForeignKey(d => d.OrderHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_CustomerReview_tbl_OrderHeader");

            entity.HasOne(d => d.ProductHeader).WithMany(p => p.TblCustomerReviews)
                .HasForeignKey(d => d.ProductHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_CustomerReview_tbl_ProductHeader");

            entity.HasOne(d => d.Status).WithMany(p => p.TblCustomerReviews)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_CustomerReview_tbl_Status");
        });

        modelBuilder.Entity<TblCustomerReviewImage>(entity =>
        {
            entity.HasKey(e => e.CustomerReviewImageId);

            entity.ToTable("tbl_CustomerReviewImage");

            entity.Property(e => e.ImagePath)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.CustomerReview).WithMany(p => p.TblCustomerReviewImages)
                .HasForeignKey(d => d.CustomerReviewId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_CustomerReviewImage_tbl_CustomerReview");

            entity.HasOne(d => d.Status).WithMany(p => p.TblCustomerReviewImages)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_CustomerReviewImage_tbl_Status");
        });

        modelBuilder.Entity<TblDiscount>(entity =>
        {
            entity.HasKey(e => e.DiscountId);

            entity.ToTable("tbl_Discount");

            entity.Property(e => e.CouponCode).HasMaxLength(50);
            entity.Property(e => e.DiscountDescription).HasMaxLength(500);
            entity.Property(e => e.DiscountTitle).HasMaxLength(250);

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.TblDiscountCreatedByUsers)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_Discount_tbl_User");

            entity.HasOne(d => d.Status).WithMany(p => p.TblDiscounts)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_Discount_tbl_Status");

            entity.HasOne(d => d.UpdatedByUser).WithMany(p => p.TblDiscountUpdatedByUsers)
                .HasForeignKey(d => d.UpdatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_Discount_tbl_User1");
        });

        modelBuilder.Entity<TblGender>(entity =>
        {
            entity.HasKey(e => e.GenderId);

            entity.ToTable("tbl_Gender");

            entity.Property(e => e.GenderType).HasMaxLength(30);
        });

        modelBuilder.Entity<TblOrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId);

            entity.ToTable("tbl_OrderDetail");

            entity.HasOne(d => d.Discount).WithMany(p => p.TblOrderDetails)
                .HasForeignKey(d => d.DiscountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderDetail_tbl_Discount");

            entity.HasOne(d => d.OrderHeader).WithMany(p => p.TblOrderDetails)
                .HasForeignKey(d => d.OrderHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderDetail_tbl_OrderHeader");

            entity.HasOne(d => d.ProductDetail).WithMany(p => p.TblOrderDetails)
                .HasForeignKey(d => d.ProductDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderDetail_tbl_ProductDetail");
        });

        modelBuilder.Entity<TblOrderHeader>(entity =>
        {
            entity.HasKey(e => e.OrderHeaderId);

            entity.ToTable("tbl_OrderHeader");

            entity.Property(e => e.OrderDate).HasColumnType("date");
            entity.Property(e => e.PaymentReceiptSnapshot)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ShippingDate).HasColumnType("date");
            entity.Property(e => e.TransactionDate).HasColumnType("date");
            entity.Property(e => e.TransactionNo)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.CustomerUser).WithMany(p => p.TblOrderHeaders)
                .HasForeignKey(d => d.CustomerUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderHeader_tbl_User");

            entity.HasOne(d => d.OrderStatus).WithMany(p => p.TblOrderHeaders)
                .HasForeignKey(d => d.OrderStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderHeader_tbl_OrderStatus");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.TblOrderHeaders)
                .HasForeignKey(d => d.PaymentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderHeader_tbl_PaymentType");

            entity.HasOne(d => d.ShippingFee).WithMany(p => p.TblOrderHeaders)
                .HasForeignKey(d => d.ShippingFeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderHeader_tbl_ShippingFee");

            entity.HasOne(d => d.UserAddress).WithMany(p => p.TblOrderHeaders)
                .HasForeignKey(d => d.UserAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderHeader_tbl_UserAddress");
        });

        modelBuilder.Entity<TblOrderPayment>(entity =>
        {
            entity.HasKey(e => e.OrderPaymentId);

            entity.ToTable("tbl_OrderPayment");

            entity.Property(e => e.PaymentGateway).HasMaxLength(500);

            entity.HasOne(d => d.OrderHeader).WithMany(p => p.TblOrderPayments)
                .HasForeignKey(d => d.OrderHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderPayment_tbl_OrderHeader");

            entity.HasOne(d => d.PaymentStatus).WithMany(p => p.TblOrderPayments)
                .HasForeignKey(d => d.PaymentStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderPayment_tbl_PaymentStatus");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.TblOrderPayments)
                .HasForeignKey(d => d.PaymentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderPayment_tbl_PaymentType");
        });

        modelBuilder.Entity<TblOrderStatus>(entity =>
        {
            entity.HasKey(e => e.OrderStatusId);

            entity.ToTable("tbl_OrderStatus");

            entity.Property(e => e.OrderStatusTitle).HasMaxLength(150);

            entity.HasOne(d => d.Status).WithMany(p => p.TblOrderStatuses)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderStatus_tbl_Status");
        });

        modelBuilder.Entity<TblPaymentStatus>(entity =>
        {
            entity.HasKey(e => e.PaymentStatusId);

            entity.ToTable("tbl_PaymentStatus");

            entity.Property(e => e.PaymentStatus).HasMaxLength(250);
        });

        modelBuilder.Entity<TblPaymentType>(entity =>
        {
            entity.HasKey(e => e.PaymentTypeId);

            entity.ToTable("tbl_PaymentType");

            entity.Property(e => e.PaymentType).HasMaxLength(150);
        });

        modelBuilder.Entity<TblProductDetail>(entity =>
        {
            entity.HasKey(e => e.ProductDetailId);

            entity.ToTable("tbl_ProductDetail");

            entity.Property(e => e.BarCode).HasMaxLength(50);

            entity.HasOne(d => d.ColorType).WithMany(p => p.TblProductDetails)
                .HasForeignKey(d => d.ColorTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductDetail_ColorType");

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.TblProductDetails)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductDetail_User");

            entity.HasOne(d => d.ProductHeader).WithMany(p => p.TblProductDetails)
                .HasForeignKey(d => d.ProductHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductDetail_ProductHeader");

            entity.HasOne(d => d.SizeTypeByLevel).WithMany(p => p.TblProductDetails)
                .HasForeignKey(d => d.SizeTypeByLevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductDetail_SizeTypeByLevel");

            entity.HasOne(d => d.Status).WithMany(p => p.TblProductDetails)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductDetail_Status");

            entity.HasOne(d => d.Unit).WithMany(p => p.TblProductDetails)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductDetail_Unit");
        });

        modelBuilder.Entity<TblProductFeature>(entity =>
        {
            entity.HasKey(e => e.ProductFeatureId);

            entity.ToTable("tbl_ProductFeature");

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.TblProductFeatures)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductFeature_User");

            entity.HasOne(d => d.ProductHeader).WithMany(p => p.TblProductFeatures)
                .HasForeignKey(d => d.ProductHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductFeature_ProductHeader");

            entity.HasOne(d => d.Status).WithMany(p => p.TblProductFeatures)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductFeature_Status");
        });

        modelBuilder.Entity<TblProductHeader>(entity =>
        {
            entity.HasKey(e => e.ProductHeaderId);

            entity.ToTable("tbl_ProductHeader");

            entity.Property(e => e.ProductTitle).HasMaxLength(250);
            entity.Property(e => e.Skucode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SKUCode");

            entity.HasOne(d => d.Brand).WithMany(p => p.TblProductHeaders)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductHeader_Brand");

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.TblProductHeaderCreatedByUsers)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductHeader_User");

            entity.HasOne(d => d.SubCategory).WithMany(p => p.TblProductHeaders)
                .HasForeignKey(d => d.SubCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductHeader_SubCategory");

            entity.HasOne(d => d.UpdatedByUser).WithMany(p => p.TblProductHeaderUpdatedByUsers)
                .HasForeignKey(d => d.UpdatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductHeader_User_Update");
        });

        modelBuilder.Entity<TblProductTag>(entity =>
        {
            entity.HasKey(e => e.ProductTagId);

            entity.ToTable("tbl_ProductTag");

            entity.HasOne(d => d.ProductHeader).WithMany(p => p.TblProductTags)
                .HasForeignKey(d => d.ProductHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductTag_ProductHeader");

            entity.HasOne(d => d.Status).WithMany(p => p.TblProductTags)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductTag_Status");

            entity.HasOne(d => d.Tag).WithMany(p => p.TblProductTags)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ProductTag_Tag");
        });

        modelBuilder.Entity<TblSeason>(entity =>
        {
            entity.HasKey(e => e.SeasonId);

            entity.ToTable("tbl_Season");

            entity.Property(e => e.SeasonEndDate).HasColumnType("date");
            entity.Property(e => e.SeasonStartDate).HasColumnType("date");
            entity.Property(e => e.SeasonTitle).HasMaxLength(500);

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.TblSeasons)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_Season_User");
        });

        modelBuilder.Entity<TblSeasonDiscount>(entity =>
        {
            entity.HasKey(e => e.SeasonDiscountId);

            entity.ToTable("tbl_SeasonDiscount");

            entity.HasOne(d => d.ProductHeader).WithMany(p => p.TblSeasonDiscounts)
                .HasForeignKey(d => d.ProductHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_SeasonDiscount_ProductHeader");

            entity.HasOne(d => d.Season).WithMany(p => p.TblSeasonDiscounts)
                .HasForeignKey(d => d.SeasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_SeasonDiscount_Season");

            entity.HasOne(d => d.Status).WithMany(p => p.TblSeasonDiscounts)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_SeasonDiscount_Status");
        });

        modelBuilder.Entity<TblShippingFee>(entity =>
        {
            entity.HasKey(e => e.ShippingFeeId);

            entity.ToTable("tbl_ShippingFee");

            entity.HasOne(d => d.City).WithMany(p => p.TblShippingFees)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ShippingFee_tbl_Country_City1");

            entity.HasOne(d => d.Status).WithMany(p => p.TblShippingFees)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ShippingFee_tbl_Status");
        });

        modelBuilder.Entity<TblSizeLevel>(entity =>
        {
            entity.HasKey(e => e.SizeLevelId);

            entity.ToTable("tbl_SizeLevel");

            entity.Property(e => e.SizeLevel).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSizeType>(entity =>
        {
            entity.HasKey(e => e.SizeTypeId);

            entity.ToTable("tbl_SizeType");

            entity.Property(e => e.SizeType).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSizeTypeByLevel>(entity =>
        {
            entity.HasKey(e => e.SizeTypeByLevelId);

            entity.ToTable("tbl_SizeTypeByLevel");

            entity.Property(e => e.SizeLevelValue).HasMaxLength(50);

            entity.HasOne(d => d.Gender).WithMany(p => p.TblSizeTypeByLevels)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_SizeTypeByLevel_tbl_Gender");

            entity.HasOne(d => d.SizeLevel).WithMany(p => p.TblSizeTypeByLevels)
                .HasForeignKey(d => d.SizeLevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_SizeTypeByLevel_SizeLevel");

            entity.HasOne(d => d.SizeType).WithMany(p => p.TblSizeTypeByLevels)
                .HasForeignKey(d => d.SizeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_SizeTypeByLevel_SizeType");

            entity.HasOne(d => d.Status).WithMany(p => p.TblSizeTypeByLevels)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_SizeTypeByLevel_Status");
        });

        modelBuilder.Entity<TblStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("tbl_Status");

            entity.Property(e => e.StatusId).ValueGeneratedNever();
            entity.Property(e => e.Status)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSubCategory>(entity =>
        {
            entity.HasKey(e => e.SubCategoryId);

            entity.ToTable("tbl_SubCategory");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.SubCategoryTitle).HasMaxLength(300);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Category).WithMany(p => p.TblSubCategories)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_SubCategory_Category");

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.TblSubCategories)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_SubCategory_User");

            entity.HasOne(d => d.Status).WithMany(p => p.TblSubCategories)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_tbl_SubCategory_Status");
        });

        modelBuilder.Entity<TblTag>(entity =>
        {
            entity.HasKey(e => e.TagId);

            entity.ToTable("tbl_Tag");

            entity.Property(e => e.TagTitle).HasMaxLength(250);
        });

        modelBuilder.Entity<TblUnit>(entity =>
        {
            entity.HasKey(e => e.UnitId);

            entity.ToTable("tbl_Unit");

            entity.Property(e => e.UnitTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("tbl_User");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.Gender).WithMany(p => p.TblUsers)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_User_tbl_Gender1");

            entity.HasOne(d => d.UserStatus).WithMany(p => p.TblUsers)
                .HasForeignKey(d => d.UserStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_User_tbl_UserStatus1");

            entity.HasOne(d => d.UserType).WithMany(p => p.TblUsers)
                .HasForeignKey(d => d.UserTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_User_tbl_UserType1");
        });

        modelBuilder.Entity<TblUserAddress>(entity =>
        {
            entity.HasKey(e => e.UserAddressId);

            entity.ToTable("tbl_UserAddress");

            entity.Property(e => e.ContactNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.AddressType).WithMany(p => p.TblUserAddresses)
                .HasForeignKey(d => d.AddressTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_UserAddress_tbl_AddressType1");

            entity.HasOne(d => d.City).WithMany(p => p.TblUserAddresses)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_tbl_UserAddress_tbl_Country_City1");

            entity.HasOne(d => d.Status).WithMany(p => p.TblUserAddresses)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_UserAddress_tbl_Status1");
        });

        modelBuilder.Entity<TblUserStatus>(entity =>
        {
            entity.HasKey(e => e.UserStatusId);

            entity.ToTable("tbl_UserStatus");

            entity.Property(e => e.UserStatus).HasMaxLength(150);
        });

        modelBuilder.Entity<TblUserType>(entity =>
        {
            entity.HasKey(e => e.UserTypeId).HasName("PK__tbl_User__40D2D81658B9E840");

            entity.ToTable("tbl_UserType");

            entity.Property(e => e.UserType).HasMaxLength(150);
        });

        modelBuilder.Entity<TblWishList>(entity =>
        {
            entity.HasKey(e => e.WishListId);

            entity.ToTable("tbl_WishList");

            entity.Property(e => e.AddDate).HasColumnType("date");

            entity.HasOne(d => d.ProductHeader).WithMany(p => p.TblWishLists)
                .HasForeignKey(d => d.ProductHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_WishList_ProductHeader");

            entity.HasOne(d => d.WishListUser).WithMany(p => p.TblWishLists)
                .HasForeignKey(d => d.WishListUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_WishList_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
