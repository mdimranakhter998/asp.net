using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblBrand
{
    public int BrandId { get; set; }

    public string BrandTitle { get; set; } = null!;

    public int StatusId { get; set; }

    public virtual TblStatus Status { get; set; } = null!;

    public virtual ICollection<TblProductHeader> TblProductHeaders { get; set; } = new List<TblProductHeader>();
}
