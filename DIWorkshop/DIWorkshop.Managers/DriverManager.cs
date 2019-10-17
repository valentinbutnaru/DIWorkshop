using DIWorkshop.Entities;
using DIWorkshop.Interfaces;

namespace DIWorkshop.Managers
{
	public class DriverManager : IDriverManager
	{
		private readonly IDriverRepository _driverRepository;

		public DriverManager(IDriverRepository driverRepository)
		{
			_driverRepository = driverRepository;
		}

		public Driver GetDriver(int id)
		{
			return _driverRepository.GetDriver(id);
		}
	}
}
