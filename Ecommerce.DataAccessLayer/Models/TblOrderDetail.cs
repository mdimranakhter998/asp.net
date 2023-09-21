using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblOrderDetail
{
    public int OrderDetailId { get; set; }

    public int OrderHeaderId { get; set; }

    public int ProductDetailId { get; set; }

    public double UnitPrice { get; set; }

    public int Quantity { get; set; }

    public int DiscountId { get; set; }

    public virtual TblDiscount Discount { get; set; } = null!;

    public virtual TblOrderHeader OrderHeader { get; set; } = null!;

    public virtual TblProductDetail ProductDetail { get; set; } = null!;
}
