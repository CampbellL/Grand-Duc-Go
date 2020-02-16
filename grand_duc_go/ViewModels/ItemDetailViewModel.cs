using System;

using grand_duc_go.Models;

namespace grand_duc_go.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Objective Obj { get; set; }
        public ItemDetailViewModel(Objective obj = null)
        {
            Title = Obj?.Name;
            Obj = obj;
        }
    }
}
