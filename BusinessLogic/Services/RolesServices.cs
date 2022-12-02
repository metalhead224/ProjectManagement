using BusinessLogic.Interface;
using BusinessLogic.Mapper;
using BusinessLogic.ViewModel;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class RolesServices : IRolesServices
    {
        private TaskContext _context;

        public RolesServices(TaskContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(RolesVM role)
        {
            try
            {
                var entity = RolesConverter.Convert(role);
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<List<RolesVM>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
