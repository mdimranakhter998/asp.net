using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblCountryCity
{
    public int CityId { get; set; }

    public string CityName { get; set; } = null!;

    public int? CountryId { get; set; }

    public virtual TblCountry? Country { get; set; }

    public virtual ICollection<TblShippingFee> TblShippingFees { get; set; } = new List<TblShippingFee>();

    public virtual ICollection<TblUserAddress> TblUserAddresses { get; set; } = new List<TblUserAddress>();
}
