using System.Diagnostics.CodeAnalysis;
using Xamarin_QR_Scanner_MAUI.Models;

namespace Xamarin_QR_Scanner_MAUI.Utilities;

/// <summary>
/// Project Model Extentions
/// </summary>
public static class ProjectExtentions
{
	/// <summary>
	/// Check if the project is null or new.
	/// </summary>
	/// <param name="project"></param>
	/// <returns></returns>
	public static bool IsNullOrNew([NotNullWhen(false)] this Project? project)
	{
		return project is null || project.ID == 0;
	}
}