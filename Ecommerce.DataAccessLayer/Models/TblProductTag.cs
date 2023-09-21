using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblProductTag
{
    public int ProductTagId { get; set; }

    public int ProductHeaderId { get; set; }

    public int TagId { get; set; }

    public int StatusId { get; set; }

    public virtual TblProductHeader ProductHeader { get; set; } = null!;

    public virtual TblStatus Status { get; set; } = null!;

    public virtual TblTag Tag { get; set; } = null!;
}
