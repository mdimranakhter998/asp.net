using Ecommerce.ModelAccessLayer.Admin.Models.User;

namespace Ecommerce.BusinessAccessLayer.Repository.Admin.User
{
    public interface IUserType
    {
        Task<int> AddAUserTypeAsync(UserTypeModel userType);
        Task<IEnumerable<UserTypeModel>> GetAllUserTypeAsync();
        Task<UserTypeModel> GetUserTypeByIdAsync(int id);
        Task<int> EditUserTypeAsync(UserTypeModel userType);
        Task<int> DeleteUserTypeAsync(int id);
    }
}
