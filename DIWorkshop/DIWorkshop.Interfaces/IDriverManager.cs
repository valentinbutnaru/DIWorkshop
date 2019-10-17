using DIWorkshop.Entities;

namespace DIWorkshop.Interfaces
{
	public interface IDriverManager
	{
		Driver GetDriver(int id);
        Driver GetDriverByCar(int id);

    }
}
