using SumaAppMvvm.ViewModels;
namespace SumaAppMvvm.Views;

public partial class MainPage : ContentPage
{
	MainPageViewModel ViewModel;
	public MainPage()
	{
		InitializeComponent();
		ViewModel = new MainPageViewModel();
		BindingContext = ViewModel;

	}
}