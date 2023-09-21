using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblDiscount
{
    public int DiscountId { get; set; }

    public string DiscountTitle { get; set; } = null!;

    public byte[] CouponCode { get; set; } = null!;

    public string DiscountDescription { get; set; } = null!;

    public int StatusId { get; set; }

    public int CreatedByUserId { get; set; }

    public int UpdatedByUserId { get; set; }

    public virtual TblUser CreatedByUser { get; set; } = null!;

    public virtual TblStatus Status { get; set; } = null!;

    public virtual ICollection<TblCart> TblCarts { get; set; } = new List<TblCart>();

    public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; } = new List<TblOrderDetail>();

    public virtual TblUser UpdatedByUser { get; set; } = null!;
}
