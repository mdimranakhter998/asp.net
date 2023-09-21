using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblSeason
{
    public int SeasonId { get; set; }

    public string SeasonTitle { get; set; } = null!;

    public DateTime SeasonStartDate { get; set; }

    public DateTime SeasonEndDate { get; set; }

    public int CreatedByUserId { get; set; }

    public virtual TblUser CreatedByUser { get; set; } = null!;

    public virtual ICollection<TblSeasonDiscount> TblSeasonDiscounts { get; set; } = new List<TblSeasonDiscount>();
}
