using TaskManager.Data.Entities;
using FluentNHibernate.Mapping;

namespace TaskManager.Data.SqlServer.Mapping
{
	public class UserMap : VersionedClassMap<User>
	{
		public UserMap()
		{
			Id(x => x.UserId);
			Map(x => x.Login).Not.Nullable();
			Map(x => x.Password).Not.Nullable();
			Map(x => x.FirstName).Nullable();
			Map(x => x.LastName).Nullable();
			Map(x => x.Email).Not.Nullable();

			
		}

	}
}
