using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IBranchServices
    {
        Task<bool> Add(BranchVM branch);
        Task<List<BranchVM>> GetAll();
        Task<BranchVM> GetById(int Id);
    }
}
