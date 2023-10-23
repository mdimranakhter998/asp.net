using Ecommerce.BusinessAccessLayer.Repository.Admin.User;
using Ecommerce.ModelAccessLayer.Admin.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceUI.Admin.Controllers
{
    [Route("[controller]")]
    public class UserStatusController : Controller
    {
        private readonly IUserStatus _userStatus;
        public UserStatusController(IUserStatus userStatus)
        {
            _userStatus = userStatus;
        }

        [Route("add", Name = "AddUserStatus")]
        public async Task<IActionResult> AddUserStatus()
        {
            return View();
        }
        [Route("add", Name = "AddUserStatus")]
        [HttpPost]
        public async Task<IActionResult> AddUserStatus(UserStatusModel model)
        {
            if (ModelState.IsValid)
            {
                int result = await _userStatus.AddAUserStatusAsync(model);
                if (result > 0)
                {
                    ViewData["Message"] = "You Have Added Successfully";
                    return Redirect("/list/");
                }
            }
            return View(ModelState);
        }

        [Route("list", Name = "UserStatusList")]
        [HttpGet]
        public async Task<IActionResult> UserStatusList()
        {
            var userStatuses = await _userStatus.GetAllUserStatusAsync();
            if (userStatuses == null)
            {
                ViewData["Message"] = "No Data Is Found";
                return View();
            }

            return View(userStatuses);
        }

        [Route("edit/{Id}", Name = "EditUserStatusById")]
        public async Task<IActionResult> EditUserStatus(int Id)
        {
            var userStatus = await _userStatus.GetUserStatusByIdAsync(Id);
            if (userStatus == null)
            {
                return NotFound();
            }
            return View(userStatus);

        }

        [Route("edit", Name = "EditUserStatus")]
        public async Task<IActionResult> EditUserStatus(UserStatusModel model)
        {
            if (ModelState.IsValid)
            {
                int result = await _userStatus.EditUserStatusAsync(model);
                if (result > 0)
                {
                    ViewData["Message"] = "You Have Updated Successfully";
                    return Redirect("/list/");
                }
            }
            return View(ModelState);

        }

        [Route("delete/{Id}", Name = "DeleteUserStatus")]
        public async Task<IActionResult> DeleteUserStatus(int Id)
        {
            int deleteUserStatusById = await _userStatus.DeleteUserStatusAsync(Id);
            if (deleteUserStatusById == 0)
            {
                return NotFound();
            }
            ViewData["Message"] = "You have Deleted Successfully";
            return Redirect("/list/");
        }
    }
}
