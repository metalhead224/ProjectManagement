using BusinessLogic.ViewModel;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mapper
{
    public class BranchConverter
    {
        public static BranchVM Convert(Branch entity)
        {
			try
			{
				if (entity == null) return null;
				var data = new BranchVM()
				{
					Id= entity.Id,
					Name=entity.Name,
					Address=entity.Address,
					IsHeadOffice=entity.IsHeadOffice,
					IsRegionalHead=entity.IsRegionalHead,
					IsActive=entity.IsActive,
					ContactNumber1= entity.ContactNumber1,
					ContactNumber2= entity.ContactNumber2,
					Email=entity.Email,
					Code=entity.Code,
					ShortName=entity.ShortName,
					ContactPerson=entity.ContactPerson,
					CreatedBy=entity.CreatedBy,
					CreatedDate=entity.CreatedDate,
					UpdatedBy=entity.UpdatedBy,
					UpdatedDate=entity.UpdatedDate,
				};
				return data;

			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		public static Branch Convert(BranchVM entity)
		{
			try
			{
				if (entity == null) return null;
				var data = new Branch()
				{
					Id= entity.Id,
					Name=entity.Name,
					Address=entity.Address,
					IsHeadOffice=entity.IsHeadOffice,
					IsRegionalHead=entity.IsRegionalHead,
					IsActive=entity.IsActive,
					ContactNumber1= entity.ContactNumber1,
					ContactNumber2= entity.ContactNumber2,
					Email=entity.Email,
					Code=entity.Code,
					ShortName=entity.ShortName,
					ContactPerson=entity.ContactPerson,
					CreatedBy=entity.CreatedBy,
					CreatedDate=entity.CreatedDate,
					UpdatedBy=entity.UpdatedBy,
					UpdatedDate=entity.UpdatedDate,
				};
				return data;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public List<BranchVM> Convert(List<Branch> entities)
		{
			try
			{
				List<BranchVM> data = new List<BranchVM>();
				foreach (var entity in entities) 
				{
					if(entity != null)
					{
						data.Add(Convert(entity));
					}
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
