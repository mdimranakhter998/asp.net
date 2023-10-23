using Ecommerce.BusinessAccessLayer.Repository.Admin.User;
using Ecommerce.ModelAccessLayer.Admin.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceUI.Admin.Controllers
{
    [Route("[controller]")]
    public class AddressTypeController : Controller
    {
        private readonly IAddressType _addressType;
        public AddressTypeController(IAddressType addressType) 
        {
            _addressType = addressType;
        }

        [Route("add", Name = "AddAddressType")]
        public async Task<IActionResult> AddAddressType()
        {
            return View();
        }
        [Route("add", Name = "AddAddressType")]
        [HttpPost]
        public async Task<IActionResult> AddAddressType(AddressTypeModel model)
        {
            if (ModelState.IsValid)
            {
                int result= await  _addressType.AddAddressTypeAsync(model);
                if (result > 0)
                {
                    ViewData["Message"] = "You Have Added Successfully";
                    return Redirect("/list/");
                }
            }
            return View(ModelState);
        }

        [Route("list", Name = "AddressTypeList")]
        [HttpGet]
        public async Task<IActionResult> AddressTypeList()
        {
          var addresses= await _addressType.GetAllAddressTypeAsync();
            if (addresses == null)
            {
                ViewData["Message"] = "No Data Is Found";
                return View();
            }

            return View(addresses);
        }

        [Route("edit/{Id}", Name = "EditAddressTypeById")]
        public async Task<IActionResult> EditAddressType(int Id)
        {
            var addressType= await _addressType.GetAddressTypeByIdAsync(Id);
            if (addressType == null)
            {
                return NotFound();
            }
            return View(addressType);

        }
        
        [Route("edit", Name = "EditAddressType")]
        public async Task<IActionResult>EditAddressType(AddressTypeModel model)
        {
            if (ModelState.IsValid)
            { 
               int result= await _addressType.EditAddessTypeAsync(model);
                if (result > 0)
                {
                    ViewData["Message"] = "You Have Updated Successfully";
                    return Redirect("/list/");
                }
            }
            return View(ModelState);

        }

        [Route("delete/{Id}", Name = "DeleteAddressType")]
        public async Task<IActionResult>DeleteAddressType(int Id)
        {
            int deleteAddressTypeById =await _addressType.DeleteAddressTypeAsync(Id);
            if (deleteAddressTypeById == 0)
            {
                return NotFound();
            }
            ViewData["Message"] = "You have Deleted Successfully";
            return Redirect("/list/");
        }
    }
}
