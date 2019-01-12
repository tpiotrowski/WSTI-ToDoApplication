using AutoMapper;
using TaskManager.Common.TypeMapping;
using TaskManager.Web.Api.Models;

namespace TaskManager.Web.Api.AutoMappingConfiguration
{
	public class UserToUserEntityAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
	{
		public void Configure()
		{
			Mapper.CreateMap<User, Data.Entities.User>()
				.ForMember(dest => dest.Version, opt => opt.Ignore());

		}
	}
}