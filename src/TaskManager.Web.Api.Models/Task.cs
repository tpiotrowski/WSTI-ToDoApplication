using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Web.Api.Models
{
	public class Task : ILinkContaining
	{
		private List<Link> _links;
		private bool _shouldSerializeRoles;

		[Key]
		public long? TaskId { get; set; }

		[Editable(true)]
		public virtual string Subject { get; set; }

		[Editable(true)]
		public DateTime StartDate { get; set; }

		[Editable(true)]
		public DateTime DueDate { get; set; }

		[Editable(false)]
		public DateTime CompletedDate { get; set; }

		[Editable(true)]
		public Status Status { get; set; }

		[Editable(false)]
		public DateTime CreatedDate { get; set; }

		[Editable(false)]
		public IList<User> Assignees { get; set; }

		[Editable(false)]
		public List<Link> Links
		{
			get { return _links ?? (_links = new List<Link>()); }
			set { _links = value; }
		}

		public void AddLink(Link link)
		{
			Links.Add(link);
		}

		public void SetShouldSerializeRoles(bool shouldSerialize)
		{
			_shouldSerializeRoles = shouldSerialize;
		}

		public bool ShouldSerializeRoles()
		{
			return _shouldSerializeRoles;
		}

	}
}
