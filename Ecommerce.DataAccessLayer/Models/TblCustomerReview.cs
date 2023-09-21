using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblCustomerReview
{
    public int CustomerReviewId { get; set; }

    public int ProductHeaderId { get; set; }

    public string CustomerReview { get; set; } = null!;

    public int StatusId { get; set; }

    public int CustomerReviewUserId { get; set; }

    public int OrderHeaderId { get; set; }

    public virtual TblUser CustomerReviewUser { get; set; } = null!;

    public virtual TblOrderHeader OrderHeader { get; set; } = null!;

    public virtual TblProductHeader ProductHeader { get; set; } = null!;

    public virtual TblStatus Status { get; set; } = null!;

    public virtual ICollection<TblCustomerReviewImage> TblCustomerReviewImages { get; set; } = new List<TblCustomerReviewImage>();
}
