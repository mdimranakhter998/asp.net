using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblUser
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int GenderId { get; set; }

    public int UserTypeId { get; set; }

    public int UserStatusId { get; set; }

    public virtual TblGender Gender { get; set; } = null!;

    public virtual ICollection<TblBankAccount> TblBankAccounts { get; set; } = new List<TblBankAccount>();

    public virtual ICollection<TblCategory> TblCategories { get; set; } = new List<TblCategory>();

    public virtual ICollection<TblCompare> TblCompares { get; set; } = new List<TblCompare>();

    public virtual ICollection<TblCustomerReview> TblCustomerReviews { get; set; } = new List<TblCustomerReview>();

    public virtual ICollection<TblDiscount> TblDiscountCreatedByUsers { get; set; } = new List<TblDiscount>();

    public virtual ICollection<TblDiscount> TblDiscountUpdatedByUsers { get; set; } = new List<TblDiscount>();

    public virtual ICollection<TblOrderHeader> TblOrderHeaders { get; set; } = new List<TblOrderHeader>();

    public virtual ICollection<TblProductDetail> TblProductDetails { get; set; } = new List<TblProductDetail>();

    public virtual ICollection<TblProductFeature> TblProductFeatures { get; set; } = new List<TblProductFeature>();

    public virtual ICollection<TblProductHeader> TblProductHeaderCreatedByUsers { get; set; } = new List<TblProductHeader>();

    public virtual ICollection<TblProductHeader> TblProductHeaderUpdatedByUsers { get; set; } = new List<TblProductHeader>();

    public virtual ICollection<TblSeason> TblSeasons { get; set; } = new List<TblSeason>();

    public virtual ICollection<TblSubCategory> TblSubCategories { get; set; } = new List<TblSubCategory>();

    public virtual ICollection<TblWishList> TblWishLists { get; set; } = new List<TblWishList>();

    public virtual TblUserStatus UserStatus { get; set; } = null!;

    public virtual TblUserType UserType { get; set; } = null!;
}
