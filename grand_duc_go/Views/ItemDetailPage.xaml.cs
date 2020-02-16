using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using grand_duc_go.Models;
using grand_duc_go.ViewModels;

namespace grand_duc_go.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        private void ScanClicked(object sender, EventArgs e)
        {
            QrReader.ReadQrAsync();
        }
        

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
            this.FindByName<Button>("Button").Clicked += (e, s) =>
            {
                Navigation.PushAsync(new QuizManagerPage(viewModel.Obj));
            };
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            viewModel = new ItemDetailViewModel(Objective.GetObjectives()[0]);
            BindingContext = viewModel;
        }
    }
}