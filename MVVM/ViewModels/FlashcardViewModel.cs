using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flashcards.MVVM.Models;

namespace Flashcards.MVVM.ViewModels
{
    public partial class FlashcardViewModel
    {
        private ObservableCollection<Models.FlashCard> _flashcards;

        private int _currentIndex;

        private Models.FlashCard _currentFlashcard;

        private bool _isAnswerVisible;

        public FlashcardViewModel()
        {
            _flashcards = new ObservableCollection<Models.FlashCard>
            {
                new Models.FlashCard("Whats my name", "Jm"),
            };

            
        }
    }
}
