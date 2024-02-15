using Microsoft.Extensions.Logging;

namespace GestaoDePedidosMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Rubik-Medium.ttf", "RubikMedium");
                fonts.AddFont("Rubik-Regular.ttf", "RubikRegular");
                fonts.AddFont("DMSans_18pt-Medium.ttf", "DmMedium");
                fonts.AddFont("DMSans_18pt-SemiBold.ttf", "DmSemiBold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
