using BusinessLogic.ViewModel;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mapper
{
    public class UserAuthenticationConverter
    {
        public static UserAuthenticationVM Convert(UserAuthentication entity)
        {
			try
			{
				if (entity == null) return null;
				var data = new UserAuthenticationVM()
				{
					Id= entity.Id,
					UserId=entity.UserId,
					Hash= entity.Hash,
					Salt=entity.Salt,
					LoginAttempt=entity.LoginAttempt,
					IsBlocked=entity.IsBlocked,
				};
				return data;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		public static UserAuthentication Convert(UserAuthenticationVM entity)
		{
			try
			{
				if (entity == null) return null;
				var data = new UserAuthentication()
				{
					Id= entity.Id,
					UserId=entity.UserId,
					Hash=entity.Hash,
					Salt=entity.Salt,
					LoginAttempt=entity.LoginAttempt,
					IsBlocked=entity.IsBlocked,
				};
				return data;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static List<UserAuthenticationVM> Convert(List<UserAuthentication> entities)
		{
			try
			{
				List<UserAuthenticationVM> data = new List<UserAuthenticationVM>();
				foreach(var entity in entities)
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
