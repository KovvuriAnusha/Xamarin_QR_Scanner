using Syncfusion.Maui.Toolkit.Charts;

namespace Xamarin_QR_Scanner_MAUI.Pages.Controls;

public class LegendExt : ChartLegend
{
	protected override double GetMaximumSizeCoefficient()
	{
		return 0.5;
	}
}
