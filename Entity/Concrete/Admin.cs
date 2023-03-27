using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
	public class Admin
	{
		[Key]
		public int AdminId { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ImageURL { get; set; }
		public string Role { get; set; }

	}
}

