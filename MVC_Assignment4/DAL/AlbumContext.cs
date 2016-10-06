using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Assignment4.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVC_Assignment4.DAL
{
	public class AlbumContext : DbContext
	{
		public AlbumContext() : base("AlbumContext")
		{ }
		public DbSet<Album> Album { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}