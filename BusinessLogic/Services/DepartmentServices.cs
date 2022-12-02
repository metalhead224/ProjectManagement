using BusinessLogic.ViewModel;
using BusinessLogic.Mapper;
using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.Interface;

namespace Services
{
    
        public class DepartmentServices: IDepartmentServices
        {
            private TaskContext _context;
            public DepartmentServices(TaskContext context)
            {
                _context = context;
            }
            public async Task<bool> Add(DepartmentVM depart)
            {
                try
                {
                    var entity = DepartmentConverter.Convert(depart);                       
                    await _context.AddAsync(entity);
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch (Exception ex )
                {
                    throw ex;
                }
            }

            public Task<bool> Delete(int id)
            {
                throw new NotImplementedException();
            }

            public async Task<List<DepartmentVM>> GetAll()
            {
                var list =await  _context.Department.ToListAsync();
                return DepartmentConverter.Convert(list);
            }
        }
       
    }
