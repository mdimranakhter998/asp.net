using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblSizeLevel
{
    public int SizeLevelId { get; set; }

    public string SizeLevel { get; set; } = null!;

    public virtual ICollection<TblSizeTypeByLevel> TblSizeTypeByLevels { get; set; } = new List<TblSizeTypeByLevel>();
}
