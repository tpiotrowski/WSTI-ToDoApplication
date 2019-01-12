using AutoMapper;
using TaskManager.Common.TypeMapping;
using TaskManager.Data.Entities;

namespace TaskManager.Web.Api.AutoMappingConfiguration
{
	public class UserEntityToUserAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
	{
		public void Configure()
		{
			Mapper.CreateMap<User, Web.Api.Models.User>()
				.ForMember(dest => dest.Links, opt => opt.Ignore());
		}
	}
}