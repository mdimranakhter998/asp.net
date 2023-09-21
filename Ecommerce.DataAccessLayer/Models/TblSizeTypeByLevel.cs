using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblSizeTypeByLevel
{
    public int SizeTypeByLevelId { get; set; }

    public int SizeTypeId { get; set; }

    public int SizeLevelId { get; set; }

    public string SizeLevelValue { get; set; } = null!;

    public int StatusId { get; set; }

    public int GenderId { get; set; }

    public virtual TblGender Gender { get; set; } = null!;

    public virtual TblSizeLevel SizeLevel { get; set; } = null!;

    public virtual TblSizeType SizeType { get; set; } = null!;

    public virtual TblStatus Status { get; set; } = null!;

    public virtual ICollection<TblProductDetail> TblProductDetails { get; set; } = new List<TblProductDetail>();
}
