using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblStatus
{
    public int StatusId { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<TblBankAccount> TblBankAccounts { get; set; } = new List<TblBankAccount>();

    public virtual ICollection<TblCategory> TblCategories { get; set; } = new List<TblCategory>();

    public virtual ICollection<TblColorType> TblColorTypes { get; set; } = new List<TblColorType>();

    public virtual ICollection<TblCustomerReviewImage> TblCustomerReviewImages { get; set; } = new List<TblCustomerReviewImage>();

    public virtual ICollection<TblCustomerReview> TblCustomerReviews { get; set; } = new List<TblCustomerReview>();

    public virtual ICollection<TblDiscount> TblDiscounts { get; set; } = new List<TblDiscount>();

    public virtual ICollection<TblOrderStatus> TblOrderStatuses { get; set; } = new List<TblOrderStatus>();

    public virtual ICollection<TblProductDetail> TblProductDetails { get; set; } = new List<TblProductDetail>();

    public virtual ICollection<TblProductFeature> TblProductFeatures { get; set; } = new List<TblProductFeature>();

    public virtual ICollection<TblProductTag> TblProductTags { get; set; } = new List<TblProductTag>();

    public virtual ICollection<TblSeasonDiscount> TblSeasonDiscounts { get; set; } = new List<TblSeasonDiscount>();

    public virtual ICollection<TblShippingFee> TblShippingFees { get; set; } = new List<TblShippingFee>();

    public virtual ICollection<TblSizeTypeByLevel> TblSizeTypeByLevels { get; set; } = new List<TblSizeTypeByLevel>();

    public virtual ICollection<TblSubCategory> TblSubCategories { get; set; } = new List<TblSubCategory>();

    public virtual ICollection<TblUserAddress> TblUserAddresses { get; set; } = new List<TblUserAddress>();
}
