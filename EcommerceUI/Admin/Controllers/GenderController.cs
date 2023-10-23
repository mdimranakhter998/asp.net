using Ecommerce.BusinessAccessLayer.Repository.Admin.User;
using Ecommerce.ModelAccessLayer.Admin.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceUI.Admin.Controllers
{
    [Route("[controller]")]
    public class GenderController : Controller
	{
        private readonly IGender _gender;
      
        public GenderController(IGender gender)
        {
            _gender= gender;
         
        }

        [Route("add",Name ="AddGender")]
        [HttpGet]
		public async Task<IActionResult> AddGender()
		{        

            return View();
        }
        [Route("add",Name ="AddGender")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddGender(GenderModel model)
        {           
                if (ModelState.IsValid)
                {
                    int addGender = await _gender.AddGenderAsync(model);
                    if (addGender > 0)
                    {
					    ModelState.Clear();
					    ViewData["Message"] = "you have added Successfully";                       
                        return RedirectToRoute("list");
                    }

                }
          
            
           return View(ModelState);           
           
        }
        //[Route("Gender/List")]
        //public async Task<IActionResult> List()
        //{
        //   var genderLists=await _context.TblGenders.ToListAsync();
        //    List <GenderModel> genders = new List<GenderModel>();
        //    foreach(var gender in genderLists)
        //    {
        //        genders.Add(new GenderModel()
        //        {
        //            GenderId = gender.GenderId,
        //            GenderType = gender.GenderType
        //        });

        //    }
          
        //    return new JsonResult(genders);
        //}
        [Route("list",Name ="GenderList")]
        public async Task<IActionResult> GenderList()
        {
          var genders= await _gender.GetAllGenderAsync();
            if (genders == null)
            {
                ViewData["Message"] = "No Data Is Found";
                return View();
            }
            return View(genders);
        }
        [Route("edit/{id}",Name ="EditGenderById")]
        public async Task<IActionResult> EditGender(int id)
        {
          var  gender=await _gender.GetGenderByIdAsync(id);
            if (gender == null)
            {
                return NotFound();
               
            }
            return View(gender);
        }

        [Route("edit",Name ="EditGender")]       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>EditGender(GenderModel model)
        {          
                if (ModelState.IsValid)
                {
                    int a = await _gender.EditGenderAsync(model);
                    if (a > 0)
                    {
                        ViewData["Message"] = "you have added Successfully";
                        ModelState.Clear();
                        return Redirect("list");
                        
                    }
                }       
           
            return View(ModelState);       

        }

        [Route("delete/{Id}",Name ="DeleteGender")]
        
        public async Task<IActionResult> DeleteGender(int Id)
        {
            int deleteGenderById = await _gender.DeleteGenderAsync(Id);          
            if (deleteGenderById==0)
            {
                return NotFound();
               
            }
            ViewData["Message"] = "You Have deleted Successfully";
            return Redirect("list");
        }
    }
}
