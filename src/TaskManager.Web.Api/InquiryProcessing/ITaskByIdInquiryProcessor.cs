
using TaskManager.Common.TypeMapping;
using TaskManager.Data.Exceptions;
using TaskManager.Data.QueryProcessors;
using TaskManager.Web.Api.Models;

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
            var taskById = _queryProcessor.GetTaskById(taskId);

            if(taskById == null) throw  new RootObjectNotFoundException("Tas not found");

            var task = _autoMapper.Map<Task>(taskById);
            return task;
        }
    }

    public interface IUserByIdInquiryProcessor
    {
        User GeUserById(long userId);
    }

    class UserByIdInquiryProcessor : IUserByIdInquiryProcessor
    {
        private readonly IAutoMapper _autoMapper;
        private readonly IUserByIdQueryProcessor _queryProcessor;

        public UserByIdInquiryProcessor(IAutoMapper autoMapper, IUserByIdQueryProcessor queryProcessor)
        {
            _autoMapper = autoMapper;
            _queryProcessor = queryProcessor;
        }

        public User GeUserById(long userId)
        {
            var userById = _queryProcessor.GetUserById(userId);

            if (userById == null) throw new RootObjectNotFoundException("User not found");

            var user = _autoMapper.Map<User>(userById);

            return user;
        }
    }
}