using TaskManager.Data.Entities;
using FluentNHibernate.Mapping;

namespace TaskManager.Data.SqlServer.Mapping
{
	public class StatusMap : VersionedClassMap<Status>
	{
		StatusMap()
		{
			Id(x => x.StatusId).Not.Nullable();
			Map(x => x.Name).Not.Nullable();
			Map(x => x.Ordinal).Not.Nullable();
		}
	}
}
