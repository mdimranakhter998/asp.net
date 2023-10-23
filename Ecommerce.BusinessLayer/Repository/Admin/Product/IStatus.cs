using Ecommerce.ModelAccessLayer.Admin.Models.Product;

namespace Ecommerce.BusinessAccessLayer.Repository.Admin.Product
{
    public interface IStatus
	{
		Task<int> AddStatusAsync(StatusModel status);
		Task <IEnumerable<StatusModel>> GetAllStatusAsync();
		Task<StatusModel> GetStatusByIdAsync(int id);
		Task <int>EditStatusAsync(StatusModel status);
		Task<int> DeleteStatusAsync(int id);
	}
}
