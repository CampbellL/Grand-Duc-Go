using System.Collections.Generic;
using System.Reactive.Subjects;


namespace grand_duc_go
{
    public class GameEventHandler
    {
        public static Dictionary<string,string> QrCodes = new Dictionary<string, string>()
        {
            {"cm","Casemates du Bock"},
            {"palais","Palais Grand-Ducal"},
            {"hz","The Bock"},
            {"GG","Place Guillaume II"},
        };
        public static Subject<string> QrScanObservable { get; private set; } = new Subject<string>();

        public static void PushQrEvent(string eventCode)
        {
            QrScanObservable.OnNext(eventCode);
        }
    }
}