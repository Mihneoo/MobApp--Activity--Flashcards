namespace Flashcards.MVVM.Views;

using Flashcards.MVVM.Models;
using Flashcards.MVVM.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public partial class Creation_of_FlashcardView : ContentPage
{
	public Creation_of_FlashcardView(FlashcardViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

}