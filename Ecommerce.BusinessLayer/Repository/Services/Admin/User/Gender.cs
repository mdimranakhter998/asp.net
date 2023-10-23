using Ecommerce.BusinessAccessLayer.Repository.Admin.User;
using Ecommerce.DataAccessLayer;
using Ecommerce.DataAccessLayer.Models;
using Ecommerce.ModelAccessLayer.Admin.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.BusinessAccessLayer.Repository.Services.Admin.User
{
    public class Gender : IGender
    {
        private readonly Context _context;
        public Gender(Context context)
        {
            _context = context;
        }
        public async Task<int> AddGenderAsync(GenderModel gender)
        {
            if (gender == null)
            {
                return 0;
            }
            try
            {
                TblGender entity = new TblGender()
                {
                    GenderType = gender.GenderType
                };

                await _context.TblGenders.AddAsync(entity);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;

        }

        public async Task<int> DeleteGenderAsync(int Id)
        {
            if (Id == 0)
            {
                return 0;
            }
            var gender = await _context.TblGenders.FindAsync(Id);
            if (gender == null)
            {
                return 0;
            }
            try
            {
                _context.TblGenders.Remove(gender);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;

        }

        public async Task<int> EditGenderAsync(GenderModel gender)
        {
            var getByIdGender = await _context.TblGenders.FindAsync(gender.GenderId);
            if (getByIdGender == null)
            {
                return 0;
            }
            try
            {
				getByIdGender.GenderId = gender.GenderId;
				getByIdGender.GenderType = gender.GenderType;
				return await _context.SaveChangesAsync();
			}
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }

        public async Task<IEnumerable<GenderModel>> GetAllGenderAsync()
        {

            var genders = await _context.TblGenders.ToListAsync();
            if (genders == null)
            {
                return null;
            }
            List<GenderModel> genderList = new List<GenderModel>();
            foreach (var gender in genders)
            {
                genderList.Add(
                    new GenderModel()
                    {
                        GenderId = gender.GenderId,
                        GenderType = gender.GenderType
                    }
                );
            }
            return genderList;

        }

        public async Task<GenderModel> GetGenderByIdAsync(int Id)
        {

            var gender = await _context.TblGenders.FindAsync(Id);
            if (gender == null)
            {
                return null;
            }

            GenderModel model = new GenderModel()
            {
                GenderId = gender.GenderId,
                GenderType = gender.GenderType

            };
            return model;

        }

    }
}
