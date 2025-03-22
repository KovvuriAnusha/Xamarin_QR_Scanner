using Xamarin_QR_Scanner_MAUI.Models;
using Xamarin_QR_Scanner_MAUI.PageModels;

namespace Xamarin_QR_Scanner_MAUI.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}