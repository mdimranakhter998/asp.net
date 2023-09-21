using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblUserAddress
{
    public int UserAddressId { get; set; }

    public int UserId { get; set; }

    public int AddressTypeId { get; set; }

    public string FullAddress { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string ContactNo { get; set; } = null!;

    public int StatusId { get; set; }

    public int? CityId { get; set; }

    public virtual TblAddressType AddressType { get; set; } = null!;

    public virtual TblCountryCity? City { get; set; }

    public virtual TblStatus Status { get; set; } = null!;

    public virtual ICollection<TblOrderHeader> TblOrderHeaders { get; set; } = new List<TblOrderHeader>();
}
