using AutoMapper;
using TaskManager.Common.TypeMapping;
using TaskManager.Data.Entities;

namespace TaskManager.Web.Api.AutoMappingConfiguration
{
	public class TaskEntityToTaskAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
	{
		public void Configure()
		{
			Mapper.CreateMap<Task, Web.Api.Models.Task>()
				.ForMember(dest => dest.Links, opt => opt.Ignore())
				.ForMember(dest => dest.Assignees, opt => opt.ResolveUsing<TaskAssigneesResolver>());
		}
	}
}