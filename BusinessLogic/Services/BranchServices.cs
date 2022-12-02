using BusinessLogic.Interface;
using BusinessLogic.Mapper;
using BusinessLogic.ViewModel;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public async Task<List<BranchVM>> GetAll()
        {
			try
			{
				var data =await _context.Branch.ToListAsync();
				return BranchConverter.Convert(data);

			}
			catch (Exception)
			{

				throw new Exception("Not Found!");
			}
        }

        public async Task<BranchVM> GetById(int Id)
        {
			try
			{
                var data = await _context.Branch.FindAsync(Id);
                return BranchConverter.Convert(data);
            }
			catch (Exception)
			{

				throw new Exception("Not Found");
			}
        }
    }
}
