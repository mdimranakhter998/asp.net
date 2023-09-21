using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblGender
{
    public int GenderId { get; set; }

    public string? GenderType { get; set; }

    public virtual ICollection<TblSizeTypeByLevel> TblSizeTypeByLevels { get; set; } = new List<TblSizeTypeByLevel>();

    public virtual ICollection<TblUser> TblUsers { get; set; } = new List<TblUser>();
}
