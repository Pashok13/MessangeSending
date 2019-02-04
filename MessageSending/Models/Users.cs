using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MessengeSending.Models
{
    public class User
    {
        [Key]
		public int UserId		{ get; set; }
		public string Login		{ get; set; }
		public string Password	{ get; set; }
		public string Name		{ get; set; }

        public ICollection<Message> Messages { get; set; }

        public User()
        {
            Messages = new List<Message>();
        }
    }
}
