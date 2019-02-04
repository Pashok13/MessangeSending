using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MessengeSending.Models
{
	public class AdditInfo
	{
		[Key]
		public int Id			{ get; set; }
		public int PhoneId		{ get; set; }
		public string Info		{ get; set; }

		[ForeignKey("PhoneId")]
		public Phone Phone { get; set; }
	}
}