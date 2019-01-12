using System.CodeDom;
using System.Web.Http;
using TaskManager.Common;
using TaskManager.Data.QueryProcessors;
using TaskManager.Web.Api.Models;
using TaskManager.Web.Common.Routing;

namespace TaskManager.Web.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("tasks")]
    [Authorize(Roles = Constants.RoleNames.User)]
    public class TasksController : ApiController
    {
        private readonly ITaskByIdQueryProcessor _taskByIdQueryProcessor;

        public TasksController(ITaskByIdQueryProcessor taskByIdQueryProcessor)
        {
            _taskByIdQueryProcessor = taskByIdQueryProcessor;
        }

        // GET
        public IHttpActionResult Get(long id)
        {
            var taskById = _taskByIdQueryProcessor.GetTaskById(id);

            return NotFound();
        }
    }
}