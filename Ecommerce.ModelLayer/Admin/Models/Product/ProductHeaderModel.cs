using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class ProductHeaderModel
    {
        public ProductHeaderModel()
        {
            this.Brand=new List<SelectListItem>();
            this.CreatedByUser = new List<SelectListItem>();
            this.SubCategory = new List<SelectListItem>();
            this.UpdatedByUser = new List<SelectListItem>();
        }
        public int ProductHeaderId { get; set; }

        public int SubCategoryId { get; set; }

        public string ProductTitle { get; set; }

        public int BrandId { get; set; }

        public int CreatedByUserId { get; set; }

        public int UpdatedByUserId { get; set; }

        public string ProductInformation { get; set; }

        public string Skucode { get; set; }

        public IList<SelectListItem> Brand { get; set; }

        public IList<SelectListItem> CreatedByUser { get; set; }

        public IList<SelectListItem>SubCategory { get; set; }
        public IList<SelectListItem> UpdatedByUser { get; set; }
    }
}
