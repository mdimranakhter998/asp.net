using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblProductDetail
{
    public int ProductDetailId { get; set; }

    public int ProductHeaderId { get; set; }

    public int ColorTypeId { get; set; }

    public int SizeTypeByLevelId { get; set; }

    public int UnitId { get; set; }

    public int Quantity { get; set; }

    public double UnitPrice { get; set; }

    public string BarCode { get; set; } = null!;

    public int StatusId { get; set; }

    public int CreatedByUserId { get; set; }

    public int UpdatedByUserId { get; set; }

    public virtual TblColorType ColorType { get; set; } = null!;

    public virtual TblUser CreatedByUser { get; set; } = null!;

    public virtual TblProductHeader ProductHeader { get; set; } = null!;

    public virtual TblSizeTypeByLevel SizeTypeByLevel { get; set; } = null!;

    public virtual TblStatus Status { get; set; } = null!;

    public virtual ICollection<TblCart> TblCarts { get; set; } = new List<TblCart>();

    public virtual ICollection<TblCompare> TblCompares { get; set; } = new List<TblCompare>();

    public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; } = new List<TblOrderDetail>();

    public virtual TblUnit Unit { get; set; } = null!;
}
