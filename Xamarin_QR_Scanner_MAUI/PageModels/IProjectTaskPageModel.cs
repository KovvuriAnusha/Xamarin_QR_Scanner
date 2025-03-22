using CommunityToolkit.Mvvm.Input;
using Xamarin_QR_Scanner_MAUI.Models;

namespace Xamarin_QR_Scanner_MAUI.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}