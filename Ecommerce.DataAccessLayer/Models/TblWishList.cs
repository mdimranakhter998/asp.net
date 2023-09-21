using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblWishList
{
    public int WishListId { get; set; }

    public int WishListUserId { get; set; }

    public int ProductHeaderId { get; set; }

    public DateTime AddDate { get; set; }

    public virtual TblProductHeader ProductHeader { get; set; } = null!;

    public virtual TblUser WishListUser { get; set; } = null!;
}
