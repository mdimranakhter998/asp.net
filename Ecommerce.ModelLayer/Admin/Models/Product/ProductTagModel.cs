
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class ProductTagModel
    {
        public ProductTagModel() 
        {
            this.ProductHeader = new List<SelectListItem>();
            this.Status = new List<SelectListItem>();
            this.Tag = new List<SelectListItem>();

        }
        public int ProductTagId { get; set; }

        public int ProductHeaderId { get; set; }

        public int TagId { get; set; }

        public int StatusId { get; set; }

        public IList<SelectListItem> ProductHeader { get; set; }

        public IList<SelectListItem> Status { get; set; }

        public IList<SelectListItem> Tag { get; set; }
    }
}
