using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblSizeType
{
    public int SizeTypeId { get; set; }

    public string SizeType { get; set; } = null!;

    public virtual ICollection<TblSizeTypeByLevel> TblSizeTypeByLevels { get; set; } = new List<TblSizeTypeByLevel>();
}
