using ZXing;
using ZXing.Mobile;

namespace grand_duc_go
{
    public class QrReader
    {        
        public static async void ReadQrAsync()
        {
            MobileBarcodeScanningOptions optionsCustom = new MobileBarcodeScanningOptions();
            MobileBarcodeScanner scanner = new MobileBarcodeScanner();
            Result scanResult = await scanner.Scan(optionsCustom);
            if (scanResult == null) return;
            GameEventHandler.PushQrEvent(scanResult.Text);
        }
    }
}