using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblCompare
{
    public int CompareId { get; set; }

    public int CompareUserId { get; set; }

    public int ProductDetailId { get; set; }

    public virtual TblUser CompareUser { get; set; } = null!;

    public virtual TblProductDetail ProductDetail { get; set; } = null!;
}
