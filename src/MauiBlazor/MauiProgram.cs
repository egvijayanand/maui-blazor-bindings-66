namespace MauiBlazor
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder.UseMauiApp<App>()
				.UseMauiBlazorBindings()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("fa-brands-400.ttf", FontAwesomeBrands);
					fonts.AddFont("fa-regular-400.ttf", FontAwesomeRegular);
					fonts.AddFont("fa-solid-900.ttf", FontAwesomeSolid);
				});

			builder.Services.AddSingleton<ShellNavigationManager>();

			return builder.Build();
		}
	}
}
