using Flashcards.MVVM.ViewModels;
using Flashcards.MVVM.Views;
using Microsoft.Extensions.Logging;

namespace Flashcards
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<FlashcardViewModel>();
            builder.Services.AddSingleton<FlashcardViews>();
            builder.Services.AddTransient<Creation_of_FlashcardView>();

            return builder.Build();
        }
    }
}
