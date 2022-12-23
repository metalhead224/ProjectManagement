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
            public async Task<bool> Add(DepartmentVM dept)
            {
                try
                {
                    var entity = DepartmentConverter.Convert(dept);                       
                    await _context.AddAsync(entity);
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch (Exception ex )
                {
                    throw ex;
                }
            }

            public async Task<bool> Delete(int Id)
            {
            try
            {
                var entity = await _context.Department.FindAsync(Id);

                if (entity == null)
                {
                    return false;
                }
                else
                {
                    _context.Department.Remove(entity);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            }

            public async Task<List<DepartmentVM>> GetAll()
            {
                var list =await  _context.Department.ToListAsync();
                return DepartmentConverter.Convert(list);
            }
        }
       
    }
