using BusinessLogic.ViewModel;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mapper
{
    public class RolesConverter
    {
        public static RolesVM Convert(Roles entity)
        {
			try
			{
				if (entity == null) return null;
				var data = new RolesVM()
				{
					Id= entity.Id,
					Name = entity.Name,
					AllowAccessAll= entity.AllowAccessAll,
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

		public static Roles Convert(RolesVM entity)
		{
			try
			{
				if (entity == null) return null;
				var data = new Roles()
				{
					Id= entity.Id,
					Name = entity.Name,
					AllowAccessAll= entity.AllowAccessAll,
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

		public static List<RolesVM> Convert(List<Roles> entities)
		{
			try
			{
				List<RolesVM> data = new List<RolesVM>();
				foreach (var entity in entities)
				{
					if(entities != null)
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
