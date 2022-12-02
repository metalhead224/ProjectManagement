using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IUserAuthenticationServices
    {
        Task<bool> Add(UserAuthenticationVM UserAuth);
        Task<List<UserAuthenticationVM>> GetAll();
        Task<UserAuthenticationVM> GetById(int Id);
    }
}
