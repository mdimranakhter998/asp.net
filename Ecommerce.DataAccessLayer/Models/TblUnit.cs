using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblUnit
{
    public int UnitId { get; set; }

    public string UnitTitle { get; set; } = null!;

    public virtual ICollection<TblProductDetail> TblProductDetails { get; set; } = new List<TblProductDetail>();
}
