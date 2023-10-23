using Ecommerce.BusinessAccessLayer.Repository.Admin.Product;
using Ecommerce.BusinessAccessLayer.Repository.Services.Admin.Product;
using Ecommerce.ModelAccessLayer.Admin.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceUI.Admin.Controllers
{
    [Route("[controller]")]
    public class StatusController : Controller
	{
		private readonly IStatus _status;
		public StatusController(IStatus status)
		{
			_status= status;
		}

		[Route("add",Name = "AddStatus")]
		public async Task<IActionResult> AddStatus()
		{
			return View();
		}
		[Route("add", Name = "AddStaus")]
        [HttpPost]
		public async Task<IActionResult> AddStatus(StatusModel model)
		{
			if (ModelState.IsValid)
			{
				int result = await _status.AddStatusAsync(model);
				if (result > 0)
				{
					ViewData["Message"] = "You Have Added Successfully";
					return Redirect("list");
				}
			}
			return View(ModelState);
		}

		[Route("list",Name ="StatusList")]
		[HttpGet]
		public async Task<IActionResult> StatusList()
		{
			var statuses = await _status.GetAllStatusAsync();
			if (statuses == null)
			{
				ViewData["Message"] = "No Data Is Found";
				return View();
			}

			return View(statuses);
		}

		[Route("edit/{Id}",Name ="EditStatusById")]
		[HttpGet]
		public async Task<IActionResult> EditStatus(int Id)
		{
			var status = await _status.GetStatusByIdAsync(Id);
			if (status == null)
			{
				return NotFound();
			}
			return View(status);

		}

		[Route("edit",Name ="EditStatus")]
		[HttpPost]
		public async Task<IActionResult> EditStatus(StatusModel model)
		{
			if (ModelState.IsValid)
			{
				int result = await _status.EditStatusAsync(model);
				if (result > 0)
				{
					ViewData["Message"] = "You Have Updated Successfully";
					return Redirect("list");
				}
			}
			return View(model);

		}

		[Route("delete/{Id}",Name ="DeleteStatus")]
	
		public async Task<IActionResult> DeleteStatus(int Id)
		{
			int deleteStatusById = await _status.DeleteStatusAsync(Id);
			if (deleteStatusById == 0)
			{
				return NotFound();
			}
			ViewData["Message"] = "You have Deleted Successfully";
			return Redirect("status/list/");
		}
	}
}
