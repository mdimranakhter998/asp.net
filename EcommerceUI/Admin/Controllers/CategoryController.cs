using Ecommerce.BusinessAccessLayer.Repository.Admin.Product;
using Ecommerce.BusinessAccessLayer.Repository.Services.Admin.Product;
using Ecommerce.ModelAccessLayer.Admin.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EcommerceUI.Admin.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
	{
		private readonly ICategory _category;
		private readonly IStatus _status;

      
        public CategoryController(ICategory category,IStatus status)
		{
			_category = category;
			_status = status;
		}
		[Route("add")]
		public async Task<IActionResult> AddCategory()
		{
			var statuses = await _status.GetAllStatusAsync();
			CategoryModel categoryModel = new CategoryModel();
			categoryModel.Status.Add(new SelectListItem() {Text = "Select", Selected = true });
			foreach(var status in statuses) 
			{
				categoryModel.Status.Add(new SelectListItem()
				{
					Value=status.StatusId.ToString(),
					Text=status.Status
					
				});

			}
			return View(categoryModel);
		}
		[Route("add")]
		[HttpPost]
		public async Task<IActionResult> AddCategory(CategoryModel model)
		{
			if (ModelState.IsValid)
			{
				int addCategory=await _category.AddCategoryAsync(model);
				if (addCategory > 0)
				{
					ModelState.Clear();
					ViewData["Message"] = "you have added Successfully";
					return Redirect("list");
				}
			}
			return View(model);
		}
		
		
		
	}
}
