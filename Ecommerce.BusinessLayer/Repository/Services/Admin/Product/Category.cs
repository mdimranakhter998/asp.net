using Ecommerce.BusinessAccessLayer.Repository.Admin.Product;
using Ecommerce.DataAccessLayer;
using Ecommerce.DataAccessLayer.Models;
using Ecommerce.ModelAccessLayer.Admin.Models.Product;
using Ecommerce.ModelAccessLayer.Admin.Models.User;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Net.WebSockets;

namespace Ecommerce.BusinessAccessLayer.Repository.Services.Admin.Product
{
    public class Category : ICategory
    {
        private readonly Context _context;
        public Category(Context context)
        {
            _context = context;
        }
        public async Task<int> AddCategoryAsync(CategoryModel category)
        {
            if (category == null)
            {
                return 0;
            }
            try
            {
                TblCategory entity = new TblCategory()
                {

                    CategoryTitle = category.CategoryTitle,
                    CreatedByUserId = category.CreatedByUserId,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    StatusId = category.StatusId,

                };
                await _context.TblCategories.AddAsync(entity);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return 0;
        }

        public async Task<int> DeleteCategoryAsync(int id)
        {
            if (id == 0)
            {
                return 0;
            }
            var getCategoryById = await _context.TblCategories.FindAsync(id);
            if (getCategoryById == null)
            {
                return 0;
            }
            try
            {
                _context.TblCategories.Remove(getCategoryById);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;

        }

        public async Task<int> EditCategoryAsync(CategoryModel category)
        {
            var getCategoryById = await _context.TblCategories.FindAsync(category.CategoryId);
            if (getCategoryById == null)
            {
                return 0;
            }
            try
            {
                getCategoryById.CategoryId = category.CategoryId;
                getCategoryById.CategoryTitle = category.CategoryTitle;
                getCategoryById.UpdatedOn = DateTime.Now;
                getCategoryById.CreatedByUserId = category.CreatedByUserId;
                getCategoryById.StatusId = category.StatusId;
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }

        public async Task<IEnumerable<CategoryModel>> GetAllCategoryAsync()
        {

            var getAllCategory = await _context.TblCategories.Select(c => new
            {
                c.CategoryId,
                c.CategoryTitle,
                c.CreatedOn,
                c.UpdatedOn,
                c.CreatedByUser.UserName,
                c.Status.Status
            }).ToListAsync();

            if (getAllCategory == null)
            {
                return null;
            }
            List<CategoryModel> categoryModelList = new List<CategoryModel>();

            var categoryModel = new CategoryModel();

            foreach (var category in getAllCategory)
            {

                categoryModel.CategoryId = category.CategoryId;
                categoryModel.CategoryTitle = category.CategoryTitle;
                categoryModel.userModel.UserName = category.UserName;
                categoryModel.CreatedOn = category.CreatedOn;
                categoryModel.UpdatedOn = category.UpdatedOn;
                categoryModel.statusModel.Status = category.Status;
                categoryModelList.Add(categoryModel);
            }           

            return categoryModelList;
        }

        public async Task<CategoryModel> GetCategoryByIdAsync(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var getCategoryById = _context.TblCategories.Select(c => new
            {
                c.CategoryId,
                c.CategoryTitle,
                c.CreatedByUser.UserName,
                c.CreatedOn,
                c.UpdatedOn,
                c.Status.Status
            }).Where(c => c.CategoryId == id).ToListAsync();
            if (getCategoryById == null)
            {
                return null;
            }

            var categoryModel = new CategoryModel();

            foreach (var category in await getCategoryById)
            {               

                categoryModel.CategoryId = category.CategoryId;
                categoryModel.CategoryTitle = category.CategoryTitle;
                categoryModel.userModel.UserName = category.UserName;
                categoryModel.CreatedOn = category.CreatedOn;
                categoryModel.UpdatedOn = category.UpdatedOn;
                categoryModel.statusModel.Status = category.Status;               
            }

            return categoryModel;

        }
    }
}
