using Ecommerce.BusinessAccessLayer.Repository.Admin.User;
using Ecommerce.DataAccessLayer;
using Ecommerce.DataAccessLayer.Models;
using Ecommerce.ModelAccessLayer.Admin.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.BusinessAccessLayer.Repository.Services.Admin.User
{
    public class UserStatus:IUserStatus
    {
        private readonly Context _context;
        public UserStatus(Context context)
        {
            _context = context;
        }
        public async Task<int> AddAUserStatusAsync(UserStatusModel userStatus)
        {
            if (userStatus == null)
            {
                return 0;
            }
            try
            {

                TblUserStatus entity = new TblUserStatus()
                {
                    UserStatus = userStatus.UserStatus
                };
                await _context.TblUserStatuses.AddAsync(entity);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }

        public Task<int> DeleteUserStatusAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteUserTypeAsync(int id)
        {
            var getUserStatusById = await _context.TblUserStatuses.FindAsync(id);
            if (getUserStatusById == null)
            {
                return 0;
            }
            try
            {
                _context.TblUserStatuses.Remove(getUserStatusById);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }

        public async Task<int> EditUserStatusAsync(UserStatusModel userStatus)
        {
            var getUserStatusById = await _context.TblUserStatuses.FindAsync(userStatus.UserStatusId);
            if (getUserStatusById == null)
            {
                return 0;
            }
            try
            {
				getUserStatusById.UserStatusId = userStatus.UserStatusId;
				getUserStatusById.UserStatus = userStatus.UserStatus;
				return await _context.SaveChangesAsync();
			}
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return 0;

        }

        public async Task<IEnumerable<UserStatusModel>> GetAllUserStatusAsync()
        {
            var getAllUserStatus= await _context.TblUserStatuses.ToListAsync();
            if (getAllUserStatus == null)
            {
                return null;
            }
            List<UserStatusModel> userStatusModel = new List<UserStatusModel>();
            foreach (var userStatus in getAllUserStatus)
            {
                userStatusModel.Add(new UserStatusModel()
                {
                    UserStatusId = userStatus.UserStatusId,
                    UserStatus = userStatus.UserStatus
                }
                );
            }
            return userStatusModel;
        }

        public async Task<UserStatusModel> GetUserStatusByIdAsync(int id)
        {
            var getUserStatusById = await _context.TblUserStatuses.FindAsync(id);
            if (getUserStatusById == null)
            {
                return null;
            }
            UserStatusModel model = new UserStatusModel()
            {
                UserStatusId = getUserStatusById.UserStatusId,
                UserStatus = getUserStatusById.UserStatus
            };
            return model;
        }
    }
}
