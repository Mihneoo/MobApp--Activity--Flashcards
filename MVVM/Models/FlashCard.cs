using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flashcards.MVVM.ViewModels;

namespace Flashcards.MVVM.Models
{
    public class FlashCard
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public FlashCard(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}
