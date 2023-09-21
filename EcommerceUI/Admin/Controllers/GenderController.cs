using Ecommerce.DataAccessLayer.Models;
using EcommerceUI.Admin.Models.Common;
using EcommerceUI.Admin.Models.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Console;
using System.Runtime.CompilerServices;

namespace EcommerceUI.Admin.Controllers
{
    
	public class GenderController : Controller
	{
        private readonly Context _context;
      
        public GenderController(Context Context)
        {
            _context = Context;
         
        }

        [Route("add")]
        [HttpGet]
		public async Task<IActionResult> AddGender()
		{


            return View();

        }
        [Route("add")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddGender(string name)
        { 
            if (ModelState.IsValid)
            {

                //TblGender entity = new TblGender();
                //entity.GenderType = model.GenderType;
                //_context.Add(entity);
                //int a = await _context.SaveChangesAsync();
                //Console.WriteLine(a);
                return View();
            }
            return RedirectToRoute("list");

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
        [Route("list")]
        public async Task<IActionResult> GenderList()
        {
            var genderLists = await _context.TblGenders.ToListAsync();
            List<GenderModel> genders = new List<GenderModel>();
            foreach (var gender in genderLists)
            {
                genders.Add(new GenderModel()
                {
                    GenderId = gender.GenderId,
                    GenderType = gender.GenderType
                });

            }


            return View(genders);
        }
        [Route("edit/{id}")]
        public async Task<IActionResult> EditGender(int id)
        {
            try
            {
                var gender = await _context.TblGenders.SingleOrDefaultAsync(e => e.GenderId == id);
               var genderModel= new GenderModel()
               {
                   GenderId = gender.GenderId,
                   GenderType = gender.GenderType
               };
                return View(genderModel);
            }
            catch
            {
                return RedirectToAction("/list/");
            }
            
            
        }
    }
}
