using System.Collections.Generic;
using grand_duc_go.Models;
using Xamarin.Forms;

namespace grand_duc_go.ViewModels
{
    public class QuizViewModel : BaseViewModel
    {
        public bool[] CheckBoxes;
        public Quiz PageQuiz { get; set; }

        public QuizViewModel(Quiz pageQuiz)
        {
            PageQuiz = pageQuiz;
        }
    }
}