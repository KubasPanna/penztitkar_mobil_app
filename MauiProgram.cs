using Microsoft.Extensions.Logging;
using penztitkar_kubaspanna.ViewModels;
using penztitkar_kubaspanna.Views;
using penztitkar_kubaspanna.Services;

namespace penztitkar_kubaspanna
{
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
                });
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<EditTransactionPageViewModel>();
            builder.Services.AddSingleton<EditTransactionPage>();
            builder.Services.AddSingleton<StatisticsPageViewModel>();
            builder.Services.AddSingleton<StatisticsPage>();
            builder.Services.AddSingleton<ImagePreviewPageViewModel>();
            builder.Services.AddSingleton<ImagePreviewPage>();
            builder.Services.AddSingleton<ITransactionDatabase, SQLiteTransactionDatabase>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
