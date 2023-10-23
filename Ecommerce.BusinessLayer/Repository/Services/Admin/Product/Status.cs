using Ecommerce.BusinessAccessLayer.Repository.Admin.Product;
using Ecommerce.DataAccessLayer;
using Ecommerce.DataAccessLayer.Models;
using Ecommerce.ModelAccessLayer.Admin.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.BusinessAccessLayer.Repository.Services.Admin.Product
{
    public class Status : IStatus
	{
		private readonly Context _context;
		public Status(Context context) 
		{
			_context = context;
		}
		public async Task<int> AddStatusAsync(StatusModel status)
		{
			if(status == null)
			{
				return 0;
			}
			try
			{
				TblStatus entity = new TblStatus()
				{
					Status=status.Status

				};
				await _context.TblStatuses.AddAsync(entity);
				return await _context.SaveChangesAsync();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
			}
			return 0;
		}

		public async Task<int> DeleteStatusAsync(int id)
		{
			if(id == 0)
			{
				return 0;
			}
			var getStatusById=await _context.TblStatuses.FindAsync(id);
			if(getStatusById == null)
			{
				return 0;
			}
			try
			{
				_context.TblStatuses.Remove(getStatusById);
				return await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);	
			}
			return 0;
		}

		public async Task<int> EditStatusAsync(StatusModel status)
		{
			var getStatusById=await _context.TblStatuses.FindAsync(status.StatusId);
			if (getStatusById == null)
			{
				return 0;
			}
			try
			{
				//getStatusById.StatusId = status.StatusId;
				getStatusById.Status = status.Status;
				return await _context.SaveChangesAsync();
			}
			catch( Exception ex)
			{
				Console.WriteLine(ex);
			}
			return 0;
		}

		public async Task<IEnumerable<StatusModel>> GetAllStatusAsync()
		{
			var getAllStatus = await _context.TblStatuses.ToListAsync();
			if (getAllStatus == null)
			{
				return null;
			}
			List<StatusModel> StatusModel = new List<StatusModel>();
			foreach (var status in getAllStatus)
			{
				StatusModel.Add(new StatusModel()
				{
					StatusId=status.StatusId,
					Status = status.Status,
				}
				);
			}
			return StatusModel;
		}

		public async Task<StatusModel> GetStatusByIdAsync(int id)
		{
			if (id == 0)
			{
				return null;
			}
			var getStatusById = await _context.TblStatuses.FindAsync(id);
			if (getStatusById == null)
			{
				return null;
			}
			StatusModel statusModel = new StatusModel()
			{
				StatusId = getStatusById.StatusId,
				Status = getStatusById.Status,
			};
			return statusModel;
		}
	}
}
