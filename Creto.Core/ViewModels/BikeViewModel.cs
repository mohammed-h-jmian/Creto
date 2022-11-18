using Creto.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creto.Core.ViewModels
{
	public class BikeViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double WheelSize { get; set; }
		public double FrameSize { get; set; }
		public double Price { get; set; }
		public double HotPrice { get; set; }
		public string Color { get; set; }
		public string Gender { get; set; }
		public string Type { get; set; }
		public int BrandId { get; set; }
		public BrandViewModel Brand { get; set; }
	}
}
