using Flashcards.MVVM.Models;
using Flashcards.MVVM.ViewModels;
using Flashcards.MVVM.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Flashcards
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            var flashcardViews = serviceProvider.GetRequiredService<FlashcardViews>();

            MainPage = new NavigationPage(flashcardViews);
        }
    }
}
