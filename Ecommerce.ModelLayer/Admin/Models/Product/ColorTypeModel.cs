using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    
    public class ColorTypeModel
    {
        public ColorTypeModel() 
        {
            this.Status=new List<SelectListItem>();
        }

        public int ColorTypeId { get; set; }

        public string ColorTitle { get; set; }

        public string ColorCode { get; set; }

        public int? StatusId { get; set; }

        public IList<SelectListItem>  Status { get; set; }
    }
}
