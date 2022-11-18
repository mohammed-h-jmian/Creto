using Creto.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creto.Data.Models
{
	public class Bike
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public double WheelSize { get; set; }
		[Required]
		public double FrameSize { get; set; }
		[Required]
		public double Price { get; set; }
		[Required]
		public double HotPrice { get; set; }
		[Required]
		public Color Color { get; set; }
		[Required]
		public Gender Gender { get; set; }
		[Required]
		public BikeType Type { get; set; }
		[Required]
		public int BrandId { get; set; }
		public Brand Brand { get; set; }
	}
}
