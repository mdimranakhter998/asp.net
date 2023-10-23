using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class SeasonModel
    {
        public SeasonModel() 
        {
            this.CreatedByUser = new List<SelectListItem>();
        }
        public int SeasonId { get; set; }

        public string SeasonTitle { get; set; } = null!;

        public DateTime SeasonStartDate { get; set; }

        public DateTime SeasonEndDate { get; set; }

        public int CreatedByUserId { get; set; }

        public IList<SelectListItem> CreatedByUser { get; set; }
    }
}
