using System.Linq;
using System.Reactive.Subjects;
using grand_duc_go.Models;
using grand_duc_go.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace grand_duc_go.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizManagerPage : ContentPage
    {
        public Objective Objective;
        public QuizManagerPage(Objective obj)
        {
            this.Objective = obj;
            InitializeComponent();
            CreateQuizOrEnd();
        }

        public void CreateQuizOrEnd()
        {
            Quiz nextQuiz = this.Objective.Quizzes.FirstOrDefault(e => !e.IsCompleted);
            if (nextQuiz != null)
            {
                QuizPage page = new QuizPage(new QuizViewModel(nextQuiz));
                Navigation.PushModalAsync(page,true);
                page.Disappearing += (s, e) =>
                {
                    CreateQuizOrEnd();
                };
            }
            else
            {
                DisplayAlert("Congratulation","You have completed all quizzes","Yay off to the next one");
                this.Objective.QuizCompleted = true;
            }
        }
    }
}