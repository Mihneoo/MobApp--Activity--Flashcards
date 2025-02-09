namespace Flashcards.MVVM.Views;

using Flashcards.MVVM.ViewModels;

public partial class FlashcardViews : ContentPage
{
	public FlashcardViews()
	{
		InitializeComponent();
		BindingContext = new FlashcardViewModel();
	}

}