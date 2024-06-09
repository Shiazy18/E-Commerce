using System;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
	public class category
	{
		[Key]
		public int ID  { get; set; }
		[Required]
		public string CategoryName { get; set; }
		public object CategotyOrder { get; set; }

	}
}

