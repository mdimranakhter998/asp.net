using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class CompareModel
    {
        public CompareModel()
        {
            this.CompareUser = new List<SelectListItem>();
            this.ProductDetail = new List<SelectListItem>();


        }
        public int CompareId { get; set; }

        public int CompareUserId { get; set; }

        public int ProductDetailId { get; set; }

        public IList<SelectListItem> CompareUser { get; set; } = null!;

        public IList<SelectListItem> ProductDetail { get; set; } = null!;
    }
}
