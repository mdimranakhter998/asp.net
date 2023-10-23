using Microsoft.AspNetCore.Mvc;

namespace EcommerceUI.Admin.Controllers
{
    public class AdminController:Controller
    {
        [Route("admin")]
        public async Task<IActionResult> Admin()
        {
            return View();
        }
    }
}
