using BusinessLogic.Interface;
using BusinessLogic.Mapper;
using BusinessLogic.ViewModel;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<BranchVM> UpdateBranch(BranchVM branch)
        {
			try
			{
				var data = await _context.Branch.FindAsync(branch.Id);

				if (data == null)
				{
					return null;
				}
				data.Name= branch.Name;
				data.Address= branch.Address;
				data.ShortName= branch.ShortName;
				data.ContactNumber1 = branch.ContactNumber1;
				data.ContactNumber2= branch.ContactNumber2;
				data.Code = branch.Code;
				data.Email = branch.Email;
				data.ContactPerson = branch.ContactPerson;
				data.IsHeadOffice = branch.IsHeadOffice;
				data.IsRegionalHead = branch.IsRegionalHead;

				_context.Update(data);
				await _context.SaveChangesAsync();
				return BranchConverter.Convert(data);
				
			}
			catch (Exception ex)
			{
				throw ex;
            }
        }
    }
}
