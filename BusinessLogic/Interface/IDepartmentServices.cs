using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IDepartmentServices
    {
        Task<bool> Add(DepartmentVM dept);
        Task<List<DepartmentVM>> GetAll();
        Task<bool> Delete(int Id);
    }
}
