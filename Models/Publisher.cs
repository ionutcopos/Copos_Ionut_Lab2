using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Copos_Ionut_Lab2.Models
{
	public class Publisher
    {
		public int ID { get; set; }
		[Display(Name = "Publisher")]
		public string PublisherName { get; set; }
		public ICollection<Book>? Books { get; set; }
	}
}
