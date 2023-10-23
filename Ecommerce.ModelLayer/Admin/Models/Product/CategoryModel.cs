using Ecommerce.ModelAccessLayer.Admin.Models.User;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.ModelAccessLayer.Admin.Models.Product
{
    public class CategoryModel
    {
        public CategoryModel()
        {
            this.Status = new List<SelectListItem>();
            this.User = new List<SelectListItem>();
            this.userModel = new UserModel();
            this.statusModel = new StatusModel();

        }
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int StatusId { get; set; }
        public IList<SelectListItem> Status { get; set; }
        public IList<SelectListItem> User { get; set; }
        public  StatusModel statusModel { get; set; }
        public  UserModel userModel { get; set; } 
    }
}