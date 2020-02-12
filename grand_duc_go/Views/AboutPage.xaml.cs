using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;

namespace grand_duc_go.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            MobileBarcodeScanningOptions optionsDefault = new MobileBarcodeScanningOptions();
            MobileBarcodeScanningOptions optionsCustom = new MobileBarcodeScanningOptions();

            MobileBarcodeScanner scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            DisplayAlert("Code",scanResult.Text,"Okayy");
        }
    }
}