using CarSQLite.MVVM.ViewModels;

namespace CarSQLite;

public partial class CarPage : ContentPage
{
	public CarPage()
	{
		InitializeComponent();
		BindingContext = new CarPageViewModel();
	}
}