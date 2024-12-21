using CarSQLite.Repositories;

namespace CarSQLite;

public partial class App : Application
{
	public static CarRepository _carRepo {get ; set;}
	public App(CarRepository carRepo)
	{
		InitializeComponent();

		_carRepo = carRepo;

		MainPage = new CarPage();
	}
}