using Flashcards.MVVM.Models;
using Flashcards.MVVM.Views;

namespace Flashcards
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlashcardViews();
        }
    }
}
