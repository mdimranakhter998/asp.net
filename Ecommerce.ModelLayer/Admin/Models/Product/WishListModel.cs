using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class WishListModel
    {
        public WishListModel() 
        {
            this.ProductHeader = new List<SelectListItem>();
            this.WishListUser = new List<SelectListItem>();

        }
        public int WishListId { get; set; }

        public int WishListUserId { get; set; }

        public int ProductHeaderId { get; set; }

        public DateTime AddDate { get; set; }

        public IList<SelectListItem> ProductHeader { get; set; } = null!;

        public IList<SelectListItem> WishListUser { get; set; } = null!;
    }
}
