using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblSubCategory
{
    public int SubCategoryId { get; set; }

    public string SubCategoryTitle { get; set; } = null!;

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public int CategoryId { get; set; }

    public int? StatusId { get; set; }

    public virtual TblCategory Category { get; set; } = null!;

    public virtual TblUser CreatedByUser { get; set; } = null!;

    public virtual TblStatus? Status { get; set; }

    public virtual ICollection<TblProductHeader> TblProductHeaders { get; set; } = new List<TblProductHeader>();
}
