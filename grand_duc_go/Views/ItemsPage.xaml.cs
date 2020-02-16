using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using grand_duc_go.Models;
using grand_duc_go.ViewModels;
using static grand_duc_go.Models.Objective;

namespace grand_duc_go.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        private ItemsViewModel _viewModel;
        public ItemsPage()
        {
            InitializeComponent();
            GameEventHandler.QrScanObservable.Subscribe((e) =>
            {
                if (GameEventHandler.QrCodes.ContainsKey(e))
                {
                    Objective objective = GetObjectives().FirstOrDefault(obj => GameEventHandler.QrCodes != null && obj.Name == GameEventHandler.QrCodes[e]);
                    if (objective != null && objective.Unlocked != true)
                    {
                        DisplayAlert("Congratulations", "You have unlocked " + GameEventHandler.QrCodes[e], "Okay");
                        objective.Unlocked = true;
                        Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(GetObjectives().FirstOrDefault(el => el.Name == objective.Name))));
                    }
                    else
                    {
                        DisplayAlert("Stop, you violated the law.", "You have already unlocked " + GameEventHandler.QrCodes[e], "Okay");
                    }
                }
                else
                {
                    DisplayAlert("Invalid Code","This is not a Grand Duc Go Code.","I stop cheating, i promise.");
                }
            });
            Navigation.PushModalAsync(new AboutPage());
            this._viewModel = new ItemsViewModel();
            RefreshLayout();
        }

        public void RefreshLayout()
        {
            StackLayout layout = this.FindByName<StackLayout>("StackLayout");
            layout.Children.Clear();
            foreach (Objective objective in GetObjectives())
            {
                Frame frame = new Frame {CornerRadius = 20, Margin = 15};
                StackLayout cardLayout = new StackLayout();
                cardLayout.Children.Add(new Image(){Source = objective.Image});
                cardLayout.Children.Add(new Label(){Text = objective.Heading});
                frame.Content = cardLayout;
                TapGestureRecognizer gestureRecognizer = new TapGestureRecognizer();
                gestureRecognizer.Tapped += (s, e) =>
                {
                    Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(GetObjectives().FirstOrDefault(el => el.Name == objective.Name))));
                };
                frame.GestureRecognizers.Add(gestureRecognizer);
                layout.Children.Add(frame);
            }
        }

        private void ScanClicked(object sender, EventArgs e)
        {
            QrReader.ReadQrAsync();
        }
    }
}