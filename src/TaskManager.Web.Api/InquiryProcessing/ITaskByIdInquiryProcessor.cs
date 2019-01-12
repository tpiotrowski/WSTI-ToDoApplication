using System.Threading.Tasks;
using TaskManager.Common.TypeMapping;
using TaskManager.Data.QueryProcessors;

namespace TaskManager.Web.Api.InquiryProcessing
{
    public interface ITaskByIdInquiryProcessor
    {
        Task GetTaskById(long taskId);
    }

    class TaskByIdInquiryProcessor : ITaskByIdInquiryProcessor
    {
        private readonly IAutoMapper _autoMapper;
        private readonly ITaskByIdQueryProcessor _queryProcessor;

        public TaskByIdInquiryProcessor(IAutoMapper autoMapper, ITaskByIdQueryProcessor queryProcessor)
        {
            _autoMapper = autoMapper;
            _queryProcessor = queryProcessor;
        }

        public Task GetTaskById(long taskId)
        {
            throw new System.NotImplementedException();
        }
    }
}