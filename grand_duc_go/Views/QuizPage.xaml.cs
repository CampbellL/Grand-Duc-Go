using System;
using System.Linq;
using grand_duc_go.Models;
using grand_duc_go.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace grand_duc_go.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPage : ContentPage
    {
        public QuizViewModel _viewModel;
        private CheckBox _checkBox;

        public QuizPage(QuizViewModel qz)
        {
            InitializeComponent();
            BindingContext = this._viewModel = qz;
        }


        private void Checkbox(object sender, EventArgs e)
        {
            if (_checkBox != null)
            {
                _checkBox.IsChecked = false;
            }
            this._checkBox = sender as CheckBox;
        }

        private void Submit(object sender, EventArgs e)
        {
            if (_checkBox == null || !_checkBox.IsChecked)
            {
                DisplayAlert("You're not done here", "Please answer the question by checking the box", "Ah Oui");
            }
            else
            {
                Answer selectedAnswer = this._viewModel.PageQuiz.Answers[Convert.ToInt32(_checkBox.StyleId) - 1];
                if (selectedAnswer.IsCorrect)
                {
                    DisplayAlert("Congratulations", this._viewModel.PageQuiz.CompletionText, "Yay");
                    this._viewModel.PageQuiz.IsCompleted = true;
                    Navigation.PopModalAsync(true);
                }
                else
                {
                    DisplayAlert("Wrong!", this._viewModel.PageQuiz.CompletionText, "Oops");
                    this._viewModel.PageQuiz.IsCompleted = true;
                    Navigation.PopModalAsync(true);
                }
            }
        }
    }
}