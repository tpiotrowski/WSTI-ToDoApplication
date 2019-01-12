using System;
using System.Collections.Generic;

namespace TaskManager.Web.Api.Models
{
	public class NewTask
	{
		public virtual string Subject { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime DueDate { get; set; }
		public IList<User> Assignees { get; set; }
	}
}
