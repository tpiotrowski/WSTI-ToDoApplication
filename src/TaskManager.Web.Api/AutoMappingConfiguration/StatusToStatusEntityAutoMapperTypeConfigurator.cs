using AutoMapper;
using TaskManager.Common.TypeMapping;
using TaskManager.Web.Api.Models;

namespace TaskManager.Web.Api.AutoMappingConfiguration
{
	public class StatusToStatusEntityAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
	{
		public void Configure()
		{
			Mapper.CreateMap<Status, Data.Entities.Status>()
				.ForMember(dest => dest.Version, opt => opt.Ignore());
				
		}
	}
}