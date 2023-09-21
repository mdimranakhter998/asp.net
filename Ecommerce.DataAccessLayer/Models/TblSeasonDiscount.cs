using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblSeasonDiscount
{
    public int SeasonDiscountId { get; set; }

    public int ProductHeaderId { get; set; }

    public int DiscountPercent { get; set; }

    public int StatusId { get; set; }

    public int SeasonId { get; set; }

    public virtual TblProductHeader ProductHeader { get; set; } = null!;

    public virtual TblSeason Season { get; set; } = null!;

    public virtual TblStatus Status { get; set; } = null!;
}
