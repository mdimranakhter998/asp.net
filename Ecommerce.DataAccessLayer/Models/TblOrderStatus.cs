using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblOrderStatus
{
    public int OrderStatusId { get; set; }

    public string OrderStatusTitle { get; set; } = null!;

    public int StatusId { get; set; }

    public virtual TblStatus Status { get; set; } = null!;

    public virtual ICollection<TblOrderHeader> TblOrderHeaders { get; set; } = new List<TblOrderHeader>();
}
