using BusinessLogic.Interface;
using BusinessLogic.Mapper;
using BusinessLogic.ViewModel;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class UserAuthenticationServices : IUserAuthenticationServices
    {
        private TaskContext _context;

        public UserAuthenticationServices(TaskContext context)
        {
            _context = context;
        }
        public async Task<bool> Add(UserAuthenticationVM UserAuth)
        {
            try
            {
                var entity = UserAuthenticationConverter.Convert(UserAuth);
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<UserAuthenticationVM>> GetAll()
        {
            var data = await _context.UserAuthentication.ToListAsync();
            return UserAuthenticationConverter.Convert(data);
        }

        public async Task<UserAuthenticationVM> GetById(int Id)
        {
            var data = await _context.UserAuthentication.FindAsync(Id);
            return UserAuthenticationConverter.Convert(data);
        }

        public string GetHashed(string password)
        {

            HMACSHA256 hash = new HMACSHA256();



            var key = Convert.FromHexString(password);

            return hash.ComputeHash(key).ToString();

        }
    }
}

