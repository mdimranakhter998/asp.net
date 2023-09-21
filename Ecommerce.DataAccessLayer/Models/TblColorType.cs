using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblColorType
{
    public int ColorTypeId { get; set; }

    public string ColorTitle { get; set; } = null!;

    public string ColorCode { get; set; } = null!;

    public int? StatusId { get; set; }

    public virtual TblStatus? Status { get; set; }

    public virtual ICollection<TblProductDetail> TblProductDetails { get; set; } = new List<TblProductDetail>();
}
