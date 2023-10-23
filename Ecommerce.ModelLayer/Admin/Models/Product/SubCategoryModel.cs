using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class SubCategoryModel
    {

        public SubCategoryModel() 
        {
            this.Category=new List<SelectListItem>();
            this.CreatedByUser = new List<SelectListItem>();
            this.Status = new List<SelectListItem>();

        }
        public int SubCategoryId { get; set; }

        public string SubCategoryTitle { get; set; }

        public int CreatedByUserId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public int CategoryId { get; set; }

        public int? StatusId { get; set; }

        public IList<SelectListItem> Category { get; set; }

        public IList<SelectListItem> CreatedByUser { get; set; }
        public IList<SelectListItem > Status { get; set; }

    }
}
