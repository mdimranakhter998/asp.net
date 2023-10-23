using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ModelAccessLayer.Admin.Models.User
{
    public class UserTypeModel
    {
        [Display(Name = "Id")]
        public int UserTypeId { get; set; }
        [Display(Name = "User Type")]
        public string? UserType { get; set; }
    }
}
