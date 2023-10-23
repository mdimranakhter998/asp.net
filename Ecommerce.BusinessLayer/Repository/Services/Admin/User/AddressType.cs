using Ecommerce.BusinessAccessLayer.Repository.Admin.User;
using Ecommerce.DataAccessLayer;
using Ecommerce.DataAccessLayer.Models;
using Ecommerce.ModelAccessLayer.Admin.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.BusinessAccessLayer.Repository.Services.Admin.User
{
    public class AddressType : IAddressType
    {
        private readonly Context _context;
        public AddressType(Context context)
        {
            _context = context;
        }
        public async Task<int> AddAddressTypeAsync(AddressTypeModel addressType)
        {
            if (addressType == null)
            {
                return 0;
            }
            try
            {
              
                TblAddressType entity = new TblAddressType()
                {
                    AddressType = addressType.AddressType
                };
                await _context.TblAddressTypes.AddAsync(entity);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }






        public async Task<int> DeleteAddressTypeAsync(int id)
        {
            var getAddressTypeById = await _context.TblAddressTypes.FindAsync(id);
            if (getAddressTypeById== null)
            {
                return 0;
            }
            try
            {
                _context.TblAddressTypes.Remove(getAddressTypeById);
               return await _context.SaveChangesAsync();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
            return 0;
          
        }

        public async Task<int> EditAddessTypeAsync(AddressTypeModel addressType)
        {
            var getAddressTypeById =await  _context.TblAddressTypes.FindAsync(addressType.AddressTypeId);
            if (getAddressTypeById == null)
            {
                return 0;
            }
            try
            {
                getAddressTypeById.AddressTypeId = addressType.AddressTypeId;
                getAddressTypeById.AddressType = addressType.AddressType;
                return await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;

        }

        public async Task<AddressTypeModel> GetAddressTypeByIdAsync(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var getAddressTypeById = await _context.TblAddressTypes.FindAsync(id);
            if (getAddressTypeById == null)
            {
                return null;
            }
            AddressTypeModel model = new AddressTypeModel()
            {
                AddressTypeId = getAddressTypeById.AddressTypeId,
                AddressType = getAddressTypeById.AddressType
            };
            return model;

        }

        public async Task<IEnumerable<AddressTypeModel>> GetAllAddressTypeAsync()
        {
            var getAllAddressType=  await _context.TblAddressTypes.ToListAsync();
            if (getAllAddressType == null)
            {
                return null;
            }
            List<AddressTypeModel> addressTypeModel = new List<AddressTypeModel>();
            foreach (var addressType in getAllAddressType)
            {
                addressTypeModel.Add(new AddressTypeModel()
                {
                    AddressTypeId = addressType.AddressTypeId,
                    AddressType = addressType.AddressType
                }
                );
            }
            return addressTypeModel;
        }
    }
}
