using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class BrandModel
    {
        public BrandModel() 
        {
            this.Status = new List<SelectListItem>();
        }
        public int BrandId { get; set; }

        public string BrandTitle { get; set; } = null!;

        public int StatusId { get; set; }

        public IList<SelectListItem> Status { get; set; }
        
       
    }
}
