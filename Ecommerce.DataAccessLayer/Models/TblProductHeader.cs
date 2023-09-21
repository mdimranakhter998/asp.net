using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblProductHeader
{
    public int ProductHeaderId { get; set; }

    public int SubCategoryId { get; set; }

    public string ProductTitle { get; set; } = null!;

    public int BrandId { get; set; }

    public int CreatedByUserId { get; set; }

    public int UpdatedByUserId { get; set; }

    public string ProductInformation { get; set; } = null!;

    public string Skucode { get; set; } = null!;

    public virtual TblBrand Brand { get; set; } = null!;

    public virtual TblUser CreatedByUser { get; set; } = null!;

    public virtual TblSubCategory SubCategory { get; set; } = null!;

    public virtual ICollection<TblCustomerReview> TblCustomerReviews { get; set; } = new List<TblCustomerReview>();

    public virtual ICollection<TblProductDetail> TblProductDetails { get; set; } = new List<TblProductDetail>();

    public virtual ICollection<TblProductFeature> TblProductFeatures { get; set; } = new List<TblProductFeature>();

    public virtual ICollection<TblProductTag> TblProductTags { get; set; } = new List<TblProductTag>();

    public virtual ICollection<TblSeasonDiscount> TblSeasonDiscounts { get; set; } = new List<TblSeasonDiscount>();

    public virtual ICollection<TblWishList> TblWishLists { get; set; } = new List<TblWishList>();

    public virtual TblUser UpdatedByUser { get; set; } = null!;
}
