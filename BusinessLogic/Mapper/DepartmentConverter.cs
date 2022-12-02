using BusinessLogic.ViewModel;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mapper
{
    public class DepartmentConverter
    {
        public static DepartmentVM Convert(Department entity)
        {
            try
            {
                if (entity == null) return null;
                var data = new DepartmentVM()
                {
                    Id=  entity.Id,
                    BranchId = entity.BranchId,
                    Name = entity.Name,
                    IsActive = entity.IsActive,
                    CreatedBy = entity.CreatedBy,
                    CreatedDate  = entity.CreatedDate,
                    UpdatedBy = entity.UpdatedBy,
                    UpdatedDate  = entity.UpdatedDate

                };
                return data;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public static Department Convert(DepartmentVM  entity)
        {
            try
            {
                if (entity == null) return null;
                var data = new Department()
                {
                    Id=  entity.Id,
                    BranchId = entity.BranchId,
                    Name = entity.Name,
                    IsActive = entity.IsActive,
                    CreatedBy = entity.CreatedBy,
                    CreatedDate  = entity.CreatedDate,
                    UpdatedBy = entity.UpdatedBy,
                    UpdatedDate  = entity.UpdatedDate

                };
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
                //throw ex.Message;
            }
        }
        public static List<DepartmentVM> Convert(List<Department> entities)
        {
            try
            {
                List<DepartmentVM> data = new List<DepartmentVM>();
                foreach (var entity in entities)
                {
                    if (entity != null)
                        data.Add(Convert(entity));
                }
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
