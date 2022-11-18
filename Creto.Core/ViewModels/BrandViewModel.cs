using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creto.Core.ViewModels
{
	public class BrandViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<BikeViewModel> Bikes { get; set; }
	}
}
