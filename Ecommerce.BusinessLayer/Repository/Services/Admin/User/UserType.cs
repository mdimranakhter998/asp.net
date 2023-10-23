using Ecommerce.BusinessAccessLayer.Repository.Admin.User;
using Ecommerce.DataAccessLayer;
using Ecommerce.DataAccessLayer.Models;
using Ecommerce.ModelAccessLayer.Admin.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.BusinessAccessLayer.Repository.Services.Admin.User
{
    public class UserType :IUserType
    {
        private readonly Context _context;
        public UserType(Context context)
        {
            _context = context;
        }
        public async Task<int> AddAUserTypeAsync(UserTypeModel userType)
        {
            if (userType == null)
            {
                return 0;
            }
            try
            {

                TblUserType entity = new TblUserType()
                {
                    UserType=userType.UserType
                };
                await _context.TblUserTypes.AddAsync(entity);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }

        public async Task<int> DeleteUserTypeAsync(int id)
        {
            var getUserTypeById = await _context.TblUserTypes.FindAsync(id);
            if (getUserTypeById == null)
            {
                return 0;
            }
            try
            {
                _context.TblUserTypes.Remove(getUserTypeById);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }

        public async Task<int> EditUserTypeAsync(UserTypeModel userType)
        {
            var getUserTypeById = await _context.TblUserTypes.FindAsync(userType.UserTypeId);
            if (getUserTypeById == null)
            {
                return 0;
            }
            try
            {
				getUserTypeById.UserTypeId = userType.UserTypeId;
				getUserTypeById.UserType = userType.UserType;
				return await _context.SaveChangesAsync();
			}
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return 0;
        }

        public async Task<IEnumerable<UserTypeModel>> GetAllUserTypeAsync()
        {
            var getAllUserType = await _context.TblUserTypes.ToListAsync();
            if (getAllUserType == null)
            {
                return null;
            }
            List<UserTypeModel> userTypeModel = new List<UserTypeModel>();
            foreach (var userType in getAllUserType)
            {
                userTypeModel.Add(new UserTypeModel()
                {
                    UserTypeId = userType.UserTypeId,
                    UserType = userType.UserType
                }
                );
            }
            return userTypeModel;
        }

        public async Task<UserTypeModel> GetUserTypeByIdAsync(int id)
        {
            var getUserTypeById = await _context.TblUserTypes.FindAsync(id);
            if (getUserTypeById == null)
            {
                return null;
            }
            UserTypeModel model = new UserTypeModel()
            {
                UserTypeId = getUserTypeById.UserTypeId,
                UserType = getUserTypeById.UserType
            };
            return model;
        }
    }
}
