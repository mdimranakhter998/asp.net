using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class ProductDetailModel
    {
        public ProductDetailModel()
        {
            this.ProductHeader = new List<SelectListItem>();
            this.Status = new List<SelectListItem>();
            this.ColorType = new List<SelectListItem>();
            this.CreatedByUser = new List<SelectListItem>();
            this.SizeTypeByLevel = new List<SelectListItem>();
            this.Unit = new List<SelectListItem>();



        }
        public int ProductDetailId { get; set; }

        public int ProductHeaderId { get; set; }

        public int ColorTypeId { get; set; }

        public int SizeTypeByLevelId { get; set; }

        public int UnitId { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public string BarCode { get; set; } = null!;

        public int StatusId { get; set; }

        public int CreatedByUserId { get; set; }

        public int UpdatedByUserId { get; set; }

        public IList<SelectListItem> ColorType { get; set; }

        public IList<SelectListItem> CreatedByUser { get; set; } 

        public IList<SelectListItem> ProductHeader { get; set; } 

        public IList<SelectListItem> SizeTypeByLevel { get; set; } 

        public IList<SelectListItem>  Status { get; set; }        

        public IList<SelectListItem> Unit { get; set; }

    }
}
