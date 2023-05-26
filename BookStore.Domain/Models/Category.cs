using System;
namespace BookStore.Domain.Models
{
	public class Category : Entity
	{
		public string Name { get; set; }

		/* EF Relations */
		//A category may be related to many Books
		public IEnumerable<Book> Books { get; set; }
	}
}

