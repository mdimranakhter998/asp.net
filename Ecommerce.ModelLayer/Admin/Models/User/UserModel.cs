

namespace Ecommerce.ModelAccessLayer.Admin.Models.User
{
    public class UserModel
    {
        
        public int UserId { get; set; }

        public string UserName { get; set; } = null!;

        public string EmailAddress { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public int GenderId { get; set; }

        public int UserTypeId { get; set; }

        public int UserStatusId { get; set; }

        public List<GenderModel> Genders { get; set; }
        public List<UserTypeModel> UserTypes { get; set; }
        public List<UserStatusModel> UserStatuses { get; set; }

      


    }
}
