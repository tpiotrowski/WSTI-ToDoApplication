

namespace TaskManager.Data.Entities
{
	public class User : IVersionedEntity
	{
		public virtual long UserId { get; set; }
		public virtual string Login { get; set; }
		public virtual string Password { get; set; }
		public virtual string FirstName { get; set; }
		public virtual string LastName { get; set; }
		public virtual string Email { get; set; }
		public virtual byte[] Version { get; set; }
	}
}
