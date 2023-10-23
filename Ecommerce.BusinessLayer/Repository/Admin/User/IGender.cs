using Ecommerce.ModelAccessLayer.Admin.Models.User;

namespace Ecommerce.BusinessAccessLayer.Repository.Admin.User
{
    public interface IGender
    {
        Task<int> AddGenderAsync(GenderModel gender);
        Task<IEnumerable<GenderModel>> GetAllGenderAsync();
        Task<GenderModel> GetGenderByIdAsync(int Id);
        Task<int> EditGenderAsync(GenderModel gender);
        Task<int> DeleteGenderAsync(int Id);

    }
}
