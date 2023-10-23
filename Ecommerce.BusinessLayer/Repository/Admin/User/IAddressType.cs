using Ecommerce.ModelAccessLayer.Admin.Models.User;

namespace Ecommerce.BusinessAccessLayer.Repository.Admin.User
{
    public interface IAddressType
    {
        public Task<int> AddAddressTypeAsync(AddressTypeModel addressType);
        public Task<IEnumerable<AddressTypeModel>> GetAllAddressTypeAsync();
        public Task<AddressTypeModel> GetAddressTypeByIdAsync(int id);
        public Task<int> EditAddessTypeAsync(AddressTypeModel addressType);
        public Task<int> DeleteAddressTypeAsync(int id);

    }
}
