using BusinessLogic.Interface;
using BusinessLogic.Mapper;
using BusinessLogic.ViewModel;
using DataLayer;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
	public class BranchServices : IBranchServices
    {
        private TaskContext _context;

        public BranchServices(TaskContext context)
		{
			_context = context;
		}
        public async Task<bool> Add(BranchVM branch)
        {
			try
			{
				var entity = BranchConverter.Convert(branch);
				await _context.AddAsync(entity);
				await _context.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

        public async Task<bool> Delete(int Id)
        {
			try
			{
				var entity = await _context.Branch.FindAsync(Id);

				if (entity == null)
				{ 
					return false;
				} 
				else
				{
					_context.Branch.Remove(entity);
					await _context.SaveChangesAsync();
					return true;
				}
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

        public async Task<List<BranchVM>> GetAll()
        {
			try
			{
				var data =await _context.Branch.ToListAsync();
				return BranchConverter.Convert(data);

			}
			catch (Exception ex) 
			{ 
				throw ex; 
			}
        }

        public async Task<BranchVM> GetById(int Id)
        {
			try
			{
                var data = await _context.Branch.FindAsync(Id);
                return BranchConverter.Convert(data);
            }
			catch (Exception ex)
			{

				throw ex;
			}
        }
    }
}
