
using NHibernate;
using TaskManager.Data.Entities;
using TaskManager.Data.QueryProcessors;

namespace TaskManager.Data.SqlServer.QueryProcessors
{
    public class TaskByIdQueryProcessor : ITaskByIdQueryProcessor
    {
        private readonly ISession _sessiion;

        public TaskByIdQueryProcessor(ISession sessiion)
        {
            _sessiion = sessiion;
        }

        public Task GetTaskById(long id)
        {
            var task = _sessiion.Get<Task>(id);

            return task;
        }
    }
}