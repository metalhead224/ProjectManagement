using BusinessLogic.ViewModel;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mapper
{
    public class UsersConverter
    {
        public static UsersVM Convert(Users entity)
        {
			try
			{
				if (entity == null) return null;

				var data = new UsersVM()
				{
					Id= entity.Id,
					DepartmentId= entity.DepartmentId,
					RoleId= entity.RoleId,
					FirstName= entity.FirstName,
					MiddleName= entity.MiddleName,
					LastName= entity.LastName,
					Address= entity.Address,
					PersonalEmail= entity.PersonalEmail,
					OfficeEmail= entity.OfficeEmail,
					ContactNumber1= entity.ContactNumber1,
					ContactNumber2= entity.ContactNumber2,
					PhoneExtension= entity.PhoneExtension,
					IsActive= entity.IsActive,
					CurrentPosition= entity.CurrentPosition,
					IsTeamLead= entity.IsTeamLead,
					CreatedBy= entity.CreatedBy,
					CreatedDate= entity.CreatedDate,
					UpdatedBy= entity.UpdatedBy,
					UpdatedDate= entity.UpdatedDate,
				};
				return data;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		public static Users Convert(UsersVM entity)
		{
			try
			{
				if (entity == null) return null;

				var data = new Users()
				{
					Id= entity.Id,
					DepartmentId= entity.DepartmentId,
					FirstName= entity.FirstName,
					MiddleName= entity.MiddleName,
					LastName= entity.LastName,
					Address= entity.Address,
					PersonalEmail= entity.PersonalEmail,
					OfficeEmail= entity.OfficeEmail,
					ContactNumber1= entity.ContactNumber1,
					ContactNumber2= entity.ContactNumber2,
					PhoneExtension= entity.PhoneExtension,
					IsActive= entity.IsActive,
					CurrentPosition= entity.CurrentPosition,
					IsTeamLead= entity.IsTeamLead,
					CreatedBy= entity.CreatedBy,
					CreatedDate= entity.CreatedDate,
					UpdatedBy= entity.UpdatedBy,
					UpdatedDate= entity.UpdatedDate,
				};
				return data;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static List<UsersVM> Convert(List<Users> entities)
		{
			try
			{
				List<UsersVM> data = new List<UsersVM>();
				foreach (var entity in entities)
				{
					if(entity != null)
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
