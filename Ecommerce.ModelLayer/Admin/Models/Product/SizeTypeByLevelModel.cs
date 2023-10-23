using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class SizeTypeByLevelModel
    {
        public SizeTypeByLevelModel() 
        {
            this.Gender = new List<SelectListItem>();
            this.SizeLevel = new List<SelectListItem>();
            this.SizeType = new List<SelectListItem>();
            this.Status = new List<SelectListItem>();
        }
        public int SizeTypeByLevelId { get; set; }

        public int SizeTypeId { get; set; }

        public int SizeLevelId { get; set; }

        public string SizeLevelValue { get; set; } 

        public int StatusId { get; set; }

        public int GenderId { get; set; }

        public IList<SelectListItem> Gender { get; set; } 

        public IList<SelectListItem> SizeLevel { get; set; } 

        public IList<SelectListItem> SizeType { get; set; } 

        public IList<SelectListItem> Status { get; set; } 

    }
}
