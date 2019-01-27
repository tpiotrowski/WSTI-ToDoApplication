using System.CodeDom;
using System.Web.Http;
using TaskManager.Common;
using TaskManager.Data.QueryProcessors;
using TaskManager.Web.Api.InquiryProcessing;
using TaskManager.Web.Api.Models;
using TaskManager.Web.Common.Routing;

namespace TaskManager.Web.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("tasks")]
    [Authorize(Roles = Constants.RoleNames.User)]
    
    public class TasksController : ApiController
    {
        private readonly ITaskByIdInquiryProcessor _taskByIdInquiryProcessor;


        public TasksController(ITaskByIdInquiryProcessor taskByIdInquiryProcessor)
        {
            _taskByIdInquiryProcessor = taskByIdInquiryProcessor;
        }

        [Route("{id:long}", Name = "GetTaskRoute")]
        public IHttpActionResult Get(long id)
        {
            var taskById = _taskByIdInquiryProcessor.GetTaskById(id);

            return Ok(taskById);
        }
    }

    [ApiVersion1RoutePrefix("users")]
    [Authorize(Roles = Constants.RoleNames.User)]

    public class UserController : ApiController
    {
        private readonly IUserByIdInquiryProcessor _taskByIdInquiryProcessor;


        public UserController(IUserByIdInquiryProcessor taskByIdInquiryProcessor)
        {
            _taskByIdInquiryProcessor = taskByIdInquiryProcessor;
        }

        [Route("{id:long}", Name = "GetUserRoute")]
        public IHttpActionResult Get(long id)
        {
            var taskById = _taskByIdInquiryProcessor.GeUserById(id);

            return Ok(taskById);
        }
    }
}