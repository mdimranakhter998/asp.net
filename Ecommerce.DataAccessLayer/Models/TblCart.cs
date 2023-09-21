using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblCart
{
    public int CartId { get; set; }

    public int ProductDetailId { get; set; }

    public int Quantity { get; set; }

    public int DiscountId { get; set; }

    public string UniqueNo { get; set; } = null!;

    public double UnitPrice { get; set; }

    public virtual TblDiscount Discount { get; set; } = null!;

    public virtual TblProductDetail ProductDetail { get; set; } = null!;
}
