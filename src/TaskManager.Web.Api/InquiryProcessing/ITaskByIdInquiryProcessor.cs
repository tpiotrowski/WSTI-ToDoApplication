using System.Threading.Tasks;

namespace TaskManager.Web.Api.InquiryProcessing
{
    public interface ITaskByIdInquiryProcessor
    {
        Task GetTaskById(long taskId);
    }
}