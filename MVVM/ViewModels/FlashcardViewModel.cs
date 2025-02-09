using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Flashcards.MVVM.Models;
using Flashcards.MVVM.Views;

namespace Flashcards.MVVM.ViewModels
{
    public partial class FlashcardViewModel : INotifyPropertyChanged
    {
        private string _question;
        private string _answer;

        public string Question 
        { 
            get => _question;
            set
            { 
                _question = value;
                OnPropertyChanged();
            } 
        }

        public string Answer 
        {
            get => _answer;
            set 
            { 
                _answer = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<FlashCard> _flashcards;
        public ObservableCollection<FlashCard> Flashcards
        {
            get => _flashcards;
            set
            {
                _flashcards = value;
                OnPropertyChanged();
            }
        }


        private int _currentFlashcardIndex;
        public int CurrentFlashcardIndex
        {
            get => _currentFlashcardIndex;
            set
            {
                if (_currentFlashcardIndex != value)
                {
                    _currentFlashcardIndex = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(CurrentFlashcard));

                }

            }
        }

        public FlashCard CurrentFlashcard => Flashcards?[CurrentFlashcardIndex];

        private bool _isAnswerVisible;
        public bool IsAnswerVisible
        {
            get => _isAnswerVisible;
            set
            {
                _isAnswerVisible = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(AnswerText));
            }

        }

        public string AnswerText => IsAnswerVisible ? CurrentFlashcard.Answer : "Tap to reveal the answer";

        public ICommand AddFlashcardCommand { get; }
        public FlashcardViewModel()
        {
            Flashcards = new ObservableCollection<FlashCard>
            {
                new FlashCard("What's the name of the Subject?","Advanced Mobile Application"),
                new FlashCard("5 x 5?","25"),
                new FlashCard("What did Eden eat?","Apple"),
                new FlashCard("Defense of the ____?","Ancients"),
                new FlashCard(".Net ___?","Maui"),
                new FlashCard(".Net comes from the word?","Network"),
                new FlashCard("Way Lami ang?","ACT"),
                
            };
            AddFlashcardCommand = new Command(AddFlashcard);
            CurrentFlashcardIndex = 0;
            IsAnswerVisible = false;
        }

        public Command NextCommand => new Command(NextFlashcard);

        public Command BackCommand => new Command(BackFlashcard);

        public Command ToggleAnswerCommand => new Command(ToggleAnswer);

        private void AddFlashcard()
        {
            if (!string.IsNullOrWhiteSpace(Question) && !string.IsNullOrWhiteSpace(Answer))
            {
                Flashcards.Add(new FlashCard(Question, Answer));
                Question = string.Empty; // Clear the question entry
                Answer = string.Empty;   // Clear the answer entry
            }
        }

        private void NextFlashcard()
        {
            if (CurrentFlashcardIndex < Flashcards.Count - 1)
            {
                CurrentFlashcardIndex++;
                IsAnswerVisible = false;
            }
        }

        private void BackFlashcard()
        {
            if (CurrentFlashcardIndex > 0)
            {
                CurrentFlashcardIndex--;
                IsAnswerVisible = false;
            }
        }
        private void ToggleAnswer()
        {
            IsAnswerVisible = !IsAnswerVisible;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
