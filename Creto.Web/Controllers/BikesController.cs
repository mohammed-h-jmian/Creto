using Microsoft.AspNetCore.Mvc;

namespace Creto.Web.Controllers
{
	public class BikesController : BaseController
	{

		public IActionResult Shop()
		{
			return View();
		}
	}
}
