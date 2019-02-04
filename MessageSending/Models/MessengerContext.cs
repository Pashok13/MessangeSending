using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MessengeSending.Models
{
	public class MessengerContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<MessegeRecipient> MessegesRecipients { get; set; }
		public DbSet<Phone> Phones { get; set; }
		public DbSet<AdditInfo> AdditInfo { get; set; }
	}
}