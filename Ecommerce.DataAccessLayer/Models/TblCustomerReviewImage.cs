using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblCustomerReviewImage
{
    public int CustomerReviewImageId { get; set; }

    public int CustomerReviewId { get; set; }

    public string ImagePath { get; set; } = null!;

    public int StatusId { get; set; }

    public virtual TblCustomerReview CustomerReview { get; set; } = null!;

    public virtual TblStatus Status { get; set; } = null!;
}
