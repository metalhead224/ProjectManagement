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

        public async Task<bool> Delete(int Id)
        {
            try
            {
                var entity = await _context.Users.FindAsync(Id);

                if(entity == null) 
                {
                    return false;
                }
                else
                {
                    _context.Users.Remove(entity);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex) 
            { 
                throw ex;
            }
        }

        public async Task<List<UsersVM>> GetAll()
        {
            try
            {
                var data = await _context.Users.ToListAsync();
                return UsersConverter.Convert(data);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<UsersVM> GetById(int Id)
        {
            try
            {
                var data = await _context.Users.FindAsync(Id);
                return UsersConverter.Convert(data);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
