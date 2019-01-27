
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

    public class UserByIdQueryProcessor : IUserByIdQueryProcessor
    {
        private readonly ISession _session;


        public UserByIdQueryProcessor(ISession session)
        {
            _session = session;
        }

        public User GetUserById(long id)
        {
            var user = _session.Get<User>(id);

            return user;
        }
    }
}