using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creto.Data.Models
{
	public class QandA
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Question { get; set; }
		[Required]
		public string Answer  { get; set; }
		public int BikeId  { get; set; }
		public Bike Bike  { get; set; }
	}
}
