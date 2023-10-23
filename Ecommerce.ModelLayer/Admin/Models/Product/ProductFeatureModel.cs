using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class ProductFeatureModel
    {
        public ProductFeatureModel()
        {
            this.CreatedByUser = new List<SelectListItem>();
            this.ProductHeader = new List<SelectListItem>();
            this.Status  = new List<SelectListItem>();

        }
        public int ProductFeatureId { get; set; }

        public int ProductHeaderId { get; set; }

        public string ProductFeature { get; set; }

        public int CreatedByUserId { get; set; }

        public int UpdatedByUserId { get; set; }

        public int StatusId { get; set; }

        public IList<SelectListItem> CreatedByUser { get; set; }

        public IList<SelectListItem> ProductHeader { get; set; }

        public IList<SelectListItem> Status { get; set; }
    }
}
