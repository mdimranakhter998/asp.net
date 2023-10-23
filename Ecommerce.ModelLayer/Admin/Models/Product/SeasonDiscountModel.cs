using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class SeasonDiscountModel
    {
        public SeasonDiscountModel()
        { 
            this.ProductHeader = new List<SelectListItem>();        
            this.Season = new List<SelectListItem>();
            this.Status = new List<SelectListItem>();

        }
        public int SeasonDiscountId { get; set; }

        public int ProductHeaderId { get; set; }

        public int DiscountPercent { get; set; }

        public int StatusId { get; set; }

        public int SeasonId { get; set; }

        public IList<SelectListItem> ProductHeader { get; set; } 

        public IList<SelectListItem> Season { get; set; }

        public IList<SelectListItem> Status { get; set; }
    }
}
