using Ecommerce.ModelAccessLayer.Admin.Models.User;

namespace Ecommerce.BusinessAccessLayer.Repository.Admin.User
{
    public interface IUserStatus
    {
        Task<int> AddAUserStatusAsync(UserStatusModel userStatus);
        Task<IEnumerable<UserStatusModel>> GetAllUserStatusAsync();
        Task<UserStatusModel> GetUserStatusByIdAsync(int id);
        Task<int> EditUserStatusAsync(UserStatusModel userStatus);
        Task<int> DeleteUserStatusAsync(int id);
    }
}
