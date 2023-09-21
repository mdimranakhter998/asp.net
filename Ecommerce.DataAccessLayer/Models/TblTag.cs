using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblTag
{
    public int TagId { get; set; }

    public string TagTitle { get; set; } = null!;

    public virtual ICollection<TblProductTag> TblProductTags { get; set; } = new List<TblProductTag>();
}
