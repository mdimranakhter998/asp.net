using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblProductFeature
{
    public int ProductFeatureId { get; set; }

    public int ProductHeaderId { get; set; }

    public string ProductFeature { get; set; } = null!;

    public int CreatedByUserId { get; set; }

    public int UpdatedByUserId { get; set; }

    public int StatusId { get; set; }

    public virtual TblUser CreatedByUser { get; set; } = null!;

    public virtual TblProductHeader ProductHeader { get; set; } = null!;

    public virtual TblStatus Status { get; set; } = null!;
}
