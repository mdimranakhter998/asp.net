using Ecommerce.BusinessAccessLayer.Repository.Admin.User;
using Ecommerce.ModelAccessLayer.Admin.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceUI.Admin.Controllers
{
    [Route("[controller]")]
    public class UserTypeController : Controller
    {
        private readonly IUserType _userType;
        public UserTypeController(IUserType userType)
        {
            _userType = userType;
        }

        [Route("add",Name ="AddUserType")]
        public async Task<IActionResult> AddUserType()
        {
            return View();
        }
        [Route("add", Name = "AddUserType")]
        [HttpPost]
        public async Task<IActionResult> AddUserType(UserTypeModel model)
        {
            if (ModelState.IsValid)
            {
                int result = await _userType.AddAUserTypeAsync(model);
                if (result > 0)
                {
                    ViewData["Message"] = "You Have Added Successfully";
                    return Redirect("/list/");
                }
            }
            return View(ModelState);
        }

        [Route("list", Name = "UserTypeList")]
        [HttpGet]
        public async Task<IActionResult> UserTypeList()
        {
            var usertypes = await _userType.GetAllUserTypeAsync();
            if (usertypes == null)
            {
                ViewData["Message"] = "No Data Is Found";
                return View();
            }

            return View(usertypes);
        }

        [Route("edit/{Id}", Name = "EditUserTypeById")]
        public async Task<IActionResult> EditUserType(int Id)
        {
            var userType = await _userType.GetUserTypeByIdAsync(Id);
            if (userType == null)
            {
                return NotFound();
            }
            return View(userType);

        }

        [Route("edit", Name = "EditUserType")]
        public async Task<IActionResult> EditUserType(UserTypeModel model)
        {
            if (ModelState.IsValid)
            {
                int result = await _userType.EditUserTypeAsync(model);
                if (result > 0)
                {
                    ViewData["Message"] = "You Have Updated Successfully";
                    return Redirect("/list/");
                }
            }
            return View(ModelState);

        }

        [Route("delete/{Id}", Name = "DeleteUserType")]
        public async Task<IActionResult> DeleteUserType(int Id)
        {
            int deleteUserTypeById = await _userType.DeleteUserTypeAsync(Id);
            if (deleteUserTypeById == 0)
            {
                return NotFound();
            }
            ViewData["Message"] = "You have Deleted Successfully";
            return Redirect("/list/");
        }
    }
}
