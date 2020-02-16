using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace grand_duc_go.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GrandDucPage : ContentPage
    {
        public GrandDucPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            while (Navigation.ModalStack.Count > 0)
            {
                Navigation.PopModalAsync();
            }
        }
    }
}