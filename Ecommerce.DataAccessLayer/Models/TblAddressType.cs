using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblAddressType
{
    public int AddressTypeId { get; set; }

    public string AddressType { get; set; } = null!;

    public virtual ICollection<TblUserAddress> TblUserAddresses { get; set; } = new List<TblUserAddress>();
}
