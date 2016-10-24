using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Assignment4.Models
{
	public class MusicGenre
	{
		public int MusicGenreId { get; set; }
		public string GenreType { get; set; }

		public virtual Album Album { get; set; }
	}
}