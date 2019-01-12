using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Web.Api.Models
{
	public class User : ILinkContaining
	{
		private List<Link> _links;
		private bool _shouldSerializeRoles;
	
		[Key]
		public long? UserId { get; set; }

		[Editable(true)]
		public string Login { get; set; }

		[Editable(true)]
		public string Password { get; set; }

		[Editable(true)]
		public string FirstName { get; set; }

		[Editable(true)]
		public string LastName { get; set; }

		[Editable(true)]
		public string Email { get; set; }

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
