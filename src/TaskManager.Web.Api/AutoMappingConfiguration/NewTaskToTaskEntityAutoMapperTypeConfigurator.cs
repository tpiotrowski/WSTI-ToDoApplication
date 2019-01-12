using AutoMapper;
using TaskManager.Common.TypeMapping;
using TaskManager.Web.Api.Models;

namespace TaskManager.Web.Api.AutoMappingConfiguration
{
	public class NewTaskToTaskEntityAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
	{
		public void Configure()
		{
			Mapper.CreateMap<NewTask, Data.Entities.Task>()
				.ForMember(dest => dest.Version, opt => opt.Ignore())
				.ForMember(dest => dest.TaskId, opt => opt.Ignore())
				.ForMember(dest => dest.CompletedDate, opt => opt.Ignore())
				.ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
				.ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
				.ForMember(dest => dest.Status, opt => opt.Ignore())
				.ForMember(dest => dest.Users, opt => opt.Ignore());
		}
	}
}