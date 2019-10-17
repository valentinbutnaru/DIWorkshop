using DIWorkshop.Interfaces;
using System.Web.Http;

namespace DIWorkshop.WebApi.Controllers
{
	public class DriverController : ApiController
    {
		private readonly IDriverManager _driverManager;

		public DriverController(IDriverManager driverManager)
		{
			_driverManager = driverManager;
		}

		[Route("driver/{id}")]
		public IHttpActionResult GetDriver(int id)
		{
			return Ok(_driverManager.GetDriver(id));
		}
    }
}
