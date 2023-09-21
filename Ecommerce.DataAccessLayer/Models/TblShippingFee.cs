using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblShippingFee
{
    public int ShippingFeeId { get; set; }

    public int CityId { get; set; }

    public double ShippingFee { get; set; }

    public int DeliveryTimeInDay { get; set; }

    public int StatusId { get; set; }

    public virtual TblCountryCity City { get; set; } = null!;

    public virtual TblStatus Status { get; set; } = null!;

    public virtual ICollection<TblOrderHeader> TblOrderHeaders { get; set; } = new List<TblOrderHeader>();
}
