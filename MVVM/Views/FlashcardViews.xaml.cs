namespace Flashcards.MVVM.Views;

using Flashcards.MVVM.ViewModels;

public partial class FlashcardViews : ContentPage
{
    public FlashcardViews(FlashcardViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private bool _isFlipped = false;
    private async void Add_Flashcard(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Creation_of_FlashcardView(BindingContext as FlashcardViewModel));
    }

    private async void ToggleAnswer_Tapped(object sender, TappedEventArgs e)
    {
        
    }
}