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
    public class UsersServices : IUsersServices
    {
        private TaskContext _context;

        public UsersServices(TaskContext context)
        {
            _context = context;
        }
        public async Task<bool> Add(UsersVM user)
        {
            try
            {
                var entity = UsersConverter.Convert(user);
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
