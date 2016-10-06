using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Assignment4.Models
{
	public class Album
	{
		public int Id { get; set; }
		public string Artist { get; set; }
		public string Title { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string ArtistBio { get; set; }
	}
}