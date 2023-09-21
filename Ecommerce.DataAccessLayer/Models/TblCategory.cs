using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblCategory
{
    public int CategoryId { get; set; }

    public string CategoryTitle { get; set; } = null!;

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public int? StatusId { get; set; }

    public virtual TblUser CreatedByUser { get; set; } = null!;

    public virtual TblStatus? Status { get; set; }

    public virtual ICollection<TblSubCategory> TblSubCategories { get; set; } = new List<TblSubCategory>();
}
