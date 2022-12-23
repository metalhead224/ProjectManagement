using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IUsersServices
    {
        Task<bool> Add(UsersVM user);
        Task<List<UsersVM>> GetAll();
        Task<UsersVM> GetById(int Id);
        Task<bool> Delete(int Id);
    }
}
