using DIWorkshop.Managers;
using DIWorkshop.Persistence;
using System.Web.Http;

namespace DIWorkshop.WebApi.Homework.Controllers
{
	public class DriverController : ApiController
    {
		private readonly DriverManager _driverManager;

		public DriverController()
		{
			_driverManager = new DriverManager(new DriverRepository(new DbContext()));
		}

		[Route("driver/{id}")]
		public IHttpActionResult GetDriver(int id)
		{
			return Ok(_driverManager.GetDriver(id));
		}
	}
}
