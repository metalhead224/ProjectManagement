using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IRolesServices
    {
        Task<bool> Add(RolesVM role);
        Task<List<RolesVM>> GetAll();
    }
}
