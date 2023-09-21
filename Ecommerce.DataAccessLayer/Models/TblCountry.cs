using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblCountry
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public virtual ICollection<TblCountryCity> TblCountryCities { get; set; } = new List<TblCountryCity>();
}
