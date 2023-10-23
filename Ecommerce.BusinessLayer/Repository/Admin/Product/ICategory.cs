using Ecommerce.ModelAccessLayer.Admin.Models.Product;

namespace Ecommerce.BusinessAccessLayer.Repository.Admin.Product
{
    public interface ICategory
    {
        public Task<int> AddCategoryAsync(CategoryModel category);
        public Task<IEnumerable<CategoryModel>> GetAllCategoryAsync();
        public Task<CategoryModel> GetCategoryByIdAsync(int id);
        public Task<int> EditCategoryAsync(CategoryModel category);
        public Task<int> DeleteCategoryAsync(int id);
    }
}
